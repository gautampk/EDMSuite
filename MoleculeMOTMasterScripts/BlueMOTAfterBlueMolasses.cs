﻿using MOTMaster;
using MOTMaster.SnippetLibrary;

using System;
using System.Collections.Generic;

using DAQ.Pattern;
using DAQ.Analog;

// This script is supposed to be the basic script for loading a molecule MOT.
// Note that times are all in units of the clock periods of the two pattern generator boards (at present, both are 10us).
// All times are relative to the Q switch, though note that this is not the first event in the pattern.
public class Patterns : MOTMasterScript
{
    public Patterns()
    {
        Parameters = new Dictionary<string, object>();
        Parameters["PatternLength"] = 50000;
        Parameters["TCLBlockStart"] = 2000; // This is a time before the Q switch
        Parameters["TCLBlockDuration"] = 8000;
        Parameters["FlashToQ"] = 16; // This is a time before the Q switch
        Parameters["QSwitchPulseDuration"] = 10;
        Parameters["FlashPulseDuration"] = 10;

        Parameters["MOTSwitchOffTime"] = 6300;
        Parameters["MolassesDelay"] = 100;
        Parameters["MolassesHoldTime"] = 600;
        Parameters["MolassesRampDuration"] = 200;
        Parameters["v0F0PumpDuration"] = 10;
        Parameters["MOTPictureTriggerTime"] = 4000;
        Parameters["MOTWaitBeforeImage"] = 2000;
        Parameters["xShimZeemanSplitValue"] = 0.0;

        // Camera
        Parameters["Frame0TriggerDuration"] = 10;

        //PMT
        Parameters["PMTTrigger"] = 4000;
        Parameters["PMTTriggerDuration"] = 10;

        // Slowing
        Parameters["slowingAOMOnStart"] = 250;
        Parameters["slowingAOMOnDuration"] = 45000;
        Parameters["slowingAOMOffStart"] = 1500;
        Parameters["slowingAOMOffDuration"] = 40000;
        Parameters["slowingRepumpAOMOnStart"] = 250;
        Parameters["slowingRepumpAOMOnDuration"] = 45000;
        Parameters["slowingRepumpAOMOffStart"] = 1700;
        Parameters["slowingRepumpAOMOffDuration"] = 40000;

        // Slowing Chirp
        Parameters["SlowingChirpStartTime"] = 340;
        Parameters["SlowingChirpDuration"] = 1160;
        Parameters["SlowingChirpStartValue"] = 0.0;
        Parameters["SlowingChirpEndValue"] = -1.3;

        // Slowing field
        Parameters["slowingCoilsValue"] = 1.1;
        Parameters["slowingCoilsOffTime"] = 1500;

        // B Field
        Parameters["MOTCoilsSwitchOn"] = 0;
        Parameters["MOTCoilsCurrentRampStartValue"] = 0.65;
        Parameters["MOTCoilsCurrentRampStartTime"] = 4000;
        Parameters["MOTCoilsCurrentRampEndValue"] = 0.65;
        Parameters["MOTCoilsCurrentRampDuration"] = 1000;
        Parameters["MOTCoilsCurrentMolassesValue"] = 0.0; //0.21
        Parameters["MOTCoilsCurrentBlueMOTValue"] = 0.15;


        Parameters["CoilsSwitchOffTime"] = 40000;

        // Shim fields
        Parameters["xShimLoadCurrent"] = 0.0;// 3.0;
        Parameters["yShimLoadCurrent"] = 0.0;
        Parameters["zShimLoadCurrent"] = -6.0;

        // v0 Light Intensity
        Parameters["v0IntensityRampStartTime"] = 5500;
        Parameters["v0IntensityRampDuration"] = 400;
        Parameters["v0IntensityRampStartValue"] = 5.8;
        Parameters["v0IntensityRampEndValue"] = 8.465;
        Parameters["v0IntensityMolassesValue"] = 5.8;
        Parameters["v0IntensityBlueMOTValue"] = 5.8;
        Parameters["v0IntensityImageValue"] = 5.8;

        // v0 Light Frequency
        Parameters["v0FrequencyMOTValue"] = 0.0; //set this to 0.0 for 114.1MHz 
        Parameters["v0FrequencyMolassesValue"] = 30.0; //set this to MHz detuning desired if doing frequency jump (positive for blue detuning)
        Parameters["v0FrequencyBlueMOTValue"] = 20.0; //set this to 0.0 for 114.1MHz 

        // v0 pumping EOM
        Parameters["v0EOMMOTValue"] = 5.7;

        //v0aomCalibrationValues
        Parameters["lockAomFrequency"] = 114.1;
        Parameters["calibOffset"] = 64.2129;
        Parameters["calibGradient"] = 5.55075;


    }

