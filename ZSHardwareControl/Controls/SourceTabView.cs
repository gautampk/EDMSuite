﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeemanSisyphusHardwareControl.Controls
{
    public partial class SourceTabView : ZeemanSisyphusHardwareControl.Controls.GenericView
    {
        protected SourceTabController castController;

        public SourceTabView(SourceTabController controllerInstance) : base(controllerInstance)
        {
            InitializeComponent();
            castController = (SourceTabController)controller; // saves casting in every method
        }

        #region UI Update Handlers

        public void UpdateCurrentTemperature(string temp)
        {
            currentTemperature.Text = temp;
        }

        public void UpdateGraph(double time, double temp)
        {
            tempGraph.PlotXYAppend(time, temp);
        }

        public void UpdateReadButton(bool state)
        {
            readButton.Text = state ? "Start Reading" : "Stop Reading";
        }

        public void UpdateCycleButton(bool state)
        {
            cycleButton.Text = state ? "Cycle Source" : "Stop Cycling";
        }

        public void EnableControls(bool state)
        {
            heaterSwitch.Enabled = state;
            cryoSwitch.Enabled = state;
            cycleButton.Enabled = state;
        }

        public void SetCryoState(bool state)
        {
            cryoSwitch.Value = state;
            cryoLED.Value = state;
        }

        public void SetHeaterState(bool state)
        {
            heaterSwitch.Value = state;
            heaterLED.Value = state;
        }

        #endregion

        #region UI Query Handlers

        public double GetCycleLimit()
        {
            return (double)cycleLimit.Value;
        }

        #endregion

        #region UI Event Handlers

        private void toggleReading(object sender, EventArgs e)
        {
            castController.ToggleReading();
        }

        private void toggleCycling(object sender, EventArgs e)
        {
            castController.ToggleCycling();
        }

        private void toggleHeater(object sender, NationalInstruments.UI.ActionEventArgs e)
        {
            bool state = heaterSwitch.Value;
            heaterLED.Value = state;
            castController.SetHeaterState(state);
        }

        private void toggleCryo(object sender, NationalInstruments.UI.ActionEventArgs e)
        {
            bool state = cryoSwitch.Value;
            cryoLED.Value = state;
            castController.SetCryoState(state);
        }

        #endregion
 
    }
}
