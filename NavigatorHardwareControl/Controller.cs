﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Runtime.Remoting.Lifetime;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows;
using IMAQ;

using NationalInstruments;
using NationalInstruments.DAQmx;
using NationalInstruments.ModularInstruments.Interop;
using NationalInstruments.UI;
using NationalInstruments.VisaNS;

using DAQ;
using DAQ.HAL;
using DAQ.Environment;


namespace NavigatorHardwareControl
{
    /// <summary>
    /// This is the interface to the Navigator hardware controller and is based largely on the sympathetic hardware controller.
    /// </summary>
    public class Controller : MarshalByRefObject
    {
        
        #region Constants
        private static string cameraAttributesPath = (string)Environs.FileSystem.Paths["cameraAttributesPath"];
        private static Hashtable calibrations = Environs.Hardware.Calibrations;
        private static string profilesPath = (string)Environs.FileSystem.Paths["settingsPath"]
            + "NavigatorHardwareController\\";
        #endregion

        #region setup
        public ControlWindow controlWindow;

        //table of digital tasks
        private Dictionary<string,Task> digitalTasks;
        
        //dictionary of analog output tasks
        private Dictionary<string, Task> analogOutTasks;
        private Dictionary<string, Task> analogInTasks;

        //enumerate the state of the hardware controller for remoting access
        public enum NavHardwareState { OFF, LOCAL, REMOTE };
        public NavHardwareState hcState = new NavHardwareState();

        public HardwareState hardwareState;
        //Used for keeping track of changes
        public HardwareState previousState;
        // without this method, any remote connections to this object will time out after
        // five minutes of inactivity.
        // It just overrides the lifetime lease system completely.
        public override Object InitializeLifetimeService()
        {
            return null;
        }