    public override PatternBuilder32 GetDigitalPattern()
    {
        PatternBuilder32 p = new PatternBuilder32();
        int patternStartBeforeQ = (int)Parameters["TCLBlockStart"];
        int molassesStartTime = (int)Parameters["MOTSwitchOffTime"] + (int)Parameters["MolassesDelay"];
        int molassesRampTime = molassesStartTime + (int)Parameters["MolassesHoldTime"];
        int blueMOTCaptureTime = molassesRampTime + (int)Parameters["MolassesRampDuration"];
        int imageTime = blueMOTCaptureTime + (int)Parameters["MOTWaitBeforeImage"];

        MOTMasterScriptSnippet lm = new LoadMoleculeMOT(p, Parameters);  // This is how you load "preset" patterns. 

        p.Pulse(patternStartBeforeQ, (int)Parameters["MOTSwitchOffTime"], (int)Parameters["MolassesDelay"], "v00MOTAOM"); // pulse off the MOT light whilst MOT fields are turning off
        p.Pulse(patternStartBeforeQ, imageTime, (int)Parameters["Frame0TriggerDuration"], "cameraTrigger"); // camera trigger

        return p;
    }

    public override AnalogPatternBuilder GetAnalogPattern()
    {
        AnalogPatternBuilder p = new AnalogPatternBuilder((int)Parameters["PatternLength"]);

        MOTMasterScriptSnippet lm = new LoadMoleculeMOT(p, Parameters);

        int molassesStartTime = (int)Parameters["MOTSwitchOffTime"] + (int)Parameters["MolassesDelay"];
        int molassesRampTime = molassesStartTime + (int)Parameters["MolassesHoldTime"];
        int blueMOTCaptureTime = molassesRampTime + (int)Parameters["MolassesRampDuration"];
        int imageTime = blueMOTCaptureTime + (int)Parameters["MOTWaitBeforeImage"];
        
        // Add Analog Channels
        p.AddChannel("v00Intensity");
        p.AddChannel("v00Frequency");
        p.AddChannel("xShimCoilCurrent");
        p.AddChannel("yShimCoilCurrent");
        p.AddChannel("v00EOMAmp");
        p.AddChannel("zShimCoilCurrent");

        // Slowing field
        p.AddAnalogValue("slowingCoilsCurrent", 0, (double)Parameters["slowingCoilsValue"]);
        p.AddAnalogValue("slowingCoilsCurrent", (int)Parameters["slowingCoilsOffTime"], 0.0);

        // B Field
        p.AddAnalogValue("MOTCoilsCurrent", (int)Parameters["MOTCoilsSwitchOn"], (double)Parameters["MOTCoilsCurrentRampStartValue"]);
        p.AddLinearRamp("MOTCoilsCurrent", (int)Parameters["MOTCoilsCurrentRampStartTime"], (int)Parameters["MOTCoilsCurrentRampDuration"], (double)Parameters["MOTCoilsCurrentRampEndValue"]);
        //p.AddAnalogValue("MOTCoilsCurrent", (int)Parameters["MOTSwitchOffTime"], (double)Parameters["MOTCoilsCurrentMolassesValue"]);
        p.AddAnalogValue("MOTCoilsCurrent", blueMOTCaptureTime, (double)Parameters["MOTCoilsCurrentBlueMOTValue"]);
        p.AddAnalogValue("MOTCoilsCurrent", (int)Parameters["CoilsSwitchOffTime"], 0.0);

        // Shim Fields
        p.AddAnalogValue("xShimCoilCurrent", 0, (double)Parameters["xShimLoadCurrent"]);
        p.AddAnalogValue("zShimCoilCurrent", 0, (double)Parameters["zShimLoadCurrent"]);

        // v0 Intensity Ramp
        p.AddAnalogValue("v00Intensity", 0, (double)Parameters["v0IntensityRampStartValue"]);
        p.AddLinearRamp("v00Intensity", (int)Parameters["v0IntensityRampStartTime"], (int)Parameters["v0IntensityRampDuration"], (double)Parameters["v0IntensityRampEndValue"]);
        p.AddAnalogValue("v00Intensity", molassesStartTime, (double)Parameters["v0IntensityMolassesValue"]);
        p.AddAnalogValue("v00Intensity", molassesRampTime + 50, 7.4);
        p.AddAnalogValue("v00Intensity", molassesRampTime + 200, 7.83);
        p.AddAnalogValue("v00Intensity", molassesRampTime + 150, 8.09);
        p.AddAnalogValue("v00Intensity", blueMOTCaptureTime, (double)Parameters["v0IntensityBlueMOTValue"]);

        // v0 EOM
        p.AddAnalogValue("v00EOMAmp", 0, (double)Parameters["v0EOMMOTValue"]);

        // v0 Frequency Ramp
        p.AddAnalogValue("v00Frequency", 0, ((double)Parameters["lockAomFrequency"] - (double)Parameters["v0FrequencyMOTValue"] / 2 - (double)Parameters["calibOffset"]) / (double)Parameters["calibGradient"]);
        p.AddAnalogValue(
            "v00Frequency",
            molassesStartTime,
            ((double)Parameters["lockAomFrequency"] - (double)Parameters["v0FrequencyMolassesValue"] / 2 - (double)Parameters["calibOffset"]) / (double)Parameters["calibGradient"]
        );
        p.AddAnalogValue(
            "v00Frequency",
            blueMOTCaptureTime,
            ((double)Parameters["lockAomFrequency"] - (double)Parameters["v0FrequencyBlueMOTValue"] / 2 - (double)Parameters["calibOffset"]) / (double)Parameters["calibGradient"]
        );
        return p;
    }

}
