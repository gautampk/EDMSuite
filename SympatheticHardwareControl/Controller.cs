using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Runtime.Remoting.Lifetime;
using System.Windows.Forms;
using System.Drawing;

using NationalInstruments;
using NationalInstruments.DAQmx;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using NationalInstruments.VisaNS;

using DAQ.HAL;
using DAQ.Environment;

using NationalInstruments.Vision;
using NationalInstruments.Vision.Acquisition.Imaqdx;
using NationalInstruments.Vision.Internal;
using NationalInstruments.Vision.WindowsForms.Internal;

using SympatheticHardwareControl.CameraControl;

namespace SympatheticHardwareControl
{
    /// <summary>
    /// This is the interface to the sympathetic specific hardware.
    /// 
    /// There are 2 modes of operation: LOCAL and REMOTE.
    /// When operating in LOCAL, the state displayed on the UI gets directly output to hardware. 
    /// The controller can only read from the UI panel and apply it to hardware. It has no capability of deciding
    /// what to output itself.
    /// In the unusual case when the controller needs to take over (only when stopping and starting control),
    /// it can load a set a parameters to the panel (which then gets applied to hardware in the usual way).
    /// 
    /// </summary>
    public class Controller : MarshalByRefObject, CameraControlable, HardwareReportable
    {
        #region Constants
        //Put any constants and stuff here

        private static string cameraAttributesPath = (string)Environs.FileSystem.Paths["UntriggeredCameraAttributesPath"];
        private static string profilesPath = (string)Environs.FileSystem.Paths["settingsPath"]
            + "SympatheticHardwareController\\";

        private static Hashtable calibrations = Environs.Hardware.Calibrations;
        #endregion

        #region Setup



        // table of all digital analogTasks
        Hashtable digitalTasks = new Hashtable();
        public string p = cameraAttributesPath;
        //Cameras
        IMAQdxCameraControl cam0Control;


        // Declare that there will be a controlWindow
        ControlWindow controlWindow;
        ImageViewerWindow imageWindow;
        HardwareMonitorWindow monitorWindow;

        //private bool sHCUIControl;
        public enum SHCUIControlState { OFF, LOCAL, REMOTE };
        public SHCUIControlState HCState = new SHCUIControlState();

        //private DataStore dataStore = new DataStore();
        private class cameraNotFoundException : ArgumentException { };

        
        hardwareState currentState;
        private Dictionary<string, Task> analogTasks;

        // without this method, any remote connections to this object will time out after
        // five minutes of inactivity.
        // It just overrides the lifetime lease system completely.
        public override Object InitializeLifetimeService()
        {
            return null;
        }


        public void Start()
        {

            // make the digital analogTasks. The function "CreateDigitalTask" is defined later
            //e.g   CreateDigitalTask("notEOnOff");
            //      CreateDigitalTask("eOnOff");

            analogTasks = new Dictionary<string, Task>();
            currentState = new hardwareState();
            currentState.analogs = new Dictionary<string, double>();
            currentState.digitals = new Dictionary<string, bool>();
            

            CreateDigitalTask("aom0enable");
            CreateDigitalTask("aom1enable");
            CreateDigitalTask("aom2enable");
            CreateDigitalTask("aom3enable");

            // make the analog output analogTasks. The function "CreateAnalogOutputTask" is defined later
            //e.g.  bBoxAnalogOutputTask = CreateAnalogOutputTask("b");
            //      steppingBBiasAnalogOutputTask = CreateAnalogOutputTask("steppingBBias");

            CreateAnalogOutputTask("aom0amplitude");
            CreateAnalogOutputTask("aom0frequency");
            CreateAnalogOutputTask("aom1amplitude");
            CreateAnalogOutputTask("aom1frequency");
            CreateAnalogOutputTask("aom2amplitude");
            CreateAnalogOutputTask("aom2frequency");
            CreateAnalogOutputTask("aom3amplitude");
            CreateAnalogOutputTask("aom3frequency");
            CreateAnalogOutputTask("coil0current");
            CreateAnalogOutputTask("coil1current");
            
            CreateAnalogInputTask("laserLockErrorSignal", -10, 10);
            CreateAnalogInputTask("chamber1Pressure");

            // make analog input analogTasks. "CreateAnalogInputTask" is defined later
            //e.g   probeMonitorInputTask = CreateAnalogInputTask("probePD", 0, 5);
            //      pumpMonitorInputTask = CreateAnalogInputTask("pumpPD", 0, 5);

            //readAnalogVoltageTask = CreateAnalogInputTask("testAI");
            // make the control controlWindow
            controlWindow = new ControlWindow();
            controlWindow.controller = this;
            

            imageWindow = new ImageViewerWindow();
            imageWindow.controller = this;


            

            HCState = SHCUIControlState.OFF;

            // run
            //Application.Run(imageWindow);
            //Application.Run(controlWindow);

             Application.Run(controlWindow);

        }