        //Create the Muquans Communicator
        public MuquansCommunicator muquans;
        //Used for static outputs of the HSDIO card
        public HSDIOStaticChannelController hsdio;
        //Create an instance of the Fibre Aligner
        public FibreAligner fibreAlign;
        //these are used to handle errors from the slave and aom dds processes
        public StreamReader slaveErr;
        public StreamReader aomErr;
        //Cameras
        public CameraController ImageController;
        public ImageViewer imAnalWindow;
        //Used for locking the laser - only one can be running at once
        private Thread laserThread;
        public void Start()
        {
            if (Environs.Hardware.GetType() != new DAQ.HAL.NavigatorHardware().GetType())
                throw new Exception("Hardware class is inconsistent with this Controller. Please check the Environs configuration.");
            analogOutTasks = new Dictionary<string, Task>();
            analogInTasks = new Dictionary<string, Task>();
            digitalTasks = new Dictionary<string, Task>();
            //initialise the hardware state
            hardwareState = new HardwareState();
            hardwareState.analogs = new Dictionary<string, double>();
            hardwareState.digitals = new Dictionary<string, bool>();
            hardwareState.muquansAnalog = new Dictionary<string, double>();
            hardwareState.muquansDigital = new Dictionary<string, bool>();

            if (!Environs.Debug)
            {
            
                //Only creates these tasks when the Debug flag is set to false. Useful when developing on another computer
                if (Environs.Hardware.Boards.ContainsKey("hsDigital"))
                //The simplest thing is to make all the output channels static.Before running a sequence, the output is aborted and configured for dynamic generation
                {
                    hsdio = new HSDIOStaticChannelController((string)Environs.Hardware.Boards["hsDigital"], "");
                    foreach (DictionaryEntry channel in Environs.Hardware.DigitalOutputChannels)
                    {
                        DigitalOutputChannel doChannel = (DigitalOutputChannel)channel.Value;
                        if (doChannel.Device == (string)Environs.Hardware.Boards["hsDigital"])
                            hsdio.CreateHSDigitalTask((string)channel.Key,doChannel.BitNumber);
                        else
                            CreateDigitalTask((string)channel.Key);
                       }
                }
                else
                foreach (string channel in Environs.Hardware.AnalogOutputChannels.Keys)
                        CreateDigitalTask(channel);
                //Create the analogue tasks
                foreach (string channel in Environs.Hardware.AnalogOutputChannels.Keys)
                    CreateAnalogOutputTask(channel);
                foreach (string channel in Environs.Hardware.AnalogInputChannels.Keys)
                    CreateAnalogInputTask(channel);
               

               try
                {
                    muquans = new MuquansCommunicator();

                    muquans.slaveDDS.EnableRaisingEvents = true;
                    muquans.aomDDS.EnableRaisingEvents = true;

                    //slaveErr = muquans.slaveDDS.StandardError;
                    //aomErr = muquans.aomDDS.StandardError
                    muquans.Start();
                    muquans.slaveDDS.OutputDataReceived += new DataReceivedEventHandler(DDSErrorHandler);
                    muquans.aomDDS.ErrorDataReceived += new DataReceivedEventHandler(DDSErrorHandler);

                    //Starts the DDS programs - these port numbers depend on the virtual COM ports use
                    ProcessStartInfo slaveInfo = muquans.ConfigureDDS("slave", 18);
                    ProcessStartInfo aomInfo = muquans.ConfigureDDS("aom", 20);

                    muquans.slaveDDS.StartInfo = slaveInfo;
                    muquans.aomDDS.StartInfo = aomInfo;
                    muquans.slaveDDS.Start();
                    muquans.aomDDS.Start();

                   //Adds Muquans parameters to hardwareState - probably a better way to define this
                    hardwareState.muquansAnalog["Slave0dds"] = 0.0;
                    hardwareState.muquansAnalog["Slave1dds"] = 0.0;
                    hardwareState.muquansAnalog["Slave2dds"] = 0.0;
                    hardwareState.muquansAnalog["Ramandds"] = 0.0;
                    hardwareState.muquansAnalog["Mphidds"] = 0.0;
                    hardwareState.muquansAnalog["Motdds"] = 0.0;
                    hardwareState.muquansAnalog["EDFA0Val"] = 0.0;
                    hardwareState.muquansAnalog["EDFA1Val"] = 0.0;
                    hardwareState.muquansAnalog["EDFA2Val"] = 0.0;
                    hardwareState.muquansAnalog["MOTaomdds"] = 0.0;
                    hardwareState.muquansAnalog["Ramanaomdds"] = 0.0;


                    hardwareState.muquansDigital["MasterLock"] = false;
                    hardwareState.muquansDigital["Slave0Lock"] = false;
                    hardwareState.muquansDigital["Slave1Lock"] = false;
                    hardwareState.muquansDigital["Slave2Lock"] = false;
                    hardwareState.muquansDigital["EDFA0Lock"] = false;
                    hardwareState.muquansDigital["EDFA1Lock"] = false;
                    hardwareState.muquansDigital["EDFA2Lock"] = false;
                    hardwareState.muquansDigital["EDFA0Type"] = false;
                    hardwareState.muquansDigital["EDFA1Type"] = false;
                    hardwareState.muquansDigital["EDFA2Type"] = false;


                }
                catch(Exception e)
                {
                    Console.WriteLine("Couldn't start Muquans communication: " + e.Message);
                }
        
        
            }
            else
            {
                muquans = new MuquansCommunicator();
                muquans.Start();

                hardwareState.muquansAnalog["Slave0dds"] = 0.0;
                hardwareState.muquansAnalog["Slave1dds"] = 0.0;
                hardwareState.muquansAnalog["Slave2dds"] = 0.0;
                hardwareState.muquansAnalog["Ramandds"] = 0.0;
                hardwareState.muquansAnalog["Mphidds"] = 0.0;
                hardwareState.muquansAnalog["Motdds"] = 0.0;
                hardwareState.muquansAnalog["EDFA0Val"] = 0.0;
                hardwareState.muquansAnalog["EDFA1Val"] = 0.0;
                hardwareState.muquansAnalog["EDFA2Val"] = 0.0;

                hardwareState.muquansDigital["MasterLock"] = false;
                hardwareState.muquansDigital["Slave0Lock"] = false;
                hardwareState.muquansDigital["Slave1Lock"] = false;
                hardwareState.muquansDigital["Slave2Lock"] = false;
                hardwareState.muquansDigital["EDFA0Lock"] = false;
                hardwareState.muquansDigital["EDFA1Lock"] = false;
                hardwareState.muquansDigital["EDFA2Lock"] = false;
                hardwareState.muquansDigital["EDFA0Type"] = false;
                hardwareState.muquansDigital["EDFA1Type"] = false;
                hardwareState.muquansDigital["EDFA2Type"] = false;

            }
            fibreAlign = new FibreAligner("horizPiezo", "vertPiezo", "fibrePD");
            fibreAlign.controller = this;
           
        }

        #endregion

        #region Parameter Serialisation and Hardware State Tracking
        ///<summary>
        // this is basically just a collection of dictionaries to make it a bit easier to add values as necessary. The keys used are the names of the object that represents them in the hardwarecontroller.
        ///Anytime the hardware gets modified by this program, the stateRecord get updated. Don't hack this. 
        /// It's useful to know what the hardware is doing at all times.
        /// When switching to REMOTE, the updates no longer happen. That's why we store the state before switching to REMOTE and apply the state
        /// back again when returning to LOCAL.
        /// </summary>
        [Serializable]
        public class HardwareState
        {
            //TODO make the objects that reference hardware not controlled via analogue/digital values behave properly

