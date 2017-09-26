﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MOTMaster2.SequenceData;
using Newtonsoft.Json;

namespace MOTMaster2
{
    [Serializable,JsonObject]
    public class ExperimentData
    {
        //Flag to save raw data or average from each segment
        public bool SaveRawData { get; set; }
        //Name to identify each experiment
        public string ExperimentName {get; set;}
        //Collects time indices for each segment of analog data as a tuple tStart,tEnd
        public Dictionary<string, Tuple<int, int>> AnalogSegments { get; set; }

        public List<string> IgnoredSegments { get; set; }
        //Raw data recorded from each shot
        List<ExperimentShot> shotData = new List<ExperimentShot>();
        //List of sequence parameters for each shot
        List<Dictionary<string, object>> shotParams = new List<Dictionary<string, object>>();
        //Sampling rate for data
        private int sampleRate = 200000;
        public int SampleRate { get { return sampleRate; } set { sampleRate = value; } }
        //Number of acquired samples
        public int NSamples { get; set; }
        private Random random = new Random();
        public string InterferometerStepName { get; set; }
        //Rise time in seconds to be excluded from data
        public double RiseTime { get; set; }

        private int preTrigSamples = 64;
        public int PreTrigSamples { get { return preTrigSamples; } set { preTrigSamples = value; } }

        public InterferometerParams InterferometerPulses = new InterferometerParams(); 

        public static double[] TransferFunc { get; set; }

        public ExperimentData()
        {
           
           
        }

        public Dictionary<string, double[]> SegmentShot(double[,] rawData)
        {
            int riseSamples = (int)(RiseTime * SampleRate);
            int imin;
            int imax;
            Dictionary<string, double[]> segData = new Dictionary<string, double[]>();
            foreach (KeyValuePair<string, Tuple<int, int>> entry in AnalogSegments.OrderBy(t => t.Value.Item1))
            {
                if (!IgnoredSegments.Contains(entry.Key))
                {
                    imin = entry.Value.Item1 + riseSamples;
                    imax = entry.Value.Item2;
                    double[] data = new double[imax-imin];
                    for (int i = imin; i < imax; i++) data[i-imin] = rawData[0,i];
                    segData[entry.Key] = data;
                }
                else if (entry.Key == InterferometerStepName)
                {
                    imin = entry.Value.Item1;
                    imax = entry.Value.Item2;
                    double[] accelData = new double[imax-imin];
                    for (int i = imin; i < imax; i++) accelData[i - imin] = rawData[1, i];
                    ConvertAccelerometerVoltage(ref segData, accelData);
                }
            }
            return segData;
        }

        /// <summary>
        /// Converts the accelerometer voltage into acceleration and integrates it using the interferometer response function
        /// </summary>
        /// <param name="segData"></param>
        /// <param name="accelData"></param>
        private void ConvertAccelerometerVoltage(ref Dictionary<string, double[]> segData, double[] accelData)
        {
            double keff = 4 * Math.PI / (780 * 1e-9);
            double accScale = 1.235976 * 1e-3 * 6 * 1e3 / 9.81;// V/ms^-2
            int nAccSamps = accelData.Length;
            double accSum = 0.0;
            //Uses the simple triangular form of the transfer function and trapezium rule to integrate
            for (int i = 1; i < nAccSamps / 2; i++) accSum += i* accelData[i];
            for (int i = nAccSamps / 2 + 1; i < nAccSamps; i++) accSum += (nAccSamps - i) * accelData[i];

            double accPhase = keff * accSum/(accScale * sampleRate * sampleRate); // 1/sampleRate comes from both transfer function and integration
            
            double accMean = accelData.Average();
            double accStd = 0.0;
            for (int i = 0; i < accelData.Length; i++) accStd += accelData[i]*accelData[i];
            accStd = accStd/nAccSamps-1;
            accStd = Math.Sqrt(accStd - accMean*accMean);

            segData["AccPhase"] = new double[] {accPhase};
            segData["AccMeanV"] = new double[] {accMean};
            segData["AccMeanA"] = new double[] {accMean/accScale};
            segData["AccStdV"] = new double[] {accStd};
            segData["AccStdA"] = new double[] {accStd/accScale};
          
        }
        //Useful when starting a new scan
        public void ClearData()
        {
            shotData.Clear();
            shotParams.Clear();
            ExperimentName = "";
        }

