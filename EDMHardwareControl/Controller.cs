using System;
using System.Collections;
using System.Threading;
using System.Runtime.Remoting.Lifetime;
using System.Windows.Forms;
using NationalInstruments;
using NationalInstruments.DAQmx;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using NationalInstruments.VisaNS;

using DAQ.HAL;
using DAQ.Environment;

namespace EDMHardwareControl
{
	/// <summary>
	/// This is the interface to the edm specific hardware.
	/// 
	/// Everything is just bundled into a single
	/// class. The methods/properties are grouped: the first set change the state of the hardware, these
	/// usually act immediately, but sometimes you need to call an update method. Read the code to find out
	/// which are which. The second set of methods read out the state of the hardware. These invariably need
	/// to be brought up to date with an update method before use.
	/// </summary>
	public class Controller : MarshalByRefObject
	{
		#region Constants
		private const double greenSynthOffAmplitude = -130.0;
		private const double redSynthOffFrequency = 36.0;
		private const int eDischargeTime = 5000;
		private const int eBleedTime = 1000;
		private const int eWaitTime = 500;
		private const int eChargeTime = 1000;
		// E field controller calibrations
		private const double cPlusOffset = -18.917;
        private const double cPlusSlope = 9015.49;
		private const double cMinusOffset = -5.24;
        private const double cMinusSlope = 9505.59;
		private const double gPlusOffset = 4.71;
		private const double gPlusSlope = -2908.07;
		private const double gMinusOffset = -15.49;
		private const double gMinusSlope = -3072.35;
		// E field monitor scale factors - what you need to multiply the monitor voltage by
		// to get the plate voltage
		private const double cScale = 1000;
		private const double gScale = 1000;
		// E field controller channel mappings
		private const int cPlusChan = 3;
		private const int cMinusChan = 4;
		private const int gPlusChan = 1;
		private const int gMinusChan = 2;
		// E field controller mode
		private enum EFieldMode { TTL, GPIB };
		private EFieldMode eFieldMode = EFieldMode.GPIB;

		#endregion

		#region Setup

		// hardware
		HP8657ASynth greenSynth = (HP8657ASynth)Environs.Hardware.GPIBInstruments["green"];
		Synth redSynth = (Synth)Environs.Hardware.GPIBInstruments["red"];
		ICS4861A voltageController = (ICS4861A)Environs.Hardware.GPIBInstruments["4861"];
		HP34401A bCurrentMeter = (HP34401A)Environs.Hardware.GPIBInstruments["bCurrentMeter"];
		Hashtable digitalTasks = new Hashtable();
		LeakageMonitor northCLeakageMonitor = 
			new LeakageMonitor( (CounterChannel)Environs.Hardware.CounterChannels["northCLeakage"], 5049, 5040 );
		LeakageMonitor southCLeakageMonitor = 
			new LeakageMonitor( (CounterChannel)Environs.Hardware.CounterChannels["southCLeakage"], 4976, 4990 );
		LeakageMonitor northGLeakageMonitor = 
			new LeakageMonitor( (CounterChannel)Environs.Hardware.CounterChannels["northGLeakage"], 1, 5000 );
		LeakageMonitor southGLeakageMonitor = 
			new LeakageMonitor( (CounterChannel)Environs.Hardware.CounterChannels["southGLeakage"], 1, 5000 );
		BrilliantLaser yag = (BrilliantLaser)Environs.Hardware.YAG;
		Task bBoxAnalogOutputTask;
		Task rf1AttenuatorOutputTask;
		Task rf2AttenuatorOutputTask;
		Task probeMonitorInputTask;
		Task pumpMonitorInputTask;

		ControlWindow window;