            public Dictionary<string, double> analogs {get; set;}
            public Dictionary<string, bool> digitals { get; set; }

            public Dictionary<string, double> muquansAnalog { get; set; }
            public Dictionary<string, bool> muquansDigital { get; set; }

        }

        public void SaveParametersWithDialog()
        {
            readValuesOnUI();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "nav parameters|*.bin";
            saveFileDialog1.Title = "Save parameters";
            String settingsPath = (string)Environs.FileSystem.Paths["settingsPath"];
            String hardwareStateDir = settingsPath + "NavHardwareController";
            saveFileDialog1.InitialDirectory = hardwareStateDir;
            if (saveFileDialog1.ShowDialog()==true)
            {
                if (saveFileDialog1.FileName != "")
                {
                    StoreParameters(saveFileDialog1.FileName);
                }
            }
        }

        public void StoreParameters()
        {
            hardwareState = readValuesOnUI();
            String settingsPath = (string)Environs.FileSystem.Paths["settingsPath"];
            String hardwareStateFilePath = settingsPath + "\\NavHardwareController\\parameters.bin";
            StoreParameters(hardwareStateFilePath);
        }

        public void StoreParameters(String hardwareStateFilePath)
        {
            // serialize it
            BinaryFormatter s = new BinaryFormatter();
            try
            {
                s.Serialize(new FileStream(hardwareStateFilePath, FileMode.Create), hardwareState);
            }
            catch (Exception)
            { Console.Out.WriteLine("Unable to store settings"); }
        }

        public void LoadParametersWithDialog()
        {
            //TODO fix deserialisation of binary object for UIData class.
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "navhc parameters|*.bin";
            dialog.Title = "Load parameters";
            String settingsPath = (string)Environs.FileSystem.Paths["settingsPath"];
            String hardwareStateDir = settingsPath + "NavHardwareController";
            dialog.InitialDirectory = hardwareStateDir;
            dialog.ShowDialog();
            if (dialog.FileName != "") hardwareState = LoadParameters(dialog.FileName);
            setValuesDisplayedOnUI(hardwareState);
        }

        private HardwareState LoadParameters()
        {
            String settingsPath = (string)Environs.FileSystem.Paths["settingsPath"];
            String hardwareStateFilePath = settingsPath + "\\NavHardwareController\\parameters.bin";
            return LoadParameters(hardwareStateFilePath);
        }

        private HardwareState LoadParameters(String hardwareStateFilePath)
        {
            // deserialize
            BinaryFormatter s = new BinaryFormatter();
            HardwareState hardwareState = new HardwareState();
            // eat any errors in the following, as it's just a convenience function
            try
            {
                hardwareState = (HardwareState)s.Deserialize(new FileStream(hardwareStateFilePath, FileMode.Open));
            }
            catch (Exception e)
            { Console.WriteLine("Unable to load settings: "+e.Message); }
            return hardwareState;
        }


        #endregion

        #region Hardware task creation methods
        private void CreateAnalogInputTask(string channel)
        {

            Task task = new Task("NavHCIn" + channel);
            ((AnalogInputChannel)Environs.Hardware.AnalogInputChannels[channel]).AddToTask(
                task,
                0,
                10
            );
            task.Control(TaskAction.Verify);
            analogInTasks.Add(channel, task);
        }

        private void CreateAnalogInputTask(string channel, double lowRange, double highRange)
        {
            Task task = new Task("NavHCIn" + channel);
            ((AnalogInputChannel)Environs.Hardware.AnalogInputChannels[channel]).AddToTask(
                task,
                lowRange,
                highRange
            );
            task.Control(TaskAction.Verify);
            analogInTasks.Add(channel, task);
        }

        private void CreateAnalogOutputTask(string channel)
        {
            hardwareState.analogs[channel] = 0.0;
            Task task = new Task("NavHCOut" + channel);
            AnalogOutputChannel c = ((AnalogOutputChannel)Environs.Hardware.AnalogOutputChannels[channel]);
            c.AddToTask(
                task,
                c.RangeLow,
                c.RangeHigh
                );
            task.Control(TaskAction.Verify);
            analogOutTasks.Add(channel, task);
        }
        //TODO implement Creation of Task with multiple channels