        // this method runs immediately after the GUI sets up
        internal void WindowLoaded()
        {
            try
            {
                cam0Control = new IMAQdxCameraControl("cam0", cameraAttributesPath);
                cam0Control.InitializeCamera();
                imageWindow.Show();

            }
            catch (ImaqdxException e)
            {
                MessageBox.Show(e.Message, "Camera Initialization Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();

            }
            finally
            {
                setUIValues(loadParameters(profilesPath + "StoppedParameters.bin"));
                UpdateHardware();
            }

        }

        public void Stop()
        {
            // things like saving parameters, turning things off before quitting the program should go here
            StopCameraStream();
            try
            {
                cam0Control.CloseCamera();
            }
            catch { }
            Application.Exit();
        }
        public void OpenNewHardwareMonitorWindow()
        {
            monitorWindow = new HardwareMonitorWindow();
            monitorWindow.controller = this;
            monitorWindow.Show();
        }
        #endregion

        #region private methods for creating un-timed Tasks/channels
        // a list of functions for creating various analogTasks
        private void CreateAnalogInputTask(string channel)
        {
            analogTasks[channel] = new Task(channel);
            ((AnalogInputChannel)Environs.Hardware.AnalogInputChannels[channel]).AddToTask(
                analogTasks[channel],
                0,
                10
            );
            analogTasks[channel].Control(TaskAction.Verify);
        }

        // an overload to specify input range
        private void CreateAnalogInputTask(string channel, double lowRange, double highRange)
        {
            analogTasks[channel] = new Task(channel);
            ((AnalogInputChannel)Environs.Hardware.AnalogInputChannels[channel]).AddToTask(
                analogTasks[channel],
                lowRange,
                highRange
            );
            analogTasks[channel].Control(TaskAction.Verify);
        }


        private void CreateAnalogOutputTask(string channel)
        {
            currentState.analogs[channel] = (double)0.0;
            analogTasks[channel] = new Task(channel);
            AnalogOutputChannel c = ((AnalogOutputChannel)Environs.Hardware.AnalogOutputChannels[channel]);
            c.AddToTask(
                analogTasks[channel],
                c.RangeLow,
                c.RangeHigh
                );
            analogTasks[channel].Control(TaskAction.Verify);
        }

        // setting an analog voltage to an output
        private void SetAnalogOutput(string channel, double voltage)
        {
            SetAnalogOutput(channel, voltage, false);
        }
        //Overload for using a calibration before outputting to hardware
        private void SetAnalogOutput(string channelName, double voltage, bool useCalibration)
        {
            
            AnalogSingleChannelWriter writer = new AnalogSingleChannelWriter(analogTasks[channelName].Stream);
            double output;
            if (useCalibration)
            {
                try
                {
                    output = ((Calibration)calibrations[channelName]).Convert(voltage);
                }
                catch
                {
                    MessageBox.Show("Calibration error");
                    output = voltage;
                }
            }
            else
            {
                output = voltage;
            }
            try
            {
                writer.WriteSingleSample(true, output);
                analogTasks[channelName].Control(TaskAction.Unreserve);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // reading an analog voltage from input
        private double ReadAnalogInput(string channel)
        {
            return ReadAnalogInput(channel, false);
        }
        private double ReadAnalogInput(string channelName, bool useCalibration)
        {
            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogTasks[channelName].Stream);
            double val = reader.ReadSingleSample();
            analogTasks[channelName].Control(TaskAction.Unreserve);
            if (useCalibration)
            {
                try
                {
                    return ((Calibration)calibrations[channelName]).Convert(val);
                }
                catch
                {
                    MessageBox.Show("Calibration error");
                    return val;
                }
            }
            else
            {
                return val;
            }
        }
        
        // overload for reading multiple samples
        private double ReadAnalogInput(string channel, double sampleRate, int numOfSamples, bool useCalibration)
        {
            //Configure the timing parameters of the task
            analogTasks[channel].Timing.ConfigureSampleClock("", sampleRate,
                SampleClockActiveEdge.Rising, SampleQuantityMode.FiniteSamples, numOfSamples);

            //Read in multiple samples
            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogTasks[channel].Stream);
            double[] valArray = reader.ReadMultiSample(numOfSamples);
            analogTasks[channel].Control(TaskAction.Unreserve);

            //Calculate the average of the samples
            double sum = 0;
            for (int j = 0; j < numOfSamples; j++)
            {
                sum = sum + valArray[j];
            }
            double val = sum / numOfSamples;
            if (useCalibration)
            {
                try
                {
                    return ((Calibration)calibrations[channel]).Convert(val);
                }
                catch
                {
                    MessageBox.Show("Calibration error");
                    return val;
                }
            }
            else
            {
                return val;
            }
        }


        private void CreateDigitalTask(String name)
        {
            currentState.digitals[name] = false;
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

        #region keeping track of the things on this controller!

        [Serializable]
        private struct hardwareState
        {
            public Dictionary<string, double> analogs;
            public Dictionary<string, bool> digitals;
        }
        

        #endregion

        #region Saving and loading experimental parameters
        // Saving the parameters when closing the controller
        public void SaveParametersWithDialog()
        {
            hardwareState state = readUIValues();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "shc parameters|*.bin";
            saveFileDialog1.Title = "Save parameters";
            saveFileDialog1.InitialDirectory = profilesPath;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    StoreParameters(saveFileDialog1.FileName, state);
                }
            }
        }