		// without this method, any remote connections to this object will time out after
		// five minutes of inactivity.
		// It just overrides the lifetime lease system completely.
		public override Object InitializeLifetimeService()
		{
			return null;
		}
		
		
		public void Start()
		{
			// make the digital tasks
			CreateDigitalTask("notEOnOff");
			CreateDigitalTask("eOnOff");
			CreateDigitalTask("ePol");
			CreateDigitalTask("notEPol");
			CreateDigitalTask("eBleed");
			CreateDigitalTask("rf1Switch");
			CreateDigitalTask("rf2Switch");
			CreateDigitalTask("greenFM");
			CreateDigitalTask("b");
			CreateDigitalTask("notDB");
			CreateDigitalTask("piFlip");
			CreateDigitalTask("piFlipEnable");
			CreateDigitalTask("pumpShutter");
			CreateDigitalTask("pump2Shutter");

			// initialise the current leakage monitors
			northCLeakageMonitor.Initialize();
			southCLeakageMonitor.Initialize();
//			northGLeakageMonitor.Initialize();
//			southGLeakageMonitor.Initialize();

			// analog outputs
			bBoxAnalogOutputTask = CreateAnalogOutputTask("b");
			rf1AttenuatorOutputTask = CreateAnalogOutputTask("rf1Attenuator");
			rf2AttenuatorOutputTask = CreateAnalogOutputTask("rf2Attenuator");

			// analog inputs
			probeMonitorInputTask = CreateAnalogInputTask("probePD");
			pumpMonitorInputTask = CreateAnalogInputTask("pumpPD");

			// make the control window
			window = new ControlWindow();
			window.controller = this;
			Application.Run(window);
		}

		// this method runs immediately after the GUI sets up
		internal void WindowLoaded()
		{
			// update the GPIB switcher's cached voltages
			// works around a "first-time" bug with the E-field switch
			lastGPlus = GPlusVoltage;
			lastGMinus = GMinusVoltage;
			lastCPlus = CPlusVoltage;
			lastCMinus = CMinusVoltage;
		}

		private Task CreateAnalogInputTask(string channel)
		{
			Task task = new Task("EDMHCIn" + channel);
			((AnalogInputChannel)Environs.Hardware.AnalogInputChannels[channel]).AddToTask(
				task,
				0,
				10
			);
			task.Control(TaskAction.Verify);
			return task;
		}

		private Task CreateAnalogOutputTask(string channel)
		{
			Task task = new Task("EDMHCOut" + channel);
			((AnalogOutputChannel)Environs.Hardware.AnalogOutputChannels[channel]).AddToTask(
				task,
				-10,
				10
				);
			task.Control(TaskAction.Verify);
			return task;
		}

		private void SetAnalogOutput(Task task, double voltage)
		{
			AnalogSingleChannelWriter writer = new AnalogSingleChannelWriter(task.Stream);
			writer.WriteSingleSample(true, voltage);
			task.Control(TaskAction.Unreserve);
		}

		private double ReadAnalogInput(Task task)
		{
			AnalogSingleChannelReader reader = new AnalogSingleChannelReader(task.Stream);
			double val = reader.ReadSingleSample();
			task.Control(TaskAction.Unreserve);
			return val;
		}

		private void CreateDigitalTask(String name)
		{
			Task digitalTask = new Task(name);
			((DigitalOutputChannel)Environs.Hardware.DigitalOutputChannels[name]).AddToTask(digitalTask);
			digitalTask.Control(TaskAction.Verify);
			digitalTasks.Add(name, digitalTask);
		}

		private void SetDigitalLine(string name, bool value)
		{
			Task digitalTask = ((Task)digitalTasks[name]);
			DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalTask.Stream);
			writer.WriteSingleSampleSingleLine(true, value);
			digitalTask.Control(TaskAction.Unreserve);
		}

		#endregion

		#region Public properties for controlling the hardware

		public double GreenSynthOnFrequency
		{
			get
			{
				return Double.Parse(window.greenOnFreqBox.Text);
			}
			set
			{
				window.SetTextBox(window.greenOnFreqBox, value.ToString());
			}
		}

		public double GreenSynthOnAmplitude
		{
			get
			{
				return Double.Parse(window.greenOnAmpBox.Text);
			}
			set
			{
				window.SetTextBox(window.greenOnAmpBox, value.ToString());
			}
		}

		public double GreenSynthDCFM
		{
			get
			{
				return Double.Parse(window.greenDCFMBox.Text);
			}
			set
			{
				window.SetTextBox(window.greenDCFMBox, value.ToString());
			}
		}

		public double RedSynthOnFrequency
		{
			get
			{
				return Double.Parse(window.redOnFreqBox.Text);
			}
			set
			{
				window.SetTextBox(window.redOnFreqBox, value.ToString());
			}
		}