        //Generates some fake data that is normally distributed about some mean value
        public double[,] GenerateFakeData()
        {
            double[,] fakeData = new double[2,NSamples];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < NSamples; j++) { double g = Gauss(0, 1); fakeData[i,j] = g; }
            return fakeData;
        }

        //Randomly generates normally distributed numbers using the BoxMuller transform
        public double Gauss(double mean, double std)
        {
            
            double u = 2 * random.NextDouble() - 1;
            double v = 2 * random.NextDouble() - 1;
            double w = u * u + v * v;
            if (w == 0 || w >= 1) return Gauss(mean, std);
            double c = Math.Sqrt(-2 * Math.Log(w) / w);
            return u * c * std + mean;
            
        }


    }

    /// <summary>
    /// Data from a single experiment shot
    /// </summary>
    [Serializable,JsonObject]
    public struct ExperimentShot
    {
        //Index of run. Might not be needed if adding each to a list
        public int runID;

        
        [JsonIgnore]
        internal double[,] analogInData;

        public Dictionary<string, double[]> analogSegments;

        public ExperimentShot(int id, double[,] data)
        {
            runID = id;
            analogInData = data;
            analogSegments = null;
        }
    }

    /// <summary>
    /// Encapsulates data about the parameters for the interferometer pulses
    /// </summary>
     [Serializable,JsonObject]
    public class InterferometerParams
    {
        public struct PulseParams
        {
            private double power;
            public double Power { get { return power; } set { power = value; } }
            public double duration;
            public double Duration { get { return duration; } set { duration = value; } }
            public double phase;
            public double Phase { get { return phase; } set {phase = value; } }
        }
        public InterferometerParams() 
        {           
            Pulse1 = new PulseParams();
            Pulse2 = new PulseParams();
            Pulse3 = new PulseParams();
            VelPulse = new PulseParams();
        }
        
        public PulseParams Pulse1; 
        public PulseParams Pulse2; 
        public PulseParams Pulse3; 
        public PulseParams VelPulse;

        public double PLLFreq;
        public double ChirpRate;
        public double ChirpDuration;
        public double TTime; 

        public void GetMSquaredParameters()
        {
            Dictionary<string, object> pllDict = Controller.M2PLL.get_status();
            if (pllDict["aux_lock_status"] != "on") throw new DAQ.HAL.PLLException("PLL lock is not engaged - currently set to " + (string)pllDict["aux_lock_status"]);
            //The DCS ICEBloc does not implement a method to get the parameters of the current configuration
            throw new NotImplementedException();
        }

        public void SetMSquaredParameters()
        {
            CheckPhaseLock();
            Controller.M2PLL.configure_lo_profile(true,false,"ecd",PLLFreq,0.0,ChirpRate,ChirpDuration,true);
            //Checks the phase lock has not come out-of-loop
            CheckPhaseLock();

            Controller.M2DCS.ConfigurePulse("X", 0, VelPulse.Duration, VelPulse.Power, 1e-6, VelPulse.Phase);
            Controller.M2DCS.ConfigurePulse("X", 1, Pulse1.Duration, Pulse1.Power, 1e-6, Pulse1.Phase);
            Controller.M2DCS.ConfigurePulse("X", 2, Pulse2.Duration, Pulse2.Power, 1e-6, Pulse2.Phase);
            Controller.M2DCS.ConfigurePulse("X", 3, Pulse3.Duration, Pulse3.Power, 1e-6, Pulse3.Phase);

            Controller.M2DCS.UpdateSequenceParameters();


        }

        private static void CheckPhaseLock()
        {
            DAQ.HAL.ICEBlocPLL.Lock_Status lockStatus = new DAQ.HAL.ICEBlocPLL.Lock_Status ();
            bool locked = Controller.M2PLL.ecd_lock_status(out lockStatus);
            if (!locked) throw new DAQ.HAL.PLLException("PLL lock is not engaged - currently "+ lockStatus.ToString());
        }
    }

}