        private void StoreParameters(String dataStoreFilePath, hardwareState state)
        {
            BinaryFormatter s = new BinaryFormatter();
            FileStream fs = new FileStream(dataStoreFilePath, FileMode.Create);
            try
            {
                //s.Serialize(fs, dataStore);
                s.Serialize(fs, state);
            }
            catch (Exception)
            {
                Console.Out.WriteLine("Saving failed");
            }
            finally
            {
                fs.Close();
                controlWindow.WriteToConsole("Saved parameters to " + dataStoreFilePath);
            }

        }

        //Load parameters when opening the controller
        public void LoadParametersWithDialog()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "shc parameters|*.bin";
            dialog.Title = "Load parameters";
            dialog.InitialDirectory = profilesPath;
            dialog.ShowDialog();
            if (dialog.FileName != "") setUIValues(loadParameters(dialog.FileName));
        }

        private hardwareState loadParameters(String dataStoreFilePath)
        {
            // deserialize
            BinaryFormatter s = new BinaryFormatter();
            FileStream fs;
            hardwareState state = new hardwareState();
            fs = new FileStream(dataStoreFilePath, FileMode.Open);
            try
            {
                state = (hardwareState)s.Deserialize(fs);
            }
            catch (Exception e)
            { MessageBox.Show(e.Message); }
            finally
            {
                fs.Close();
                controlWindow.WriteToConsole("Loaded parameters from " + dataStoreFilePath);
            }
            return state;
        }
        #endregion

        #region Controlling hardware and UI.
        //This gets/sets the values on the GUI panel

        

        #region updating the hardware

        public void ReapplyStateToHardware()
        {
            hardwareState uiState = readUIValues(currentState.digitals.Keys, currentState.analogs.Keys);
            if (HCState == SHCUIControlState.OFF)
            {

                HCState = SHCUIControlState.LOCAL;
                controlWindow.UpdateUIState(HCState);

                ApplyAnalogsToHardware(uiState);
                ApplyDigitalsToHardware(uiState);

                HCState = SHCUIControlState.OFF;
                controlWindow.UpdateUIState(HCState);

                currentState = uiState;

                controlWindow.WriteToConsole("Reapplied Hardware State.");
            }
        }