		public bool GreenSynthEnabled
		{
			get
			{
				return window.greenOnCheck.Checked;
			}
			set
			{
				window.SetCheckBox(window.greenOnCheck, value);
			}
		}

		public bool RedSynthEnabled
		{
			get
			{
				return window.redOnCheck.Checked;
			}
			set
			{
				window.SetCheckBox(window.redOnCheck, value);
			}
		}
		
	
		public bool GreenRFSwitchEnabled
		{
			get
			{
				return window.greenRFSwitchEnableCheck.Checked;
			}
			set
			{
				window.SetCheckBox(window.greenRFSwitchEnableCheck, value);
			}
		}

		public bool RedRFSwitchEnabled
		{
			get
			{
				return window.redRFSwitchEnableCheck.Checked;
			}
			set
			{
				window.SetCheckBox(window.redRFSwitchEnableCheck, value);
			}
		}

		public bool GreenDCFMEnabled
		{
			get
			{
				return window.greenFMEnableCheck.Checked;
			}
			set
			{
				window.SetCheckBox(window.greenFMEnableCheck, value);
			}
		}

		public bool EFieldEnabled
		{
			get
			{
				return window.eOnCheck.Checked;
			}
			set
			{
				window.SetCheckBox(window.eOnCheck, value);
			}
		}

		public bool EFieldPolarity
		{
			get
			{
				return window.ePolarityCheck.Checked;
			}
			set
			{
				window.SetCheckBox(window.ePolarityCheck, value);
			}
		}

		public bool EBleedEnabled
		{
			get
			{
				return window.eBleedCheck.Checked;
			}
			set
			{
				window.SetCheckBox(window.eBleedCheck, value);
			}
		}

		public double CPlusVoltage
		{
			get
			{
				return Double.Parse(window.cPlusTextBox.Text);
			}
			set
			{
				window.SetTextBox(window.cPlusTextBox, value.ToString());
			}
		}
		
		public double CMinusVoltage
		{
			get
			{
				return Double.Parse(window.cMinusTextBox.Text);
			}
			set
			{
				window.SetTextBox(window.cMinusTextBox, value.ToString());
			}
		}

		public double GPlusVoltage
		{
			get
			{
				return Double.Parse(window.gPlusTextBox.Text);
			}
			set
			{
				window.SetTextBox(window.gPlusTextBox, value.ToString());
			}
		}
		
		public double GMinusVoltage
		{
			get
			{
				return Double.Parse(window.gMinusTextBox.Text);
			}
			set
			{
				window.SetTextBox(window.gMinusTextBox, value.ToString());
			}
		}

		public bool CalFlipEnabled
		{
			get
			{
				return window.calFlipCheck.Checked;
			}
			set
			{
				window.SetCheckBox(window.calFlipCheck, value);
			}
		}

		public bool BFlipEnabled
		{
			get
			{
				return window.bFlipCheck.Checked;
			}
			set
			{
				window.SetCheckBox(window.bFlipCheck, value);
			}
		}

		public bool PumpShutter
		{
			get
			{
				return window.pumpShutterCheck.Checked;
			}
			set
			{
				window.SetCheckBox(window.pumpShutterCheck, value);
			}
		}

		public bool Pump2Shutter
		{
			get
			{
				return window.pump2ShutterCheck.Checked;
			}
			set
			{
				window.SetCheckBox(window.pump2ShutterCheck, value);
			}
		}

		/* This is something of a cheesy hack. It lets the edm script check to see if the YAG
		 * laser has failed.
		 */
		public bool YAGInterlockFailed
		{
			get
			{
				return ((BrilliantLaser)Environs.Hardware.YAG).InterlockFailed;
			}
		}
		
		#endregion

		#region Public properties for monitoring the hardware

		public double BCurrent00
		{
			get
			{
				return Double.Parse(window.bCurrent00TextBox.Text);
			}
		}

		public double BCurrent01
		{
			get
			{
				return Double.Parse(window.bCurrent01TextBox.Text);
			}
		}

		public double BCurrent10
		{
			get
			{
				return Double.Parse(window.bCurrent10TextBox.Text);
			}
		}

		public double BCurrent11
		{
			get
			{
				return Double.Parse(window.bCurrent11TextBox.Text);
			}
		}

		public double BiasCurrent
		{
			get
			{
				return Double.Parse(window.bCurrentBiasTextBox.Text);
			}
		}