        // setting an analog voltage to an output. Since the hardware state also keeps track of the muquans laser values which are set elsewhere, for the moment this does nothing with them.
        private void SetAnalogOutput(string channel, double voltage)
        {
            if(analogOutTasks.ContainsKey(channel))
                SetAnalogOutput(channel, voltage, false);
   

        }
        //Overload for using a calibration before outputting to hardware
        private void SetAnalogOutput(string channelName, double voltage, bool useCalibration)
        {

            AnalogSingleChannelWriter writer = new AnalogSingleChannelWriter(analogOutTasks[channelName].Stream);
            double output;
            if (useCalibration)
            {
                try
                {
                    output = ((Calibration)calibrations[channelName]).Convert(voltage);
                }
                catch (DAQ.HAL.Calibration.CalibrationRangeException)
                {
                    MessageBox.Show("The number you have typed is out of the calibrated range! \n Try typing something more sensible.");
                    throw new CalibrationException();
                }
                catch
                {
                    MessageBox.Show("Calibration error");
                    throw new CalibrationException();
                }
            }
            else
            {
                output = voltage;
            }
            try
            {
                writer.WriteSingleSample(true, output);
                analogOutTasks[channelName].Control(TaskAction.Unreserve);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public class CalibrationException : ArgumentOutOfRangeException { };
        // reading an analog voltage from input
        public double ReadAnalogInput(string channel)
        {
            return ReadAnalogInput(channel, false);
        }
        public double ReadAnalogInput(string channelName, bool useCalibration)
        {
            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTasks[channelName].Stream);
            double val = reader.ReadSingleSample();
            analogInTasks[channelName].Control(TaskAction.Unreserve);
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

        public object ReadAnalogInput(string channel, double sampleRate, int numOfSamples, bool average)
        {
            Task task = analogInTasks[channel];
            //Configure the timing parameters of the task
            task.Timing.ConfigureSampleClock("", sampleRate,
                SampleClockActiveEdge.Rising, SampleQuantityMode.FiniteSamples, numOfSamples);

            //Read in multiple samples
            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(task.Stream);
            double[] valArray = reader.ReadMultiSample(numOfSamples);
            task.Control(TaskAction.Unreserve);
            if (!average)
                return valArray;
            else
            {   //Calculate the average of the samples
                double sum = 0;
                for (int j = 0; j < numOfSamples; j++)
                {
                    sum = sum + valArray[j];
                }
                double val = sum / numOfSamples;
                return val;
            }
        }

        private void CreateDigitalTask(String name)
        {
            hardwareState.digitals[name] = false;
            Task digitalTask = new Task(name);
            ((DigitalOutputChannel)Environs.Hardware.DigitalOutputChannels[name]).AddToTask(digitalTask);
            digitalTask.Control(TaskAction.Verify);
            digitalTasks.Add(name, digitalTask);
        }


        // We won't be using digital inputs but I'll leave this here in case
        //private void CreateDigitalInputTask(String name)
        //{
        //    Task digitalInputTask = new Task(name);
        //    ((DigitalInputChannel)Environs.Hardware.DigitalInputChannels[name]).AddToTask(digitalInputTask);
        //    digitalInputTask.Control(TaskAction.Verify);
        //    digitalInputTasks.Add(name, digitalInputTask);
        //}
        //
        //bool ReadDigitalLine(string name)
        //{
        //    Task digitalInputTask = ((Task)digitalInputTasks[name]);
        //    DigitalSingleChannelReader reader = new DigitalSingleChannelReader(digitalInputTask.Stream);
        //    bool digSample = reader.ReadSingleSampleSingleLine();
        //    digitalInputTask.Control(TaskAction.Unreserve);
        //    return digSample;
        //}

        private void SetDigitalLine(string name, bool value)
        {
            if (digitalTasks.ContainsKey(name))
            {
                Task digitalTask = digitalTasks[name];
                DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalTask.Stream);
                writer.WriteSingleSampleSingleLine(true, value);
                digitalTask.Control(TaskAction.Unreserve);
            }
            else
                try
                {
                    hsdio.SetHSDigitalLine(name, value);
                }
                catch (Exception)
                {
                    
                    Console.WriteLine("Couldn't set the ouptut of "+name+". If this is a Muquans laser value, this is expected.");
                }
               
        }
        /// <summary>
        /// Creates a separate task for each hardware channel
        /// </summary>
        private void CreateAllTasks()
        {
            if (Environs.Hardware.Boards.ContainsKey("hsDigital"))
            //The simplest thing is to make all the output channels static.Before running a sequence, the output is aborted and configured for dynamic generation
            {
                hsdio = new HSDIOStaticChannelController((string)Environs.Hardware.Boards["hsDigital"], "");
                foreach (DictionaryEntry channel in Environs.Hardware.DigitalOutputChannels)
                {
                    DigitalOutputChannel doChannel = (DigitalOutputChannel)channel.Value;
                    if (doChannel.Device == (string)Environs.Hardware.Boards["hsDigital"])
                        hsdio.CreateHSDigitalTask((string)channel.Key, doChannel.BitNumber);
                    else
                        CreateDigitalTask((string)channel.Key);
                }
            }
            else
                foreach (string channel in Environs.Hardware.AnalogOutputChannels.Keys)
                    CreateDigitalTask(channel);
            //Create the analogue tasks
            foreach (string channel in Environs.Hardware.AnalogOutputChannels.Keys)
                CreateAnalogOutputTask(channel);
            foreach (string channel in Environs.Hardware.AnalogInputChannels.Keys)
                CreateAnalogInputTask(channel);
               
        }

        /// <summary>
        /// Saves all the parameters from the state record and stops all the tasks
        /// </summary>
        private void FinishAllTasks()
        {
            foreach (string name in analogOutTasks.Keys)
            {
                analogOutTasks[name].Control(TaskAction.Stop);
            }
            foreach (string name in digitalTasks.Keys)
            {
                digitalTasks[name].Control(TaskAction.Stop);
            }
            foreach (string name in analogInTasks.Keys)
            {
                analogInTasks[name].Control(TaskAction.Stop);
            }
            //Releases the hsdio card
            hsdio.ReleaseHardware();
            
            
        }
        #endregion

        #region Controlling Hardware with UI

        #region Hardware Update
            public void ApplyRecordedStateToHardware()
        {
            applyToHardware(hardwareState);          
        }


        public void UpdateHardware()
        {
            if (previousState == null)
            {
                previousState = hardwareState;
                applyToHardware(previousState);
          
            }
            else 
            {
                HardwareState uiState = readValuesOnUI();
                if (uiState.analogs != hardwareState.analogs && uiState.digitals != hardwareState.digitals)
                    controlWindow.WriteToConsole("UI State doesn't match hardware state. Check the values are bound properly");
                HardwareState changes = getDiscrepancies(hardwareState, previousState);
                applyToHardware(changes);
                updateStateRecord(changes);
                previousState = hardwareState;
            }
        }

        private void applyToHardware(HardwareState state)
        {
            if (state.analogs.Count != 0 || state.digitals.Count != 0)
            {
                if (hcState == NavHardwareState.OFF)
                {

                    hcState = NavHardwareState.LOCAL;
                    controlWindow.UpdateUIState(hcState);

                    applyAnalogs(state);
                    applyDigitals(state);

                    hcState = NavHardwareState.OFF;
                    controlWindow.UpdateUIState(hcState);

                    controlWindow.WriteToConsole("Update finished!");
                }
            }
            else
            {
                controlWindow.WriteToConsole("The values on the UI are identical to those on the controller's records. Hardware must be up to date.");
            }
        }

        private HardwareState getDiscrepancies(HardwareState oldState, HardwareState newState)
        {
            HardwareState state = new HardwareState();
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

        private void updateStateRecord(HardwareState changes)
        {
            foreach (KeyValuePair<string, double> pairs in changes.analogs)
            {
                hardwareState.analogs[pairs.Key] = changes.analogs[pairs.Key];
            }
            foreach (KeyValuePair<string, bool> pairs in changes.digitals)
            {
                hardwareState.digitals[pairs.Key] = changes.digitals[pairs.Key];
            }
        }

        
        private void applyAnalogs(HardwareState state)
        {
            List<string> toRemove = new List<string>();  //In case of errors, keep track of things to delete from the list of changes.
            foreach (KeyValuePair<string, double> pairs in state.analogs)
            {
                try
                {
                    if (calibrations.ContainsKey(pairs.Key))
                    {
                        SetAnalogOutput(pairs.Key, pairs.Value, true);

                    }
                    else
                    {
                        SetAnalogOutput(pairs.Key, pairs.Value);
                    }
                    controlWindow.WriteToConsole("Set channel '" + pairs.Key.ToString() + "' to " + pairs.Value.ToString());
                }
                catch (CalibrationException)
                {
                    controlWindow.WriteToConsole("Failed to set channel '"+ pairs.Key.ToString() + "' to new value");                    
                    toRemove.Add(pairs.Key);
                }
            }
            foreach (string s in toRemove)  //Remove those from the list of changes, as nothing was done to the Hardware.
            {
                state.analogs.Remove(s);
            }
        }

        private void applyDigitals(HardwareState state)
        {
            foreach (KeyValuePair<string, bool> pairs in state.digitals)
            {
                SetDigitalLine(pairs.Key, pairs.Value);
                controlWindow.WriteToConsole("Set channel '" + pairs.Key.ToString() + "' to " + pairs.Value.ToString());
            }
        }
        #endregion 

        #region Reading and Writing to UI

        private HardwareState readValuesOnUI()
        {
            HardwareState state = new HardwareState();
            state.analogs = readUIAnalogs(hardwareState.analogs.Keys);
            state.digitals = readUIDigitals(hardwareState.digitals.Keys);
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
       

        private void setValuesDisplayedOnUI(HardwareState state)
        {
            setUIAnalogs(state);
            setUIDigitals(state);
        }
        private void setUIAnalogs(HardwareState state)
        {
            foreach (KeyValuePair<string, double> pairs in state.analogs)
            {
                controlWindow.SetAnalog(pairs.Key, (double)pairs.Value);
            }
        }
        private void setUIDigitals(HardwareState state)
        {
            foreach (KeyValuePair<string, bool> pairs in state.digitals)
            {
                controlWindow.SetDigital(pairs.Key, (bool)pairs.Value);
            }
        }

#endregion

        #region Remoting stuff

        /// <summary>
        /// This is used when you want another program to take control of some/all of the hardware. The hc then just saves the
        /// last hardware state, then prevents you from making any changes to the UI. Use this if your other program wants direct control of hardware.
        /// </summary>
        public void StartRemoteControl()
        {
            if (hcState == NavHardwareState.OFF)
            {
                StoreParameters(profilesPath + "tempParameters.bin");
                hcState = NavHardwareState.REMOTE;
                controlWindow.UpdateUIState(hcState);
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
                setValuesDisplayedOnUI(LoadParameters(profilesPath + "tempParameters.bin"));

                if (System.IO.File.Exists(profilesPath + "tempParameters.bin"))
                {
                    System.IO.File.Delete(profilesPath + "tempParameters.bin");
                }
            }
            catch (Exception)
            {
                controlWindow.WriteToConsole("Unable to load Parameters.");
            }
            hcState = NavHardwareState.OFF;
            controlWindow.UpdateUIState(hcState);
            ApplyRecordedStateToHardware();
        }

        /// <summary>
        /// These SetValue functions are for giving commands to the hc from another program, while keeping the hc in control of hardware.
        /// Use this if you want the HC to keep control, but you want to control the HC from some other program
        /// </summary>
        public void SetValue(string channel, double value)
        {
            hcState = NavHardwareState.LOCAL;
            hardwareState.analogs[channel] = value;
            SetAnalogOutput(channel, value, false);
            //TODO Fix this so it properly dispatches the call to another thread
            // controlWindow.console.WriteLine("Set " + channel + " to " + value);
            //setValuesDisplayedOnUI(hardwareState);
            hcState = NavHardwareState.OFF;

        }
        public void SetValue(string channel, double value, bool useCalibration)
        {
            hardwareState.analogs[channel] = value;
            hcState = NavHardwareState.LOCAL;
            SetAnalogOutput(channel, value, useCalibration);
            //controlWindow.console.WriteLine("Set " + channel + " to " + value);
            setValuesDisplayedOnUI(hardwareState);
            hcState = NavHardwareState.OFF;

        }
        public void SetValue(string channel, bool value)
        {
            hcState = NavHardwareState.LOCAL;
            hardwareState.digitals[channel] = value;
            SetDigitalLine(channel, value);
            //controlWindow.console.WriteLine("Set " + channel + " to " + value);
            //setValuesDisplayedOnUI(hardwareState);
            hcState = NavHardwareState.OFF;

        }
        /// <summary>
        /// A generic method to either read the value of an input channel or get the value of one of the outputs using the hardware state
        /// </summary>
        /// <param name="channel"></param>
        /// <returns></returns>
        public object GetValue(string channel)
        {
            object value;
            hcState = NavHardwareState.LOCAL;
            if (analogInTasks.ContainsKey(channel))
            {
                value = ReadAnalogInput(channel);
                return value;  
            }
            foreach( object dict in hardwareState.analogs)
            {
                Dictionary<string,object> item = dict as Dictionary<string, object>;
                if (item.ContainsKey(channel))
                {
                    return item[channel];
                }
            }
            foreach (object dict in hardwareState.digitals)
            {
                Dictionary<string, object> item = dict as Dictionary<string, object>;
                if (item.ContainsKey(channel))
                {
                    return item[channel];
                }
            }
            return "Channel not found in hardware";
        }

        public object GetValue(string channel,double sampleRate, int samples)
        {
            hcState = NavHardwareState.LOCAL;
            if (analogInTasks.ContainsKey(channel))
            {
                double value = (double)ReadAnalogInput(channel,sampleRate,samples,true);
                return value;
            }
            else
            {
                return "Channel not an input channel. Use GetValue(channel)";
            }
        }

        public Dictionary<string,string> GetChannels()
        {
            Dictionary<string, string> channels = new Dictionary<string,string>();
            foreach (DictionaryEntry ao in Environs.Hardware.AnalogOutputChannels)
            {
                AnalogOutputChannel aoChan = (AnalogOutputChannel)ao.Value;
                channels[(string)ao.Key] = aoChan.PhysicalChannel;
            }
            foreach (DictionaryEntry dio in Environs.Hardware.DigitalOutputChannels)
            {
                DigitalOutputChannel doChan = (DigitalOutputChannel)dio.Value;
                channels[(string)dio.Key] = doChan.PhysicalChannel;
            }
            foreach (DictionaryEntry ai in Environs.Hardware.AnalogInputChannels)
            {
                AnalogInputChannel aiChan = (AnalogInputChannel)ai.Value;
                channels[(string)ai.Key] = aiChan.PhysicalChannel;
            }
            return channels;
        }
        #endregion

        #region Muquans Control
        public void UpdateDDS()
        {
            //Gets the DDS values to send to the Muquans communicator

        }

        public void EdfaLock(string edfaID, bool lockParam, double lockValue)
        {
            muquans.LockEDFA(edfaID, lockParam, lockValue);
        }

        public void StartEDFA(string id)
        {
            muquans.StartEDFA(id);
        }

        public void StopEDFA(string id)
        {
            muquans.StopEDFA(id);
        }

        public void LockLaser(string laserID)
        {
            //Starts this in a new Thread and runs until a user input closes the thread
            if (laserThread.IsAlive)
            {
                Console.WriteLine("A laser is currently being locked. Wait until that has finished before locking another");
            }
            else
            {
                Console.WriteLine("Starting to lock " + laserID);
                laserThread = new Thread(new ParameterizedThreadStart(muquans.LockLaser));
                laserThread.Start(laserID);

            }

        }

        public void CloseLaserThread()
        {
            if (laserThread != null)
            {
                if(laserThread.IsAlive)
                    laserThread.Abort();
                    Console.WriteLine("Finished Laser Lock");
            }
        }
        public void UnlockLaser(string laserID)
        {
            muquans.UnlockLaser(laserID);
        }
        #endregion

        #region Fibre Alignment
        /// <summary>
        /// Scans the piezos for the mirror mount and returns an array of the measured PD values.
        /// </summary>
        /// <param name="numSteps">number of voltage steps for piezos</param>
        /// <param name="numSamp">Number of samples per input</param>
        public double[,] ScanFibre(int numSteps, double sampleRate, int numSamples)
        {
            double horizVolt;
            double vertVolt;
            double[,] scanData = new double[numSteps, numSteps];
            //The voltage range for each piezo is from 0 to 10V
            for (int i = 0; i < numSteps; i++)
            {
                for (int j = 0; j < numSteps; j++)
                {
                    vertVolt = 10.0 * j / numSteps;
                    horizVolt = 10.0 * i / numSteps;
                    SetAnalogOutput("horizPiezo", horizVolt);
                    SetAnalogOutput("vertPiezo", vertVolt);
                    double value = (double)ReadAnalogInput("fibrePD",sampleRate,numSamples,true);
                    scanData[i, j] = value;
                }
            }
            fibreAlign.ScanData = scanData;
            
            //TODO Implement code to write this scandata to a csv.
            return scanData;
        }

        public string LoadFibreScanData()
        {
            //Returns the path to a fibre scan
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = ".csv";
            openFile.Title = "Choose Fibre Scan Data to Test";
            openFile.InitialDirectory = (string)Environs.FileSystem.Paths["settingsPath"];
            openFile.ShowDialog();
            return openFile.FileName;
        }
        /// <summary>
        /// Aligns the fibre by trying to maximise the input power
        /// </summary>
        /// <param name="threshold">Threshold value for alignment. Ideally normalised to 1</param>
        /// <returns></returns>
        public int[] AlignFibre(double threshold, bool align)
        {
            int[] coords = new int[2];

            //Probably not a good idea to hardcode these here.
            fibreAlign.sampleRate = 10000.0;
            fibreAlign.numSamples = 100;
            if (Environs.Debug)
            {
                //force align to be false so it will use the scan data
                align = false;
            }
            coords = fibreAlign.AlignFibre(threshold, align);
            return coords;
        }

        #endregion

        #endregion

        #region Local camera control

        public void StartCameraControl()
        {
            try
            {
                ImageController = new CameraController("cam0");
                ImageController.Initialize();
                ImageController.PrintCameraAttributesToConsole();
                controlWindow.WriteToConsole(ImageController.IsCameraFree().ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Camera Initialization Error");
         

            }
        }
        public void CameraStream()
        {
            try
            {
                ImageController.Stream(cameraAttributesPath);
            }
            catch { }
        }

        public void StopCameraStream()
        {
            try
            {
                ImageController.StopStream();
            }
            catch { }
        }

        public void CameraSnapshot(bool background)
        {
            //Takes two images and switches off the repump light to take a background
            if (!background)
            {
                try
                {
                    
                    ImageController.SingleSnapshot(cameraAttributesPath);
                    SetDigitalLine("cameraTTL", true);
                    SetDigitalLine("cameraTTL", false);
                }
                catch { }
            }
            else
            {
                try
                {
                    ImageController.MultipleSnapshot(cameraAttributesPath, 2);
                    SetDigitalLine("cameraTTL", true);
                    SetDigitalLine("cameraTTL", false);
                    SetDigitalLine("motTTL", false);
                    SetDigitalLine("cameraTTL", true);
                    SetDigitalLine("cameraTTL", false);
                    SetDigitalLine("motTTL", true);

                }
                catch
                {

                }
            }
        }
        public void CameraSnapshot()
        {
            CameraSnapshot(false);
        }

        #endregion

        #region Saving Images

        public void SaveImageWithDialog(bool background)
        {
            if (background)
                ImageController.StoreImageListWithDialog();
            else
                ImageController.SaveImageWithDialog();
           
        }
        public void SaveImageWithDialog()
        {
            SaveImageWithDialog(false);
        }
        public void SaveImage(string path)
        {
            try
            {
                ImageController.SaveImage(path);
            }
            catch { }
        }
        #endregion

        #region ImageAnalysisWindow

        public void OpenNewImageAnalysisWindow()
        {
            if (ImageController == null)
            {
                StartCameraControl();
            }
            imAnalWindow = new ImageViewer();
            imAnalWindow.imageWindow.controller = ImageController;
            imAnalWindow.Show();
            startImageAnalysis();
        }

        private bool analyseImage = false;

        private void startImageAnalysis()
        {
            analyseImage = true;
            Thread imageAnalThread = new Thread(doImageAnalysis);
            imageAnalThread.Start();
        }

        public void stopImageAnalysis()
        {
            analyseImage = false;
        }

        private void doImageAnalysis()
        {
            while (analyseImage)
            {
                if (ImageController.rectangleROI.Count != 0)
                {
                    imAnalWindow.imageWindow.updateImageAndAnalyse();
                }
                Thread.Sleep(200);

            }
        }
        #endregion

        #region Remote Camera Control
        //Written for taking images triggered by TTL. This "Arm" sets the camera so it's expecting a TTL.

        public byte[,] GrabSingleImage(string cameraAttributesPath)
        {
            return ImageController.SingleSnapshot(cameraAttributesPath);
        }
        public byte[][,] GrabMultipleImages(string cameraAttributesPath, int numberOfShots)
        {
            try
            {
                byte[][,] images = ImageController.MultipleSnapshot(cameraAttributesPath, numberOfShots);
                return images;
            }

            catch (TimeoutException)
            {
                FinishRemoteCameraControl();
                return null;
            }

        }

        public bool IsReadyForAcquisition()
        {
            return ImageController.IsReadyForAcqisition();
        }

        public void PrepareRemoteCameraControl()
        {
            StartRemoteControl();
        }
        public void FinishRemoteCameraControl()
        {
            StopRemoteControl();
        }

        #endregion

        #region Event Handlers

        private void DDSErrorHandler(object sendingProcess, DataReceivedEventArgs eventArgs)
        {
            //If one of the DDS programs exits, this prints the error output to the console and opens a message box
            controlWindow.WriteToConsole(eventArgs.Data);
            Console.WriteLine(eventArgs.Data);
            MessageBox.Show("One (or both) of the DDS programs has crashed. Check the console for more information.");
        }

        public void ControllerExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            //If there is an unhandled exception in the controller, it prints this to the console.
                   //this is designed to handled an exception in a thread and print it to the console. Should help prevent uneccessary terminations
            try
            {
                Exception ex = e.ExceptionObject as Exception;
                string errorMessage =
           "Unhandled Exception:\n\n" +
           ex.Message + "\n\n" +
           ex.GetType() +
           "\n\nStack Trace:\n" +
           ex.StackTrace;
                Console.WriteLine(errorMessage);
            }
            catch
            {
                MessageBox.Show("Fatal Error");
            }
        }
        #endregion


    }
}