        public void UpdateHardware()
        {
            hardwareState uiState = readUIValues(currentState.digitals.Keys, currentState.analogs.Keys);
            hardwareState differences = getChangesToState(currentState, uiState);
            if (differences.analogs.Count != 0 || differences.digitals.Count != 0)
            {
                if (HCState == SHCUIControlState.OFF)
                {

                    HCState = SHCUIControlState.LOCAL;
                    controlWindow.UpdateUIState(HCState);

                    ApplyAnalogsToHardware(differences);
                    ApplyDigitalsToHardware(differences);

                    HCState = SHCUIControlState.OFF;
                    controlWindow.UpdateUIState(HCState);

                    applyChangesToControllerCopy(differences, currentState);

                    controlWindow.WriteToConsole("Update finished!");
                }
            }
            else
            {
                controlWindow.WriteToConsole("I can't find any changes to make. Hardware must be up to date.");
            }
        }
        private hardwareState getChangesToState(hardwareState oldState, hardwareState newState)
        {
            hardwareState state = new hardwareState();
            state.analogs = new Dictionary<string, double>();
            state.digitals = new Dictionary<string, bool>();
            foreach(KeyValuePair<string, double> pairs in oldState.analogs)
            {
                if (oldState.analogs[pairs.Key] != newState.analogs[pairs.Key])
                {
                    state.analogs[pairs.Key] = newState.analogs[pairs.Key];
                }
            }
            foreach (KeyValuePair<string, bool> pairs in oldState.digitals)
            {
                if (oldState.digitals[pairs.Key] != newState.digitals[pairs.Key])
                {
                    state.digitals[pairs.Key] = newState.digitals[pairs.Key];
                }
            }
            return state;
        }
        private void applyChangesToControllerCopy(hardwareState changes, hardwareState controllerCopy)
        {
            foreach (KeyValuePair<string, double> pairs in changes.analogs)
            {
                controllerCopy.analogs[pairs.Key] = changes.analogs[pairs.Key];
            }
            foreach (KeyValuePair<string, bool> pairs in changes.digitals)
            {
                controllerCopy.digitals[pairs.Key] = changes.digitals[pairs.Key];
            }
        }
        private void ApplyAnalogsToHardware(hardwareState state)
        {
            foreach (KeyValuePair<string, double> pairs in state.analogs)
            {

                if (calibrations.ContainsKey(pairs.Key))
                {
                    SetAnalogOutput(pairs.Key, pairs.Value, true);
                }
                else
                {
                    SetAnalogOutput(pairs.Key, pairs.Value);
                }
                controlWindow.WriteToConsole("Updated " + pairs.Key.ToString() + " to " + pairs.Value.ToString());
            }
        }
        private void ApplyDigitalsToHardware(hardwareState state)
        {
            foreach (KeyValuePair<string, bool> pairs in state.digitals)
            {
                SetDigitalLine(pairs.Key, pairs.Value);
                controlWindow.WriteToConsole("Updated " + pairs.Key.ToString() + " to " + pairs.Value.ToString());
            }
        }
        #endregion 

        #region Reading and Writing to UI
        private hardwareState readUIValues()
        {
            return readUIValues(currentState.digitals.Keys, currentState.analogs.Keys);
        }
        private hardwareState readUIValues(Dictionary<string, bool>.KeyCollection digitalKeys, 
            Dictionary<string, double>.KeyCollection analogKeys)
        {
            hardwareState state = new hardwareState();
            state.analogs = readUIAnalogs(analogKeys);
            state.digitals = readUIDigitals(digitalKeys);
            return state;
        }
        private Dictionary<string, double> readUIAnalogs(Dictionary<string, double>.KeyCollection keys)
        {
            Dictionary<string, double> analogs = new Dictionary<string, double>();
            string[] keyArray = new string[keys.Count];
            keys.CopyTo(keyArray, 0);
            for (int i = 0; i < keys.Count; i++)
            {
                analogs[keyArray[i]] = controlWindow.ReadAnalog(keyArray[i]);
            }
            return analogs;
        }
        private Dictionary<string, bool> readUIDigitals(Dictionary<string, bool>.KeyCollection keys)
        {
            Dictionary<string, bool> digitals = new Dictionary<string,bool>();
            string[] keyArray = new string[keys.Count];
            keys.CopyTo(keyArray, 0);
            for (int i = 0; i < keys.Count; i++)
            {
                digitals[keyArray[i]] = controlWindow.ReadDigital(keyArray[i]);
            }
            return digitals;
        }
       

        private void setUIValues(hardwareState state)
        {
            setUIAnalogs(state);
            setUIDigitals(state);
        }
        private void setUIAnalogs(hardwareState state)
        {
            foreach (KeyValuePair<string, double> pairs in state.analogs)
            {
                    controlWindow.SetAnalog(pairs.Key, (double)pairs.Value);
            }
        }
        private void setUIDigitals(hardwareState state)
        {
            foreach (KeyValuePair<string, bool> pairs in state.digitals)
            {
                controlWindow.SetDigital(pairs.Key, (bool)pairs.Value);
            }
        }
        #endregion

        #region remoting stuff