		public double FlipStepCurrent
		{
			get
			{
				return Double.Parse(window.bCurrentFlipStepTextBox.Text);
			}
		}

		public double CalStepCurrent
		{
			get
			{
				return Double.Parse(window.bCurrentCalStepTextBox.Text);
			}
		}

		#endregion

		#region Hardware control methods - safe for remote

		public void SwitchE()
		{
			SwitchE(!EFieldPolarity, eDischargeTime, eBleedTime, eWaitTime, eChargeTime);
		}

		public void SwitchE(bool state, int dischargeTime, int bleedTime, int switchTime, int chargeTime)
		{
			// don't waste time if the field isn't really switching
			if (state != EFieldPolarity)
			{
				EFieldEnabled = false;
				Thread.Sleep(dischargeTime);
				EBleedEnabled = true;
				Thread.Sleep(bleedTime);
				EBleedEnabled = false;
				EFieldPolarity = state;
				Thread.Sleep(switchTime);
				EFieldEnabled = true;
				Thread.Sleep(chargeTime);
			}
		}

        //Commented out by Henry, 20.4.06 I have fitted my measured voltage as a function of AO voltage, so to get a 
        //desired HV, the inverse equation is used. i.e.
        //I have V_hv=slope_x * V_AO_x + offset_x, so I arrange as:
        //V_AO_x=(V_hv - offset_x)/slope_x, where x is the appropriate channel

        //public void UpdateVoltages()
        //{
        //    voltageController.SetOutputVoltage(cPlusChan, (CPlusVoltage * cPlusSlope) - cPlusOffset);
        //    voltageController.SetOutputVoltage(cMinusChan, (CMinusVoltage * cMinusSlope) - cMinusOffset);
        //    voltageController.SetOutputVoltage(gPlusChan, (GPlusVoltage * gPlusSlope) - gPlusOffset);
        //    voltageController.SetOutputVoltage(gMinusChan, (GMinusVoltage * gMinusSlope) - gMinusOffset);
        //}

        public void UpdateVoltages()
        {
			// kludge in the asymmetric field switch here
			double cPlus = CPlusVoltage;
			double cMinus = CMinusVoltage;
			if (EFieldEnabled && window.eFieldAsymmetryCheckBox.Checked)
			{
				if (EFieldPolarity == false)
				{
					cPlus += Double.Parse(window.zeroPlusOneMinusBoostTextBox.Text);
					cPlus += Double.Parse(window.zeroPlusBoostTextBox.Text);
				}
				else
				{
					cMinus -= Double.Parse(window.zeroPlusOneMinusBoostTextBox.Text);
				}
			}

            voltageController.SetOutputVoltage(cPlusChan, (cPlus - cPlusOffset) / cPlusSlope);
            voltageController.SetOutputVoltage(cMinusChan, (cMinus - cMinusOffset) / cMinusSlope);
            voltageController.SetOutputVoltage(gPlusChan, (GPlusVoltage - gPlusOffset) / gPlusSlope);
            voltageController.SetOutputVoltage(gMinusChan, (GMinusVoltage - gMinusOffset) / gMinusSlope);
        }

		public void UpdateBCurrentMonitor()
		{
			// DB0 dB0
			BFlipEnabled = false;
			CalFlipEnabled = false;
			double i00 = 1000000 * bCurrentMeter.ReadCurrent();
			window.SetTextBox(window.bCurrent00TextBox, i00.ToString());
			Thread.Sleep(50);

			// DB0 dB1
			BFlipEnabled = false;
			CalFlipEnabled = true;
			double i01 = 1000000 * bCurrentMeter.ReadCurrent();
			window.SetTextBox(window.bCurrent01TextBox, i01.ToString());
			Thread.Sleep(50);

			// DB1 dB0
			BFlipEnabled = true;
			CalFlipEnabled = false;
			double i10 = 1000000 * bCurrentMeter.ReadCurrent();
			window.SetTextBox(window.bCurrent10TextBox, i10.ToString());
			Thread.Sleep(50);
			
			// DB1 dB1
			BFlipEnabled = true;
			CalFlipEnabled = true;
			double i11 = 1000000 * bCurrentMeter.ReadCurrent();
			window.SetTextBox(window.bCurrent11TextBox, i11.ToString());
			Thread.Sleep(50);

			// calculate the steps
			double bias = (i00 + i01 + i10 + i11) / 4;
			double calStep = (i01 - i00 - i11 + i10) / 4;
			double flipStep = (i10 - i00 + i11 - i01) / 4;
			window.SetTextBox(window.bCurrentBiasTextBox, bias.ToString());
			window.SetTextBox(window.bCurrentCalStepTextBox, calStep.ToString());
			window.SetTextBox(window.bCurrentFlipStepTextBox, flipStep.ToString());

		}

