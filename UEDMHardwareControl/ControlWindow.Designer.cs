﻿namespace UEDMHardwareControl
{
    partial class ControlWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlWindow));
            this.gbTempMonitors = new System.Windows.Forms.GroupBox();
            this.labelTS1 = new System.Windows.Forms.Label();
            this.tbTS1 = new System.Windows.Forms.TextBox();
            this.tbTSF6 = new System.Windows.Forms.TextBox();
            this.labelTSF6 = new System.Windows.Forms.Label();
            this.tbTNeon = new System.Windows.Forms.TextBox();
            this.labelTNeon = new System.Windows.Forms.Label();
            this.tbTS2 = new System.Windows.Forms.TextBox();
            this.labelTS2 = new System.Windows.Forms.Label();
            this.labelTCell = new System.Windows.Forms.Label();
            this.tbTCell = new System.Windows.Forms.TextBox();
            this.labelPBeamline = new System.Windows.Forms.Label();
            this.tbPBeamline = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPSource = new System.Windows.Forms.Label();
            this.tbPSource = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pressureAndTemperaturePlotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pressureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPlotPressureChart = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSavePressurePlotDataCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPlotTemperatureChart = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveTemperaturePlotDataCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.neonFlowPlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPlotNeonFlowChart = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveNeonFlowDataCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbCryoControl = new System.Windows.Forms.GroupBox();
            this.checkBoxCryoEnable = new System.Windows.Forms.CheckBox();
            this.cbTurnCryoOn = new System.Windows.Forms.CheckBox();
            this.labelCryoState = new System.Windows.Forms.Label();
            this.tbCryoState = new System.Windows.Forms.TextBox();
            this.cbLogPressureData = new System.Windows.Forms.CheckBox();
            this.labelPressureLogPeriod = new System.Windows.Forms.Label();
            this.tbpressureMonitorLogPeriod = new System.Windows.Forms.TextBox();
            this.gbTemperatureandPressureMonitoringControl = new System.Windows.Forms.GroupBox();
            this.btUpdatePTPollPeriod = new System.Windows.Forms.Button();
            this.labelTandPPollPeriod = new System.Windows.Forms.Label();
            this.tbTandPPollPeriod = new System.Windows.Forms.TextBox();
            this.btStopTandPMonitoring = new System.Windows.Forms.Button();
            this.btStartTandPMonitoring = new System.Windows.Forms.Button();
            this.gbPlotOptions = new System.Windows.Forms.GroupBox();
            this.btClearAllPressureData = new System.Windows.Forms.Button();
            this.btClearBeamlinePressureData = new System.Windows.Forms.Button();
            this.btClearSourcePressureData = new System.Windows.Forms.Button();
            this.labelClearPressurePlotData = new System.Windows.Forms.Label();
            this.checkBoxBeamlinePressurePlot = new System.Windows.Forms.CheckBox();
            this.checkBoxSourcePressurePlot = new System.Windows.Forms.CheckBox();
            this.labelSelectPressureDataToPlotChart1 = new System.Windows.Forms.Label();
            this.comboBoxPlot1ScaleY = new System.Windows.Forms.ComboBox();
            this.labelPlot1ScaleY = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btRollingTemperatureChartTimeAxis = new System.Windows.Forms.Button();
            this.labelTemperatureRollingTimeAxisPeriod = new System.Windows.Forms.Label();
            this.tbRollingTemperatureChartTimeAxisPeriod = new System.Windows.Forms.TextBox();
            this.cbEnableTemperatureChartRollingTimeAxis = new System.Windows.Forms.CheckBox();
            this.labelRollingTemperaturePlotTimeAxis = new System.Windows.Forms.Label();
            this.checkBoxNeonTempPlot = new System.Windows.Forms.CheckBox();
            this.btClearNeonTempData = new System.Windows.Forms.Button();
            this.labelClearTemperaturePlotData = new System.Windows.Forms.Label();
            this.btClearSF6TempData = new System.Windows.Forms.Button();
            this.btClearS2TempData = new System.Windows.Forms.Button();
            this.btClearS1TempData = new System.Windows.Forms.Button();
            this.btClearCellTempData = new System.Windows.Forms.Button();
            this.btClearAllTempData = new System.Windows.Forms.Button();
            this.checkBoxSF6TempPlot = new System.Windows.Forms.CheckBox();
            this.checkBoxS2TempPlot = new System.Windows.Forms.CheckBox();
            this.checkBoxS1TempPlot = new System.Windows.Forms.CheckBox();
            this.checkBoxCellTempPlot = new System.Windows.Forms.CheckBox();
            this.labelSelectTempDataToPlotChart2 = new System.Windows.Forms.Label();
            this.comboBoxPlot2ScaleY = new System.Windows.Forms.ComboBox();
            this.labelPlot2ScaleY = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePlotting = new System.Windows.Forms.TabPage();
            this.tabPageFlowControllers = new System.Windows.Forms.TabPage();
            this.gbSF6FlowController = new System.Windows.Forms.GroupBox();
            this.gbNeonFlowController = new System.Windows.Forms.GroupBox();
            this.btSetNewNeonFlowSetpoint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbNewNeonFlowSetPoint = new System.Windows.Forms.TextBox();
            this.btStartNeonFlowActMonitor = new System.Windows.Forms.Button();
            this.labelMonitorActualNeonFlow = new System.Windows.Forms.Label();
            this.btClearNeonFlowActPlotData = new System.Windows.Forms.Button();
            this.labelClearNeonFlowActData = new System.Windows.Forms.Label();
            this.tbNeonFlowSetpoint = new System.Windows.Forms.TextBox();
            this.btStopNeonFlowActMonitor = new System.Windows.Forms.Button();
            this.labelNeonFlowMonitorFL = new System.Windows.Forms.Label();
            this.tbNeonFlowActPollPeriod = new System.Windows.Forms.TextBox();
            this.labelNeonFlowMonitorSP = new System.Windows.Forms.Label();
            this.labelNeonFlowActPollPeriod = new System.Windows.Forms.Label();
            this.tbNeonFlowActual = new System.Windows.Forms.TextBox();
            this.tabPageHeatersControl = new System.Windows.Forms.TabPage();
            this.checkBoxMonitorPressureWhenHeating = new System.Windows.Forms.CheckBox();
            this.gbDigitalHeaters = new System.Windows.Forms.GroupBox();
            this.tbHeaterControlStatus = new System.Windows.Forms.TextBox();
            this.labelHeaterControlStatus = new System.Windows.Forms.Label();
            this.btHeatersTurnOffWaitCancel = new System.Windows.Forms.Button();
            this.btHeatersTurnOffWaitStart = new System.Windows.Forms.Button();
            this.labelHowLongUntilHeatersTurnOff = new System.Windows.Forms.Label();
            this.labelTurnHeatersOffAt = new System.Windows.Forms.Label();
            this.tbHowLongUntilHeatersTurnOff = new System.Windows.Forms.TextBox();
            this.dateTimePickerHeatersTurnOff = new System.Windows.Forms.DateTimePicker();
            this.gbCryoStage1HeaterControl = new System.Windows.Forms.GroupBox();
            this.btUpdateHeaterControlStage1 = new System.Windows.Forms.Button();
            this.btStopHeaterControlStage1 = new System.Windows.Forms.Button();
            this.checkBoxEnableHeatersS1 = new System.Windows.Forms.CheckBox();
            this.btStartHeaterControlStage1 = new System.Windows.Forms.Button();
            this.tbHeaterTempSetpointStage1 = new System.Windows.Forms.TextBox();
            this.labelHeaterSetpointStage1 = new System.Windows.Forms.Label();
            this.gbCryoStage2HeaterControl = new System.Windows.Forms.GroupBox();
            this.btUpdateHeaterControlStage2 = new System.Windows.Forms.Button();
            this.btStopHeaterControlStage2 = new System.Windows.Forms.Button();
            this.btStartHeaterControlStage2 = new System.Windows.Forms.Button();
            this.labelHeaterSetpointStage2 = new System.Windows.Forms.Label();
            this.tbHeaterTempSetpointStage2 = new System.Windows.Forms.TextBox();
            this.checkBoxEnableHeatersS2 = new System.Windows.Forms.CheckBox();
            this.tabPageLakeShore = new System.Windows.Forms.TabPage();
            this.gbAutotune = new System.Windows.Forms.GroupBox();
            this.btQueryAutotuneError = new System.Windows.Forms.Button();
            this.rtbAutotuneStatus = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxLakeShore336OutputsAutotune = new System.Windows.Forms.ComboBox();
            this.labelAutotuneModes = new System.Windows.Forms.Label();
            this.btAutotuneLakeShore336Output = new System.Windows.Forms.Button();
            this.comboBoxLakeShore336AutotuneModes = new System.Windows.Forms.ComboBox();
            this.gbLakeShore336PIDLoops = new System.Windows.Forms.GroupBox();
            this.labelPIDLoopsOutputs = new System.Windows.Forms.Label();
            this.tbLakeShore336PIDDValueInput = new System.Windows.Forms.TextBox();
            this.tbLakeShore336PIDIValueInput = new System.Windows.Forms.TextBox();
            this.tbLakeShore336PIDPValueInput = new System.Windows.Forms.TextBox();
            this.btSetLakeShore336PIDvalues = new System.Windows.Forms.Button();
            this.comboBoxLakeShore336OutputsSet = new System.Windows.Forms.ComboBox();
            this.tbLakeShore336PIDDValueOutput = new System.Windows.Forms.TextBox();
            this.tbLakeShore336PIDIValueOutput = new System.Windows.Forms.TextBox();
            this.labelLakeShore336DValue = new System.Windows.Forms.Label();
            this.labelLakeShore336IValue = new System.Windows.Forms.Label();
            this.tbLakeShore336PIDPValueOutput = new System.Windows.Forms.TextBox();
            this.labelLakeShore336PValue = new System.Windows.Forms.Label();
            this.btQueryLakeShore336PIDvalues = new System.Windows.Forms.Button();
            this.comboBoxLakeShore336OutputsQuery = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabPageSourceModes = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRefreshMode = new System.Windows.Forms.TabPage();
            this.gbRefreshModeWarmUp = new System.Windows.Forms.GroupBox();
            this.btRefreshModeTemperatureSetpointUpdate = new System.Windows.Forms.Button();
            this.labelRefreshModeTemperatureSetpoint = new System.Windows.Forms.Label();
            this.tbRefreshModeTemperatureSetpoint = new System.Windows.Forms.TextBox();
            this.labelRefreshModeHowLongUntilHeatersTurnOff = new System.Windows.Forms.Label();
            this.tbRefreshModeHowLongUntilHeatersTurnOff = new System.Windows.Forms.TextBox();
            this.checkBoxRefreshSourceAtRoomTemperature = new System.Windows.Forms.CheckBox();
            this.labelRefreshModeTurnHeatersOff = new System.Windows.Forms.Label();
            this.dateTimePickerRefreshModeTurnHeatersOff = new System.Windows.Forms.DateTimePicker();
            this.btCancelRefreshMode = new System.Windows.Forms.Button();
            this.gbRefreshModeCoolDown = new System.Windows.Forms.GroupBox();
            this.labelRefreshModeCryoTurnOnDateTime = new System.Windows.Forms.Label();
            this.labelRefreshModeHowLongUntilCryoTurnsOn = new System.Windows.Forms.Label();
            this.tbRefreshModeHowLongUntilCryoTurnsOn = new System.Windows.Forms.TextBox();
            this.dateTimePickerRefreshModeTurnCryoOn = new System.Windows.Forms.DateTimePicker();
            this.btStartRefreshMode = new System.Windows.Forms.Button();
            this.tbRefreshModeStatus = new System.Windows.Forms.TextBox();
            this.labelRefreshModeStatus = new System.Windows.Forms.Label();
            this.tabPageWarmUpMode = new System.Windows.Forms.TabPage();
            this.btCancelWarmUpMode = new System.Windows.Forms.Button();
            this.btStartWarmUpMode = new System.Windows.Forms.Button();
            this.tbWarmUpModeStatus = new System.Windows.Forms.TextBox();
            this.labelWarmUpModeStatus = new System.Windows.Forms.Label();
            this.gbWarmUpModeWarmUp = new System.Windows.Forms.GroupBox();
            this.btWarmUpModeTemperatureSetpointUpdate = new System.Windows.Forms.Button();
            this.labelWarmUpModeTemperatureSetpoint = new System.Windows.Forms.Label();
            this.tbWarmUpModeTemperatureSetpoint = new System.Windows.Forms.TextBox();
            this.labelWarmUpModeHowLongUntilHeatersTurnOff = new System.Windows.Forms.Label();
            this.tbWarmUpModeHowLongUntilHeatersTurnOff = new System.Windows.Forms.TextBox();
            this.checkBoxWarmUpSourceToRoomTemperature = new System.Windows.Forms.CheckBox();
            this.labelWarmUpModeTurnHeatersOff = new System.Windows.Forms.Label();
            this.dateTimePickerWarmUpModeTurnHeatersOff = new System.Windows.Forms.DateTimePicker();
            this.tabPageCoolDownMode = new System.Windows.Forms.TabPage();
            this.gbCoolDownModeWarmUp = new System.Windows.Forms.GroupBox();
            this.btCoolDownModeTemperatureSetpointUpdate = new System.Windows.Forms.Button();
            this.labelCoolDownModeTemperatureSetpoint = new System.Windows.Forms.Label();
            this.tbCoolDownModeTemperatureSetpoint = new System.Windows.Forms.TextBox();
            this.labelCoolDownModeHowLongUntilHeatersTurnOff = new System.Windows.Forms.Label();
            this.tbCoolDownModeHowLongUntilHeatersTurnOff = new System.Windows.Forms.TextBox();
            this.checkBoxCoolDownSourceAtRoomTemperature = new System.Windows.Forms.CheckBox();
            this.labelCoolDownModeTurnHeatersOff = new System.Windows.Forms.Label();
            this.dateTimePickerCoolDownModeTurnHeatersOff = new System.Windows.Forms.DateTimePicker();
            this.btCancelCoolDownMode = new System.Windows.Forms.Button();
            this.gbCoolDownModeCoolDown = new System.Windows.Forms.GroupBox();
            this.labelCoolDownModeCryoTurnOnDateTime = new System.Windows.Forms.Label();
            this.labelCoolDownModeHowLongUntilCryoTurnsOn = new System.Windows.Forms.Label();
            this.tbCoolDownModeHowLongUntilCryoTurnsOn = new System.Windows.Forms.TextBox();
            this.dateTimePickerCoolDownModeTurnCryoOn = new System.Windows.Forms.DateTimePicker();
            this.btStartCoolDownMode = new System.Windows.Forms.Button();
            this.tbCoolDownModeStatus = new System.Windows.Forms.TextBox();
            this.labelCoolDownModeStatus = new System.Windows.Forms.Label();
            this.gbTempMonitors.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.gbCryoControl.SuspendLayout();
            this.gbTemperatureandPressureMonitoringControl.SuspendLayout();
            this.gbPlotOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPagePlotting.SuspendLayout();
            this.tabPageFlowControllers.SuspendLayout();
            this.gbNeonFlowController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.tabPageHeatersControl.SuspendLayout();
            this.gbDigitalHeaters.SuspendLayout();
            this.gbCryoStage1HeaterControl.SuspendLayout();
            this.gbCryoStage2HeaterControl.SuspendLayout();
            this.tabPageLakeShore.SuspendLayout();
            this.gbAutotune.SuspendLayout();
            this.gbLakeShore336PIDLoops.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageSourceModes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageRefreshMode.SuspendLayout();
            this.gbRefreshModeWarmUp.SuspendLayout();
            this.gbRefreshModeCoolDown.SuspendLayout();
            this.tabPageWarmUpMode.SuspendLayout();
            this.gbWarmUpModeWarmUp.SuspendLayout();
            this.tabPageCoolDownMode.SuspendLayout();
            this.gbCoolDownModeWarmUp.SuspendLayout();
            this.gbCoolDownModeCoolDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTempMonitors
            // 
            this.gbTempMonitors.Controls.Add(this.labelTS1);
            this.gbTempMonitors.Controls.Add(this.tbTS1);
            this.gbTempMonitors.Controls.Add(this.tbTSF6);
            this.gbTempMonitors.Controls.Add(this.labelTSF6);
            this.gbTempMonitors.Controls.Add(this.tbTNeon);
            this.gbTempMonitors.Controls.Add(this.labelTNeon);
            this.gbTempMonitors.Controls.Add(this.tbTS2);
            this.gbTempMonitors.Controls.Add(this.labelTS2);
            this.gbTempMonitors.Controls.Add(this.labelTCell);
            this.gbTempMonitors.Controls.Add(this.tbTCell);
            this.gbTempMonitors.Location = new System.Drawing.Point(16, 43);
            this.gbTempMonitors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTempMonitors.Name = "gbTempMonitors";
            this.gbTempMonitors.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTempMonitors.Size = new System.Drawing.Size(272, 201);
            this.gbTempMonitors.TabIndex = 0;
            this.gbTempMonitors.TabStop = false;
            this.gbTempMonitors.Text = "Temperature Monitors";
            // 
            // labelTS1
            // 
            this.labelTS1.AutoSize = true;
            this.labelTS1.Location = new System.Drawing.Point(69, 98);
            this.labelTS1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTS1.Name = "labelTS1";
            this.labelTS1.Size = new System.Drawing.Size(29, 17);
            this.labelTS1.TabIndex = 9;
            this.labelTS1.Text = "S1:";
            // 
            // tbTS1
            // 
            this.tbTS1.Location = new System.Drawing.Point(108, 95);
            this.tbTS1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTS1.Name = "tbTS1";
            this.tbTS1.Size = new System.Drawing.Size(132, 22);
            this.tbTS1.TabIndex = 8;
            // 
            // tbTSF6
            // 
            this.tbTSF6.Location = new System.Drawing.Point(108, 159);
            this.tbTSF6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTSF6.Name = "tbTSF6";
            this.tbTSF6.Size = new System.Drawing.Size(132, 22);
            this.tbTSF6.TabIndex = 7;
            // 
            // labelTSF6
            // 
            this.labelTSF6.AutoSize = true;
            this.labelTSF6.Location = new System.Drawing.Point(61, 162);
            this.labelTSF6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTSF6.Name = "labelTSF6";
            this.labelTSF6.Size = new System.Drawing.Size(37, 17);
            this.labelTSF6.TabIndex = 6;
            this.labelTSF6.Text = "SF6:";
            // 
            // tbTNeon
            // 
            this.tbTNeon.Location = new System.Drawing.Point(108, 127);
            this.tbTNeon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTNeon.Name = "tbTNeon";
            this.tbTNeon.Size = new System.Drawing.Size(132, 22);
            this.tbTNeon.TabIndex = 5;
            // 
            // labelTNeon
            // 
            this.labelTNeon.AutoSize = true;
            this.labelTNeon.Location = new System.Drawing.Point(52, 130);
            this.labelTNeon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTNeon.Name = "labelTNeon";
            this.labelTNeon.Size = new System.Drawing.Size(46, 17);
            this.labelTNeon.TabIndex = 4;
            this.labelTNeon.Text = "Neon:";
            // 
            // tbTS2
            // 
            this.tbTS2.Location = new System.Drawing.Point(108, 63);
            this.tbTS2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTS2.Name = "tbTS2";
            this.tbTS2.Size = new System.Drawing.Size(132, 22);
            this.tbTS2.TabIndex = 3;
            // 
            // labelTS2
            // 
            this.labelTS2.AutoSize = true;
            this.labelTS2.Location = new System.Drawing.Point(69, 66);
            this.labelTS2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTS2.Name = "labelTS2";
            this.labelTS2.Size = new System.Drawing.Size(29, 17);
            this.labelTS2.TabIndex = 2;
            this.labelTS2.Text = "S2:";
            // 
            // labelTCell
            // 
            this.labelTCell.AutoSize = true;
            this.labelTCell.Location = new System.Drawing.Point(64, 34);
            this.labelTCell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTCell.Name = "labelTCell";
            this.labelTCell.Size = new System.Drawing.Size(35, 17);
            this.labelTCell.TabIndex = 1;
            this.labelTCell.Text = "Cell:";
            // 
            // tbTCell
            // 
            this.tbTCell.Location = new System.Drawing.Point(108, 31);
            this.tbTCell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTCell.Name = "tbTCell";
            this.tbTCell.Size = new System.Drawing.Size(132, 22);
            this.tbTCell.TabIndex = 0;
            // 
            // labelPBeamline
            // 
            this.labelPBeamline.AutoSize = true;
            this.labelPBeamline.Location = new System.Drawing.Point(29, 60);
            this.labelPBeamline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPBeamline.Name = "labelPBeamline";
            this.labelPBeamline.Size = new System.Drawing.Size(70, 17);
            this.labelPBeamline.TabIndex = 2;
            this.labelPBeamline.Text = "Beamline:";
            // 
            // tbPBeamline
            // 
            this.tbPBeamline.Location = new System.Drawing.Point(108, 57);
            this.tbPBeamline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPBeamline.Name = "tbPBeamline";
            this.tbPBeamline.Size = new System.Drawing.Size(132, 22);
            this.tbPBeamline.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPBeamline);
            this.groupBox1.Controls.Add(this.labelPBeamline);
            this.groupBox1.Controls.Add(this.labelPSource);
            this.groupBox1.Controls.Add(this.tbPSource);
            this.groupBox1.Location = new System.Drawing.Point(16, 251);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(272, 92);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pressure Monitors";
            // 
            // labelPSource
            // 
            this.labelPSource.AutoSize = true;
            this.labelPSource.Location = new System.Drawing.Point(41, 27);
            this.labelPSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPSource.Name = "labelPSource";
            this.labelPSource.Size = new System.Drawing.Size(57, 17);
            this.labelPSource.TabIndex = 1;
            this.labelPSource.Text = "Source:";
            // 
            // tbPSource
            // 
            this.tbPSource.Location = new System.Drawing.Point(108, 23);
            this.tbPSource.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPSource.Name = "tbPSource";
            this.tbPSource.Size = new System.Drawing.Size(132, 22);
            this.tbPSource.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1705, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plotsToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // plotsToolStripMenuItem
            // 
            this.plotsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pressureAndTemperaturePlotsToolStripMenuItem,
            this.neonFlowPlotToolStripMenuItem});
            this.plotsToolStripMenuItem.Name = "plotsToolStripMenuItem";
            this.plotsToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.plotsToolStripMenuItem.Text = "Plots";
            // 
            // pressureAndTemperaturePlotsToolStripMenuItem
            // 
            this.pressureAndTemperaturePlotsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pressureToolStripMenuItem,
            this.temperatureToolStripMenuItem});
            this.pressureAndTemperaturePlotsToolStripMenuItem.Name = "pressureAndTemperaturePlotsToolStripMenuItem";
            this.pressureAndTemperaturePlotsToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.pressureAndTemperaturePlotsToolStripMenuItem.Text = "Pressure and Temperature Plots";
            // 
            // pressureToolStripMenuItem
            // 
            this.pressureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemPlotPressureChart,
            this.ToolStripMenuItemSavePressurePlotDataCSV});
            this.pressureToolStripMenuItem.Name = "pressureToolStripMenuItem";
            this.pressureToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.pressureToolStripMenuItem.Text = "Pressure";
            // 
            // ToolStripMenuItemPlotPressureChart
            // 
            this.ToolStripMenuItemPlotPressureChart.Name = "ToolStripMenuItemPlotPressureChart";
            this.ToolStripMenuItemPlotPressureChart.Size = new System.Drawing.Size(186, 26);
            this.ToolStripMenuItemPlotPressureChart.Text = "Plot Image";
            this.ToolStripMenuItemPlotPressureChart.Click += new System.EventHandler(this.ToolStripMenuItemPlotPressureChart_Click);
            // 
            // ToolStripMenuItemSavePressurePlotDataCSV
            // 
            this.ToolStripMenuItemSavePressurePlotDataCSV.Name = "ToolStripMenuItemSavePressurePlotDataCSV";
            this.ToolStripMenuItemSavePressurePlotDataCSV.Size = new System.Drawing.Size(186, 26);
            this.ToolStripMenuItemSavePressurePlotDataCSV.Text = "Plot Data (CSV)";
            this.ToolStripMenuItemSavePressurePlotDataCSV.Click += new System.EventHandler(this.ToolStripMenuItemSavePressurePlotDataCSV_Click);
            // 
            // temperatureToolStripMenuItem
            // 
            this.temperatureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemPlotTemperatureChart,
            this.ToolStripMenuItemSaveTemperaturePlotDataCSV});
            this.temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            this.temperatureToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.temperatureToolStripMenuItem.Text = "Temperature";
            // 
            // ToolStripMenuItemPlotTemperatureChart
            // 
            this.ToolStripMenuItemPlotTemperatureChart.Name = "ToolStripMenuItemPlotTemperatureChart";
            this.ToolStripMenuItemPlotTemperatureChart.Size = new System.Drawing.Size(186, 26);
            this.ToolStripMenuItemPlotTemperatureChart.Text = "Plot Image";
            this.ToolStripMenuItemPlotTemperatureChart.Click += new System.EventHandler(this.ToolStripMenuItemPlotTemperatureChart_Click);
            // 
            // ToolStripMenuItemSaveTemperaturePlotDataCSV
            // 
            this.ToolStripMenuItemSaveTemperaturePlotDataCSV.Name = "ToolStripMenuItemSaveTemperaturePlotDataCSV";
            this.ToolStripMenuItemSaveTemperaturePlotDataCSV.Size = new System.Drawing.Size(186, 26);
            this.ToolStripMenuItemSaveTemperaturePlotDataCSV.Text = "Plot Data (CSV)";
            this.ToolStripMenuItemSaveTemperaturePlotDataCSV.Click += new System.EventHandler(this.ToolStripMenuItemSaveTemperaturePlotDataCSV_Click);
            // 
            // neonFlowPlotToolStripMenuItem
            // 
            this.neonFlowPlotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neonToolStripMenuItem});
            this.neonFlowPlotToolStripMenuItem.Name = "neonFlowPlotToolStripMenuItem";
            this.neonFlowPlotToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.neonFlowPlotToolStripMenuItem.Text = "Gas Flow Plots";
            // 
            // neonToolStripMenuItem
            // 
            this.neonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemPlotNeonFlowChart,
            this.ToolStripMenuItemSaveNeonFlowDataCSV});
            this.neonToolStripMenuItem.Name = "neonToolStripMenuItem";
            this.neonToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.neonToolStripMenuItem.Text = "Neon";
            // 
            // ToolStripMenuItemPlotNeonFlowChart
            // 
            this.ToolStripMenuItemPlotNeonFlowChart.Name = "ToolStripMenuItemPlotNeonFlowChart";
            this.ToolStripMenuItemPlotNeonFlowChart.Size = new System.Drawing.Size(186, 26);
            this.ToolStripMenuItemPlotNeonFlowChart.Text = "Plot Image";
            this.ToolStripMenuItemPlotNeonFlowChart.Click += new System.EventHandler(this.ToolStripMenuItemPlotNeonFlowChart_Click);
            // 
            // ToolStripMenuItemSaveNeonFlowDataCSV
            // 
            this.ToolStripMenuItemSaveNeonFlowDataCSV.Name = "ToolStripMenuItemSaveNeonFlowDataCSV";
            this.ToolStripMenuItemSaveNeonFlowDataCSV.Size = new System.Drawing.Size(186, 26);
            this.ToolStripMenuItemSaveNeonFlowDataCSV.Text = "Plot Data (CSV)";
            this.ToolStripMenuItemSaveNeonFlowDataCSV.Click += new System.EventHandler(this.ToolStripMenuItemSaveNeonFlowDataCSV_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.Black;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.Black;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.Title = "Pressure (mbar)";
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Black;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartAreaPressureChart";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "LegendPressureChart";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(8, 7);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartAreaPressureChart";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.White;
            series1.CustomProperties = "EmptyPointValue=Zero";
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.Legend = "LegendPressureChart";
            series1.Name = "Source Pressure";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.ChartArea = "ChartAreaPressureChart";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Enabled = false;
            series2.Legend = "LegendPressureChart";
            series2.Name = "Beamline Pressure";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(964, 423);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chartPressure";
            title1.BackColor = System.Drawing.Color.Black;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "chartTitleSourcePressure";
            title1.Text = "Pressure";
            this.chart1.Titles.Add(title1);
            // 
            // gbCryoControl
            // 
            this.gbCryoControl.Controls.Add(this.checkBoxCryoEnable);
            this.gbCryoControl.Controls.Add(this.cbTurnCryoOn);
            this.gbCryoControl.Controls.Add(this.labelCryoState);
            this.gbCryoControl.Controls.Add(this.tbCryoState);
            this.gbCryoControl.Location = new System.Drawing.Point(16, 548);
            this.gbCryoControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCryoControl.Name = "gbCryoControl";
            this.gbCryoControl.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCryoControl.Size = new System.Drawing.Size(272, 138);
            this.gbCryoControl.TabIndex = 19;
            this.gbCryoControl.TabStop = false;
            this.gbCryoControl.Text = "Cryo Cooler Control";
            // 
            // checkBoxCryoEnable
            // 
            this.checkBoxCryoEnable.AutoSize = true;
            this.checkBoxCryoEnable.Location = new System.Drawing.Point(12, 86);
            this.checkBoxCryoEnable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxCryoEnable.Name = "checkBoxCryoEnable";
            this.checkBoxCryoEnable.Size = new System.Drawing.Size(192, 38);
            this.checkBoxCryoEnable.TabIndex = 4;
            this.checkBoxCryoEnable.Text = "Enable Cryo \r\n(temporary digital control)";
            this.checkBoxCryoEnable.UseVisualStyleBackColor = true;
            this.checkBoxCryoEnable.CheckedChanged += new System.EventHandler(this.checkBoxCryoEnable_CheckedChanged);
            // 
            // cbTurnCryoOn
            // 
            this.cbTurnCryoOn.AutoSize = true;
            this.cbTurnCryoOn.Enabled = false;
            this.cbTurnCryoOn.Location = new System.Drawing.Point(12, 58);
            this.cbTurnCryoOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTurnCryoOn.Name = "cbTurnCryoOn";
            this.cbTurnCryoOn.Size = new System.Drawing.Size(116, 21);
            this.cbTurnCryoOn.TabIndex = 3;
            this.cbTurnCryoOn.Text = "Turn Cryo On";
            this.cbTurnCryoOn.UseVisualStyleBackColor = true;
            this.cbTurnCryoOn.CheckedChanged += new System.EventHandler(this.cbTurnCryoOn_CheckedChanged);
            // 
            // labelCryoState
            // 
            this.labelCryoState.AutoSize = true;
            this.labelCryoState.Enabled = false;
            this.labelCryoState.Location = new System.Drawing.Point(8, 25);
            this.labelCryoState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCryoState.Name = "labelCryoState";
            this.labelCryoState.Size = new System.Drawing.Size(78, 17);
            this.labelCryoState.TabIndex = 1;
            this.labelCryoState.Text = "Cryo State:";
            // 
            // tbCryoState
            // 
            this.tbCryoState.Enabled = false;
            this.tbCryoState.ForeColor = System.Drawing.Color.Black;
            this.tbCryoState.Location = new System.Drawing.Point(95, 21);
            this.tbCryoState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCryoState.Name = "tbCryoState";
            this.tbCryoState.Size = new System.Drawing.Size(132, 22);
            this.tbCryoState.TabIndex = 0;
            this.tbCryoState.Text = "UNKNOWN";
            // 
            // cbLogPressureData
            // 
            this.cbLogPressureData.AutoSize = true;
            this.cbLogPressureData.Location = new System.Drawing.Point(51, 91);
            this.cbLogPressureData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLogPressureData.Name = "cbLogPressureData";
            this.cbLogPressureData.Size = new System.Drawing.Size(149, 21);
            this.cbLogPressureData.TabIndex = 17;
            this.cbLogPressureData.Text = "Log Pressure Data";
            this.cbLogPressureData.UseVisualStyleBackColor = true;
            this.cbLogPressureData.CheckedChanged += new System.EventHandler(this.cbLogPressureData_CheckedChanged);
            // 
            // labelPressureLogPeriod
            // 
            this.labelPressureLogPeriod.AutoSize = true;
            this.labelPressureLogPeriod.Location = new System.Drawing.Point(47, 59);
            this.labelPressureLogPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPressureLogPeriod.Name = "labelPressureLogPeriod";
            this.labelPressureLogPeriod.Size = new System.Drawing.Size(102, 17);
            this.labelPressureLogPeriod.TabIndex = 16;
            this.labelPressureLogPeriod.Text = "Log Period (s):";
            // 
            // tbpressureMonitorLogPeriod
            // 
            this.tbpressureMonitorLogPeriod.Location = new System.Drawing.Point(155, 55);
            this.tbpressureMonitorLogPeriod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpressureMonitorLogPeriod.Name = "tbpressureMonitorLogPeriod";
            this.tbpressureMonitorLogPeriod.Size = new System.Drawing.Size(84, 22);
            this.tbpressureMonitorLogPeriod.TabIndex = 15;
            this.tbpressureMonitorLogPeriod.Text = "60";
            // 
            // gbTemperatureandPressureMonitoringControl
            // 
            this.gbTemperatureandPressureMonitoringControl.Controls.Add(this.btUpdatePTPollPeriod);
            this.gbTemperatureandPressureMonitoringControl.Controls.Add(this.labelTandPPollPeriod);
            this.gbTemperatureandPressureMonitoringControl.Controls.Add(this.tbTandPPollPeriod);
            this.gbTemperatureandPressureMonitoringControl.Controls.Add(this.btStopTandPMonitoring);
            this.gbTemperatureandPressureMonitoringControl.Controls.Add(this.btStartTandPMonitoring);
            this.gbTemperatureandPressureMonitoringControl.Location = new System.Drawing.Point(16, 351);
            this.gbTemperatureandPressureMonitoringControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTemperatureandPressureMonitoringControl.Name = "gbTemperatureandPressureMonitoringControl";
            this.gbTemperatureandPressureMonitoringControl.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTemperatureandPressureMonitoringControl.Size = new System.Drawing.Size(272, 193);
            this.gbTemperatureandPressureMonitoringControl.TabIndex = 20;
            this.gbTemperatureandPressureMonitoringControl.TabStop = false;
            this.gbTemperatureandPressureMonitoringControl.Text = "Temperature and Pressure Monitoring";
            // 
            // btUpdatePTPollPeriod
            // 
            this.btUpdatePTPollPeriod.Location = new System.Drawing.Point(23, 144);
            this.btUpdatePTPollPeriod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btUpdatePTPollPeriod.Name = "btUpdatePTPollPeriod";
            this.btUpdatePTPollPeriod.Size = new System.Drawing.Size(100, 28);
            this.btUpdatePTPollPeriod.TabIndex = 21;
            this.btUpdatePTPollPeriod.Text = "Update";
            this.btUpdatePTPollPeriod.UseVisualStyleBackColor = true;
            this.btUpdatePTPollPeriod.Click += new System.EventHandler(this.btUpdatePTPollPeriod_Click);
            // 
            // labelTandPPollPeriod
            // 
            this.labelTandPPollPeriod.AutoSize = true;
            this.labelTandPPollPeriod.Location = new System.Drawing.Point(19, 117);
            this.labelTandPPollPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTandPPollPeriod.Name = "labelTandPPollPeriod";
            this.labelTandPPollPeriod.Size = new System.Drawing.Size(111, 17);
            this.labelTandPPollPeriod.TabIndex = 20;
            this.labelTandPPollPeriod.Text = "Poll period (ms):";
            // 
            // tbTandPPollPeriod
            // 
            this.tbTandPPollPeriod.Location = new System.Drawing.Point(135, 113);
            this.tbTandPPollPeriod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTandPPollPeriod.Name = "tbTandPPollPeriod";
            this.tbTandPPollPeriod.Size = new System.Drawing.Size(84, 22);
            this.tbTandPPollPeriod.TabIndex = 13;
            this.tbTandPPollPeriod.Text = "1000";
            // 
            // btStopTandPMonitoring
            // 
            this.btStopTandPMonitoring.Enabled = false;
            this.btStopTandPMonitoring.Location = new System.Drawing.Point(23, 64);
            this.btStopTandPMonitoring.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btStopTandPMonitoring.Name = "btStopTandPMonitoring";
            this.btStopTandPMonitoring.Size = new System.Drawing.Size(100, 28);
            this.btStopTandPMonitoring.TabIndex = 1;
            this.btStopTandPMonitoring.Text = "Stop";
            this.btStopTandPMonitoring.UseVisualStyleBackColor = true;
            this.btStopTandPMonitoring.Click += new System.EventHandler(this.btStopTandPMonitoring_Click);
            // 
            // btStartTandPMonitoring
            // 
            this.btStartTandPMonitoring.Location = new System.Drawing.Point(23, 27);
            this.btStartTandPMonitoring.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btStartTandPMonitoring.Name = "btStartTandPMonitoring";
            this.btStartTandPMonitoring.Size = new System.Drawing.Size(100, 28);
            this.btStartTandPMonitoring.TabIndex = 0;
            this.btStartTandPMonitoring.Text = "Start";
            this.btStartTandPMonitoring.UseVisualStyleBackColor = true;
            this.btStartTandPMonitoring.Click += new System.EventHandler(this.btStartTandPMonitoring_Click);
            // 
            // gbPlotOptions
            // 
            this.gbPlotOptions.Controls.Add(this.btClearAllPressureData);
            this.gbPlotOptions.Controls.Add(this.btClearBeamlinePressureData);
            this.gbPlotOptions.Controls.Add(this.btClearSourcePressureData);
            this.gbPlotOptions.Controls.Add(this.labelClearPressurePlotData);
            this.gbPlotOptions.Controls.Add(this.checkBoxBeamlinePressurePlot);
            this.gbPlotOptions.Controls.Add(this.checkBoxSourcePressurePlot);
            this.gbPlotOptions.Controls.Add(this.labelSelectPressureDataToPlotChart1);
            this.gbPlotOptions.Controls.Add(this.comboBoxPlot1ScaleY);
            this.gbPlotOptions.Controls.Add(this.labelPlot1ScaleY);
            this.gbPlotOptions.Location = new System.Drawing.Point(980, 7);
            this.gbPlotOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPlotOptions.Name = "gbPlotOptions";
            this.gbPlotOptions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPlotOptions.Size = new System.Drawing.Size(388, 423);
            this.gbPlotOptions.TabIndex = 21;
            this.gbPlotOptions.TabStop = false;
            this.gbPlotOptions.Text = "Plot Options";
            // 
            // btClearAllPressureData
            // 
            this.btClearAllPressureData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClearAllPressureData.Location = new System.Drawing.Point(145, 172);
            this.btClearAllPressureData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClearAllPressureData.Name = "btClearAllPressureData";
            this.btClearAllPressureData.Size = new System.Drawing.Size(100, 28);
            this.btClearAllPressureData.TabIndex = 19;
            this.btClearAllPressureData.Text = "Clear all";
            this.btClearAllPressureData.UseVisualStyleBackColor = true;
            this.btClearAllPressureData.Click += new System.EventHandler(this.btClearAllPressureData_Click);
            // 
            // btClearBeamlinePressureData
            // 
            this.btClearBeamlinePressureData.Location = new System.Drawing.Point(253, 137);
            this.btClearBeamlinePressureData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClearBeamlinePressureData.Name = "btClearBeamlinePressureData";
            this.btClearBeamlinePressureData.Size = new System.Drawing.Size(100, 28);
            this.btClearBeamlinePressureData.TabIndex = 18;
            this.btClearBeamlinePressureData.Text = "Beamline";
            this.btClearBeamlinePressureData.UseVisualStyleBackColor = true;
            this.btClearBeamlinePressureData.Click += new System.EventHandler(this.btClearBeamlinePressureData_Click);
            // 
            // btClearSourcePressureData
            // 
            this.btClearSourcePressureData.Location = new System.Drawing.Point(145, 137);
            this.btClearSourcePressureData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClearSourcePressureData.Name = "btClearSourcePressureData";
            this.btClearSourcePressureData.Size = new System.Drawing.Size(100, 28);
            this.btClearSourcePressureData.TabIndex = 17;
            this.btClearSourcePressureData.Text = "Source";
            this.btClearSourcePressureData.UseVisualStyleBackColor = true;
            this.btClearSourcePressureData.Click += new System.EventHandler(this.btClearSourcePressureData_Click);
            // 
            // labelClearPressurePlotData
            // 
            this.labelClearPressurePlotData.AutoSize = true;
            this.labelClearPressurePlotData.Location = new System.Drawing.Point(33, 143);
            this.labelClearPressurePlotData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClearPressurePlotData.Name = "labelClearPressurePlotData";
            this.labelClearPressurePlotData.Size = new System.Drawing.Size(104, 17);
            this.labelClearPressurePlotData.TabIndex = 14;
            this.labelClearPressurePlotData.Text = "Clear plot data:";
            // 
            // checkBoxBeamlinePressurePlot
            // 
            this.checkBoxBeamlinePressurePlot.AutoSize = true;
            this.checkBoxBeamlinePressurePlot.Location = new System.Drawing.Point(145, 95);
            this.checkBoxBeamlinePressurePlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxBeamlinePressurePlot.Name = "checkBoxBeamlinePressurePlot";
            this.checkBoxBeamlinePressurePlot.Size = new System.Drawing.Size(88, 21);
            this.checkBoxBeamlinePressurePlot.TabIndex = 16;
            this.checkBoxBeamlinePressurePlot.Text = "Beamline";
            this.checkBoxBeamlinePressurePlot.UseVisualStyleBackColor = true;
            // 
            // checkBoxSourcePressurePlot
            // 
            this.checkBoxSourcePressurePlot.AutoSize = true;
            this.checkBoxSourcePressurePlot.Checked = true;
            this.checkBoxSourcePressurePlot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSourcePressurePlot.Location = new System.Drawing.Point(145, 70);
            this.checkBoxSourcePressurePlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxSourcePressurePlot.Name = "checkBoxSourcePressurePlot";
            this.checkBoxSourcePressurePlot.Size = new System.Drawing.Size(75, 21);
            this.checkBoxSourcePressurePlot.TabIndex = 15;
            this.checkBoxSourcePressurePlot.Text = "Source";
            this.checkBoxSourcePressurePlot.UseVisualStyleBackColor = true;
            this.checkBoxSourcePressurePlot.CheckedChanged += new System.EventHandler(this.checkBoxSourcePressurePlot_CheckedChanged);
            // 
            // labelSelectPressureDataToPlotChart1
            // 
            this.labelSelectPressureDataToPlotChart1.AutoSize = true;
            this.labelSelectPressureDataToPlotChart1.Location = new System.Drawing.Point(9, 70);
            this.labelSelectPressureDataToPlotChart1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectPressureDataToPlotChart1.Name = "labelSelectPressureDataToPlotChart1";
            this.labelSelectPressureDataToPlotChart1.Size = new System.Drawing.Size(126, 17);
            this.labelSelectPressureDataToPlotChart1.TabIndex = 14;
            this.labelSelectPressureDataToPlotChart1.Text = "Select data to plot:";
            // 
            // comboBoxPlot1ScaleY
            // 
            this.comboBoxPlot1ScaleY.FormattingEnabled = true;
            this.comboBoxPlot1ScaleY.Items.AddRange(new object[] {
            "Linear",
            "Log"});
            this.comboBoxPlot1ScaleY.Location = new System.Drawing.Point(141, 25);
            this.comboBoxPlot1ScaleY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxPlot1ScaleY.Name = "comboBoxPlot1ScaleY";
            this.comboBoxPlot1ScaleY.Size = new System.Drawing.Size(160, 24);
            this.comboBoxPlot1ScaleY.TabIndex = 1;
            this.comboBoxPlot1ScaleY.Text = "Linear";
            this.comboBoxPlot1ScaleY.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlot1ScaleY_SelectedIndexChanged);
            // 
            // labelPlot1ScaleY
            // 
            this.labelPlot1ScaleY.AutoSize = true;
            this.labelPlot1ScaleY.Location = new System.Drawing.Point(59, 28);
            this.labelPlot1ScaleY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlot1ScaleY.Name = "labelPlot1ScaleY";
            this.labelPlot1ScaleY.Size = new System.Drawing.Size(73, 17);
            this.labelPlot1ScaleY.TabIndex = 0;
            this.labelPlot1ScaleY.Text = "Plot scale:";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Black;
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.Black;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.Title = "Time";
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.InterlacedColor = System.Drawing.Color.Black;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.Title = "Temperature (K)";
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.BackImageTransparentColor = System.Drawing.Color.Black;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea2";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Black;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "LegendChart2";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(8, 434);
            this.chart2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart2.Name = "chart2";
            series3.BackSecondaryColor = System.Drawing.Color.White;
            series3.BorderColor = System.Drawing.Color.White;
            series3.ChartArea = "ChartArea2";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.White;
            series3.LabelBackColor = System.Drawing.Color.White;
            series3.Legend = "LegendChart2";
            series3.Name = "Cell Temperature";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series4.ChartArea = "ChartArea2";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Enabled = false;
            series4.Legend = "LegendChart2";
            series4.Name = "S2 Temperature";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series5.ChartArea = "ChartArea2";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Enabled = false;
            series5.Legend = "LegendChart2";
            series5.Name = "S1 Temperature";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series6.ChartArea = "ChartArea2";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Enabled = false;
            series6.Legend = "LegendChart2";
            series6.Name = "SF6 Temperature";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series7.ChartArea = "ChartArea2";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Enabled = false;
            series7.Legend = "LegendChart2";
            series7.Name = "Neon Temperature";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart2.Series.Add(series3);
            this.chart2.Series.Add(series4);
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Series.Add(series7);
            this.chart2.Size = new System.Drawing.Size(964, 423);
            this.chart2.TabIndex = 22;
            this.chart2.Text = "chart2";
            title2.BackColor = System.Drawing.Color.Black;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "chartTitle2";
            title2.Text = "Temperature";
            this.chart2.Titles.Add(title2);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btRollingTemperatureChartTimeAxis);
            this.groupBox2.Controls.Add(this.labelTemperatureRollingTimeAxisPeriod);
            this.groupBox2.Controls.Add(this.tbRollingTemperatureChartTimeAxisPeriod);
            this.groupBox2.Controls.Add(this.cbEnableTemperatureChartRollingTimeAxis);
            this.groupBox2.Controls.Add(this.labelRollingTemperaturePlotTimeAxis);
            this.groupBox2.Controls.Add(this.checkBoxNeonTempPlot);
            this.groupBox2.Controls.Add(this.btClearNeonTempData);
            this.groupBox2.Controls.Add(this.labelClearTemperaturePlotData);
            this.groupBox2.Controls.Add(this.btClearSF6TempData);
            this.groupBox2.Controls.Add(this.btClearS2TempData);
            this.groupBox2.Controls.Add(this.btClearS1TempData);
            this.groupBox2.Controls.Add(this.btClearCellTempData);
            this.groupBox2.Controls.Add(this.btClearAllTempData);
            this.groupBox2.Controls.Add(this.checkBoxSF6TempPlot);
            this.groupBox2.Controls.Add(this.checkBoxS2TempPlot);
            this.groupBox2.Controls.Add(this.checkBoxS1TempPlot);
            this.groupBox2.Controls.Add(this.checkBoxCellTempPlot);
            this.groupBox2.Controls.Add(this.labelSelectTempDataToPlotChart2);
            this.groupBox2.Controls.Add(this.comboBoxPlot2ScaleY);
            this.groupBox2.Controls.Add(this.labelPlot2ScaleY);
            this.groupBox2.Location = new System.Drawing.Point(980, 434);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(388, 423);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plot Options";
            // 
            // btRollingTemperatureChartTimeAxis
            // 
            this.btRollingTemperatureChartTimeAxis.Location = new System.Drawing.Point(253, 361);
            this.btRollingTemperatureChartTimeAxis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRollingTemperatureChartTimeAxis.Name = "btRollingTemperatureChartTimeAxis";
            this.btRollingTemperatureChartTimeAxis.Size = new System.Drawing.Size(112, 28);
            this.btRollingTemperatureChartTimeAxis.TabIndex = 20;
            this.btRollingTemperatureChartTimeAxis.Text = "Update";
            this.btRollingTemperatureChartTimeAxis.UseVisualStyleBackColor = true;
            this.btRollingTemperatureChartTimeAxis.Click += new System.EventHandler(this.btRollingTemperatureChartTimeAxis_Click);
            // 
            // labelTemperatureRollingTimeAxisPeriod
            // 
            this.labelTemperatureRollingTimeAxisPeriod.AutoSize = true;
            this.labelTemperatureRollingTimeAxisPeriod.Location = new System.Drawing.Point(9, 367);
            this.labelTemperatureRollingTimeAxisPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTemperatureRollingTimeAxisPeriod.Name = "labelTemperatureRollingTimeAxisPeriod";
            this.labelTemperatureRollingTimeAxisPeriod.Size = new System.Drawing.Size(131, 17);
            this.labelTemperatureRollingTimeAxisPeriod.TabIndex = 19;
            this.labelTemperatureRollingTimeAxisPeriod.Text = "Rolling period (ms):";
            // 
            // tbRollingTemperatureChartTimeAxisPeriod
            // 
            this.tbRollingTemperatureChartTimeAxisPeriod.Location = new System.Drawing.Point(145, 363);
            this.tbRollingTemperatureChartTimeAxisPeriod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRollingTemperatureChartTimeAxisPeriod.Name = "tbRollingTemperatureChartTimeAxisPeriod";
            this.tbRollingTemperatureChartTimeAxisPeriod.Size = new System.Drawing.Size(99, 22);
            this.tbRollingTemperatureChartTimeAxisPeriod.TabIndex = 18;
            // 
            // cbEnableTemperatureChartRollingTimeAxis
            // 
            this.cbEnableTemperatureChartRollingTimeAxis.AutoSize = true;
            this.cbEnableTemperatureChartRollingTimeAxis.Location = new System.Drawing.Point(145, 335);
            this.cbEnableTemperatureChartRollingTimeAxis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEnableTemperatureChartRollingTimeAxis.Name = "cbEnableTemperatureChartRollingTimeAxis";
            this.cbEnableTemperatureChartRollingTimeAxis.Size = new System.Drawing.Size(74, 21);
            this.cbEnableTemperatureChartRollingTimeAxis.TabIndex = 17;
            this.cbEnableTemperatureChartRollingTimeAxis.Text = "Enable";
            this.cbEnableTemperatureChartRollingTimeAxis.UseVisualStyleBackColor = true;
            this.cbEnableTemperatureChartRollingTimeAxis.CheckedChanged += new System.EventHandler(this.cbEnableTemperatureChartRollingTimeAxis_CheckedChanged);
            // 
            // labelRollingTemperaturePlotTimeAxis
            // 
            this.labelRollingTemperaturePlotTimeAxis.AutoSize = true;
            this.labelRollingTemperaturePlotTimeAxis.Location = new System.Drawing.Point(20, 336);
            this.labelRollingTemperaturePlotTimeAxis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRollingTemperaturePlotTimeAxis.Name = "labelRollingTemperaturePlotTimeAxis";
            this.labelRollingTemperaturePlotTimeAxis.Size = new System.Drawing.Size(113, 17);
            this.labelRollingTemperaturePlotTimeAxis.TabIndex = 16;
            this.labelRollingTemperaturePlotTimeAxis.Text = "Rolling time axis:";
            // 
            // checkBoxNeonTempPlot
            // 
            this.checkBoxNeonTempPlot.AutoSize = true;
            this.checkBoxNeonTempPlot.Location = new System.Drawing.Point(145, 181);
            this.checkBoxNeonTempPlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxNeonTempPlot.Name = "checkBoxNeonTempPlot";
            this.checkBoxNeonTempPlot.Size = new System.Drawing.Size(95, 21);
            this.checkBoxNeonTempPlot.TabIndex = 15;
            this.checkBoxNeonTempPlot.Text = "Neon Line";
            this.checkBoxNeonTempPlot.UseVisualStyleBackColor = true;
            this.checkBoxNeonTempPlot.CheckedChanged += new System.EventHandler(this.checkBoxNeonTempPlot_CheckedChanged);
            // 
            // btClearNeonTempData
            // 
            this.btClearNeonTempData.Location = new System.Drawing.Point(145, 295);
            this.btClearNeonTempData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClearNeonTempData.Name = "btClearNeonTempData";
            this.btClearNeonTempData.Size = new System.Drawing.Size(100, 28);
            this.btClearNeonTempData.TabIndex = 14;
            this.btClearNeonTempData.Text = "Neon Line";
            this.btClearNeonTempData.UseVisualStyleBackColor = true;
            this.btClearNeonTempData.Click += new System.EventHandler(this.btClearNeonTempData_Click);
            // 
            // labelClearTemperaturePlotData
            // 
            this.labelClearTemperaturePlotData.AutoSize = true;
            this.labelClearTemperaturePlotData.Location = new System.Drawing.Point(33, 230);
            this.labelClearTemperaturePlotData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClearTemperaturePlotData.Name = "labelClearTemperaturePlotData";
            this.labelClearTemperaturePlotData.Size = new System.Drawing.Size(104, 17);
            this.labelClearTemperaturePlotData.TabIndex = 13;
            this.labelClearTemperaturePlotData.Text = "Clear plot data:";
            // 
            // btClearSF6TempData
            // 
            this.btClearSF6TempData.Location = new System.Drawing.Point(145, 260);
            this.btClearSF6TempData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClearSF6TempData.Name = "btClearSF6TempData";
            this.btClearSF6TempData.Size = new System.Drawing.Size(100, 28);
            this.btClearSF6TempData.TabIndex = 12;
            this.btClearSF6TempData.Text = "SF6 Line";
            this.btClearSF6TempData.UseVisualStyleBackColor = true;
            this.btClearSF6TempData.Click += new System.EventHandler(this.btClearSF6TempData_Click);
            // 
            // btClearS2TempData
            // 
            this.btClearS2TempData.Location = new System.Drawing.Point(253, 260);
            this.btClearS2TempData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClearS2TempData.Name = "btClearS2TempData";
            this.btClearS2TempData.Size = new System.Drawing.Size(112, 28);
            this.btClearS2TempData.TabIndex = 11;
            this.btClearS2TempData.Text = "Cryo Stage 2";
            this.btClearS2TempData.UseVisualStyleBackColor = true;
            this.btClearS2TempData.Click += new System.EventHandler(this.btClearS2TempData_Click);
            // 
            // btClearS1TempData
            // 
            this.btClearS1TempData.Location = new System.Drawing.Point(253, 224);
            this.btClearS1TempData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClearS1TempData.Name = "btClearS1TempData";
            this.btClearS1TempData.Size = new System.Drawing.Size(112, 28);
            this.btClearS1TempData.TabIndex = 10;
            this.btClearS1TempData.Text = "Cryo Stage 1";
            this.btClearS1TempData.UseVisualStyleBackColor = true;
            this.btClearS1TempData.Click += new System.EventHandler(this.btClearS1TempData_Click);
            // 
            // btClearCellTempData
            // 
            this.btClearCellTempData.Location = new System.Drawing.Point(145, 224);
            this.btClearCellTempData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClearCellTempData.Name = "btClearCellTempData";
            this.btClearCellTempData.Size = new System.Drawing.Size(100, 28);
            this.btClearCellTempData.TabIndex = 9;
            this.btClearCellTempData.Text = "Cell";
            this.btClearCellTempData.UseVisualStyleBackColor = true;
            this.btClearCellTempData.Click += new System.EventHandler(this.btClearCellTempData_Click);
            // 
            // btClearAllTempData
            // 
            this.btClearAllTempData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClearAllTempData.Location = new System.Drawing.Point(253, 295);
            this.btClearAllTempData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClearAllTempData.Name = "btClearAllTempData";
            this.btClearAllTempData.Size = new System.Drawing.Size(112, 28);
            this.btClearAllTempData.TabIndex = 8;
            this.btClearAllTempData.Text = "Clear all";
            this.btClearAllTempData.UseVisualStyleBackColor = true;
            this.btClearAllTempData.Click += new System.EventHandler(this.btClearAllTempData_Click);
            // 
            // checkBoxSF6TempPlot
            // 
            this.checkBoxSF6TempPlot.AutoSize = true;
            this.checkBoxSF6TempPlot.Location = new System.Drawing.Point(145, 153);
            this.checkBoxSF6TempPlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxSF6TempPlot.Name = "checkBoxSF6TempPlot";
            this.checkBoxSF6TempPlot.Size = new System.Drawing.Size(86, 21);
            this.checkBoxSF6TempPlot.TabIndex = 7;
            this.checkBoxSF6TempPlot.Text = "SF6 Line";
            this.checkBoxSF6TempPlot.UseVisualStyleBackColor = true;
            this.checkBoxSF6TempPlot.CheckedChanged += new System.EventHandler(this.checkBoxSF6TempPlot_CheckedChanged);
            // 
            // checkBoxS2TempPlot
            // 
            this.checkBoxS2TempPlot.AutoSize = true;
            this.checkBoxS2TempPlot.Location = new System.Drawing.Point(145, 96);
            this.checkBoxS2TempPlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxS2TempPlot.Name = "checkBoxS2TempPlot";
            this.checkBoxS2TempPlot.Size = new System.Drawing.Size(112, 21);
            this.checkBoxS2TempPlot.TabIndex = 6;
            this.checkBoxS2TempPlot.Text = "Cryo Stage 2";
            this.checkBoxS2TempPlot.UseVisualStyleBackColor = true;
            this.checkBoxS2TempPlot.CheckedChanged += new System.EventHandler(this.checkBoxS2TempPlot_CheckedChanged);
            // 
            // checkBoxS1TempPlot
            // 
            this.checkBoxS1TempPlot.AutoSize = true;
            this.checkBoxS1TempPlot.Location = new System.Drawing.Point(145, 124);
            this.checkBoxS1TempPlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxS1TempPlot.Name = "checkBoxS1TempPlot";
            this.checkBoxS1TempPlot.Size = new System.Drawing.Size(112, 21);
            this.checkBoxS1TempPlot.TabIndex = 5;
            this.checkBoxS1TempPlot.Text = "Cryo Stage 1";
            this.checkBoxS1TempPlot.UseVisualStyleBackColor = true;
            this.checkBoxS1TempPlot.CheckedChanged += new System.EventHandler(this.checkBoxS1TempPlot_CheckedChanged);
            // 
            // checkBoxCellTempPlot
            // 
            this.checkBoxCellTempPlot.AutoSize = true;
            this.checkBoxCellTempPlot.Checked = true;
            this.checkBoxCellTempPlot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCellTempPlot.Location = new System.Drawing.Point(145, 68);
            this.checkBoxCellTempPlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxCellTempPlot.Name = "checkBoxCellTempPlot";
            this.checkBoxCellTempPlot.Size = new System.Drawing.Size(53, 21);
            this.checkBoxCellTempPlot.TabIndex = 4;
            this.checkBoxCellTempPlot.Text = "Cell";
            this.checkBoxCellTempPlot.UseVisualStyleBackColor = true;
            this.checkBoxCellTempPlot.CheckedChanged += new System.EventHandler(this.checkBoxCellTempPlot_CheckedChanged);
            // 
            // labelSelectTempDataToPlotChart2
            // 
            this.labelSelectTempDataToPlotChart2.AutoSize = true;
            this.labelSelectTempDataToPlotChart2.Location = new System.Drawing.Point(9, 69);
            this.labelSelectTempDataToPlotChart2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectTempDataToPlotChart2.Name = "labelSelectTempDataToPlotChart2";
            this.labelSelectTempDataToPlotChart2.Size = new System.Drawing.Size(126, 17);
            this.labelSelectTempDataToPlotChart2.TabIndex = 3;
            this.labelSelectTempDataToPlotChart2.Text = "Select data to plot:";
            // 
            // comboBoxPlot2ScaleY
            // 
            this.comboBoxPlot2ScaleY.FormattingEnabled = true;
            this.comboBoxPlot2ScaleY.Items.AddRange(new object[] {
            "Linear",
            "Log"});
            this.comboBoxPlot2ScaleY.Location = new System.Drawing.Point(141, 23);
            this.comboBoxPlot2ScaleY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxPlot2ScaleY.Name = "comboBoxPlot2ScaleY";
            this.comboBoxPlot2ScaleY.Size = new System.Drawing.Size(160, 24);
            this.comboBoxPlot2ScaleY.TabIndex = 1;
            this.comboBoxPlot2ScaleY.Text = "Linear";
            this.comboBoxPlot2ScaleY.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlot2ScaleY_SelectedIndexChanged);
            // 
            // labelPlot2ScaleY
            // 
            this.labelPlot2ScaleY.AutoSize = true;
            this.labelPlot2ScaleY.Location = new System.Drawing.Point(59, 27);
            this.labelPlot2ScaleY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlot2ScaleY.Name = "labelPlot2ScaleY";
            this.labelPlot2ScaleY.Size = new System.Drawing.Size(73, 17);
            this.labelPlot2ScaleY.TabIndex = 0;
            this.labelPlot2ScaleY.Text = "Plot scale:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagePlotting);
            this.tabControl.Controls.Add(this.tabPageFlowControllers);
            this.tabControl.Controls.Add(this.tabPageHeatersControl);
            this.tabControl.Controls.Add(this.tabPageLakeShore);
            this.tabControl.Controls.Add(this.tabPageSourceModes);
            this.tabControl.Location = new System.Drawing.Point(296, 33);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1388, 897);
            this.tabControl.TabIndex = 23;
            // 
            // tabPagePlotting
            // 
            this.tabPagePlotting.BackColor = System.Drawing.Color.DarkGray;
            this.tabPagePlotting.Controls.Add(this.gbPlotOptions);
            this.tabPagePlotting.Controls.Add(this.groupBox2);
            this.tabPagePlotting.Controls.Add(this.chart1);
            this.tabPagePlotting.Controls.Add(this.chart2);
            this.tabPagePlotting.Location = new System.Drawing.Point(4, 25);
            this.tabPagePlotting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePlotting.Name = "tabPagePlotting";
            this.tabPagePlotting.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePlotting.Size = new System.Drawing.Size(1380, 868);
            this.tabPagePlotting.TabIndex = 0;
            this.tabPagePlotting.Text = "Pressure and temperature plots";
            // 
            // tabPageFlowControllers
            // 
            this.tabPageFlowControllers.BackColor = System.Drawing.Color.DarkGray;
            this.tabPageFlowControllers.Controls.Add(this.gbSF6FlowController);
            this.tabPageFlowControllers.Controls.Add(this.gbNeonFlowController);
            this.tabPageFlowControllers.Location = new System.Drawing.Point(4, 25);
            this.tabPageFlowControllers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageFlowControllers.Name = "tabPageFlowControllers";
            this.tabPageFlowControllers.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageFlowControllers.Size = new System.Drawing.Size(1380, 868);
            this.tabPageFlowControllers.TabIndex = 2;
            this.tabPageFlowControllers.Text = "Flow Controllers";
            // 
            // gbSF6FlowController
            // 
            this.gbSF6FlowController.Location = new System.Drawing.Point(8, 437);
            this.gbSF6FlowController.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSF6FlowController.Name = "gbSF6FlowController";
            this.gbSF6FlowController.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSF6FlowController.Size = new System.Drawing.Size(1555, 422);
            this.gbSF6FlowController.TabIndex = 1;
            this.gbSF6FlowController.TabStop = false;
            this.gbSF6FlowController.Text = "SF6 Flow Controller";
            // 
            // gbNeonFlowController
            // 
            this.gbNeonFlowController.Controls.Add(this.btSetNewNeonFlowSetpoint);
            this.gbNeonFlowController.Controls.Add(this.label1);
            this.gbNeonFlowController.Controls.Add(this.chart3);
            this.gbNeonFlowController.Controls.Add(this.tbNewNeonFlowSetPoint);
            this.gbNeonFlowController.Controls.Add(this.btStartNeonFlowActMonitor);
            this.gbNeonFlowController.Controls.Add(this.labelMonitorActualNeonFlow);
            this.gbNeonFlowController.Controls.Add(this.btClearNeonFlowActPlotData);
            this.gbNeonFlowController.Controls.Add(this.labelClearNeonFlowActData);
            this.gbNeonFlowController.Controls.Add(this.tbNeonFlowSetpoint);
            this.gbNeonFlowController.Controls.Add(this.btStopNeonFlowActMonitor);
            this.gbNeonFlowController.Controls.Add(this.labelNeonFlowMonitorFL);
            this.gbNeonFlowController.Controls.Add(this.tbNeonFlowActPollPeriod);
            this.gbNeonFlowController.Controls.Add(this.labelNeonFlowMonitorSP);
            this.gbNeonFlowController.Controls.Add(this.labelNeonFlowActPollPeriod);
            this.gbNeonFlowController.Controls.Add(this.tbNeonFlowActual);
            this.gbNeonFlowController.Location = new System.Drawing.Point(8, 7);
            this.gbNeonFlowController.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNeonFlowController.Name = "gbNeonFlowController";
            this.gbNeonFlowController.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNeonFlowController.Size = new System.Drawing.Size(1361, 422);
            this.gbNeonFlowController.TabIndex = 0;
            this.gbNeonFlowController.TabStop = false;
            this.gbNeonFlowController.Text = "Neon flow controller";
            // 
            // btSetNewNeonFlowSetpoint
            // 
            this.btSetNewNeonFlowSetpoint.Enabled = false;
            this.btSetNewNeonFlowSetpoint.Location = new System.Drawing.Point(1240, 198);
            this.btSetNewNeonFlowSetpoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSetNewNeonFlowSetpoint.Name = "btSetNewNeonFlowSetpoint";
            this.btSetNewNeonFlowSetpoint.Size = new System.Drawing.Size(113, 28);
            this.btSetNewNeonFlowSetpoint.TabIndex = 34;
            this.btSetNewNeonFlowSetpoint.Text = "Set setpoint";
            this.btSetNewNeonFlowSetpoint.UseVisualStyleBackColor = true;
            this.btSetNewNeonFlowSetpoint.Click += new System.EventHandler(this.btSetNewNeonFlowSetpoint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(995, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "New setpoint:";
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.Black;
            chartArea3.AxisX.InterlacedColor = System.Drawing.Color.Black;
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.Title = "Time";
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.InterlacedColor = System.Drawing.Color.Black;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.Title = "Neon Flow (SCCM)";
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea3.BackColor = System.Drawing.Color.Black;
            chartArea3.BackImageTransparentColor = System.Drawing.Color.Black;
            chartArea3.BackSecondaryColor = System.Drawing.Color.White;
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartAreaNeonFlowChart";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Black;
            legend3.Enabled = false;
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.Name = "LegendNeonFlowChart";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(8, 16);
            this.chart3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart3.Name = "chart3";
            series8.ChartArea = "ChartAreaNeonFlowChart";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.IsVisibleInLegend = false;
            series8.Legend = "LegendNeonFlowChart";
            series8.Name = "Neon Flow";
            series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart3.Series.Add(series8);
            this.chart3.Size = new System.Drawing.Size(935, 399);
            this.chart3.TabIndex = 19;
            this.chart3.Text = "chartNeonFlow";
            title3.BackColor = System.Drawing.Color.Black;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            title3.ForeColor = System.Drawing.Color.White;
            title3.Name = "chartTitleNeonFlow";
            title3.Text = "Neon Flow (FL)";
            this.chart3.Titles.Add(title3);
            // 
            // tbNewNeonFlowSetPoint
            // 
            this.tbNewNeonFlowSetPoint.Enabled = false;
            this.tbNewNeonFlowSetPoint.Location = new System.Drawing.Point(1099, 201);
            this.tbNewNeonFlowSetPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewNeonFlowSetPoint.Name = "tbNewNeonFlowSetPoint";
            this.tbNewNeonFlowSetPoint.Size = new System.Drawing.Size(132, 22);
            this.tbNewNeonFlowSetPoint.TabIndex = 32;
            // 
            // btStartNeonFlowActMonitor
            // 
            this.btStartNeonFlowActMonitor.Location = new System.Drawing.Point(1108, 30);
            this.btStartNeonFlowActMonitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btStartNeonFlowActMonitor.Name = "btStartNeonFlowActMonitor";
            this.btStartNeonFlowActMonitor.Size = new System.Drawing.Size(113, 28);
            this.btStartNeonFlowActMonitor.TabIndex = 20;
            this.btStartNeonFlowActMonitor.Text = "Start";
            this.btStartNeonFlowActMonitor.UseVisualStyleBackColor = true;
            this.btStartNeonFlowActMonitor.Click += new System.EventHandler(this.btStartNeonFlowActMonitor_Click);
            // 
            // labelMonitorActualNeonFlow
            // 
            this.labelMonitorActualNeonFlow.AutoSize = true;
            this.labelMonitorActualNeonFlow.Location = new System.Drawing.Point(975, 34);
            this.labelMonitorActualNeonFlow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMonitorActualNeonFlow.Name = "labelMonitorActualNeonFlow";
            this.labelMonitorActualNeonFlow.Size = new System.Drawing.Size(123, 17);
            this.labelMonitorActualNeonFlow.TabIndex = 22;
            this.labelMonitorActualNeonFlow.Text = "Monitor neon flow:";
            // 
            // btClearNeonFlowActPlotData
            // 
            this.btClearNeonFlowActPlotData.Location = new System.Drawing.Point(1240, 386);
            this.btClearNeonFlowActPlotData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClearNeonFlowActPlotData.Name = "btClearNeonFlowActPlotData";
            this.btClearNeonFlowActPlotData.Size = new System.Drawing.Size(113, 28);
            this.btClearNeonFlowActPlotData.TabIndex = 29;
            this.btClearNeonFlowActPlotData.Text = "Clear";
            this.btClearNeonFlowActPlotData.UseVisualStyleBackColor = true;
            this.btClearNeonFlowActPlotData.Click += new System.EventHandler(this.btClearNeonFlowActPlotData_Click);
            // 
            // labelClearNeonFlowActData
            // 
            this.labelClearNeonFlowActData.AutoSize = true;
            this.labelClearNeonFlowActData.Location = new System.Drawing.Point(1128, 393);
            this.labelClearNeonFlowActData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClearNeonFlowActData.Name = "labelClearNeonFlowActData";
            this.labelClearNeonFlowActData.Size = new System.Drawing.Size(104, 17);
            this.labelClearNeonFlowActData.TabIndex = 28;
            this.labelClearNeonFlowActData.Text = "Clear plot data:";
            // 
            // tbNeonFlowSetpoint
            // 
            this.tbNeonFlowSetpoint.Location = new System.Drawing.Point(1099, 170);
            this.tbNeonFlowSetpoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNeonFlowSetpoint.Name = "tbNeonFlowSetpoint";
            this.tbNeonFlowSetpoint.Size = new System.Drawing.Size(132, 22);
            this.tbNeonFlowSetpoint.TabIndex = 31;
            // 
            // btStopNeonFlowActMonitor
            // 
            this.btStopNeonFlowActMonitor.Enabled = false;
            this.btStopNeonFlowActMonitor.Location = new System.Drawing.Point(1108, 60);
            this.btStopNeonFlowActMonitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btStopNeonFlowActMonitor.Name = "btStopNeonFlowActMonitor";
            this.btStopNeonFlowActMonitor.Size = new System.Drawing.Size(113, 28);
            this.btStopNeonFlowActMonitor.TabIndex = 21;
            this.btStopNeonFlowActMonitor.Text = "Stop";
            this.btStopNeonFlowActMonitor.UseVisualStyleBackColor = true;
            this.btStopNeonFlowActMonitor.Click += new System.EventHandler(this.btStopNeonFlowActMonitor_Click);
            // 
            // labelNeonFlowMonitorFL
            // 
            this.labelNeonFlowMonitorFL.AutoSize = true;
            this.labelNeonFlowMonitorFL.Location = new System.Drawing.Point(985, 142);
            this.labelNeonFlowMonitorFL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNeonFlowMonitorFL.Name = "labelNeonFlowMonitorFL";
            this.labelNeonFlowMonitorFL.Size = new System.Drawing.Size(104, 17);
            this.labelNeonFlowMonitorFL.TabIndex = 23;
            this.labelNeonFlowMonitorFL.Text = "Neon flow (FL):";
            // 
            // tbNeonFlowActPollPeriod
            // 
            this.tbNeonFlowActPollPeriod.Location = new System.Drawing.Point(1099, 106);
            this.tbNeonFlowActPollPeriod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNeonFlowActPollPeriod.Name = "tbNeonFlowActPollPeriod";
            this.tbNeonFlowActPollPeriod.Size = new System.Drawing.Size(132, 22);
            this.tbNeonFlowActPollPeriod.TabIndex = 26;
            this.tbNeonFlowActPollPeriod.Text = "1000";
            // 
            // labelNeonFlowMonitorSP
            // 
            this.labelNeonFlowMonitorSP.AutoSize = true;
            this.labelNeonFlowMonitorSP.Location = new System.Drawing.Point(983, 174);
            this.labelNeonFlowMonitorSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNeonFlowMonitorSP.Name = "labelNeonFlowMonitorSP";
            this.labelNeonFlowMonitorSP.Size = new System.Drawing.Size(106, 17);
            this.labelNeonFlowMonitorSP.TabIndex = 30;
            this.labelNeonFlowMonitorSP.Text = "Neon flow (SP):";
            // 
            // labelNeonFlowActPollPeriod
            // 
            this.labelNeonFlowActPollPeriod.AutoSize = true;
            this.labelNeonFlowActPollPeriod.Location = new System.Drawing.Point(983, 110);
            this.labelNeonFlowActPollPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNeonFlowActPollPeriod.Name = "labelNeonFlowActPollPeriod";
            this.labelNeonFlowActPollPeriod.Size = new System.Drawing.Size(111, 17);
            this.labelNeonFlowActPollPeriod.TabIndex = 25;
            this.labelNeonFlowActPollPeriod.Text = "Poll period (ms):";
            // 
            // tbNeonFlowActual
            // 
            this.tbNeonFlowActual.Location = new System.Drawing.Point(1099, 138);
            this.tbNeonFlowActual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNeonFlowActual.Name = "tbNeonFlowActual";
            this.tbNeonFlowActual.Size = new System.Drawing.Size(132, 22);
            this.tbNeonFlowActual.TabIndex = 24;
            // 
            // tabPageHeatersControl
            // 
            this.tabPageHeatersControl.BackColor = System.Drawing.Color.DarkGray;
            this.tabPageHeatersControl.Controls.Add(this.checkBoxMonitorPressureWhenHeating);
            this.tabPageHeatersControl.Controls.Add(this.gbDigitalHeaters);
            this.tabPageHeatersControl.Location = new System.Drawing.Point(4, 25);
            this.tabPageHeatersControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageHeatersControl.Name = "tabPageHeatersControl";
            this.tabPageHeatersControl.Size = new System.Drawing.Size(1380, 868);
            this.tabPageHeatersControl.TabIndex = 4;
            this.tabPageHeatersControl.Text = "Heaters Control";
            // 
            // checkBoxMonitorPressureWhenHeating
            // 
            this.checkBoxMonitorPressureWhenHeating.AutoSize = true;
            this.checkBoxMonitorPressureWhenHeating.Checked = true;
            this.checkBoxMonitorPressureWhenHeating.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMonitorPressureWhenHeating.Location = new System.Drawing.Point(976, 487);
            this.checkBoxMonitorPressureWhenHeating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxMonitorPressureWhenHeating.Name = "checkBoxMonitorPressureWhenHeating";
            this.checkBoxMonitorPressureWhenHeating.Size = new System.Drawing.Size(225, 21);
            this.checkBoxMonitorPressureWhenHeating.TabIndex = 6;
            this.checkBoxMonitorPressureWhenHeating.Text = "Monitor pressure when heating";
            this.checkBoxMonitorPressureWhenHeating.UseVisualStyleBackColor = true;
            this.checkBoxMonitorPressureWhenHeating.CheckedChanged += new System.EventHandler(this.checkBoxMonitorPressureWhenHeating_CheckedChanged);
            // 
            // gbDigitalHeaters
            // 
            this.gbDigitalHeaters.Controls.Add(this.tbHeaterControlStatus);
            this.gbDigitalHeaters.Controls.Add(this.labelHeaterControlStatus);
            this.gbDigitalHeaters.Controls.Add(this.btHeatersTurnOffWaitCancel);
            this.gbDigitalHeaters.Controls.Add(this.btHeatersTurnOffWaitStart);
            this.gbDigitalHeaters.Controls.Add(this.labelHowLongUntilHeatersTurnOff);
            this.gbDigitalHeaters.Controls.Add(this.labelTurnHeatersOffAt);
            this.gbDigitalHeaters.Controls.Add(this.tbHowLongUntilHeatersTurnOff);
            this.gbDigitalHeaters.Controls.Add(this.dateTimePickerHeatersTurnOff);
            this.gbDigitalHeaters.Controls.Add(this.gbCryoStage1HeaterControl);
            this.gbDigitalHeaters.Controls.Add(this.gbCryoStage2HeaterControl);
            this.gbDigitalHeaters.Location = new System.Drawing.Point(72, 148);
            this.gbDigitalHeaters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDigitalHeaters.Name = "gbDigitalHeaters";
            this.gbDigitalHeaters.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDigitalHeaters.Size = new System.Drawing.Size(1132, 315);
            this.gbDigitalHeaters.TabIndex = 17;
            this.gbDigitalHeaters.TabStop = false;
            this.gbDigitalHeaters.Text = "Digital Heater Control";
            // 
            // tbHeaterControlStatus
            // 
            this.tbHeaterControlStatus.Location = new System.Drawing.Point(581, 197);
            this.tbHeaterControlStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHeaterControlStatus.Multiline = true;
            this.tbHeaterControlStatus.Name = "tbHeaterControlStatus";
            this.tbHeaterControlStatus.Size = new System.Drawing.Size(523, 98);
            this.tbHeaterControlStatus.TabIndex = 17;
            // 
            // labelHeaterControlStatus
            // 
            this.labelHeaterControlStatus.AutoSize = true;
            this.labelHeaterControlStatus.Location = new System.Drawing.Point(520, 201);
            this.labelHeaterControlStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeaterControlStatus.Name = "labelHeaterControlStatus";
            this.labelHeaterControlStatus.Size = new System.Drawing.Size(52, 17);
            this.labelHeaterControlStatus.TabIndex = 16;
            this.labelHeaterControlStatus.Text = "Status:";
            // 
            // btHeatersTurnOffWaitCancel
            // 
            this.btHeatersTurnOffWaitCancel.Enabled = false;
            this.btHeatersTurnOffWaitCancel.Location = new System.Drawing.Point(387, 230);
            this.btHeatersTurnOffWaitCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btHeatersTurnOffWaitCancel.Name = "btHeatersTurnOffWaitCancel";
            this.btHeatersTurnOffWaitCancel.Size = new System.Drawing.Size(100, 28);
            this.btHeatersTurnOffWaitCancel.TabIndex = 15;
            this.btHeatersTurnOffWaitCancel.Text = "Cancel";
            this.btHeatersTurnOffWaitCancel.UseVisualStyleBackColor = true;
            this.btHeatersTurnOffWaitCancel.Click += new System.EventHandler(this.btHeatersTurnOffWaitCancel_Click);
            // 
            // btHeatersTurnOffWaitStart
            // 
            this.btHeatersTurnOffWaitStart.Enabled = false;
            this.btHeatersTurnOffWaitStart.Location = new System.Drawing.Point(387, 194);
            this.btHeatersTurnOffWaitStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btHeatersTurnOffWaitStart.Name = "btHeatersTurnOffWaitStart";
            this.btHeatersTurnOffWaitStart.Size = new System.Drawing.Size(100, 28);
            this.btHeatersTurnOffWaitStart.TabIndex = 14;
            this.btHeatersTurnOffWaitStart.Text = "Start";
            this.btHeatersTurnOffWaitStart.UseVisualStyleBackColor = true;
            this.btHeatersTurnOffWaitStart.Click += new System.EventHandler(this.btHeatersTurnOffWaitStart_Click);
            // 
            // labelHowLongUntilHeatersTurnOff
            // 
            this.labelHowLongUntilHeatersTurnOff.AutoSize = true;
            this.labelHowLongUntilHeatersTurnOff.Location = new System.Drawing.Point(113, 230);
            this.labelHowLongUntilHeatersTurnOff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHowLongUntilHeatersTurnOff.Name = "labelHowLongUntilHeatersTurnOff";
            this.labelHowLongUntilHeatersTurnOff.Size = new System.Drawing.Size(109, 34);
            this.labelHowLongUntilHeatersTurnOff.TabIndex = 13;
            this.labelHowLongUntilHeatersTurnOff.Text = "How long until \r\nheaters turn off:";
            // 
            // labelTurnHeatersOffAt
            // 
            this.labelTurnHeatersOffAt.AutoSize = true;
            this.labelTurnHeatersOffAt.Location = new System.Drawing.Point(92, 201);
            this.labelTurnHeatersOffAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTurnHeatersOffAt.Name = "labelTurnHeatersOffAt";
            this.labelTurnHeatersOffAt.Size = new System.Drawing.Size(130, 17);
            this.labelTurnHeatersOffAt.TabIndex = 12;
            this.labelTurnHeatersOffAt.Text = "Turn heaters off at:";
            // 
            // tbHowLongUntilHeatersTurnOff
            // 
            this.tbHowLongUntilHeatersTurnOff.Location = new System.Drawing.Point(229, 233);
            this.tbHowLongUntilHeatersTurnOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHowLongUntilHeatersTurnOff.Name = "tbHowLongUntilHeatersTurnOff";
            this.tbHowLongUntilHeatersTurnOff.Size = new System.Drawing.Size(128, 22);
            this.tbHowLongUntilHeatersTurnOff.TabIndex = 11;
            // 
            // dateTimePickerHeatersTurnOff
            // 
            this.dateTimePickerHeatersTurnOff.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHeatersTurnOff.Location = new System.Drawing.Point(229, 197);
            this.dateTimePickerHeatersTurnOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerHeatersTurnOff.Name = "dateTimePickerHeatersTurnOff";
            this.dateTimePickerHeatersTurnOff.Size = new System.Drawing.Size(128, 22);
            this.dateTimePickerHeatersTurnOff.TabIndex = 10;
            this.dateTimePickerHeatersTurnOff.Value = new System.DateTime(2019, 11, 5, 18, 37, 30, 0);
            // 
            // gbCryoStage1HeaterControl
            // 
            this.gbCryoStage1HeaterControl.Controls.Add(this.btUpdateHeaterControlStage1);
            this.gbCryoStage1HeaterControl.Controls.Add(this.btStopHeaterControlStage1);
            this.gbCryoStage1HeaterControl.Controls.Add(this.checkBoxEnableHeatersS1);
            this.gbCryoStage1HeaterControl.Controls.Add(this.btStartHeaterControlStage1);
            this.gbCryoStage1HeaterControl.Controls.Add(this.tbHeaterTempSetpointStage1);
            this.gbCryoStage1HeaterControl.Controls.Add(this.labelHeaterSetpointStage1);
            this.gbCryoStage1HeaterControl.Location = new System.Drawing.Point(569, 23);
            this.gbCryoStage1HeaterControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCryoStage1HeaterControl.Name = "gbCryoStage1HeaterControl";
            this.gbCryoStage1HeaterControl.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCryoStage1HeaterControl.Size = new System.Drawing.Size(553, 159);
            this.gbCryoStage1HeaterControl.TabIndex = 9;
            this.gbCryoStage1HeaterControl.TabStop = false;
            this.gbCryoStage1HeaterControl.Text = "Cryo Stage 1";
            // 
            // btUpdateHeaterControlStage1
            // 
            this.btUpdateHeaterControlStage1.Enabled = false;
            this.btUpdateHeaterControlStage1.Location = new System.Drawing.Point(199, 69);
            this.btUpdateHeaterControlStage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btUpdateHeaterControlStage1.Name = "btUpdateHeaterControlStage1";
            this.btUpdateHeaterControlStage1.Size = new System.Drawing.Size(100, 28);
            this.btUpdateHeaterControlStage1.TabIndex = 12;
            this.btUpdateHeaterControlStage1.Text = "Update";
            this.btUpdateHeaterControlStage1.UseVisualStyleBackColor = true;
            this.btUpdateHeaterControlStage1.Click += new System.EventHandler(this.btUpdateHeaterControlStage1_Click);
            // 
            // btStopHeaterControlStage1
            // 
            this.btStopHeaterControlStage1.Enabled = false;
            this.btStopHeaterControlStage1.Location = new System.Drawing.Point(352, 70);
            this.btStopHeaterControlStage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btStopHeaterControlStage1.Name = "btStopHeaterControlStage1";
            this.btStopHeaterControlStage1.Size = new System.Drawing.Size(100, 28);
            this.btStopHeaterControlStage1.TabIndex = 11;
            this.btStopHeaterControlStage1.Text = "Stop";
            this.btStopHeaterControlStage1.UseVisualStyleBackColor = true;
            this.btStopHeaterControlStage1.Click += new System.EventHandler(this.btStopHeaterControlStage1_Click);
            // 
            // checkBoxEnableHeatersS1
            // 
            this.checkBoxEnableHeatersS1.AutoSize = true;
            this.checkBoxEnableHeatersS1.Location = new System.Drawing.Point(12, 119);
            this.checkBoxEnableHeatersS1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEnableHeatersS1.Name = "checkBoxEnableHeatersS1";
            this.checkBoxEnableHeatersS1.Size = new System.Drawing.Size(181, 21);
            this.checkBoxEnableHeatersS1.TabIndex = 7;
            this.checkBoxEnableHeatersS1.Text = "Enable Stage 1 Heaters";
            this.checkBoxEnableHeatersS1.UseVisualStyleBackColor = true;
            this.checkBoxEnableHeatersS1.CheckedChanged += new System.EventHandler(this.checkBoxEnableHeatersS1_CheckedChanged);
            // 
            // btStartHeaterControlStage1
            // 
            this.btStartHeaterControlStage1.Enabled = false;
            this.btStartHeaterControlStage1.Location = new System.Drawing.Point(352, 34);
            this.btStartHeaterControlStage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btStartHeaterControlStage1.Name = "btStartHeaterControlStage1";
            this.btStartHeaterControlStage1.Size = new System.Drawing.Size(100, 28);
            this.btStartHeaterControlStage1.TabIndex = 10;
            this.btStartHeaterControlStage1.Text = "Start";
            this.btStartHeaterControlStage1.UseVisualStyleBackColor = true;
            this.btStartHeaterControlStage1.Click += new System.EventHandler(this.btStartHeaterControlStage1_Click);
            // 
            // tbHeaterTempSetpointStage1
            // 
            this.tbHeaterTempSetpointStage1.Location = new System.Drawing.Point(187, 37);
            this.tbHeaterTempSetpointStage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHeaterTempSetpointStage1.Name = "tbHeaterTempSetpointStage1";
            this.tbHeaterTempSetpointStage1.Size = new System.Drawing.Size(132, 22);
            this.tbHeaterTempSetpointStage1.TabIndex = 9;
            this.tbHeaterTempSetpointStage1.Text = "30.0";
            // 
            // labelHeaterSetpointStage1
            // 
            this.labelHeaterSetpointStage1.AutoSize = true;
            this.labelHeaterSetpointStage1.Location = new System.Drawing.Point(8, 41);
            this.labelHeaterSetpointStage1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeaterSetpointStage1.Name = "labelHeaterSetpointStage1";
            this.labelHeaterSetpointStage1.Size = new System.Drawing.Size(173, 17);
            this.labelHeaterSetpointStage1.TabIndex = 8;
            this.labelHeaterSetpointStage1.Text = "Temperature Setpoint (K):";
            // 
            // gbCryoStage2HeaterControl
            // 
            this.gbCryoStage2HeaterControl.Controls.Add(this.btUpdateHeaterControlStage2);
            this.gbCryoStage2HeaterControl.Controls.Add(this.btStopHeaterControlStage2);
            this.gbCryoStage2HeaterControl.Controls.Add(this.btStartHeaterControlStage2);
            this.gbCryoStage2HeaterControl.Controls.Add(this.labelHeaterSetpointStage2);
            this.gbCryoStage2HeaterControl.Controls.Add(this.tbHeaterTempSetpointStage2);
            this.gbCryoStage2HeaterControl.Controls.Add(this.checkBoxEnableHeatersS2);
            this.gbCryoStage2HeaterControl.Location = new System.Drawing.Point(8, 23);
            this.gbCryoStage2HeaterControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCryoStage2HeaterControl.Name = "gbCryoStage2HeaterControl";
            this.gbCryoStage2HeaterControl.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCryoStage2HeaterControl.Size = new System.Drawing.Size(553, 159);
            this.gbCryoStage2HeaterControl.TabIndex = 8;
            this.gbCryoStage2HeaterControl.TabStop = false;
            this.gbCryoStage2HeaterControl.Text = "Cryo Stage 2";
            // 
            // btUpdateHeaterControlStage2
            // 
            this.btUpdateHeaterControlStage2.Enabled = false;
            this.btUpdateHeaterControlStage2.Location = new System.Drawing.Point(217, 69);
            this.btUpdateHeaterControlStage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btUpdateHeaterControlStage2.Name = "btUpdateHeaterControlStage2";
            this.btUpdateHeaterControlStage2.Size = new System.Drawing.Size(100, 28);
            this.btUpdateHeaterControlStage2.TabIndex = 5;
            this.btUpdateHeaterControlStage2.Text = "Update";
            this.btUpdateHeaterControlStage2.UseVisualStyleBackColor = true;
            this.btUpdateHeaterControlStage2.Click += new System.EventHandler(this.btUpdateHeaterControlStage2_Click);
            // 
            // btStopHeaterControlStage2
            // 
            this.btStopHeaterControlStage2.Enabled = false;
            this.btStopHeaterControlStage2.Location = new System.Drawing.Point(357, 69);
            this.btStopHeaterControlStage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btStopHeaterControlStage2.Name = "btStopHeaterControlStage2";
            this.btStopHeaterControlStage2.Size = new System.Drawing.Size(100, 28);
            this.btStopHeaterControlStage2.TabIndex = 4;
            this.btStopHeaterControlStage2.Text = "Stop";
            this.btStopHeaterControlStage2.UseVisualStyleBackColor = true;
            this.btStopHeaterControlStage2.Click += new System.EventHandler(this.btStopHeaterControlStage2_Click);
            // 
            // btStartHeaterControlStage2
            // 
            this.btStartHeaterControlStage2.Enabled = false;
            this.btStartHeaterControlStage2.Location = new System.Drawing.Point(357, 34);
            this.btStartHeaterControlStage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btStartHeaterControlStage2.Name = "btStartHeaterControlStage2";
            this.btStartHeaterControlStage2.Size = new System.Drawing.Size(100, 28);
            this.btStartHeaterControlStage2.TabIndex = 3;
            this.btStartHeaterControlStage2.Text = "Start";
            this.btStartHeaterControlStage2.UseVisualStyleBackColor = true;
            this.btStartHeaterControlStage2.Click += new System.EventHandler(this.btStartHeaterControlStage2_Click);
            // 
            // labelHeaterSetpointStage2
            // 
            this.labelHeaterSetpointStage2.AutoSize = true;
            this.labelHeaterSetpointStage2.Location = new System.Drawing.Point(24, 41);
            this.labelHeaterSetpointStage2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeaterSetpointStage2.Name = "labelHeaterSetpointStage2";
            this.labelHeaterSetpointStage2.Size = new System.Drawing.Size(173, 17);
            this.labelHeaterSetpointStage2.TabIndex = 2;
            this.labelHeaterSetpointStage2.Text = "Temperature Setpoint (K):";
            // 
            // tbHeaterTempSetpointStage2
            // 
            this.tbHeaterTempSetpointStage2.Location = new System.Drawing.Point(203, 37);
            this.tbHeaterTempSetpointStage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHeaterTempSetpointStage2.Name = "tbHeaterTempSetpointStage2";
            this.tbHeaterTempSetpointStage2.Size = new System.Drawing.Size(132, 22);
            this.tbHeaterTempSetpointStage2.TabIndex = 1;
            this.tbHeaterTempSetpointStage2.Text = "4.0";
            // 
            // checkBoxEnableHeatersS2
            // 
            this.checkBoxEnableHeatersS2.AutoSize = true;
            this.checkBoxEnableHeatersS2.Location = new System.Drawing.Point(28, 119);
            this.checkBoxEnableHeatersS2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEnableHeatersS2.Name = "checkBoxEnableHeatersS2";
            this.checkBoxEnableHeatersS2.Size = new System.Drawing.Size(181, 21);
            this.checkBoxEnableHeatersS2.TabIndex = 0;
            this.checkBoxEnableHeatersS2.Text = "Enable Stage 2 Heaters";
            this.checkBoxEnableHeatersS2.UseVisualStyleBackColor = true;
            this.checkBoxEnableHeatersS2.CheckedChanged += new System.EventHandler(this.checkBoxEnableHeatersS2_CheckedChanged);
            // 
            // tabPageLakeShore
            // 
            this.tabPageLakeShore.BackColor = System.Drawing.Color.DarkGray;
            this.tabPageLakeShore.Controls.Add(this.gbAutotune);
            this.tabPageLakeShore.Controls.Add(this.gbLakeShore336PIDLoops);
            this.tabPageLakeShore.Controls.Add(this.groupBox3);
            this.tabPageLakeShore.Location = new System.Drawing.Point(4, 25);
            this.tabPageLakeShore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageLakeShore.Name = "tabPageLakeShore";
            this.tabPageLakeShore.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageLakeShore.Size = new System.Drawing.Size(1380, 868);
            this.tabPageLakeShore.TabIndex = 1;
            this.tabPageLakeShore.Text = "LakeShore 336";
            // 
            // gbAutotune
            // 
            this.gbAutotune.Controls.Add(this.btQueryAutotuneError);
            this.gbAutotune.Controls.Add(this.rtbAutotuneStatus);
            this.gbAutotune.Controls.Add(this.label3);
            this.gbAutotune.Controls.Add(this.comboBoxLakeShore336OutputsAutotune);
            this.gbAutotune.Controls.Add(this.labelAutotuneModes);
            this.gbAutotune.Controls.Add(this.btAutotuneLakeShore336Output);
            this.gbAutotune.Controls.Add(this.comboBoxLakeShore336AutotuneModes);
            this.gbAutotune.Location = new System.Drawing.Point(8, 145);
            this.gbAutotune.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAutotune.Name = "gbAutotune";
            this.gbAutotune.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAutotune.Size = new System.Drawing.Size(1365, 138);
            this.gbAutotune.TabIndex = 20;
            this.gbAutotune.TabStop = false;
            this.gbAutotune.Text = "Autotune";
            // 
            // btQueryAutotuneError
            // 
            this.btQueryAutotuneError.Location = new System.Drawing.Point(596, 37);
            this.btQueryAutotuneError.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQueryAutotuneError.Name = "btQueryAutotuneError";
            this.btQueryAutotuneError.Size = new System.Drawing.Size(209, 28);
            this.btQueryAutotuneError.TabIndex = 20;
            this.btQueryAutotuneError.Text = "Query Autotune Status:";
            this.btQueryAutotuneError.UseVisualStyleBackColor = true;
            this.btQueryAutotuneError.Click += new System.EventHandler(this.btQueryAutotuneError_Click);
            // 
            // rtbAutotuneStatus
            // 
            this.rtbAutotuneStatus.Location = new System.Drawing.Point(813, 37);
            this.rtbAutotuneStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbAutotuneStatus.Name = "rtbAutotuneStatus";
            this.rtbAutotuneStatus.Size = new System.Drawing.Size(527, 84);
            this.rtbAutotuneStatus.TabIndex = 19;
            this.rtbAutotuneStatus.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Output:";
            // 
            // comboBoxLakeShore336OutputsAutotune
            // 
            this.comboBoxLakeShore336OutputsAutotune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLakeShore336OutputsAutotune.FormattingEnabled = true;
            this.comboBoxLakeShore336OutputsAutotune.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxLakeShore336OutputsAutotune.Location = new System.Drawing.Point(168, 39);
            this.comboBoxLakeShore336OutputsAutotune.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxLakeShore336OutputsAutotune.Name = "comboBoxLakeShore336OutputsAutotune";
            this.comboBoxLakeShore336OutputsAutotune.Size = new System.Drawing.Size(160, 24);
            this.comboBoxLakeShore336OutputsAutotune.TabIndex = 13;
            this.comboBoxLakeShore336OutputsAutotune.SelectedIndexChanged += new System.EventHandler(this.comboBoxLakeShore336OutputsAutotune_SelectedIndexChanged);
            // 
            // labelAutotuneModes
            // 
            this.labelAutotuneModes.AutoSize = true;
            this.labelAutotuneModes.Location = new System.Drawing.Point(339, 20);
            this.labelAutotuneModes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAutotuneModes.Name = "labelAutotuneModes";
            this.labelAutotuneModes.Size = new System.Drawing.Size(115, 17);
            this.labelAutotuneModes.TabIndex = 17;
            this.labelAutotuneModes.Text = "Autotune Modes:";
            // 
            // btAutotuneLakeShore336Output
            // 
            this.btAutotuneLakeShore336Output.Location = new System.Drawing.Point(16, 37);
            this.btAutotuneLakeShore336Output.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAutotuneLakeShore336Output.Name = "btAutotuneLakeShore336Output";
            this.btAutotuneLakeShore336Output.Size = new System.Drawing.Size(144, 28);
            this.btAutotuneLakeShore336Output.TabIndex = 14;
            this.btAutotuneLakeShore336Output.Text = "Autotune:";
            this.btAutotuneLakeShore336Output.UseVisualStyleBackColor = true;
            this.btAutotuneLakeShore336Output.Click += new System.EventHandler(this.btAutotuneLakeShore336Output_Click);
            // 
            // comboBoxLakeShore336AutotuneModes
            // 
            this.comboBoxLakeShore336AutotuneModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLakeShore336AutotuneModes.FormattingEnabled = true;
            this.comboBoxLakeShore336AutotuneModes.Items.AddRange(new object[] {
            "P",
            "P and I",
            "P, I and D"});
            this.comboBoxLakeShore336AutotuneModes.Location = new System.Drawing.Point(337, 39);
            this.comboBoxLakeShore336AutotuneModes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxLakeShore336AutotuneModes.Name = "comboBoxLakeShore336AutotuneModes";
            this.comboBoxLakeShore336AutotuneModes.Size = new System.Drawing.Size(160, 24);
            this.comboBoxLakeShore336AutotuneModes.TabIndex = 16;
            this.comboBoxLakeShore336AutotuneModes.SelectedIndexChanged += new System.EventHandler(this.comboBoxLakeShore336AutotuneModes_SelectedIndexChanged);
            // 
            // gbLakeShore336PIDLoops
            // 
            this.gbLakeShore336PIDLoops.Controls.Add(this.labelPIDLoopsOutputs);
            this.gbLakeShore336PIDLoops.Controls.Add(this.tbLakeShore336PIDDValueInput);
            this.gbLakeShore336PIDLoops.Controls.Add(this.tbLakeShore336PIDIValueInput);
            this.gbLakeShore336PIDLoops.Controls.Add(this.tbLakeShore336PIDPValueInput);
            this.gbLakeShore336PIDLoops.Controls.Add(this.btSetLakeShore336PIDvalues);
            this.gbLakeShore336PIDLoops.Controls.Add(this.comboBoxLakeShore336OutputsSet);
            this.gbLakeShore336PIDLoops.Controls.Add(this.tbLakeShore336PIDDValueOutput);
            this.gbLakeShore336PIDLoops.Controls.Add(this.tbLakeShore336PIDIValueOutput);
            this.gbLakeShore336PIDLoops.Controls.Add(this.labelLakeShore336DValue);
            this.gbLakeShore336PIDLoops.Controls.Add(this.labelLakeShore336IValue);
            this.gbLakeShore336PIDLoops.Controls.Add(this.tbLakeShore336PIDPValueOutput);
            this.gbLakeShore336PIDLoops.Controls.Add(this.labelLakeShore336PValue);
            this.gbLakeShore336PIDLoops.Controls.Add(this.btQueryLakeShore336PIDvalues);
            this.gbLakeShore336PIDLoops.Controls.Add(this.comboBoxLakeShore336OutputsQuery);
            this.gbLakeShore336PIDLoops.Location = new System.Drawing.Point(8, 14);
            this.gbLakeShore336PIDLoops.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbLakeShore336PIDLoops.Name = "gbLakeShore336PIDLoops";
            this.gbLakeShore336PIDLoops.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbLakeShore336PIDLoops.Size = new System.Drawing.Size(1361, 121);
            this.gbLakeShore336PIDLoops.TabIndex = 19;
            this.gbLakeShore336PIDLoops.TabStop = false;
            this.gbLakeShore336PIDLoops.Text = "PID Loops";
            // 
            // labelPIDLoopsOutputs
            // 
            this.labelPIDLoopsOutputs.AutoSize = true;
            this.labelPIDLoopsOutputs.Location = new System.Drawing.Point(169, 16);
            this.labelPIDLoopsOutputs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPIDLoopsOutputs.Name = "labelPIDLoopsOutputs";
            this.labelPIDLoopsOutputs.Size = new System.Drawing.Size(55, 17);
            this.labelPIDLoopsOutputs.TabIndex = 15;
            this.labelPIDLoopsOutputs.Text = "Output:";
            // 
            // tbLakeShore336PIDDValueInput
            // 
            this.tbLakeShore336PIDDValueInput.Location = new System.Drawing.Point(647, 70);
            this.tbLakeShore336PIDDValueInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLakeShore336PIDDValueInput.Name = "tbLakeShore336PIDDValueInput";
            this.tbLakeShore336PIDDValueInput.Size = new System.Drawing.Size(132, 22);
            this.tbLakeShore336PIDDValueInput.TabIndex = 12;
            // 
            // tbLakeShore336PIDIValueInput
            // 
            this.tbLakeShore336PIDIValueInput.Location = new System.Drawing.Point(505, 70);
            this.tbLakeShore336PIDIValueInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLakeShore336PIDIValueInput.Name = "tbLakeShore336PIDIValueInput";
            this.tbLakeShore336PIDIValueInput.Size = new System.Drawing.Size(132, 22);
            this.tbLakeShore336PIDIValueInput.TabIndex = 11;
            // 
            // tbLakeShore336PIDPValueInput
            // 
            this.tbLakeShore336PIDPValueInput.Location = new System.Drawing.Point(364, 70);
            this.tbLakeShore336PIDPValueInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLakeShore336PIDPValueInput.Name = "tbLakeShore336PIDPValueInput";
            this.tbLakeShore336PIDPValueInput.Size = new System.Drawing.Size(132, 22);
            this.tbLakeShore336PIDPValueInput.TabIndex = 10;
            // 
            // btSetLakeShore336PIDvalues
            // 
            this.btSetLakeShore336PIDvalues.Location = new System.Drawing.Point(16, 66);
            this.btSetLakeShore336PIDvalues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSetLakeShore336PIDvalues.Name = "btSetLakeShore336PIDvalues";
            this.btSetLakeShore336PIDvalues.Size = new System.Drawing.Size(144, 28);
            this.btSetLakeShore336PIDvalues.TabIndex = 9;
            this.btSetLakeShore336PIDvalues.Text = "Set PID values:";
            this.btSetLakeShore336PIDvalues.UseVisualStyleBackColor = true;
            this.btSetLakeShore336PIDvalues.Click += new System.EventHandler(this.btSetLakeShore336PIDvalues_Click);
            // 
            // comboBoxLakeShore336OutputsSet
            // 
            this.comboBoxLakeShore336OutputsSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLakeShore336OutputsSet.FormattingEnabled = true;
            this.comboBoxLakeShore336OutputsSet.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxLakeShore336OutputsSet.Location = new System.Drawing.Point(168, 69);
            this.comboBoxLakeShore336OutputsSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxLakeShore336OutputsSet.Name = "comboBoxLakeShore336OutputsSet";
            this.comboBoxLakeShore336OutputsSet.Size = new System.Drawing.Size(160, 24);
            this.comboBoxLakeShore336OutputsSet.TabIndex = 8;
            // 
            // tbLakeShore336PIDDValueOutput
            // 
            this.tbLakeShore336PIDDValueOutput.Location = new System.Drawing.Point(647, 36);
            this.tbLakeShore336PIDDValueOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLakeShore336PIDDValueOutput.Name = "tbLakeShore336PIDDValueOutput";
            this.tbLakeShore336PIDDValueOutput.Size = new System.Drawing.Size(132, 22);
            this.tbLakeShore336PIDDValueOutput.TabIndex = 7;
            // 
            // tbLakeShore336PIDIValueOutput
            // 
            this.tbLakeShore336PIDIValueOutput.Location = new System.Drawing.Point(505, 36);
            this.tbLakeShore336PIDIValueOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLakeShore336PIDIValueOutput.Name = "tbLakeShore336PIDIValueOutput";
            this.tbLakeShore336PIDIValueOutput.Size = new System.Drawing.Size(132, 22);
            this.tbLakeShore336PIDIValueOutput.TabIndex = 6;
            // 
            // labelLakeShore336DValue
            // 
            this.labelLakeShore336DValue.AutoSize = true;
            this.labelLakeShore336DValue.Location = new System.Drawing.Point(643, 16);
            this.labelLakeShore336DValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLakeShore336DValue.Name = "labelLakeShore336DValue";
            this.labelLakeShore336DValue.Size = new System.Drawing.Size(97, 17);
            this.labelLakeShore336DValue.TabIndex = 5;
            this.labelLakeShore336DValue.Text = "Derivative (%)";
            // 
            // labelLakeShore336IValue
            // 
            this.labelLakeShore336IValue.AutoSize = true;
            this.labelLakeShore336IValue.Location = new System.Drawing.Point(501, 16);
            this.labelLakeShore336IValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLakeShore336IValue.Name = "labelLakeShore336IValue";
            this.labelLakeShore336IValue.Size = new System.Drawing.Size(59, 17);
            this.labelLakeShore336IValue.TabIndex = 4;
            this.labelLakeShore336IValue.Text = "Integral:";
            // 
            // tbLakeShore336PIDPValueOutput
            // 
            this.tbLakeShore336PIDPValueOutput.Location = new System.Drawing.Point(364, 36);
            this.tbLakeShore336PIDPValueOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLakeShore336PIDPValueOutput.Name = "tbLakeShore336PIDPValueOutput";
            this.tbLakeShore336PIDPValueOutput.Size = new System.Drawing.Size(132, 22);
            this.tbLakeShore336PIDPValueOutput.TabIndex = 3;
            // 
            // labelLakeShore336PValue
            // 
            this.labelLakeShore336PValue.AutoSize = true;
            this.labelLakeShore336PValue.Location = new System.Drawing.Point(360, 16);
            this.labelLakeShore336PValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLakeShore336PValue.Name = "labelLakeShore336PValue";
            this.labelLakeShore336PValue.Size = new System.Drawing.Size(89, 17);
            this.labelLakeShore336PValue.TabIndex = 2;
            this.labelLakeShore336PValue.Text = "Proportional:";
            // 
            // btQueryLakeShore336PIDvalues
            // 
            this.btQueryLakeShore336PIDvalues.Location = new System.Drawing.Point(16, 33);
            this.btQueryLakeShore336PIDvalues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQueryLakeShore336PIDvalues.Name = "btQueryLakeShore336PIDvalues";
            this.btQueryLakeShore336PIDvalues.Size = new System.Drawing.Size(144, 28);
            this.btQueryLakeShore336PIDvalues.TabIndex = 1;
            this.btQueryLakeShore336PIDvalues.Text = "Query PID values:";
            this.btQueryLakeShore336PIDvalues.UseVisualStyleBackColor = true;
            this.btQueryLakeShore336PIDvalues.Click += new System.EventHandler(this.btQueryLakeShore336PIDvalues_Click);
            // 
            // comboBoxLakeShore336OutputsQuery
            // 
            this.comboBoxLakeShore336OutputsQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLakeShore336OutputsQuery.FormattingEnabled = true;
            this.comboBoxLakeShore336OutputsQuery.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxLakeShore336OutputsQuery.Location = new System.Drawing.Point(168, 36);
            this.comboBoxLakeShore336OutputsQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxLakeShore336OutputsQuery.Name = "comboBoxLakeShore336OutputsQuery";
            this.comboBoxLakeShore336OutputsQuery.Size = new System.Drawing.Size(160, 24);
            this.comboBoxLakeShore336OutputsQuery.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbLogPressureData);
            this.groupBox3.Controls.Add(this.labelPressureLogPeriod);
            this.groupBox3.Controls.Add(this.tbpressureMonitorLogPeriod);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(1015, 574);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(300, 167);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "do not use";
            // 
            // tabPageSourceModes
            // 
            this.tabPageSourceModes.BackColor = System.Drawing.Color.DarkGray;
            this.tabPageSourceModes.Controls.Add(this.tabControl1);
            this.tabPageSourceModes.Location = new System.Drawing.Point(4, 25);
            this.tabPageSourceModes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageSourceModes.Name = "tabPageSourceModes";
            this.tabPageSourceModes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageSourceModes.Size = new System.Drawing.Size(1380, 868);
            this.tabPageSourceModes.TabIndex = 3;
            this.tabPageSourceModes.Text = "Source Modes";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRefreshMode);
            this.tabControl1.Controls.Add(this.tabPageWarmUpMode);
            this.tabControl1.Controls.Add(this.tabPageCoolDownMode);
            this.tabControl1.Location = new System.Drawing.Point(3, 7);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1373, 858);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPageRefreshMode
            // 
            this.tabPageRefreshMode.BackColor = System.Drawing.Color.Silver;
            this.tabPageRefreshMode.Controls.Add(this.gbRefreshModeWarmUp);
            this.tabPageRefreshMode.Controls.Add(this.btCancelRefreshMode);
            this.tabPageRefreshMode.Controls.Add(this.gbRefreshModeCoolDown);
            this.tabPageRefreshMode.Controls.Add(this.btStartRefreshMode);
            this.tabPageRefreshMode.Controls.Add(this.tbRefreshModeStatus);
            this.tabPageRefreshMode.Controls.Add(this.labelRefreshModeStatus);
            this.tabPageRefreshMode.Location = new System.Drawing.Point(4, 25);
            this.tabPageRefreshMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageRefreshMode.Name = "tabPageRefreshMode";
            this.tabPageRefreshMode.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageRefreshMode.Size = new System.Drawing.Size(1365, 829);
            this.tabPageRefreshMode.TabIndex = 0;
            this.tabPageRefreshMode.Text = "Refresh Mode";
            // 
            // gbRefreshModeWarmUp
            // 
            this.gbRefreshModeWarmUp.Controls.Add(this.btRefreshModeTemperatureSetpointUpdate);
            this.gbRefreshModeWarmUp.Controls.Add(this.labelRefreshModeTemperatureSetpoint);
            this.gbRefreshModeWarmUp.Controls.Add(this.tbRefreshModeTemperatureSetpoint);
            this.gbRefreshModeWarmUp.Controls.Add(this.labelRefreshModeHowLongUntilHeatersTurnOff);
            this.gbRefreshModeWarmUp.Controls.Add(this.tbRefreshModeHowLongUntilHeatersTurnOff);
            this.gbRefreshModeWarmUp.Controls.Add(this.checkBoxRefreshSourceAtRoomTemperature);
            this.gbRefreshModeWarmUp.Controls.Add(this.labelRefreshModeTurnHeatersOff);
            this.gbRefreshModeWarmUp.Controls.Add(this.dateTimePickerRefreshModeTurnHeatersOff);
            this.gbRefreshModeWarmUp.Location = new System.Drawing.Point(60, 21);
            this.gbRefreshModeWarmUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbRefreshModeWarmUp.Name = "gbRefreshModeWarmUp";
            this.gbRefreshModeWarmUp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbRefreshModeWarmUp.Size = new System.Drawing.Size(947, 96);
            this.gbRefreshModeWarmUp.TabIndex = 21;
            this.gbRefreshModeWarmUp.TabStop = false;
            this.gbRefreshModeWarmUp.Text = "Warm Up";
            // 
            // btRefreshModeTemperatureSetpointUpdate
            // 
            this.btRefreshModeTemperatureSetpointUpdate.Location = new System.Drawing.Point(532, 57);
            this.btRefreshModeTemperatureSetpointUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRefreshModeTemperatureSetpointUpdate.Name = "btRefreshModeTemperatureSetpointUpdate";
            this.btRefreshModeTemperatureSetpointUpdate.Size = new System.Drawing.Size(100, 28);
            this.btRefreshModeTemperatureSetpointUpdate.TabIndex = 22;
            this.btRefreshModeTemperatureSetpointUpdate.Text = "Update";
            this.btRefreshModeTemperatureSetpointUpdate.UseVisualStyleBackColor = true;
            this.btRefreshModeTemperatureSetpointUpdate.Click += new System.EventHandler(this.btRefreshModeTemperatureSetpointUpdate_Click);
            // 
            // labelRefreshModeTemperatureSetpoint
            // 
            this.labelRefreshModeTemperatureSetpoint.AutoSize = true;
            this.labelRefreshModeTemperatureSetpoint.Location = new System.Drawing.Point(333, 25);
            this.labelRefreshModeTemperatureSetpoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRefreshModeTemperatureSetpoint.Name = "labelRefreshModeTemperatureSetpoint";
            this.labelRefreshModeTemperatureSetpoint.Size = new System.Drawing.Size(171, 17);
            this.labelRefreshModeTemperatureSetpoint.TabIndex = 21;
            this.labelRefreshModeTemperatureSetpoint.Text = "Refresh Temperature (K):";
            // 
            // tbRefreshModeTemperatureSetpoint
            // 
            this.tbRefreshModeTemperatureSetpoint.Location = new System.Drawing.Point(513, 23);
            this.tbRefreshModeTemperatureSetpoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRefreshModeTemperatureSetpoint.Name = "tbRefreshModeTemperatureSetpoint";
            this.tbRefreshModeTemperatureSetpoint.Size = new System.Drawing.Size(132, 22);
            this.tbRefreshModeTemperatureSetpoint.TabIndex = 20;
            // 
            // labelRefreshModeHowLongUntilHeatersTurnOff
            // 
            this.labelRefreshModeHowLongUntilHeatersTurnOff.AutoSize = true;
            this.labelRefreshModeHowLongUntilHeatersTurnOff.Location = new System.Drawing.Point(48, 47);
            this.labelRefreshModeHowLongUntilHeatersTurnOff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRefreshModeHowLongUntilHeatersTurnOff.Name = "labelRefreshModeHowLongUntilHeatersTurnOff";
            this.labelRefreshModeHowLongUntilHeatersTurnOff.Size = new System.Drawing.Size(109, 34);
            this.labelRefreshModeHowLongUntilHeatersTurnOff.TabIndex = 17;
            this.labelRefreshModeHowLongUntilHeatersTurnOff.Text = "How long until \r\nheaters turn off:";
            // 
            // tbRefreshModeHowLongUntilHeatersTurnOff
            // 
            this.tbRefreshModeHowLongUntilHeatersTurnOff.Location = new System.Drawing.Point(164, 55);
            this.tbRefreshModeHowLongUntilHeatersTurnOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRefreshModeHowLongUntilHeatersTurnOff.Name = "tbRefreshModeHowLongUntilHeatersTurnOff";
            this.tbRefreshModeHowLongUntilHeatersTurnOff.Size = new System.Drawing.Size(128, 22);
            this.tbRefreshModeHowLongUntilHeatersTurnOff.TabIndex = 17;
            // 
            // checkBoxRefreshSourceAtRoomTemperature
            // 
            this.checkBoxRefreshSourceAtRoomTemperature.AutoSize = true;
            this.checkBoxRefreshSourceAtRoomTemperature.Location = new System.Drawing.Point(700, 25);
            this.checkBoxRefreshSourceAtRoomTemperature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxRefreshSourceAtRoomTemperature.Name = "checkBoxRefreshSourceAtRoomTemperature";
            this.checkBoxRefreshSourceAtRoomTemperature.Size = new System.Drawing.Size(213, 21);
            this.checkBoxRefreshSourceAtRoomTemperature.TabIndex = 17;
            this.checkBoxRefreshSourceAtRoomTemperature.Text = "Refresh at room temperature";
            this.checkBoxRefreshSourceAtRoomTemperature.UseVisualStyleBackColor = true;
            this.checkBoxRefreshSourceAtRoomTemperature.CheckedChanged += new System.EventHandler(this.checkBoxRefreshSourceAtRoomTemperature_CheckedChanged);
            // 
            // labelRefreshModeTurnHeatersOff
            // 
            this.labelRefreshModeTurnHeatersOff.AutoSize = true;
            this.labelRefreshModeTurnHeatersOff.Location = new System.Drawing.Point(27, 25);
            this.labelRefreshModeTurnHeatersOff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRefreshModeTurnHeatersOff.Name = "labelRefreshModeTurnHeatersOff";
            this.labelRefreshModeTurnHeatersOff.Size = new System.Drawing.Size(130, 17);
            this.labelRefreshModeTurnHeatersOff.TabIndex = 19;
            this.labelRefreshModeTurnHeatersOff.Text = "Turn heaters off at:";
            // 
            // dateTimePickerRefreshModeTurnHeatersOff
            // 
            this.dateTimePickerRefreshModeTurnHeatersOff.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerRefreshModeTurnHeatersOff.Location = new System.Drawing.Point(164, 23);
            this.dateTimePickerRefreshModeTurnHeatersOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerRefreshModeTurnHeatersOff.Name = "dateTimePickerRefreshModeTurnHeatersOff";
            this.dateTimePickerRefreshModeTurnHeatersOff.Size = new System.Drawing.Size(128, 22);
            this.dateTimePickerRefreshModeTurnHeatersOff.TabIndex = 18;
            this.dateTimePickerRefreshModeTurnHeatersOff.Value = new System.DateTime(2019, 11, 5, 18, 37, 30, 0);
            this.dateTimePickerRefreshModeTurnHeatersOff.ValueChanged += new System.EventHandler(this.dateTimePickerRefreshModeTurnHeatersOff_ValueChanged);
            // 
            // btCancelRefreshMode
            // 
            this.btCancelRefreshMode.Enabled = false;
            this.btCancelRefreshMode.Location = new System.Drawing.Point(907, 194);
            this.btCancelRefreshMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancelRefreshMode.Name = "btCancelRefreshMode";
            this.btCancelRefreshMode.Size = new System.Drawing.Size(100, 28);
            this.btCancelRefreshMode.TabIndex = 14;
            this.btCancelRefreshMode.Text = "Cancel";
            this.btCancelRefreshMode.UseVisualStyleBackColor = true;
            this.btCancelRefreshMode.Click += new System.EventHandler(this.btCancelRefreshMode_Click);
            // 
            // gbRefreshModeCoolDown
            // 
            this.gbRefreshModeCoolDown.Controls.Add(this.labelRefreshModeCryoTurnOnDateTime);
            this.gbRefreshModeCoolDown.Controls.Add(this.labelRefreshModeHowLongUntilCryoTurnsOn);
            this.gbRefreshModeCoolDown.Controls.Add(this.tbRefreshModeHowLongUntilCryoTurnsOn);
            this.gbRefreshModeCoolDown.Controls.Add(this.dateTimePickerRefreshModeTurnCryoOn);
            this.gbRefreshModeCoolDown.Location = new System.Drawing.Point(60, 127);
            this.gbRefreshModeCoolDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbRefreshModeCoolDown.Name = "gbRefreshModeCoolDown";
            this.gbRefreshModeCoolDown.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbRefreshModeCoolDown.Size = new System.Drawing.Size(324, 96);
            this.gbRefreshModeCoolDown.TabIndex = 20;
            this.gbRefreshModeCoolDown.TabStop = false;
            this.gbRefreshModeCoolDown.Text = "Cool down";
            // 
            // labelRefreshModeCryoTurnOnDateTime
            // 
            this.labelRefreshModeCryoTurnOnDateTime.AutoSize = true;
            this.labelRefreshModeCryoTurnOnDateTime.Location = new System.Drawing.Point(48, 25);
            this.labelRefreshModeCryoTurnOnDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRefreshModeCryoTurnOnDateTime.Name = "labelRefreshModeCryoTurnOnDateTime";
            this.labelRefreshModeCryoTurnOnDateTime.Size = new System.Drawing.Size(109, 17);
            this.labelRefreshModeCryoTurnOnDateTime.TabIndex = 11;
            this.labelRefreshModeCryoTurnOnDateTime.Text = "Turn cryo on at:";
            // 
            // labelRefreshModeHowLongUntilCryoTurnsOn
            // 
            this.labelRefreshModeHowLongUntilCryoTurnsOn.AutoSize = true;
            this.labelRefreshModeHowLongUntilCryoTurnsOn.Location = new System.Drawing.Point(55, 47);
            this.labelRefreshModeHowLongUntilCryoTurnsOn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRefreshModeHowLongUntilCryoTurnsOn.Name = "labelRefreshModeHowLongUntilCryoTurnsOn";
            this.labelRefreshModeHowLongUntilCryoTurnsOn.Size = new System.Drawing.Size(100, 34);
            this.labelRefreshModeHowLongUntilCryoTurnsOn.TabIndex = 11;
            this.labelRefreshModeHowLongUntilCryoTurnsOn.Text = "How long until \r\ncryo turns on:";
            // 
            // tbRefreshModeHowLongUntilCryoTurnsOn
            // 
            this.tbRefreshModeHowLongUntilCryoTurnsOn.Location = new System.Drawing.Point(165, 55);
            this.tbRefreshModeHowLongUntilCryoTurnsOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRefreshModeHowLongUntilCryoTurnsOn.Name = "tbRefreshModeHowLongUntilCryoTurnsOn";
            this.tbRefreshModeHowLongUntilCryoTurnsOn.Size = new System.Drawing.Size(128, 22);
            this.tbRefreshModeHowLongUntilCryoTurnsOn.TabIndex = 16;
            // 
            // dateTimePickerRefreshModeTurnCryoOn
            // 
            this.dateTimePickerRefreshModeTurnCryoOn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerRefreshModeTurnCryoOn.Location = new System.Drawing.Point(165, 23);
            this.dateTimePickerRefreshModeTurnCryoOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerRefreshModeTurnCryoOn.Name = "dateTimePickerRefreshModeTurnCryoOn";
            this.dateTimePickerRefreshModeTurnCryoOn.Size = new System.Drawing.Size(128, 22);
            this.dateTimePickerRefreshModeTurnCryoOn.TabIndex = 15;
            this.dateTimePickerRefreshModeTurnCryoOn.Value = new System.DateTime(2019, 11, 5, 18, 37, 30, 0);
            this.dateTimePickerRefreshModeTurnCryoOn.ValueChanged += new System.EventHandler(this.dateTimePickerStopHeatingAndTurnCryoOn_ValueChanged);
            // 
            // btStartRefreshMode
            // 
            this.btStartRefreshMode.Enabled = false;
            this.btStartRefreshMode.Location = new System.Drawing.Point(799, 194);
            this.btStartRefreshMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btStartRefreshMode.Name = "btStartRefreshMode";
            this.btStartRefreshMode.Size = new System.Drawing.Size(100, 28);
            this.btStartRefreshMode.TabIndex = 13;
            this.btStartRefreshMode.Text = "Start";
            this.btStartRefreshMode.UseVisualStyleBackColor = true;
            this.btStartRefreshMode.Click += new System.EventHandler(this.btStartRefreshMode_Click);
            // 
            // tbRefreshModeStatus
            // 
            this.tbRefreshModeStatus.Location = new System.Drawing.Point(224, 276);
            this.tbRefreshModeStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRefreshModeStatus.Multiline = true;
            this.tbRefreshModeStatus.Name = "tbRefreshModeStatus";
            this.tbRefreshModeStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRefreshModeStatus.Size = new System.Drawing.Size(783, 178);
            this.tbRefreshModeStatus.TabIndex = 11;
            // 
            // labelRefreshModeStatus
            // 
            this.labelRefreshModeStatus.AutoSize = true;
            this.labelRefreshModeStatus.Location = new System.Drawing.Point(71, 279);
            this.labelRefreshModeStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRefreshModeStatus.Name = "labelRefreshModeStatus";
            this.labelRefreshModeStatus.Size = new System.Drawing.Size(145, 17);
            this.labelRefreshModeStatus.TabIndex = 12;
            this.labelRefreshModeStatus.Text = "Refresh Mode Status:";
            // 
            // tabPageWarmUpMode
            // 
            this.tabPageWarmUpMode.BackColor = System.Drawing.Color.Silver;
            this.tabPageWarmUpMode.Controls.Add(this.btCancelWarmUpMode);
            this.tabPageWarmUpMode.Controls.Add(this.btStartWarmUpMode);
            this.tabPageWarmUpMode.Controls.Add(this.tbWarmUpModeStatus);
            this.tabPageWarmUpMode.Controls.Add(this.labelWarmUpModeStatus);
            this.tabPageWarmUpMode.Controls.Add(this.gbWarmUpModeWarmUp);
            this.tabPageWarmUpMode.Location = new System.Drawing.Point(4, 25);
            this.tabPageWarmUpMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageWarmUpMode.Name = "tabPageWarmUpMode";
            this.tabPageWarmUpMode.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageWarmUpMode.Size = new System.Drawing.Size(1365, 829);
            this.tabPageWarmUpMode.TabIndex = 1;
            this.tabPageWarmUpMode.Text = "Warm Up Mode";
            // 
            // btCancelWarmUpMode
            // 
            this.btCancelWarmUpMode.Enabled = false;
            this.btCancelWarmUpMode.Location = new System.Drawing.Point(907, 140);
            this.btCancelWarmUpMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancelWarmUpMode.Name = "btCancelWarmUpMode";
            this.btCancelWarmUpMode.Size = new System.Drawing.Size(100, 28);
            this.btCancelWarmUpMode.TabIndex = 26;
            this.btCancelWarmUpMode.Text = "Cancel";
            this.btCancelWarmUpMode.UseVisualStyleBackColor = true;
            this.btCancelWarmUpMode.Click += new System.EventHandler(this.btCancelWarmUpMode_Click);
            // 
            // btStartWarmUpMode
            // 
            this.btStartWarmUpMode.Enabled = false;
            this.btStartWarmUpMode.Location = new System.Drawing.Point(799, 140);
            this.btStartWarmUpMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btStartWarmUpMode.Name = "btStartWarmUpMode";
            this.btStartWarmUpMode.Size = new System.Drawing.Size(100, 28);
            this.btStartWarmUpMode.TabIndex = 25;
            this.btStartWarmUpMode.Text = "Start";
            this.btStartWarmUpMode.UseVisualStyleBackColor = true;
            this.btStartWarmUpMode.Click += new System.EventHandler(this.btStartWarmUpMode_Click);
            // 
            // tbWarmUpModeStatus
            // 
            this.tbWarmUpModeStatus.Location = new System.Drawing.Point(224, 199);
            this.tbWarmUpModeStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbWarmUpModeStatus.Multiline = true;
            this.tbWarmUpModeStatus.Name = "tbWarmUpModeStatus";
            this.tbWarmUpModeStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbWarmUpModeStatus.Size = new System.Drawing.Size(783, 178);
            this.tbWarmUpModeStatus.TabIndex = 23;
            // 
            // labelWarmUpModeStatus
            // 
            this.labelWarmUpModeStatus.AutoSize = true;
            this.labelWarmUpModeStatus.Location = new System.Drawing.Point(61, 202);
            this.labelWarmUpModeStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWarmUpModeStatus.Name = "labelWarmUpModeStatus";
            this.labelWarmUpModeStatus.Size = new System.Drawing.Size(154, 17);
            this.labelWarmUpModeStatus.TabIndex = 24;
            this.labelWarmUpModeStatus.Text = "Warm Up Mode Status:";
            // 
            // gbWarmUpModeWarmUp
            // 
            this.gbWarmUpModeWarmUp.Controls.Add(this.btWarmUpModeTemperatureSetpointUpdate);
            this.gbWarmUpModeWarmUp.Controls.Add(this.labelWarmUpModeTemperatureSetpoint);
            this.gbWarmUpModeWarmUp.Controls.Add(this.tbWarmUpModeTemperatureSetpoint);
            this.gbWarmUpModeWarmUp.Controls.Add(this.labelWarmUpModeHowLongUntilHeatersTurnOff);
            this.gbWarmUpModeWarmUp.Controls.Add(this.tbWarmUpModeHowLongUntilHeatersTurnOff);
            this.gbWarmUpModeWarmUp.Controls.Add(this.checkBoxWarmUpSourceToRoomTemperature);
            this.gbWarmUpModeWarmUp.Controls.Add(this.labelWarmUpModeTurnHeatersOff);
            this.gbWarmUpModeWarmUp.Controls.Add(this.dateTimePickerWarmUpModeTurnHeatersOff);
            this.gbWarmUpModeWarmUp.Location = new System.Drawing.Point(60, 21);
            this.gbWarmUpModeWarmUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbWarmUpModeWarmUp.Name = "gbWarmUpModeWarmUp";
            this.gbWarmUpModeWarmUp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbWarmUpModeWarmUp.Size = new System.Drawing.Size(947, 96);
            this.gbWarmUpModeWarmUp.TabIndex = 22;
            this.gbWarmUpModeWarmUp.TabStop = false;
            this.gbWarmUpModeWarmUp.Text = "Warm Up";
            // 
            // btWarmUpModeTemperatureSetpointUpdate
            // 
            this.btWarmUpModeTemperatureSetpointUpdate.Location = new System.Drawing.Point(532, 57);
            this.btWarmUpModeTemperatureSetpointUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btWarmUpModeTemperatureSetpointUpdate.Name = "btWarmUpModeTemperatureSetpointUpdate";
            this.btWarmUpModeTemperatureSetpointUpdate.Size = new System.Drawing.Size(100, 28);
            this.btWarmUpModeTemperatureSetpointUpdate.TabIndex = 22;
            this.btWarmUpModeTemperatureSetpointUpdate.Text = "Update";
            this.btWarmUpModeTemperatureSetpointUpdate.UseVisualStyleBackColor = true;
            this.btWarmUpModeTemperatureSetpointUpdate.Click += new System.EventHandler(this.btWarmUpModeTemperatureSetpointUpdate_Click);
            // 
            // labelWarmUpModeTemperatureSetpoint
            // 
            this.labelWarmUpModeTemperatureSetpoint.AutoSize = true;
            this.labelWarmUpModeTemperatureSetpoint.Location = new System.Drawing.Point(325, 25);
            this.labelWarmUpModeTemperatureSetpoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWarmUpModeTemperatureSetpoint.Name = "labelWarmUpModeTemperatureSetpoint";
            this.labelWarmUpModeTemperatureSetpoint.Size = new System.Drawing.Size(180, 17);
            this.labelWarmUpModeTemperatureSetpoint.TabIndex = 21;
            this.labelWarmUpModeTemperatureSetpoint.Text = "Warm Up Temperature (K):";
            // 
            // tbWarmUpModeTemperatureSetpoint
            // 
            this.tbWarmUpModeTemperatureSetpoint.Location = new System.Drawing.Point(513, 23);
            this.tbWarmUpModeTemperatureSetpoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbWarmUpModeTemperatureSetpoint.Name = "tbWarmUpModeTemperatureSetpoint";
            this.tbWarmUpModeTemperatureSetpoint.Size = new System.Drawing.Size(132, 22);
            this.tbWarmUpModeTemperatureSetpoint.TabIndex = 20;
            // 
            // labelWarmUpModeHowLongUntilHeatersTurnOff
            // 
            this.labelWarmUpModeHowLongUntilHeatersTurnOff.AutoSize = true;
            this.labelWarmUpModeHowLongUntilHeatersTurnOff.Location = new System.Drawing.Point(48, 47);
            this.labelWarmUpModeHowLongUntilHeatersTurnOff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWarmUpModeHowLongUntilHeatersTurnOff.Name = "labelWarmUpModeHowLongUntilHeatersTurnOff";
            this.labelWarmUpModeHowLongUntilHeatersTurnOff.Size = new System.Drawing.Size(109, 34);
            this.labelWarmUpModeHowLongUntilHeatersTurnOff.TabIndex = 17;
            this.labelWarmUpModeHowLongUntilHeatersTurnOff.Text = "How long until \r\nheaters turn off:";
            // 
            // tbWarmUpModeHowLongUntilHeatersTurnOff
            // 
            this.tbWarmUpModeHowLongUntilHeatersTurnOff.Location = new System.Drawing.Point(164, 55);
            this.tbWarmUpModeHowLongUntilHeatersTurnOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbWarmUpModeHowLongUntilHeatersTurnOff.Name = "tbWarmUpModeHowLongUntilHeatersTurnOff";
            this.tbWarmUpModeHowLongUntilHeatersTurnOff.Size = new System.Drawing.Size(128, 22);
            this.tbWarmUpModeHowLongUntilHeatersTurnOff.TabIndex = 17;
            // 
            // checkBoxWarmUpSourceToRoomTemperature
            // 
            this.checkBoxWarmUpSourceToRoomTemperature.AutoSize = true;
            this.checkBoxWarmUpSourceToRoomTemperature.Location = new System.Drawing.Point(700, 25);
            this.checkBoxWarmUpSourceToRoomTemperature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxWarmUpSourceToRoomTemperature.Name = "checkBoxWarmUpSourceToRoomTemperature";
            this.checkBoxWarmUpSourceToRoomTemperature.Size = new System.Drawing.Size(220, 21);
            this.checkBoxWarmUpSourceToRoomTemperature.TabIndex = 17;
            this.checkBoxWarmUpSourceToRoomTemperature.Text = "Warm up to room temperature";
            this.checkBoxWarmUpSourceToRoomTemperature.UseVisualStyleBackColor = true;
            this.checkBoxWarmUpSourceToRoomTemperature.CheckedChanged += new System.EventHandler(this.checkBoxWarmUpSourceToRoomTemperature_CheckedChanged);
            // 
            // labelWarmUpModeTurnHeatersOff
            // 
            this.labelWarmUpModeTurnHeatersOff.AutoSize = true;
            this.labelWarmUpModeTurnHeatersOff.Location = new System.Drawing.Point(27, 25);
            this.labelWarmUpModeTurnHeatersOff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWarmUpModeTurnHeatersOff.Name = "labelWarmUpModeTurnHeatersOff";
            this.labelWarmUpModeTurnHeatersOff.Size = new System.Drawing.Size(130, 17);
            this.labelWarmUpModeTurnHeatersOff.TabIndex = 19;
            this.labelWarmUpModeTurnHeatersOff.Text = "Turn heaters off at:";
            // 
            // dateTimePickerWarmUpModeTurnHeatersOff
            // 
            this.dateTimePickerWarmUpModeTurnHeatersOff.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerWarmUpModeTurnHeatersOff.Location = new System.Drawing.Point(164, 23);
            this.dateTimePickerWarmUpModeTurnHeatersOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerWarmUpModeTurnHeatersOff.Name = "dateTimePickerWarmUpModeTurnHeatersOff";
            this.dateTimePickerWarmUpModeTurnHeatersOff.Size = new System.Drawing.Size(128, 22);
            this.dateTimePickerWarmUpModeTurnHeatersOff.TabIndex = 18;
            this.dateTimePickerWarmUpModeTurnHeatersOff.Value = new System.DateTime(2019, 11, 5, 18, 37, 30, 0);
            this.dateTimePickerWarmUpModeTurnHeatersOff.ValueChanged += new System.EventHandler(this.dateTimePickerWarmUpModeTurnHeatersOff_ValueChanged);
            // 
            // tabPageCoolDownMode
            // 
            this.tabPageCoolDownMode.BackColor = System.Drawing.Color.Silver;
            this.tabPageCoolDownMode.Controls.Add(this.gbCoolDownModeWarmUp);
            this.tabPageCoolDownMode.Controls.Add(this.btCancelCoolDownMode);
            this.tabPageCoolDownMode.Controls.Add(this.gbCoolDownModeCoolDown);
            this.tabPageCoolDownMode.Controls.Add(this.btStartCoolDownMode);
            this.tabPageCoolDownMode.Controls.Add(this.tbCoolDownModeStatus);
            this.tabPageCoolDownMode.Controls.Add(this.labelCoolDownModeStatus);
            this.tabPageCoolDownMode.Location = new System.Drawing.Point(4, 25);
            this.tabPageCoolDownMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCoolDownMode.Name = "tabPageCoolDownMode";
            this.tabPageCoolDownMode.Size = new System.Drawing.Size(1365, 829);
            this.tabPageCoolDownMode.TabIndex = 2;
            this.tabPageCoolDownMode.Text = "Cool Down Mode";
            // 
            // gbCoolDownModeWarmUp
            // 
            this.gbCoolDownModeWarmUp.Controls.Add(this.btCoolDownModeTemperatureSetpointUpdate);
            this.gbCoolDownModeWarmUp.Controls.Add(this.labelCoolDownModeTemperatureSetpoint);
            this.gbCoolDownModeWarmUp.Controls.Add(this.tbCoolDownModeTemperatureSetpoint);
            this.gbCoolDownModeWarmUp.Controls.Add(this.labelCoolDownModeHowLongUntilHeatersTurnOff);
            this.gbCoolDownModeWarmUp.Controls.Add(this.tbCoolDownModeHowLongUntilHeatersTurnOff);
            this.gbCoolDownModeWarmUp.Controls.Add(this.checkBoxCoolDownSourceAtRoomTemperature);
            this.gbCoolDownModeWarmUp.Controls.Add(this.labelCoolDownModeTurnHeatersOff);
            this.gbCoolDownModeWarmUp.Controls.Add(this.dateTimePickerCoolDownModeTurnHeatersOff);
            this.gbCoolDownModeWarmUp.Location = new System.Drawing.Point(60, 21);
            this.gbCoolDownModeWarmUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCoolDownModeWarmUp.Name = "gbCoolDownModeWarmUp";
            this.gbCoolDownModeWarmUp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCoolDownModeWarmUp.Size = new System.Drawing.Size(947, 96);
            this.gbCoolDownModeWarmUp.TabIndex = 27;
            this.gbCoolDownModeWarmUp.TabStop = false;
            this.gbCoolDownModeWarmUp.Text = "Warm Up";
            // 
            // btCoolDownModeTemperatureSetpointUpdate
            // 
            this.btCoolDownModeTemperatureSetpointUpdate.Location = new System.Drawing.Point(532, 57);
            this.btCoolDownModeTemperatureSetpointUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCoolDownModeTemperatureSetpointUpdate.Name = "btCoolDownModeTemperatureSetpointUpdate";
            this.btCoolDownModeTemperatureSetpointUpdate.Size = new System.Drawing.Size(100, 28);
            this.btCoolDownModeTemperatureSetpointUpdate.TabIndex = 22;
            this.btCoolDownModeTemperatureSetpointUpdate.Text = "Update";
            this.btCoolDownModeTemperatureSetpointUpdate.UseVisualStyleBackColor = true;
            this.btCoolDownModeTemperatureSetpointUpdate.Click += new System.EventHandler(this.btCoolDownModeTemperatureSetpointUpdate_Click);
            // 
            // labelCoolDownModeTemperatureSetpoint
            // 
            this.labelCoolDownModeTemperatureSetpoint.AutoSize = true;
            this.labelCoolDownModeTemperatureSetpoint.Location = new System.Drawing.Point(333, 25);
            this.labelCoolDownModeTemperatureSetpoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoolDownModeTemperatureSetpoint.Name = "labelCoolDownModeTemperatureSetpoint";
            this.labelCoolDownModeTemperatureSetpoint.Size = new System.Drawing.Size(170, 17);
            this.labelCoolDownModeTemperatureSetpoint.TabIndex = 21;
            this.labelCoolDownModeTemperatureSetpoint.Text = "Heating Temperature (K):";
            // 
            // tbCoolDownModeTemperatureSetpoint
            // 
            this.tbCoolDownModeTemperatureSetpoint.Location = new System.Drawing.Point(513, 23);
            this.tbCoolDownModeTemperatureSetpoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCoolDownModeTemperatureSetpoint.Name = "tbCoolDownModeTemperatureSetpoint";
            this.tbCoolDownModeTemperatureSetpoint.Size = new System.Drawing.Size(132, 22);
            this.tbCoolDownModeTemperatureSetpoint.TabIndex = 20;
            // 
            // labelCoolDownModeHowLongUntilHeatersTurnOff
            // 
            this.labelCoolDownModeHowLongUntilHeatersTurnOff.AutoSize = true;
            this.labelCoolDownModeHowLongUntilHeatersTurnOff.Location = new System.Drawing.Point(48, 47);
            this.labelCoolDownModeHowLongUntilHeatersTurnOff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoolDownModeHowLongUntilHeatersTurnOff.Name = "labelCoolDownModeHowLongUntilHeatersTurnOff";
            this.labelCoolDownModeHowLongUntilHeatersTurnOff.Size = new System.Drawing.Size(109, 34);
            this.labelCoolDownModeHowLongUntilHeatersTurnOff.TabIndex = 17;
            this.labelCoolDownModeHowLongUntilHeatersTurnOff.Text = "How long until \r\nheaters turn off:";
            // 
            // tbCoolDownModeHowLongUntilHeatersTurnOff
            // 
            this.tbCoolDownModeHowLongUntilHeatersTurnOff.Location = new System.Drawing.Point(164, 55);
            this.tbCoolDownModeHowLongUntilHeatersTurnOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCoolDownModeHowLongUntilHeatersTurnOff.Name = "tbCoolDownModeHowLongUntilHeatersTurnOff";
            this.tbCoolDownModeHowLongUntilHeatersTurnOff.Size = new System.Drawing.Size(128, 22);
            this.tbCoolDownModeHowLongUntilHeatersTurnOff.TabIndex = 17;
            // 
            // checkBoxCoolDownSourceAtRoomTemperature
            // 
            this.checkBoxCoolDownSourceAtRoomTemperature.AutoSize = true;
            this.checkBoxCoolDownSourceAtRoomTemperature.Location = new System.Drawing.Point(704, 27);
            this.checkBoxCoolDownSourceAtRoomTemperature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxCoolDownSourceAtRoomTemperature.Name = "checkBoxCoolDownSourceAtRoomTemperature";
            this.checkBoxCoolDownSourceAtRoomTemperature.Size = new System.Drawing.Size(202, 38);
            this.checkBoxCoolDownSourceAtRoomTemperature.TabIndex = 17;
            this.checkBoxCoolDownSourceAtRoomTemperature.Text = "Leave at room temperature\r\nuntil cryo is turned on";
            this.checkBoxCoolDownSourceAtRoomTemperature.UseVisualStyleBackColor = true;
            this.checkBoxCoolDownSourceAtRoomTemperature.CheckedChanged += new System.EventHandler(this.checkBoxCoolDownSourceAtRoomTemperature_CheckedChanged);
            // 
            // labelCoolDownModeTurnHeatersOff
            // 
            this.labelCoolDownModeTurnHeatersOff.AutoSize = true;
            this.labelCoolDownModeTurnHeatersOff.Location = new System.Drawing.Point(27, 25);
            this.labelCoolDownModeTurnHeatersOff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoolDownModeTurnHeatersOff.Name = "labelCoolDownModeTurnHeatersOff";
            this.labelCoolDownModeTurnHeatersOff.Size = new System.Drawing.Size(130, 17);
            this.labelCoolDownModeTurnHeatersOff.TabIndex = 19;
            this.labelCoolDownModeTurnHeatersOff.Text = "Turn heaters off at:";
            // 
            // dateTimePickerCoolDownModeTurnHeatersOff
            // 
            this.dateTimePickerCoolDownModeTurnHeatersOff.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerCoolDownModeTurnHeatersOff.Location = new System.Drawing.Point(164, 23);
            this.dateTimePickerCoolDownModeTurnHeatersOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerCoolDownModeTurnHeatersOff.Name = "dateTimePickerCoolDownModeTurnHeatersOff";
            this.dateTimePickerCoolDownModeTurnHeatersOff.Size = new System.Drawing.Size(128, 22);
            this.dateTimePickerCoolDownModeTurnHeatersOff.TabIndex = 18;
            this.dateTimePickerCoolDownModeTurnHeatersOff.Value = new System.DateTime(2019, 11, 5, 18, 37, 30, 0);
            this.dateTimePickerCoolDownModeTurnHeatersOff.ValueChanged += new System.EventHandler(this.dateTimePickerCoolDownModeTurnHeatersOff_ValueChanged);
            // 
            // btCancelCoolDownMode
            // 
            this.btCancelCoolDownMode.Enabled = false;
            this.btCancelCoolDownMode.Location = new System.Drawing.Point(907, 194);
            this.btCancelCoolDownMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancelCoolDownMode.Name = "btCancelCoolDownMode";
            this.btCancelCoolDownMode.Size = new System.Drawing.Size(100, 28);
            this.btCancelCoolDownMode.TabIndex = 25;
            this.btCancelCoolDownMode.Text = "Cancel";
            this.btCancelCoolDownMode.UseVisualStyleBackColor = true;
            this.btCancelCoolDownMode.Click += new System.EventHandler(this.btCancelCoolDownMode_Click);
            // 
            // gbCoolDownModeCoolDown
            // 
            this.gbCoolDownModeCoolDown.Controls.Add(this.labelCoolDownModeCryoTurnOnDateTime);
            this.gbCoolDownModeCoolDown.Controls.Add(this.labelCoolDownModeHowLongUntilCryoTurnsOn);
            this.gbCoolDownModeCoolDown.Controls.Add(this.tbCoolDownModeHowLongUntilCryoTurnsOn);
            this.gbCoolDownModeCoolDown.Controls.Add(this.dateTimePickerCoolDownModeTurnCryoOn);
            this.gbCoolDownModeCoolDown.Location = new System.Drawing.Point(60, 127);
            this.gbCoolDownModeCoolDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCoolDownModeCoolDown.Name = "gbCoolDownModeCoolDown";
            this.gbCoolDownModeCoolDown.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCoolDownModeCoolDown.Size = new System.Drawing.Size(324, 96);
            this.gbCoolDownModeCoolDown.TabIndex = 26;
            this.gbCoolDownModeCoolDown.TabStop = false;
            this.gbCoolDownModeCoolDown.Text = "Cool down";
            // 
            // labelCoolDownModeCryoTurnOnDateTime
            // 
            this.labelCoolDownModeCryoTurnOnDateTime.AutoSize = true;
            this.labelCoolDownModeCryoTurnOnDateTime.Location = new System.Drawing.Point(48, 25);
            this.labelCoolDownModeCryoTurnOnDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoolDownModeCryoTurnOnDateTime.Name = "labelCoolDownModeCryoTurnOnDateTime";
            this.labelCoolDownModeCryoTurnOnDateTime.Size = new System.Drawing.Size(109, 17);
            this.labelCoolDownModeCryoTurnOnDateTime.TabIndex = 11;
            this.labelCoolDownModeCryoTurnOnDateTime.Text = "Turn cryo on at:";
            // 
            // labelCoolDownModeHowLongUntilCryoTurnsOn
            // 
            this.labelCoolDownModeHowLongUntilCryoTurnsOn.AutoSize = true;
            this.labelCoolDownModeHowLongUntilCryoTurnsOn.Location = new System.Drawing.Point(55, 47);
            this.labelCoolDownModeHowLongUntilCryoTurnsOn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoolDownModeHowLongUntilCryoTurnsOn.Name = "labelCoolDownModeHowLongUntilCryoTurnsOn";
            this.labelCoolDownModeHowLongUntilCryoTurnsOn.Size = new System.Drawing.Size(100, 34);
            this.labelCoolDownModeHowLongUntilCryoTurnsOn.TabIndex = 11;
            this.labelCoolDownModeHowLongUntilCryoTurnsOn.Text = "How long until \r\ncryo turns on:";
            // 
            // tbCoolDownModeHowLongUntilCryoTurnsOn
            // 
            this.tbCoolDownModeHowLongUntilCryoTurnsOn.Location = new System.Drawing.Point(165, 55);
            this.tbCoolDownModeHowLongUntilCryoTurnsOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCoolDownModeHowLongUntilCryoTurnsOn.Name = "tbCoolDownModeHowLongUntilCryoTurnsOn";
            this.tbCoolDownModeHowLongUntilCryoTurnsOn.Size = new System.Drawing.Size(128, 22);
            this.tbCoolDownModeHowLongUntilCryoTurnsOn.TabIndex = 16;
            // 
            // dateTimePickerCoolDownModeTurnCryoOn
            // 
            this.dateTimePickerCoolDownModeTurnCryoOn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerCoolDownModeTurnCryoOn.Location = new System.Drawing.Point(165, 23);
            this.dateTimePickerCoolDownModeTurnCryoOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerCoolDownModeTurnCryoOn.Name = "dateTimePickerCoolDownModeTurnCryoOn";
            this.dateTimePickerCoolDownModeTurnCryoOn.Size = new System.Drawing.Size(128, 22);
            this.dateTimePickerCoolDownModeTurnCryoOn.TabIndex = 15;
            this.dateTimePickerCoolDownModeTurnCryoOn.Value = new System.DateTime(2019, 11, 5, 18, 37, 30, 0);
            this.dateTimePickerCoolDownModeTurnCryoOn.ValueChanged += new System.EventHandler(this.dateTimePickerCoolDownModeTurnCryoOn_ValueChanged);
            // 
            // btStartCoolDownMode
            // 
            this.btStartCoolDownMode.Enabled = false;
            this.btStartCoolDownMode.Location = new System.Drawing.Point(799, 194);
            this.btStartCoolDownMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btStartCoolDownMode.Name = "btStartCoolDownMode";
            this.btStartCoolDownMode.Size = new System.Drawing.Size(100, 28);
            this.btStartCoolDownMode.TabIndex = 24;
            this.btStartCoolDownMode.Text = "Start";
            this.btStartCoolDownMode.UseVisualStyleBackColor = true;
            this.btStartCoolDownMode.Click += new System.EventHandler(this.btStartCoolDownMode_Click);
            // 
            // tbCoolDownModeStatus
            // 
            this.tbCoolDownModeStatus.Location = new System.Drawing.Point(224, 276);
            this.tbCoolDownModeStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCoolDownModeStatus.Multiline = true;
            this.tbCoolDownModeStatus.Name = "tbCoolDownModeStatus";
            this.tbCoolDownModeStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCoolDownModeStatus.Size = new System.Drawing.Size(783, 178);
            this.tbCoolDownModeStatus.TabIndex = 22;
            // 
            // labelCoolDownModeStatus
            // 
            this.labelCoolDownModeStatus.AutoSize = true;
            this.labelCoolDownModeStatus.Location = new System.Drawing.Point(57, 279);
            this.labelCoolDownModeStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoolDownModeStatus.Name = "labelCoolDownModeStatus";
            this.labelCoolDownModeStatus.Size = new System.Drawing.Size(162, 17);
            this.labelCoolDownModeStatus.TabIndex = 23;
            this.labelCoolDownModeStatus.Text = "Cool Down Mode Status:";
            // 
            // ControlWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1705, 945);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.gbTemperatureandPressureMonitoringControl);
            this.Controls.Add(this.gbCryoControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbTempMonitors);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ControlWindow";
            this.Text = "Ultracold EDM Hardware Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlWindow_FormClosing);
            this.Load += new System.EventHandler(this.WindowLoaded);
            this.gbTempMonitors.ResumeLayout(false);
            this.gbTempMonitors.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.gbCryoControl.ResumeLayout(false);
            this.gbCryoControl.PerformLayout();
            this.gbTemperatureandPressureMonitoringControl.ResumeLayout(false);
            this.gbTemperatureandPressureMonitoringControl.PerformLayout();
            this.gbPlotOptions.ResumeLayout(false);
            this.gbPlotOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPagePlotting.ResumeLayout(false);
            this.tabPageFlowControllers.ResumeLayout(false);
            this.gbNeonFlowController.ResumeLayout(false);
            this.gbNeonFlowController.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.tabPageHeatersControl.ResumeLayout(false);
            this.tabPageHeatersControl.PerformLayout();
            this.gbDigitalHeaters.ResumeLayout(false);
            this.gbDigitalHeaters.PerformLayout();
            this.gbCryoStage1HeaterControl.ResumeLayout(false);
            this.gbCryoStage1HeaterControl.PerformLayout();
            this.gbCryoStage2HeaterControl.ResumeLayout(false);
            this.gbCryoStage2HeaterControl.PerformLayout();
            this.tabPageLakeShore.ResumeLayout(false);
            this.gbAutotune.ResumeLayout(false);
            this.gbAutotune.PerformLayout();
            this.gbLakeShore336PIDLoops.ResumeLayout(false);
            this.gbLakeShore336PIDLoops.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageSourceModes.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRefreshMode.ResumeLayout(false);
            this.tabPageRefreshMode.PerformLayout();
            this.gbRefreshModeWarmUp.ResumeLayout(false);
            this.gbRefreshModeWarmUp.PerformLayout();
            this.gbRefreshModeCoolDown.ResumeLayout(false);
            this.gbRefreshModeCoolDown.PerformLayout();
            this.tabPageWarmUpMode.ResumeLayout(false);
            this.tabPageWarmUpMode.PerformLayout();
            this.gbWarmUpModeWarmUp.ResumeLayout(false);
            this.gbWarmUpModeWarmUp.PerformLayout();
            this.tabPageCoolDownMode.ResumeLayout(false);
            this.tabPageCoolDownMode.PerformLayout();
            this.gbCoolDownModeWarmUp.ResumeLayout(false);
            this.gbCoolDownModeWarmUp.PerformLayout();
            this.gbCoolDownModeCoolDown.ResumeLayout(false);
            this.gbCoolDownModeCoolDown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTempMonitors;
        public System.Windows.Forms.TextBox tbTCell;
        private System.Windows.Forms.Label labelTS2;
        private System.Windows.Forms.Label labelTCell;
        public System.Windows.Forms.TextBox tbTSF6;
        private System.Windows.Forms.Label labelTSF6;
        public System.Windows.Forms.TextBox tbTNeon;
        private System.Windows.Forms.Label labelTNeon;
        public System.Windows.Forms.TextBox tbTS2;
        private System.Windows.Forms.Label labelPBeamline;
        public System.Windows.Forms.TextBox tbPBeamline;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPSource;
        public System.Windows.Forms.TextBox tbPSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem plotsToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbCryoControl;
        public System.Windows.Forms.CheckBox cbTurnCryoOn;
        private System.Windows.Forms.Label labelCryoState;
        public System.Windows.Forms.TextBox tbCryoState;
        public System.Windows.Forms.CheckBox cbLogPressureData;
        private System.Windows.Forms.Label labelPressureLogPeriod;
        public System.Windows.Forms.TextBox tbpressureMonitorLogPeriod;
        private System.Windows.Forms.GroupBox gbTemperatureandPressureMonitoringControl;
        private System.Windows.Forms.Label labelTandPPollPeriod;
        public System.Windows.Forms.TextBox tbTandPPollPeriod;
        public System.Windows.Forms.Button btStopTandPMonitoring;
        public System.Windows.Forms.Button btStartTandPMonitoring;
        private System.Windows.Forms.GroupBox gbPlotOptions;
        public System.Windows.Forms.ComboBox comboBoxPlot1ScaleY;
        private System.Windows.Forms.Label labelPlot1ScaleY;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox comboBoxPlot2ScaleY;
        private System.Windows.Forms.Label labelPlot2ScaleY;
        private System.Windows.Forms.Label labelSelectTempDataToPlotChart2;
        public System.Windows.Forms.CheckBox checkBoxSF6TempPlot;
        public System.Windows.Forms.CheckBox checkBoxS2TempPlot;
        public System.Windows.Forms.CheckBox checkBoxS1TempPlot;
        public System.Windows.Forms.CheckBox checkBoxCellTempPlot;
        public System.Windows.Forms.CheckBox checkBoxCryoEnable;
        private System.Windows.Forms.Label labelClearTemperaturePlotData;
        public System.Windows.Forms.Button btClearSF6TempData;
        public System.Windows.Forms.Button btClearS2TempData;
        public System.Windows.Forms.Button btClearS1TempData;
        public System.Windows.Forms.Button btClearCellTempData;
        public System.Windows.Forms.Button btClearAllTempData;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePlotting;
        private System.Windows.Forms.TabPage tabPageLakeShore;
        private System.Windows.Forms.ToolStripMenuItem pressureAndTemperaturePlotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pressureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPlotPressureChart;
        private System.Windows.Forms.ToolStripMenuItem temperatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPlotTemperatureChart;
        private System.Windows.Forms.Label labelSelectPressureDataToPlotChart1;
        public System.Windows.Forms.CheckBox checkBoxBeamlinePressurePlot;
        public System.Windows.Forms.CheckBox checkBoxSourcePressurePlot;
        public System.Windows.Forms.Button btClearAllPressureData;
        public System.Windows.Forms.Button btClearBeamlinePressureData;
        public System.Windows.Forms.Button btClearSourcePressureData;
        private System.Windows.Forms.Label labelClearPressurePlotData;
        private System.Windows.Forms.TabPage tabPageFlowControllers;
        private System.Windows.Forms.GroupBox gbSF6FlowController;
        private System.Windows.Forms.GroupBox gbNeonFlowController;
        public System.Windows.Forms.TextBox tbNeonFlowActual;
        private System.Windows.Forms.Label labelNeonFlowMonitorFL;
        private System.Windows.Forms.Label labelMonitorActualNeonFlow;
        public System.Windows.Forms.Button btStopNeonFlowActMonitor;
        public System.Windows.Forms.Button btStartNeonFlowActMonitor;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        public System.Windows.Forms.TextBox tbNeonFlowActPollPeriod;
        private System.Windows.Forms.Label labelNeonFlowActPollPeriod;
        private System.Windows.Forms.Button btClearNeonFlowActPlotData;
        private System.Windows.Forms.Label labelClearNeonFlowActData;
        private System.Windows.Forms.Label labelNeonFlowMonitorSP;
        public System.Windows.Forms.TextBox tbNeonFlowSetpoint;
        public System.Windows.Forms.TextBox tbNewNeonFlowSetPoint;
        public System.Windows.Forms.Button btSetNewNeonFlowSetpoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDigitalHeaters;
        public System.Windows.Forms.CheckBox checkBoxEnableHeatersS2;
        public System.Windows.Forms.Button btUpdateHeaterControlStage2;
        public System.Windows.Forms.Button btStopHeaterControlStage2;
        public System.Windows.Forms.Button btStartHeaterControlStage2;
        private System.Windows.Forms.Label labelHeaterSetpointStage2;
        public System.Windows.Forms.TextBox tbHeaterTempSetpointStage2;
        public System.Windows.Forms.CheckBox checkBoxEnableHeatersS1;
        private System.Windows.Forms.GroupBox gbCryoStage1HeaterControl;
        private System.Windows.Forms.Label labelHeaterSetpointStage1;
        private System.Windows.Forms.GroupBox gbCryoStage2HeaterControl;
        public System.Windows.Forms.TextBox tbHeaterTempSetpointStage1;
        public System.Windows.Forms.Button btStopHeaterControlStage1;
        public System.Windows.Forms.Button btStartHeaterControlStage1;
        public System.Windows.Forms.Button btUpdateHeaterControlStage1;
        public System.Windows.Forms.Button btHeatersTurnOffWaitCancel;
        public System.Windows.Forms.Button btHeatersTurnOffWaitStart;
        private System.Windows.Forms.Label labelHowLongUntilHeatersTurnOff;
        private System.Windows.Forms.Label labelTurnHeatersOffAt;
        public System.Windows.Forms.TextBox tbHowLongUntilHeatersTurnOff;
        public System.Windows.Forms.DateTimePicker dateTimePickerHeatersTurnOff;
        private System.Windows.Forms.TabPage tabPageSourceModes;
        private System.Windows.Forms.Label labelRefreshModeStatus;
        public System.Windows.Forms.TextBox tbRefreshModeStatus;
        public System.Windows.Forms.Button btCancelRefreshMode;
        public System.Windows.Forms.Button btStartRefreshMode;
        public System.Windows.Forms.DateTimePicker dateTimePickerRefreshModeTurnCryoOn;
        private System.Windows.Forms.Label labelRefreshModeCryoTurnOnDateTime;
        private System.Windows.Forms.Label labelRefreshModeHowLongUntilCryoTurnsOn;
        public System.Windows.Forms.TextBox tbRefreshModeHowLongUntilCryoTurnsOn;
        public System.Windows.Forms.CheckBox checkBoxRefreshSourceAtRoomTemperature;
        private System.Windows.Forms.GroupBox gbRefreshModeWarmUp;
        private System.Windows.Forms.Label labelRefreshModeHowLongUntilHeatersTurnOff;
        public System.Windows.Forms.TextBox tbRefreshModeHowLongUntilHeatersTurnOff;
        private System.Windows.Forms.Label labelRefreshModeTurnHeatersOff;
        public System.Windows.Forms.DateTimePicker dateTimePickerRefreshModeTurnHeatersOff;
        private System.Windows.Forms.GroupBox gbRefreshModeCoolDown;
        public System.Windows.Forms.Button btRefreshModeTemperatureSetpointUpdate;
        private System.Windows.Forms.Label labelRefreshModeTemperatureSetpoint;
        public System.Windows.Forms.TextBox tbRefreshModeTemperatureSetpoint;
        private System.Windows.Forms.TabPage tabPageHeatersControl;
        private System.Windows.Forms.ToolStripMenuItem neonFlowPlotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPlotNeonFlowChart;
        public System.Windows.Forms.TextBox tbHeaterControlStatus;
        private System.Windows.Forms.Label labelHeaterControlStatus;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveNeonFlowDataCSV;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSavePressurePlotDataCSV;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveTemperaturePlotDataCSV;
        private System.Windows.Forms.Label labelTS1;
        public System.Windows.Forms.TextBox tbTS1;
        public System.Windows.Forms.Button btClearNeonTempData;
        private System.Windows.Forms.CheckBox checkBoxNeonTempPlot;
        private System.Windows.Forms.Button btUpdatePTPollPeriod;
        private System.Windows.Forms.CheckBox checkBoxMonitorPressureWhenHeating;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbLakeShore336PIDLoops;
        public System.Windows.Forms.TextBox tbLakeShore336PIDDValueInput;
        public System.Windows.Forms.TextBox tbLakeShore336PIDIValueInput;
        public System.Windows.Forms.TextBox tbLakeShore336PIDPValueInput;
        private System.Windows.Forms.Button btSetLakeShore336PIDvalues;
        public System.Windows.Forms.ComboBox comboBoxLakeShore336OutputsSet;
        public System.Windows.Forms.TextBox tbLakeShore336PIDDValueOutput;
        public System.Windows.Forms.TextBox tbLakeShore336PIDIValueOutput;
        private System.Windows.Forms.Label labelLakeShore336DValue;
        private System.Windows.Forms.Label labelLakeShore336IValue;
        public System.Windows.Forms.TextBox tbLakeShore336PIDPValueOutput;
        private System.Windows.Forms.Label labelLakeShore336PValue;
        private System.Windows.Forms.Button btQueryLakeShore336PIDvalues;
        public System.Windows.Forms.ComboBox comboBoxLakeShore336OutputsQuery;
        public System.Windows.Forms.ComboBox comboBoxLakeShore336OutputsAutotune;
        private System.Windows.Forms.Button btAutotuneLakeShore336Output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAutotuneModes;
        public System.Windows.Forms.ComboBox comboBoxLakeShore336AutotuneModes;
        private System.Windows.Forms.Label labelPIDLoopsOutputs;
        private System.Windows.Forms.GroupBox gbAutotune;
        private System.Windows.Forms.Button btQueryAutotuneError;
        public System.Windows.Forms.RichTextBox rtbAutotuneStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRefreshMode;
        private System.Windows.Forms.TabPage tabPageWarmUpMode;
        private System.Windows.Forms.TabPage tabPageCoolDownMode;
        private System.Windows.Forms.GroupBox gbWarmUpModeWarmUp;
        public System.Windows.Forms.Button btWarmUpModeTemperatureSetpointUpdate;
        private System.Windows.Forms.Label labelWarmUpModeTemperatureSetpoint;
        public System.Windows.Forms.TextBox tbWarmUpModeTemperatureSetpoint;
        private System.Windows.Forms.Label labelWarmUpModeHowLongUntilHeatersTurnOff;
        public System.Windows.Forms.TextBox tbWarmUpModeHowLongUntilHeatersTurnOff;
        public System.Windows.Forms.CheckBox checkBoxWarmUpSourceToRoomTemperature;
        private System.Windows.Forms.Label labelWarmUpModeTurnHeatersOff;
        public System.Windows.Forms.DateTimePicker dateTimePickerWarmUpModeTurnHeatersOff;
        public System.Windows.Forms.Button btCancelWarmUpMode;
        public System.Windows.Forms.Button btStartWarmUpMode;
        public System.Windows.Forms.TextBox tbWarmUpModeStatus;
        private System.Windows.Forms.Label labelWarmUpModeStatus;
        private System.Windows.Forms.GroupBox gbCoolDownModeWarmUp;
        public System.Windows.Forms.Button btCoolDownModeTemperatureSetpointUpdate;
        private System.Windows.Forms.Label labelCoolDownModeTemperatureSetpoint;
        public System.Windows.Forms.TextBox tbCoolDownModeTemperatureSetpoint;
        private System.Windows.Forms.Label labelCoolDownModeHowLongUntilHeatersTurnOff;
        public System.Windows.Forms.TextBox tbCoolDownModeHowLongUntilHeatersTurnOff;
        public System.Windows.Forms.CheckBox checkBoxCoolDownSourceAtRoomTemperature;
        private System.Windows.Forms.Label labelCoolDownModeTurnHeatersOff;
        public System.Windows.Forms.DateTimePicker dateTimePickerCoolDownModeTurnHeatersOff;
        public System.Windows.Forms.Button btCancelCoolDownMode;
        private System.Windows.Forms.GroupBox gbCoolDownModeCoolDown;
        private System.Windows.Forms.Label labelCoolDownModeCryoTurnOnDateTime;
        private System.Windows.Forms.Label labelCoolDownModeHowLongUntilCryoTurnsOn;
        public System.Windows.Forms.TextBox tbCoolDownModeHowLongUntilCryoTurnsOn;
        public System.Windows.Forms.DateTimePicker dateTimePickerCoolDownModeTurnCryoOn;
        public System.Windows.Forms.Button btStartCoolDownMode;
        public System.Windows.Forms.TextBox tbCoolDownModeStatus;
        private System.Windows.Forms.Label labelCoolDownModeStatus;
        private System.Windows.Forms.Button btRollingTemperatureChartTimeAxis;
        private System.Windows.Forms.Label labelTemperatureRollingTimeAxisPeriod;
        public System.Windows.Forms.TextBox tbRollingTemperatureChartTimeAxisPeriod;
        public System.Windows.Forms.CheckBox cbEnableTemperatureChartRollingTimeAxis;
        private System.Windows.Forms.Label labelRollingTemperaturePlotTimeAxis;
    }
}