        public void StartRemoteControl()
        {
            if (HCState == SHCUIControlState.OFF)
            {
                if (streaming)
                {
                    StopCameraStream();
                }             
                StoreParameters(profilesPath + "tempParameters.bin", currentState);
                HCState = SHCUIControlState.REMOTE;
                controlWindow.UpdateUIState(HCState);
                controlWindow.WriteToConsole("Remoting Started!");
            }
            else
            {
                MessageBox.Show("Controller is busy");
            }

        }
        public void StopRemoteControl()
        {
            try
            {
                controlWindow.WriteToConsole("Remoting Stopped!");
                setUIValues(loadParameters(profilesPath + "tempParameters.bin"));
                
                if (System.IO.File.Exists(profilesPath + "tempParameters.bin"))
                {
                    System.IO.File.Delete(profilesPath + "tempParameters.bin");
                }
            }
            catch (Exception)
            {
                Console.Out.WriteLine("Unable to load Parameters.");
            }
            HCState = SHCUIControlState.OFF;
            controlWindow.UpdateUIState(HCState);
            ReapplyStateToHardware();
        }
        #endregion
        #endregion

        //camera stuff

        #region Testing the camera
        //untriggered single shot commands. This just starts a new Session, takes one image then closes the Session.
        //Avoid using these. I think, there should only be a single Session per camera for the entire time the program is running.
        //I wrote these to test the camera.
        //Cameras
        /* public const string motCamera = "cam0";
        
         public void CameraSnapshot()
         {
             VisionImage image = new VisionImage();
             ImaqdxSession Session = new ImaqdxSession(motCamera);
             Session.Snap(image);
             Session.Close();
            
             if (controlWindow.saveImageCheckBox.Checked == true)
             {
                 StoreImage(image);
             }
             controlWindow.AttachToViewer(controlWindow.motViewer, image);

         }

         public void CameraSnapshot(string dataStoreFilePath)
         {
             VisionImage image = new VisionImage();
             ImaqdxSession Session = new ImaqdxSession(motCamera);
             Session.Snap(image);
             Session.Close();
            
             if (controlWindow.saveImageCheckBox.Checked == true)
             {
                 StoreImage(dataStoreFilePath, image);
             }
            
             controlWindow.AttachToViewer(controlWindow.motViewer, image);
         }
         //streaming video
         public object streamStopLock = new object();
         public void CameraStream()
         {
             Thread streamThread = new Thread(new ThreadStart(streamAndDisplay));
             streamThread.Start();
         }
         private void streamAndDisplay()
         {
             this.Streaming = true;
             VisionImage image = new VisionImage();
             ImaqdxSession Session = new ImaqdxSession(motCamera);
             Session.ConfigureGrab();
             controlWindow.AttachToViewer(controlWindow.motViewer, image);
             for (; ; )
             {
                 Session.Grab(image, true);
                 controlWindow.UpdateViewer(controlWindow.motViewer);

                 lock (streamStopLock)
                 {
                     if (Streaming == false)
                     {
                         Session.Close();
                         return;
                     }
                 }

             }
         }*/
        #endregion

        #region Local camera control

        public object streamStopLock = new object();
        public void CameraStream()
        {
            streaming = true;
            Thread streamThread = new Thread(new ThreadStart(streamAndDisplay));
            streamThread.Start();
        }
        public void CameraSnapshot()
        {
            Thread cameraThread = new Thread(new ThreadStart(takeSnapshotAndDisplay));
            cameraThread.Start();
        }

        private void takeSnapshotAndDisplay()
        {
            VisionImage image = new VisionImage();
            cam0Control.Session.Snap(image);
            imageWindow.Image = image;
        }

        private void streamAndDisplay()
        {
            controlWindow.WriteToConsole("Streaming from camera");
            VisionImage image = new VisionImage();
            cam0Control.Session.ConfigureGrab();
            for (; ; )
            {
                try
                {
                    cam0Control.Session.Grab(image, true);
                }
                catch (ImaqdxException e)
                { MessageBox.Show("You're probably already streaming...\n" + e.Message); }
                catch (InvalidOperationException e)
                {
                    MessageBox.Show("Something bad happened. Stopping the image stream.\n" + e.Message); 
                    streaming = false;
                }
                lock (streamStopLock)
                {
                    imageWindow.Image = image;
                    if (!streaming)
                    {
                        cam0Control.Session.Acquisition.Stop();
                        controlWindow.WriteToConsole("Streaming stopped");
                        return;
                    }
                }

            }
        }
        private bool streaming = false;
        public void StopCameraStream()
        {
            streaming = false;
        }

        public void SetCameraAttributes()
        {
            cam0Control.SetCameraAttributes();
        }

        #endregion

        #region Saving and Loading Images