		public void UpdateVMonitor()
		{
			window.SetTextBox(window.cPlusVMonitorTextBox, 
				(cScale * voltageController.ReadInputVoltage(cPlusChan)).ToString());
			window.SetTextBox(window.cMinusVMonitorTextBox, 
				(cScale * voltageController.ReadInputVoltage(cMinusChan)).ToString());
			window.SetTextBox(window.gPlusVMonitorTextBox, 
				(gScale * voltageController.ReadInputVoltage(gPlusChan)).ToString());
			window.SetTextBox(window.gMinusVMonitorTextBox, 
				(gScale * voltageController.ReadInputVoltage(gMinusChan)).ToString());
		}

		public void UpdateIMonitor()
		{
			window.SetTextBox(window.northCIMonitorTextBox, (northCLeakageMonitor.GetCurrent()).ToString());
			window.SetTextBox(window.southCIMonitorTextBox, (southCLeakageMonitor.GetCurrent()).ToString());
//			window.SetTextBox(window.northGIMonitorTextBox, (northGLeakageMonitor.GetCurrent()).ToString());
//			window.SetTextBox(window.southGIMonitorTextBox, (southGLeakageMonitor.GetCurrent()).ToString());
		}

		public void UpdateRFPowerMonitor()
		{
		}


		public void UpdateLaserPhotodiodes()
		{
			double probePDValue = ReadAnalogInput(probeMonitorInputTask);
			window.SetTextBox(window.probeMonitorTextBox, probePDValue.ToString());
			double pumpPDValue = ReadAnalogInput(pumpMonitorInputTask);
			window.SetTextBox(window.pumpMonitorTextBox, pumpPDValue.ToString());
		}

		// TODO: I'm not sure whether these button enabling properties are threadsafe.
		// Probably had better wrap them.
		public void StartYAGFlashlamps()
		{
			yag.StartFlashlamps(false);
			window.startYAGFlashlampsButton.Enabled = false;
			window.stopYagFlashlampsButton.Enabled = true;
		}

		public void StopYAGFlashlamps()
		{
			yag.StopFlashlamps();
			window.startYAGFlashlampsButton.Enabled = true;
			window.stopYagFlashlampsButton.Enabled = false;
		}

		public void EnableYAGQ()
		{
			yag.EnableQSwitch();
			window.yagQEnableButton.Enabled = false;
			window.yagQDisableButton.Enabled = true;
		}

		public void DisableYAGQ()
		{
			yag.DisableQSwitch();
			window.yagQEnableButton.Enabled = true;
			window.yagQDisableButton.Enabled = false;
		}

		public void CheckYAGInterlock()
		{
			window.SetTextBox(window.interlockStatusTextBox, yag.InterlockFailed.ToString());
		}

		public void UpdateYAGFlashlampVoltage()
		{
			yag.SetFlashlampVoltage((int)Double.Parse(window.yagFlashlampVTextBox.Text));
		}

		#endregion

		#region Hardware control methods - local use only


		public void EnableGreenSynth(bool enable)
		{
			greenSynth.Connect();
			if (enable)
			{
				greenSynth.Frequency = GreenSynthOnFrequency;
				greenSynth.Amplitude = GreenSynthOnAmplitude;
				greenSynth.DCFM = GreenSynthDCFM;
			}
			else
			{
				greenSynth.Amplitude = greenSynthOffAmplitude;
			}
			greenSynth.Disconnect();
		}

		public void EnableRedSynth(bool enable)
		{
			redSynth.Connect();
			if (enable)
			{
				redSynth.Frequency = RedSynthOnFrequency;
			}
			else
			{
				redSynth.Frequency = redSynthOffFrequency;
			}
			redSynth.Disconnect();
		}