        private ImageFileIOManager imageFileIO = new ImageFileIOManager();
        public void SaveImageWithDialog()
        {
            imageFileIO.SaveImageWithDialog(imageWindow.Image);
        }
        public void LoadImagesWithDialog()
        {
            imageWindow.Image = imageFileIO.LoadImagesWithDialog();
        }

        #endregion

        #region Remote Image Processing
        //Written for taking images triggered by TTL. This "Arm" sets the camera so it's expecting a TTL.
        private void armCameraAndWait(VisionImage image, string cameraAttributesPath)
        {
            cam0Control.SetCameraAttributes(cameraAttributesPath);
            cam0Control.Session.Snap(image);
        }
        public byte[,] GrabImage(string cameraAttributesPath)
        {

            isDone = false;
            VisionImage image = new VisionImage();
            armCameraAndWait(image, cameraAttributesPath);
            imageWindow.Image = image;
            PixelValue2D pval = image.ImageToArray();
            isDone = true;
            return pval.U8;
        }

        private bool isDone;
        public bool IsDone()
        {
            return isDone;
        }
        public bool PrepareRemoteCameraControl()
        {
            StartRemoteControl();
            return true;
        }
        public bool FinishRemoteCameraControl()
        {
            StopRemoteControl();
            cam0Control.SetCameraAttributes(cameraAttributesPath);
            return true;
        }
        #endregion

        #region Hardware Monitor

        #region Laser Lock Error Monitor

        public object leStopLock = new object();
        private bool monitorLE = false;
        public double LaserLockErrorThreshold = new double();

        public void StartMonitoringLaserErrorSignal()
        {
            monitorLE = true;
            Thread LLEThread = new Thread(new ThreadStart(leMonitorLoop));
            LLEThread.Start();
        }
        

        private double getLaserThresholdFromUI()
        {
            return monitorWindow.GetLaserErrorSignalThreshold();
        }

        private void leMonitorLoop()
        {
            Color ledColor = new Color();
            while (monitorLE)
            {
                Thread.Sleep(1000);

                LaserLockErrorThreshold = getLaserThresholdFromUI();

                double error = ReadLaserErrorSignal();
                
                bool isLocked = isLaserLocked(LaserLockErrorThreshold, error);
                
                if (isLocked)
                {
                    ledColor = Color.LightGreen;
                }
                else
                {
                    ledColor = Color.Red;
                    MessageBox.Show("Careful! Laser appears to be unlocked!");
                }
                lock (leStopLock)
                {

                    monitorWindow.SetLaserErrorSignal(error, ledColor);
                    if (!monitorLE)
                    {
                        return;
                    }
                }

            }
        }
        private bool isLaserLocked(double threshold, double error)
        {
            if (-threshold <= error && error <= threshold)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void StopMonitoringLaserErrorSignal()
        {
            monitorLE = false;
        }

        public double ReadLaserErrorSignal()
        {
            double es = 10;
            try
            {
                es = ReadAnalogInput("laserLockErrorSignal");
            }
            catch
            {
            }
            return es;
        }
        #endregion

        #region Pressure Gauges

        #region Chamber 1
        private bool monitorC1P = false;
        public object c1pStopLock = new object();


        public void StartChamber1PressureMonitor()
        {
            monitorC1P = true;
            Thread C1PThread = new Thread(new ThreadStart(chamber1PressureMonitorLoop));
            C1PThread.Start();
        }


        private void chamber1PressureMonitorLoop()
        {
            while (monitorC1P)
            {
                Thread.Sleep(1000);
                double pressure = ReadChannel1Pressure();                
                lock (c1pStopLock)
                {
                    monitorWindow.SetChamber1Pressure(pressure);
                    if (!monitorC1P)
                    {
                        return;
                    }
                }

            }
        }

        public double ReadChannel1Pressure()
        {
            double value = 10;
            try
            {
                value = ReadAnalogInput("chamber1Pressure", true);
            }
            catch
            {
            }
            return value;
        }

        public void StopChamber1PressureMonitor()
        {
            monitorC1P = false;
        }

        #endregion
        #endregion

        #region Remote Access for Hardware Monitor

        public Dictionary<String, Object> GetHardwareReport()
        {
            Dictionary<String, Object> report = new Dictionary<String, Object>();
            report["laserLockErrorSignal"] = ReadLaserErrorSignal();
            report["chamber1Pressure"] = ReadChannel1Pressure();
            return report;
        }
        #endregion

        #endregion
    }
}