		public void EnableGreenRFSwitch(bool enable)
		{
			SetDigitalLine("rf1Switch", enable);
		}

		public void EnableRedRFSwitch(bool enable)
		{
			SetDigitalLine("rf2Switch", enable);
		}

		private double lastGPlus = 0;
		private double lastGMinus = 0;
		private double lastCPlus = 0;
		private double lastCMinus = 0;
		public void SetEFieldOnOff(bool enable)
		{
			if (eFieldMode == EFieldMode.TTL)
			{
				SetDigitalLine("eOnOff", enable);
				SetDigitalLine("notEOnOff", !enable);
			}
			if (eFieldMode == EFieldMode.GPIB)
			{
				if (!enable)
				{
					// switching off, so save the voltages for when we switch back on
					lastGPlus = GPlusVoltage;
					lastGMinus = GMinusVoltage;
					lastCPlus = CPlusVoltage;
					lastCMinus = CMinusVoltage;
					// set the voltages to zero and update
					GPlusVoltage = 0;
					GMinusVoltage = 0;
					CPlusVoltage = 0;
					CMinusVoltage = 0;
					UpdateVoltages();
				}
				else
				{
					// switching on, so restore the voltages at last switch off
					GPlusVoltage = lastGPlus;
					GMinusVoltage = lastGMinus;
					CPlusVoltage = lastCPlus;
					CMinusVoltage = lastCMinus;
					UpdateVoltages();
				}
			}
		}

		public void SetEPolarity(bool state)
		{
			SetDigitalLine("ePol", state);
			SetDigitalLine("notEPol", !state);
		}

		public void SetBleed(bool enable)
		{
			SetDigitalLine("eBleed", enable);
		}

		public void SetBFlip(bool enable)
		{
			SetDigitalLine("b", enable);
		}

		public void SetCalFlip(bool enable)
		{
			SetDigitalLine("notDB", !enable);
		}

		public void EnableGreenDCFM(bool enable)
		{
			SetDigitalLine("greenFM", enable);
		}

		public void SetPhaseFlip1(bool enable)
		{
			SetDigitalLine("piFlip", enable);
		}

		public void SetPhaseFlip2(bool enable)
		{
			SetDigitalLine("piFlipEnable", enable);
		}

		internal void SetPumpShutter(bool enable)
		{
			SetDigitalLine("pumpShutter", enable); 
		}

		internal void SetPump2Shutter(bool enable)
		{
			SetDigitalLine("pump2Shutter", enable);
		}

		public void SetDualRF()
		{
			double lrFreq = Double.Parse(window.lrFrequencyBox.Text);
			double urFreq = Double.Parse(window.urFrequencyBox.Text);

			if (lrFreq < urFreq)
			{
				GreenSynthOnFrequency = lrFreq;
				GreenSynthDCFM = Math.Round( 1000 * (urFreq - lrFreq) );
			}
			else
			{
				GreenSynthOnFrequency = urFreq;
				GreenSynthDCFM = Math.Round( 1000 * (lrFreq - urFreq) );
			}
			GreenSynthOnAmplitude = Double.Parse(window.ramanAmplitudeBox.Text);
			GreenSynthEnabled = false;
			GreenSynthEnabled = true;
		}

		public void SetScanningBVoltage()
		{
			double bBoxVoltage = Double.Parse(window.scanningBVoltageBox.Text);
			SetAnalogOutput(bBoxAnalogOutputTask, bBoxVoltage);
		}

		public void SetScanningBZero()
		{
			window.SetTextBox(window.scanningBVoltageBox, "0.0");
			SetScanningBVoltage();
		}

		public void SetScanningBFS()
		{
			window.SetTextBox(window.scanningBVoltageBox, "5.0");
			SetScanningBVoltage();
		}


		public void SetAttenutatorVoltages()
		{
			double rf1AttenuatorVoltage = Double.Parse(window.rf1AttenuatorVoltageTextBox.Text);
			double rf2AttenuatorVoltage = Double.Parse(window.rf2AttenuatorVoltageTextBox.Text);
			SetAnalogOutput(rf1AttenuatorOutputTask, rf1AttenuatorVoltage);
			SetAnalogOutput(rf2AttenuatorOutputTask, rf2AttenuatorVoltage);
		}

		#endregion
	}
}
