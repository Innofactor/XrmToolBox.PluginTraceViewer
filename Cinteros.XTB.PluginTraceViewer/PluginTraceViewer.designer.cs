﻿namespace Cinteros.XTB.PluginTraceViewer
{
    partial class PluginTraceViewer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginTraceViewer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsbCloseThisTab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.buttonOpen = new System.Windows.Forms.ToolStripDropDownButton();
            this.buttonOpenFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonOpenLogRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOpenFXB = new System.Windows.Forms.ToolStripMenuItem();
            this.dropdownSave = new System.Windows.Forms.ToolStripDropDownButton();
            this.buttonSaveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSaveLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSaveQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.dropdownView = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiViewFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLocalTimes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRefreshFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPluginStats = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonRetrieveLogs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.comboLogSetting = new System.Windows.Forms.ToolStripComboBox();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.textCorrelationId = new System.Windows.Forms.TextBox();
            this.chkCorrelation = new System.Windows.Forms.CheckBox();
            this.labelTimeZone = new System.Windows.Forms.Label();
            this.comboEntity = new System.Windows.Forms.ComboBox();
            this.chkEntity = new System.Windows.Forms.CheckBox();
            this.comboMessage = new System.Windows.Forms.ComboBox();
            this.chkMessage = new System.Windows.Forms.CheckBox();
            this.comboPlugin = new System.Windows.Forms.ComboBox();
            this.chkPlugin = new System.Windows.Forms.CheckBox();
            this.checkDateTo = new System.Windows.Forms.CheckBox();
            this.checkDateFrom = new System.Windows.Forms.CheckBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.panelOperationFilter = new System.Windows.Forms.Panel();
            this.rbOperWF = new System.Windows.Forms.RadioButton();
            this.rbOperPlugin = new System.Windows.Forms.RadioButton();
            this.rbOperAll = new System.Windows.Forms.RadioButton();
            this.chkRecords = new System.Windows.Forms.CheckBox();
            this.chkDurationMax = new System.Windows.Forms.CheckBox();
            this.chkDurationMin = new System.Windows.Forms.CheckBox();
            this.numDurationMax = new System.Windows.Forms.NumericUpDown();
            this.numDurationMin = new System.Windows.Forms.NumericUpDown();
            this.numRecords = new System.Windows.Forms.NumericUpDown();
            this.rbModeAsync = new System.Windows.Forms.RadioButton();
            this.rbModeSync = new System.Windows.Forms.RadioButton();
            this.rbModeAll = new System.Windows.Forms.RadioButton();
            this.chkExceptions = new System.Windows.Forms.CheckBox();
            this.crmGridView = new Cinteros.Xrm.CRMWinForm.CRMGridView();
            this.correlation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.performanceexecutionstarttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.performanceexecutionduration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messagename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primaryentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correlationid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exceptionsummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messagebody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exceptiondetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiFilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByEntity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByCorrelation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCorrelation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCorrelationId = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCorrelationSelectThis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColCorrelation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColStartTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColDuration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColStep = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColDepth = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColMode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColStage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColRank = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColEntity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColCorrelationId = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColRequestId = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColException = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerRight = new System.Windows.Forms.SplitContainer();
            this.groupTraceLog = new System.Windows.Forms.GroupBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.groupException = new System.Windows.Forms.GroupBox();
            this.textException = new System.Windows.Forms.TextBox();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.groupStatistics = new System.Windows.Forms.GroupBox();
            this.txtStatTermOther = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtStatTermHandles = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStatTermMemory = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStatTermCPU = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStatCrashContrPct = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStatCrashPct = new System.Windows.Forms.TextBox();
            this.txtStatCrashCnt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStatFailPct = new System.Windows.Forms.TextBox();
            this.txtStatFailCnt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStatSecPerDay = new System.Windows.Forms.TextBox();
            this.txtStatAvgExecTime = new System.Windows.Forms.TextBox();
            this.txtStatExecCnt = new System.Windows.Forms.TextBox();
            this.txtStatModified = new System.Windows.Forms.TextBox();
            this.txtStatCreated = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vS2005Theme1 = new WeifenLuo.WinFormsUI.Docking.VS2005Theme();
            this.dock = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsmiHighlight = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain.SuspendLayout();
            this.groupFilter.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.panelOperationFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crmGridView)).BeginInit();
            this.contextMenuGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).BeginInit();
            this.splitContainerRight.Panel1.SuspendLayout();
            this.splitContainerRight.Panel2.SuspendLayout();
            this.splitContainerRight.SuspendLayout();
            this.groupTraceLog.SuspendLayout();
            this.groupException.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelStatistics.SuspendLayout();
            this.groupStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCloseThisTab,
            this.toolStripSeparator4,
            this.tsbAbout,
            this.buttonOpen,
            this.dropdownSave,
            this.dropdownView,
            this.toolStripSeparator3,
            this.buttonRetrieveLogs,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.comboLogSetting,
            this.toolStripButton1});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1114, 25);
            this.toolStripMain.TabIndex = 24;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // tsbCloseThisTab
            // 
            this.tsbCloseThisTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCloseThisTab.Image = ((System.Drawing.Image)(resources.GetObject("tsbCloseThisTab.Image")));
            this.tsbCloseThisTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCloseThisTab.Name = "tsbCloseThisTab";
            this.tsbCloseThisTab.Size = new System.Drawing.Size(23, 22);
            this.tsbCloseThisTab.Text = "Close this tab";
            this.tsbCloseThisTab.Click += new System.EventHandler(this.tsbCloseThisTab_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAbout
            // 
            this.tsbAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbout.Image")));
            this.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbout.Name = "tsbAbout";
            this.tsbAbout.Size = new System.Drawing.Size(60, 22);
            this.tsbAbout.Text = "About";
            this.tsbAbout.Click += new System.EventHandler(this.tsbAbout_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonOpenFilter,
            this.toolStripSeparator5,
            this.buttonOpenLogRecord,
            this.buttonOpenFXB});
            this.buttonOpen.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen.Image")));
            this.buttonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(65, 22);
            this.buttonOpen.Text = "Open";
            // 
            // buttonOpenFilter
            // 
            this.buttonOpenFilter.Name = "buttonOpenFilter";
            this.buttonOpenFilter.Size = new System.Drawing.Size(224, 22);
            this.buttonOpenFilter.Text = "Filter...";
            this.buttonOpenFilter.Click += new System.EventHandler(this.buttonOpenFilter_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(221, 6);
            // 
            // buttonOpenLogRecord
            // 
            this.buttonOpenLogRecord.Enabled = false;
            this.buttonOpenLogRecord.Name = "buttonOpenLogRecord";
            this.buttonOpenLogRecord.Size = new System.Drawing.Size(224, 22);
            this.buttonOpenLogRecord.Text = "Selected log record in CRM";
            this.buttonOpenLogRecord.Click += new System.EventHandler(this.buttonOpenLogRecord_Click);
            // 
            // buttonOpenFXB
            // 
            this.buttonOpenFXB.Name = "buttonOpenFXB";
            this.buttonOpenFXB.Size = new System.Drawing.Size(224, 22);
            this.buttonOpenFXB.Text = "Query in FetchXML Builder...";
            this.buttonOpenFXB.Click += new System.EventHandler(this.buttonOpenFXB_Click);
            // 
            // dropdownSave
            // 
            this.dropdownSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonSaveFilter,
            this.buttonSaveLogs,
            this.buttonSaveQuery});
            this.dropdownSave.Image = ((System.Drawing.Image)(resources.GetObject("dropdownSave.Image")));
            this.dropdownSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropdownSave.Name = "dropdownSave";
            this.dropdownSave.Size = new System.Drawing.Size(60, 22);
            this.dropdownSave.Text = "Save";
            // 
            // buttonSaveFilter
            // 
            this.buttonSaveFilter.Name = "buttonSaveFilter";
            this.buttonSaveFilter.Size = new System.Drawing.Size(115, 22);
            this.buttonSaveFilter.Text = "Filter...";
            this.buttonSaveFilter.Click += new System.EventHandler(this.buttonSaveFilter_Click);
            // 
            // buttonSaveLogs
            // 
            this.buttonSaveLogs.Name = "buttonSaveLogs";
            this.buttonSaveLogs.Size = new System.Drawing.Size(115, 22);
            this.buttonSaveLogs.Text = "Logs...";
            this.buttonSaveLogs.Click += new System.EventHandler(this.buttonSaveLogs_Click);
            // 
            // buttonSaveQuery
            // 
            this.buttonSaveQuery.Name = "buttonSaveQuery";
            this.buttonSaveQuery.Size = new System.Drawing.Size(115, 22);
            this.buttonSaveQuery.Text = "Query...";
            this.buttonSaveQuery.Click += new System.EventHandler(this.buttonSaveQuery_Click);
            // 
            // dropdownView
            // 
            this.dropdownView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewFilter,
            this.tsmiViewStatistics,
            this.toolStripMenuItem2,
            this.tsmiWordWrap,
            this.tsmiLocalTimes,
            this.tsmiHighlight,
            this.toolStripMenuItem3,
            this.tsmiRefreshFilter,
            this.toolStripMenuItem1,
            this.tsmiPluginStats});
            this.dropdownView.Image = ((System.Drawing.Image)(resources.GetObject("dropdownView.Image")));
            this.dropdownView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropdownView.Name = "dropdownView";
            this.dropdownView.Size = new System.Drawing.Size(61, 22);
            this.dropdownView.Text = "View";
            // 
            // tsmiViewFilter
            // 
            this.tsmiViewFilter.Checked = true;
            this.tsmiViewFilter.CheckOnClick = true;
            this.tsmiViewFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiViewFilter.Image = ((System.Drawing.Image)(resources.GetObject("tsmiViewFilter.Image")));
            this.tsmiViewFilter.Name = "tsmiViewFilter";
            this.tsmiViewFilter.Size = new System.Drawing.Size(202, 22);
            this.tsmiViewFilter.Text = "Filter panel";
            this.tsmiViewFilter.CheckedChanged += new System.EventHandler(this.tsmiViewFilter_CheckedChanged);
            // 
            // tsmiViewStatistics
            // 
            this.tsmiViewStatistics.Checked = true;
            this.tsmiViewStatistics.CheckOnClick = true;
            this.tsmiViewStatistics.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiViewStatistics.Image = ((System.Drawing.Image)(resources.GetObject("tsmiViewStatistics.Image")));
            this.tsmiViewStatistics.Name = "tsmiViewStatistics";
            this.tsmiViewStatistics.Size = new System.Drawing.Size(202, 22);
            this.tsmiViewStatistics.Text = "Statistics panel";
            this.tsmiViewStatistics.CheckedChanged += new System.EventHandler(this.tsmiViewStatistics_CheckedChanged);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(199, 6);
            // 
            // tsmiWordWrap
            // 
            this.tsmiWordWrap.CheckOnClick = true;
            this.tsmiWordWrap.Image = ((System.Drawing.Image)(resources.GetObject("tsmiWordWrap.Image")));
            this.tsmiWordWrap.Name = "tsmiWordWrap";
            this.tsmiWordWrap.Size = new System.Drawing.Size(202, 22);
            this.tsmiWordWrap.Text = "Wrap text in log window";
            this.tsmiWordWrap.CheckedChanged += new System.EventHandler(this.tsmiWordWrap_CheckedChanged);
            // 
            // tsmiLocalTimes
            // 
            this.tsmiLocalTimes.CheckOnClick = true;
            this.tsmiLocalTimes.Name = "tsmiLocalTimes";
            this.tsmiLocalTimes.Size = new System.Drawing.Size(202, 22);
            this.tsmiLocalTimes.Text = "Local Times";
            this.tsmiLocalTimes.Click += new System.EventHandler(this.tsmiLocalTimes_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(199, 6);
            // 
            // tsmiRefreshFilter
            // 
            this.tsmiRefreshFilter.Enabled = false;
            this.tsmiRefreshFilter.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRefreshFilter.Image")));
            this.tsmiRefreshFilter.Name = "tsmiRefreshFilter";
            this.tsmiRefreshFilter.Size = new System.Drawing.Size(202, 22);
            this.tsmiRefreshFilter.Text = "Refresh Filter Options";
            this.tsmiRefreshFilter.Click += new System.EventHandler(this.tsmiRefreshFilter_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 6);
            // 
            // tsmiPluginStats
            // 
            this.tsmiPluginStats.Name = "tsmiPluginStats";
            this.tsmiPluginStats.Size = new System.Drawing.Size(202, 22);
            this.tsmiPluginStats.Text = "Plugin Statistics...";
            this.tsmiPluginStats.Click += new System.EventHandler(this.tsmiPluginStats_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonRetrieveLogs
            // 
            this.buttonRetrieveLogs.Enabled = false;
            this.buttonRetrieveLogs.Image = ((System.Drawing.Image)(resources.GetObject("buttonRetrieveLogs.Image")));
            this.buttonRetrieveLogs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRetrieveLogs.Name = "buttonRetrieveLogs";
            this.buttonRetrieveLogs.Size = new System.Drawing.Size(120, 22);
            this.buttonRetrieveLogs.Text = "Retrieve Logs (F5)";
            this.buttonRetrieveLogs.ToolTipText = "Retrieve Logs <F5>";
            this.buttonRetrieveLogs.Click += new System.EventHandler(this.buttonRetrieveLogs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(98, 22);
            this.toolStripLabel1.Text = "Trace Log Setting";
            // 
            // comboLogSetting
            // 
            this.comboLogSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLogSetting.Items.AddRange(new object[] {
            "Off",
            "Exception",
            "All"});
            this.comboLogSetting.Name = "comboLogSetting";
            this.comboLogSetting.Size = new System.Drawing.Size(121, 25);
            this.comboLogSetting.SelectedIndexChanged += new System.EventHandler(this.comboLogSetting_SelectedIndexChanged);
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.panelFilter);
            this.groupFilter.Controls.Add(this.panelOptions);
            this.groupFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupFilter.Location = new System.Drawing.Point(0, 0);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(587, 172);
            this.groupFilter.TabIndex = 26;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Filter";
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.textCorrelationId);
            this.panelFilter.Controls.Add(this.chkCorrelation);
            this.panelFilter.Controls.Add(this.labelTimeZone);
            this.panelFilter.Controls.Add(this.comboEntity);
            this.panelFilter.Controls.Add(this.chkEntity);
            this.panelFilter.Controls.Add(this.comboMessage);
            this.panelFilter.Controls.Add(this.chkMessage);
            this.panelFilter.Controls.Add(this.comboPlugin);
            this.panelFilter.Controls.Add(this.chkPlugin);
            this.panelFilter.Controls.Add(this.checkDateTo);
            this.panelFilter.Controls.Add(this.checkDateFrom);
            this.panelFilter.Controls.Add(this.dateTo);
            this.panelFilter.Controls.Add(this.dateFrom);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilter.Location = new System.Drawing.Point(3, 16);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(318, 153);
            this.panelFilter.TabIndex = 1;
            // 
            // textCorrelationId
            // 
            this.textCorrelationId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCorrelationId.Enabled = false;
            this.textCorrelationId.Location = new System.Drawing.Point(97, 120);
            this.textCorrelationId.Name = "textCorrelationId";
            this.textCorrelationId.Size = new System.Drawing.Size(214, 20);
            this.textCorrelationId.TabIndex = 13;
            // 
            // chkCorrelation
            // 
            this.chkCorrelation.AutoSize = true;
            this.chkCorrelation.Location = new System.Drawing.Point(3, 122);
            this.chkCorrelation.Name = "chkCorrelation";
            this.chkCorrelation.Size = new System.Drawing.Size(88, 17);
            this.chkCorrelation.TabIndex = 12;
            this.chkCorrelation.Text = "Correlation Id";
            this.chkCorrelation.UseVisualStyleBackColor = true;
            this.chkCorrelation.CheckedChanged += new System.EventHandler(this.chkCorrelation_CheckedChanged);
            // 
            // labelTimeZone
            // 
            this.labelTimeZone.AutoSize = true;
            this.labelTimeZone.Location = new System.Drawing.Point(270, 4);
            this.labelTimeZone.Name = "labelTimeZone";
            this.labelTimeZone.Size = new System.Drawing.Size(71, 13);
            this.labelTimeZone.TabIndex = 11;
            this.labelTimeZone.Text = "Times in UTC";
            // 
            // comboEntity
            // 
            this.comboEntity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboEntity.Enabled = false;
            this.comboEntity.FormattingEnabled = true;
            this.comboEntity.Location = new System.Drawing.Point(97, 96);
            this.comboEntity.Name = "comboEntity";
            this.comboEntity.Size = new System.Drawing.Size(214, 21);
            this.comboEntity.Sorted = true;
            this.comboEntity.TabIndex = 10;
            // 
            // chkEntity
            // 
            this.chkEntity.AutoSize = true;
            this.chkEntity.Location = new System.Drawing.Point(3, 98);
            this.chkEntity.Name = "chkEntity";
            this.chkEntity.Size = new System.Drawing.Size(52, 17);
            this.chkEntity.TabIndex = 9;
            this.chkEntity.Text = "Entity";
            this.chkEntity.UseVisualStyleBackColor = true;
            this.chkEntity.CheckedChanged += new System.EventHandler(this.chkEntity_CheckedChanged);
            // 
            // comboMessage
            // 
            this.comboMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboMessage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMessage.Enabled = false;
            this.comboMessage.FormattingEnabled = true;
            this.comboMessage.Location = new System.Drawing.Point(97, 72);
            this.comboMessage.Name = "comboMessage";
            this.comboMessage.Size = new System.Drawing.Size(214, 21);
            this.comboMessage.TabIndex = 8;
            // 
            // chkMessage
            // 
            this.chkMessage.AutoSize = true;
            this.chkMessage.Location = new System.Drawing.Point(3, 74);
            this.chkMessage.Name = "chkMessage";
            this.chkMessage.Size = new System.Drawing.Size(69, 17);
            this.chkMessage.TabIndex = 7;
            this.chkMessage.Text = "Message";
            this.chkMessage.UseVisualStyleBackColor = true;
            this.chkMessage.CheckedChanged += new System.EventHandler(this.chkMessage_CheckedChanged);
            // 
            // comboPlugin
            // 
            this.comboPlugin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboPlugin.Enabled = false;
            this.comboPlugin.FormattingEnabled = true;
            this.comboPlugin.Location = new System.Drawing.Point(97, 48);
            this.comboPlugin.Name = "comboPlugin";
            this.comboPlugin.Size = new System.Drawing.Size(214, 21);
            this.comboPlugin.TabIndex = 6;
            // 
            // chkPlugin
            // 
            this.chkPlugin.AutoSize = true;
            this.chkPlugin.Location = new System.Drawing.Point(3, 50);
            this.chkPlugin.Name = "chkPlugin";
            this.chkPlugin.Size = new System.Drawing.Size(55, 17);
            this.chkPlugin.TabIndex = 5;
            this.chkPlugin.Text = "Plugin";
            this.chkPlugin.UseVisualStyleBackColor = true;
            this.chkPlugin.CheckedChanged += new System.EventHandler(this.chkPlugin_CheckedChanged);
            // 
            // checkDateTo
            // 
            this.checkDateTo.AutoSize = true;
            this.checkDateTo.Location = new System.Drawing.Point(3, 27);
            this.checkDateTo.Name = "checkDateTo";
            this.checkDateTo.Size = new System.Drawing.Size(65, 17);
            this.checkDateTo.TabIndex = 3;
            this.checkDateTo.Text = "Date To";
            this.checkDateTo.UseVisualStyleBackColor = true;
            this.checkDateTo.CheckedChanged += new System.EventHandler(this.checkDateTo_CheckedChanged);
            // 
            // checkDateFrom
            // 
            this.checkDateFrom.AutoSize = true;
            this.checkDateFrom.Location = new System.Drawing.Point(3, 3);
            this.checkDateFrom.Name = "checkDateFrom";
            this.checkDateFrom.Size = new System.Drawing.Size(75, 17);
            this.checkDateFrom.TabIndex = 1;
            this.checkDateFrom.Text = "Date From";
            this.checkDateFrom.UseVisualStyleBackColor = true;
            this.checkDateFrom.CheckedChanged += new System.EventHandler(this.checkDateFrom_CheckedChanged);
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTo.Enabled = false;
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(97, 24);
            this.dateTo.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTo.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(130, 20);
            this.dateTo.TabIndex = 4;
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateFrom.Enabled = false;
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(97, 0);
            this.dateFrom.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateFrom.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(130, 20);
            this.dateFrom.TabIndex = 2;
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.panelOperationFilter);
            this.panelOptions.Controls.Add(this.chkRecords);
            this.panelOptions.Controls.Add(this.chkDurationMax);
            this.panelOptions.Controls.Add(this.chkDurationMin);
            this.panelOptions.Controls.Add(this.numDurationMax);
            this.panelOptions.Controls.Add(this.numDurationMin);
            this.panelOptions.Controls.Add(this.numRecords);
            this.panelOptions.Controls.Add(this.rbModeAsync);
            this.panelOptions.Controls.Add(this.rbModeSync);
            this.panelOptions.Controls.Add(this.rbModeAll);
            this.panelOptions.Controls.Add(this.chkExceptions);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOptions.Location = new System.Drawing.Point(321, 16);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(263, 153);
            this.panelOptions.TabIndex = 2;
            // 
            // panelOperationFilter
            // 
            this.panelOperationFilter.Controls.Add(this.rbOperWF);
            this.panelOperationFilter.Controls.Add(this.rbOperPlugin);
            this.panelOperationFilter.Controls.Add(this.rbOperAll);
            this.panelOperationFilter.Location = new System.Drawing.Point(0, 24);
            this.panelOperationFilter.Name = "panelOperationFilter";
            this.panelOperationFilter.Size = new System.Drawing.Size(257, 22);
            this.panelOperationFilter.TabIndex = 2;
            // 
            // rbOperWF
            // 
            this.rbOperWF.AutoSize = true;
            this.rbOperWF.Location = new System.Drawing.Point(158, 2);
            this.rbOperWF.Name = "rbOperWF";
            this.rbOperWF.Size = new System.Drawing.Size(87, 17);
            this.rbOperWF.TabIndex = 7;
            this.rbOperWF.TabStop = true;
            this.rbOperWF.Text = "WF Activities";
            this.rbOperWF.UseVisualStyleBackColor = true;
            // 
            // rbOperPlugin
            // 
            this.rbOperPlugin.AutoSize = true;
            this.rbOperPlugin.Location = new System.Drawing.Point(80, 2);
            this.rbOperPlugin.Name = "rbOperPlugin";
            this.rbOperPlugin.Size = new System.Drawing.Size(59, 17);
            this.rbOperPlugin.TabIndex = 6;
            this.rbOperPlugin.TabStop = true;
            this.rbOperPlugin.Text = "Plugins";
            this.rbOperPlugin.UseVisualStyleBackColor = true;
            // 
            // rbOperAll
            // 
            this.rbOperAll.AutoSize = true;
            this.rbOperAll.Checked = true;
            this.rbOperAll.Location = new System.Drawing.Point(3, 2);
            this.rbOperAll.Name = "rbOperAll";
            this.rbOperAll.Size = new System.Drawing.Size(63, 17);
            this.rbOperAll.TabIndex = 5;
            this.rbOperAll.TabStop = true;
            this.rbOperAll.Text = "All oper.";
            this.rbOperAll.UseVisualStyleBackColor = true;
            // 
            // chkRecords
            // 
            this.chkRecords.AutoSize = true;
            this.chkRecords.Checked = true;
            this.chkRecords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecords.Location = new System.Drawing.Point(3, 122);
            this.chkRecords.Name = "chkRecords";
            this.chkRecords.Size = new System.Drawing.Size(91, 17);
            this.chkRecords.TabIndex = 12;
            this.chkRecords.Text = "Record count";
            this.chkRecords.UseVisualStyleBackColor = true;
            this.chkRecords.CheckedChanged += new System.EventHandler(this.chkRecords_CheckedChanged);
            // 
            // chkDurationMax
            // 
            this.chkDurationMax.AutoSize = true;
            this.chkDurationMax.Location = new System.Drawing.Point(3, 98);
            this.chkDurationMax.Name = "chkDurationMax";
            this.chkDurationMax.Size = new System.Drawing.Size(89, 17);
            this.chkDurationMax.TabIndex = 10;
            this.chkDurationMax.Text = "Duration Max";
            this.chkDurationMax.UseVisualStyleBackColor = true;
            this.chkDurationMax.CheckedChanged += new System.EventHandler(this.chkDurationMax_CheckedChanged);
            // 
            // chkDurationMin
            // 
            this.chkDurationMin.AutoSize = true;
            this.chkDurationMin.Location = new System.Drawing.Point(3, 74);
            this.chkDurationMin.Name = "chkDurationMin";
            this.chkDurationMin.Size = new System.Drawing.Size(86, 17);
            this.chkDurationMin.TabIndex = 8;
            this.chkDurationMin.Text = "Duration Min";
            this.chkDurationMin.UseVisualStyleBackColor = true;
            this.chkDurationMin.CheckedChanged += new System.EventHandler(this.chkDurationMin_CheckedChanged);
            // 
            // numDurationMax
            // 
            this.numDurationMax.Enabled = false;
            this.numDurationMax.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numDurationMax.Location = new System.Drawing.Point(158, 97);
            this.numDurationMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDurationMax.Name = "numDurationMax";
            this.numDurationMax.Size = new System.Drawing.Size(76, 20);
            this.numDurationMax.TabIndex = 11;
            // 
            // numDurationMin
            // 
            this.numDurationMin.Enabled = false;
            this.numDurationMin.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numDurationMin.Location = new System.Drawing.Point(158, 73);
            this.numDurationMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDurationMin.Name = "numDurationMin";
            this.numDurationMin.Size = new System.Drawing.Size(76, 20);
            this.numDurationMin.TabIndex = 9;
            // 
            // numRecords
            // 
            this.numRecords.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numRecords.Location = new System.Drawing.Point(158, 121);
            this.numRecords.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numRecords.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRecords.Name = "numRecords";
            this.numRecords.Size = new System.Drawing.Size(76, 20);
            this.numRecords.TabIndex = 13;
            this.numRecords.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numRecords.ValueChanged += new System.EventHandler(this.numRecords_ValueChanged);
            // 
            // rbModeAsync
            // 
            this.rbModeAsync.AutoSize = true;
            this.rbModeAsync.Location = new System.Drawing.Point(158, 49);
            this.rbModeAsync.Name = "rbModeAsync";
            this.rbModeAsync.Size = new System.Drawing.Size(76, 17);
            this.rbModeAsync.TabIndex = 7;
            this.rbModeAsync.TabStop = true;
            this.rbModeAsync.Text = "Async only";
            this.rbModeAsync.UseVisualStyleBackColor = true;
            // 
            // rbModeSync
            // 
            this.rbModeSync.AutoSize = true;
            this.rbModeSync.Location = new System.Drawing.Point(80, 49);
            this.rbModeSync.Name = "rbModeSync";
            this.rbModeSync.Size = new System.Drawing.Size(71, 17);
            this.rbModeSync.TabIndex = 6;
            this.rbModeSync.TabStop = true;
            this.rbModeSync.Text = "Sync only";
            this.rbModeSync.UseVisualStyleBackColor = true;
            // 
            // rbModeAll
            // 
            this.rbModeAll.AutoSize = true;
            this.rbModeAll.Checked = true;
            this.rbModeAll.Location = new System.Drawing.Point(3, 49);
            this.rbModeAll.Name = "rbModeAll";
            this.rbModeAll.Size = new System.Drawing.Size(70, 17);
            this.rbModeAll.TabIndex = 5;
            this.rbModeAll.TabStop = true;
            this.rbModeAll.Text = "All modes";
            this.rbModeAll.UseVisualStyleBackColor = true;
            // 
            // chkExceptions
            // 
            this.chkExceptions.AutoSize = true;
            this.chkExceptions.Location = new System.Drawing.Point(3, 3);
            this.chkExceptions.Name = "chkExceptions";
            this.chkExceptions.Size = new System.Drawing.Size(100, 17);
            this.chkExceptions.TabIndex = 1;
            this.chkExceptions.Text = "Exceptions only";
            this.chkExceptions.UseVisualStyleBackColor = true;
            // 
            // crmGridView
            // 
            this.crmGridView.AllowUserToAddRows = false;
            this.crmGridView.AllowUserToDeleteRows = false;
            this.crmGridView.AllowUserToOrderColumns = true;
            this.crmGridView.AllowUserToResizeRows = false;
            this.crmGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crmGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.correlation,
            this.performanceexecutionstarttime,
            this.performanceexecutionduration,
            this.operationtype,
            this.typename,
            this.stepname,
            this.depth,
            this.mode,
            this.stage,
            this.rank,
            this.messagename,
            this.primaryentity,
            this.correlationid,
            this.requestid,
            this.exceptionsummary,
            this.messagebody,
            this.exceptiondetails});
            this.crmGridView.ContextMenuStrip = this.contextMenuGridView;
            this.crmGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crmGridView.EnableHeadersVisualStyles = false;
            this.crmGridView.Location = new System.Drawing.Point(0, 172);
            this.crmGridView.Name = "crmGridView";
            this.crmGridView.ReadOnly = true;
            this.crmGridView.RowHeadersWidth = 20;
            this.crmGridView.ShowFriendlyNames = true;
            this.crmGridView.ShowIdColumn = false;
            this.crmGridView.ShowIndexColumn = false;
            this.crmGridView.Size = new System.Drawing.Size(587, 130);
            this.crmGridView.TabIndex = 25;
            this.crmGridView.RecordDoubleClick += new Cinteros.Xrm.CRMWinForm.CRMRecordEventHandler(this.crmGridView_RecordDoubleClick);
            this.crmGridView.RecordEnter += new Cinteros.Xrm.CRMWinForm.CRMRecordEventHandler(this.crmGridView_RecordEnter);
            this.crmGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.crmGridView_CellFormatting);
            this.crmGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.crmGridView_CellMouseDown);
            this.crmGridView.SelectionChanged += new System.EventHandler(this.crmGridView_SelectionChanged);
            this.crmGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.crmGridView_KeyDown);
            // 
            // correlation
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.correlation.DefaultCellStyle = dataGridViewCellStyle7;
            this.correlation.HeaderText = "Corr";
            this.correlation.Name = "correlation";
            this.correlation.ReadOnly = true;
            this.correlation.Width = 35;
            // 
            // performanceexecutionstarttime
            // 
            this.performanceexecutionstarttime.HeaderText = "Start Time";
            this.performanceexecutionstarttime.Name = "performanceexecutionstarttime";
            this.performanceexecutionstarttime.ReadOnly = true;
            this.performanceexecutionstarttime.Width = 80;
            // 
            // performanceexecutionduration
            // 
            this.performanceexecutionduration.HeaderText = "Duration";
            this.performanceexecutionduration.Name = "performanceexecutionduration";
            this.performanceexecutionduration.ReadOnly = true;
            this.performanceexecutionduration.Width = 50;
            // 
            // operationtype
            // 
            this.operationtype.HeaderText = "Operation";
            this.operationtype.Name = "operationtype";
            this.operationtype.ReadOnly = true;
            this.operationtype.Width = 78;
            // 
            // typename
            // 
            this.typename.HeaderText = "Plugin";
            this.typename.Name = "typename";
            this.typename.ReadOnly = true;
            this.typename.Width = 61;
            // 
            // stepname
            // 
            this.stepname.DataPropertyName = "step.name";
            this.stepname.HeaderText = "Step";
            this.stepname.Name = "stepname";
            this.stepname.ReadOnly = true;
            // 
            // depth
            // 
            this.depth.HeaderText = "Depth";
            this.depth.Name = "depth";
            this.depth.ReadOnly = true;
            this.depth.Width = 61;
            // 
            // mode
            // 
            this.mode.HeaderText = "Mode";
            this.mode.Name = "mode";
            this.mode.ReadOnly = true;
            this.mode.Width = 59;
            // 
            // stage
            // 
            this.stage.DataPropertyName = "step.stage";
            this.stage.FillWeight = 70F;
            this.stage.HeaderText = "Stage";
            this.stage.Name = "stage";
            this.stage.ReadOnly = true;
            // 
            // rank
            // 
            this.rank.DataPropertyName = "step.rank";
            this.rank.FillWeight = 50F;
            this.rank.HeaderText = "Rank";
            this.rank.Name = "rank";
            this.rank.ReadOnly = true;
            this.rank.Width = 50;
            // 
            // messagename
            // 
            this.messagename.HeaderText = "Message";
            this.messagename.Name = "messagename";
            this.messagename.ReadOnly = true;
            this.messagename.Width = 75;
            // 
            // primaryentity
            // 
            this.primaryentity.HeaderText = "Entity";
            this.primaryentity.Name = "primaryentity";
            this.primaryentity.ReadOnly = true;
            this.primaryentity.Width = 58;
            // 
            // correlationid
            // 
            this.correlationid.HeaderText = "Correlation GUID";
            this.correlationid.Name = "correlationid";
            this.correlationid.ReadOnly = true;
            this.correlationid.Visible = false;
            this.correlationid.Width = 150;
            // 
            // requestid
            // 
            this.requestid.HeaderText = "Request GUID";
            this.requestid.Name = "requestid";
            this.requestid.ReadOnly = true;
            this.requestid.Visible = false;
            this.requestid.Width = 150;
            // 
            // exceptionsummary
            // 
            this.exceptionsummary.HeaderText = "Exception";
            this.exceptionsummary.Name = "exceptionsummary";
            this.exceptionsummary.ReadOnly = true;
            this.exceptionsummary.Width = 200;
            // 
            // messagebody
            // 
            this.messagebody.HeaderText = "Trace Log (Hidden)";
            this.messagebody.Name = "messagebody";
            this.messagebody.ReadOnly = true;
            this.messagebody.Visible = false;
            // 
            // exceptiondetails
            // 
            this.exceptiondetails.HeaderText = "Exception Details (Hidden)";
            this.exceptiondetails.Name = "exceptiondetails";
            this.exceptiondetails.ReadOnly = true;
            this.exceptiondetails.Visible = false;
            this.exceptiondetails.Width = 150;
            // 
            // contextMenuGridView
            // 
            this.contextMenuGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFilterBy,
            this.tsmiCorrelation,
            this.tsmiDelete,
            this.tsmiShowColCorrelation,
            this.tsmiShowColStartTime,
            this.tsmiShowColDuration,
            this.tsmiShowColOperation,
            this.tsmiShowColPlugin,
            this.tsmiShowColStep,
            this.tsmiShowColDepth,
            this.tsmiShowColMode,
            this.tsmiShowColStage,
            this.tsmiShowColRank,
            this.tsmiShowColMessage,
            this.tsmiShowColEntity,
            this.tsmiShowColCorrelationId,
            this.tsmiShowColRequestId,
            this.tsmiShowColException});
            this.contextMenuGridView.Name = "contextStripMain";
            this.contextMenuGridView.Size = new System.Drawing.Size(164, 400);
            this.contextMenuGridView.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuGridView_Opening);
            // 
            // tsmiFilterBy
            // 
            this.tsmiFilterBy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFilterByEntity,
            this.tsmiFilterByMessage,
            this.tsmiFilterByPlugin,
            this.tsmiFilterByCorrelation});
            this.tsmiFilterBy.Name = "tsmiFilterBy";
            this.tsmiFilterBy.Size = new System.Drawing.Size(163, 22);
            this.tsmiFilterBy.Text = "Filter by selected";
            // 
            // tsmiFilterByEntity
            // 
            this.tsmiFilterByEntity.Name = "tsmiFilterByEntity";
            this.tsmiFilterByEntity.Size = new System.Drawing.Size(133, 22);
            this.tsmiFilterByEntity.Text = "Entity";
            this.tsmiFilterByEntity.Click += new System.EventHandler(this.tsmiFilterByEntity_Click);
            // 
            // tsmiFilterByMessage
            // 
            this.tsmiFilterByMessage.Name = "tsmiFilterByMessage";
            this.tsmiFilterByMessage.Size = new System.Drawing.Size(133, 22);
            this.tsmiFilterByMessage.Text = "Message";
            this.tsmiFilterByMessage.Click += new System.EventHandler(this.tsmiFilterByMessage_Click);
            // 
            // tsmiFilterByPlugin
            // 
            this.tsmiFilterByPlugin.Name = "tsmiFilterByPlugin";
            this.tsmiFilterByPlugin.Size = new System.Drawing.Size(133, 22);
            this.tsmiFilterByPlugin.Text = "Plugin";
            this.tsmiFilterByPlugin.Click += new System.EventHandler(this.tsmiFilterByPlugin_Click);
            // 
            // tsmiFilterByCorrelation
            // 
            this.tsmiFilterByCorrelation.Name = "tsmiFilterByCorrelation";
            this.tsmiFilterByCorrelation.Size = new System.Drawing.Size(133, 22);
            this.tsmiFilterByCorrelation.Text = "Correlation";
            this.tsmiFilterByCorrelation.Click += new System.EventHandler(this.tsmiFilterByCorrelation_Click);
            // 
            // tsmiCorrelation
            // 
            this.tsmiCorrelation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCorrelationId,
            this.tsmiCorrelationSelectThis});
            this.tsmiCorrelation.Name = "tsmiCorrelation";
            this.tsmiCorrelation.Size = new System.Drawing.Size(163, 22);
            this.tsmiCorrelation.Text = "Correlation";
            // 
            // tsmiCorrelationId
            // 
            this.tsmiCorrelationId.Name = "tsmiCorrelationId";
            this.tsmiCorrelationId.Size = new System.Drawing.Size(308, 22);
            this.tsmiCorrelationId.Text = "Id: ";
            // 
            // tsmiCorrelationSelectThis
            // 
            this.tsmiCorrelationSelectThis.Name = "tsmiCorrelationSelectThis";
            this.tsmiCorrelationSelectThis.ShortcutKeyDisplayString = "Ctrl+C";
            this.tsmiCorrelationSelectThis.Size = new System.Drawing.Size(308, 22);
            this.tsmiCorrelationSelectThis.Text = "Select all logs with this correlation id";
            this.tsmiCorrelationSelectThis.Click += new System.EventHandler(this.tsmiCorrelationSelectThis_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteSelected,
            this.tsmiDeleteAll});
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(163, 22);
            this.tsmiDelete.Text = "Delete";
            // 
            // tsmiDeleteSelected
            // 
            this.tsmiDeleteSelected.Name = "tsmiDeleteSelected";
            this.tsmiDeleteSelected.Size = new System.Drawing.Size(154, 22);
            this.tsmiDeleteSelected.Text = "Delete Selected";
            this.tsmiDeleteSelected.Click += new System.EventHandler(this.tsmiDeleteSelected_Click);
            // 
            // tsmiDeleteAll
            // 
            this.tsmiDeleteAll.Name = "tsmiDeleteAll";
            this.tsmiDeleteAll.Size = new System.Drawing.Size(154, 22);
            this.tsmiDeleteAll.Text = "Delete All...";
            this.tsmiDeleteAll.Click += new System.EventHandler(this.tsmiDeleteAll_Click);
            // 
            // tsmiShowColCorrelation
            // 
            this.tsmiShowColCorrelation.Checked = true;
            this.tsmiShowColCorrelation.CheckOnClick = true;
            this.tsmiShowColCorrelation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColCorrelation.Name = "tsmiShowColCorrelation";
            this.tsmiShowColCorrelation.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColCorrelation.Tag = "correlation";
            this.tsmiShowColCorrelation.Text = "Correlation";
            this.tsmiShowColCorrelation.CheckedChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColStartTime
            // 
            this.tsmiShowColStartTime.Checked = true;
            this.tsmiShowColStartTime.CheckOnClick = true;
            this.tsmiShowColStartTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColStartTime.Name = "tsmiShowColStartTime";
            this.tsmiShowColStartTime.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColStartTime.Tag = "performanceexecutionstarttime";
            this.tsmiShowColStartTime.Text = "Start Time";
            this.tsmiShowColStartTime.CheckedChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColDuration
            // 
            this.tsmiShowColDuration.Checked = true;
            this.tsmiShowColDuration.CheckOnClick = true;
            this.tsmiShowColDuration.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColDuration.Name = "tsmiShowColDuration";
            this.tsmiShowColDuration.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColDuration.Tag = "performanceexecutionduration";
            this.tsmiShowColDuration.Text = "Duration";
            this.tsmiShowColDuration.CheckedChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColOperation
            // 
            this.tsmiShowColOperation.Checked = true;
            this.tsmiShowColOperation.CheckOnClick = true;
            this.tsmiShowColOperation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColOperation.Name = "tsmiShowColOperation";
            this.tsmiShowColOperation.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColOperation.Tag = "operationtype";
            this.tsmiShowColOperation.Text = "Operation";
            this.tsmiShowColOperation.CheckedChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColPlugin
            // 
            this.tsmiShowColPlugin.Checked = true;
            this.tsmiShowColPlugin.CheckOnClick = true;
            this.tsmiShowColPlugin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColPlugin.Name = "tsmiShowColPlugin";
            this.tsmiShowColPlugin.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColPlugin.Tag = "typename";
            this.tsmiShowColPlugin.Text = "Plugin";
            this.tsmiShowColPlugin.CheckedChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColStep
            // 
            this.tsmiShowColStep.Checked = true;
            this.tsmiShowColStep.CheckOnClick = true;
            this.tsmiShowColStep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColStep.Name = "tsmiShowColStep";
            this.tsmiShowColStep.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColStep.Tag = "stepname";
            this.tsmiShowColStep.Text = "Step";
            this.tsmiShowColStep.CheckedChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColDepth
            // 
            this.tsmiShowColDepth.Checked = true;
            this.tsmiShowColDepth.CheckOnClick = true;
            this.tsmiShowColDepth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColDepth.Name = "tsmiShowColDepth";
            this.tsmiShowColDepth.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColDepth.Tag = "depth";
            this.tsmiShowColDepth.Text = "Depth";
            this.tsmiShowColDepth.CheckedChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColMode
            // 
            this.tsmiShowColMode.Checked = true;
            this.tsmiShowColMode.CheckOnClick = true;
            this.tsmiShowColMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColMode.Name = "tsmiShowColMode";
            this.tsmiShowColMode.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColMode.Tag = "mode";
            this.tsmiShowColMode.Text = "Mode";
            this.tsmiShowColMode.CheckedChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColStage
            // 
            this.tsmiShowColStage.Checked = true;
            this.tsmiShowColStage.CheckOnClick = true;
            this.tsmiShowColStage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColStage.Name = "tsmiShowColStage";
            this.tsmiShowColStage.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColStage.Tag = "stage";
            this.tsmiShowColStage.Text = "Stage";
            this.tsmiShowColStage.CheckedChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColRank
            // 
            this.tsmiShowColRank.Checked = true;
            this.tsmiShowColRank.CheckOnClick = true;
            this.tsmiShowColRank.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColRank.Name = "tsmiShowColRank";
            this.tsmiShowColRank.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColRank.Tag = "rank";
            this.tsmiShowColRank.Text = "Rank";
            this.tsmiShowColRank.CheckedChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColMessage
            // 
            this.tsmiShowColMessage.Checked = true;
            this.tsmiShowColMessage.CheckOnClick = true;
            this.tsmiShowColMessage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColMessage.Name = "tsmiShowColMessage";
            this.tsmiShowColMessage.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColMessage.Tag = "messagename";
            this.tsmiShowColMessage.Text = "Message";
            this.tsmiShowColMessage.CheckedChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColEntity
            // 
            this.tsmiShowColEntity.Checked = true;
            this.tsmiShowColEntity.CheckOnClick = true;
            this.tsmiShowColEntity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColEntity.Name = "tsmiShowColEntity";
            this.tsmiShowColEntity.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColEntity.Tag = "primaryentity";
            this.tsmiShowColEntity.Text = "Entity";
            this.tsmiShowColEntity.CheckedChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColCorrelationId
            // 
            this.tsmiShowColCorrelationId.CheckOnClick = true;
            this.tsmiShowColCorrelationId.Name = "tsmiShowColCorrelationId";
            this.tsmiShowColCorrelationId.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColCorrelationId.Tag = "correlationid";
            this.tsmiShowColCorrelationId.Text = "Correlation GUID";
            this.tsmiShowColCorrelationId.CheckedChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColRequestId
            // 
            this.tsmiShowColRequestId.CheckOnClick = true;
            this.tsmiShowColRequestId.Name = "tsmiShowColRequestId";
            this.tsmiShowColRequestId.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColRequestId.Tag = "requestid";
            this.tsmiShowColRequestId.Text = "Request GUID";
            this.tsmiShowColRequestId.CheckedChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColException
            // 
            this.tsmiShowColException.Checked = true;
            this.tsmiShowColException.CheckOnClick = true;
            this.tsmiShowColException.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColException.Name = "tsmiShowColException";
            this.tsmiShowColException.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColException.Tag = "exceptionsummary";
            this.tsmiShowColException.Text = "Exception";
            this.tsmiShowColException.CheckedChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // splitContainerRight
            // 
            this.splitContainerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRight.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerRight.Location = new System.Drawing.Point(0, 172);
            this.splitContainerRight.Name = "splitContainerRight";
            this.splitContainerRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRight.Panel1
            // 
            this.splitContainerRight.Panel1.Controls.Add(this.groupTraceLog);
            this.splitContainerRight.Panel1MinSize = 23;
            // 
            // splitContainerRight.Panel2
            // 
            this.splitContainerRight.Panel2.Controls.Add(this.groupException);
            this.splitContainerRight.Panel2MinSize = 23;
            this.splitContainerRight.Size = new System.Drawing.Size(465, 130);
            this.splitContainerRight.SplitterDistance = 23;
            this.splitContainerRight.SplitterWidth = 8;
            this.splitContainerRight.TabIndex = 12;
            // 
            // groupTraceLog
            // 
            this.groupTraceLog.Controls.Add(this.textMessage);
            this.groupTraceLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTraceLog.Location = new System.Drawing.Point(0, 0);
            this.groupTraceLog.Name = "groupTraceLog";
            this.groupTraceLog.Size = new System.Drawing.Size(489, 255);
            this.groupTraceLog.TabIndex = 11;
            this.groupTraceLog.TabStop = false;
            this.groupTraceLog.Text = "Trace Log";
            // 
            // textMessage
            // 
            this.textMessage.AcceptsReturn = true;
            this.textMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textMessage.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMessage.Location = new System.Drawing.Point(3, 16);
            this.textMessage.MinimumSize = new System.Drawing.Size(4, 100);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.ReadOnly = true;
            this.textMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textMessage.Size = new System.Drawing.Size(483, 236);
            this.textMessage.TabIndex = 10;
            this.textMessage.WordWrap = false;
            // 
            // groupException
            // 
            this.groupException.Controls.Add(this.textException);
            this.groupException.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupException.Location = new System.Drawing.Point(0, 0);
            this.groupException.Name = "groupException";
            this.groupException.Size = new System.Drawing.Size(489, 46);
            this.groupException.TabIndex = 7;
            this.groupException.TabStop = false;
            this.groupException.Text = "Exception";
            // 
            // textException
            // 
            this.textException.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textException.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textException.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textException.Location = new System.Drawing.Point(3, 16);
            this.textException.Multiline = true;
            this.textException.Name = "textException";
            this.textException.ReadOnly = true;
            this.textException.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textException.Size = new System.Drawing.Size(483, 27);
            this.textException.TabIndex = 6;
            this.textException.WordWrap = false;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Location = new System.Drawing.Point(54, 25);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.crmGridView);
            this.splitContainerMain.Panel1.Controls.Add(this.groupFilter);
            this.splitContainerMain.Panel1MinSize = 100;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerRight);
            this.splitContainerMain.Panel2.Controls.Add(this.panelStatistics);
            this.splitContainerMain.Panel2MinSize = 100;
            this.splitContainerMain.Size = new System.Drawing.Size(1060, 302);
            this.splitContainerMain.SplitterDistance = 587;
            this.splitContainerMain.SplitterWidth = 8;
            this.splitContainerMain.TabIndex = 31;
            // 
            // panelStatistics
            // 
            this.panelStatistics.Controls.Add(this.groupStatistics);
            this.panelStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatistics.Location = new System.Drawing.Point(0, 0);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Size = new System.Drawing.Size(465, 172);
            this.panelStatistics.TabIndex = 14;
            // 
            // groupStatistics
            // 
            this.groupStatistics.Controls.Add(this.txtStatTermOther);
            this.groupStatistics.Controls.Add(this.label14);
            this.groupStatistics.Controls.Add(this.txtStatTermHandles);
            this.groupStatistics.Controls.Add(this.label13);
            this.groupStatistics.Controls.Add(this.txtStatTermMemory);
            this.groupStatistics.Controls.Add(this.label12);
            this.groupStatistics.Controls.Add(this.txtStatTermCPU);
            this.groupStatistics.Controls.Add(this.label11);
            this.groupStatistics.Controls.Add(this.label10);
            this.groupStatistics.Controls.Add(this.txtStatCrashContrPct);
            this.groupStatistics.Controls.Add(this.label9);
            this.groupStatistics.Controls.Add(this.txtStatCrashPct);
            this.groupStatistics.Controls.Add(this.txtStatCrashCnt);
            this.groupStatistics.Controls.Add(this.label8);
            this.groupStatistics.Controls.Add(this.txtStatFailPct);
            this.groupStatistics.Controls.Add(this.txtStatFailCnt);
            this.groupStatistics.Controls.Add(this.label7);
            this.groupStatistics.Controls.Add(this.txtStatSecPerDay);
            this.groupStatistics.Controls.Add(this.txtStatAvgExecTime);
            this.groupStatistics.Controls.Add(this.txtStatExecCnt);
            this.groupStatistics.Controls.Add(this.txtStatModified);
            this.groupStatistics.Controls.Add(this.txtStatCreated);
            this.groupStatistics.Controls.Add(this.label6);
            this.groupStatistics.Controls.Add(this.label5);
            this.groupStatistics.Controls.Add(this.label4);
            this.groupStatistics.Controls.Add(this.label3);
            this.groupStatistics.Controls.Add(this.label2);
            this.groupStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupStatistics.Location = new System.Drawing.Point(0, 0);
            this.groupStatistics.Name = "groupStatistics";
            this.groupStatistics.Size = new System.Drawing.Size(465, 172);
            this.groupStatistics.TabIndex = 14;
            this.groupStatistics.TabStop = false;
            this.groupStatistics.Text = "Plugin Statistics";
            // 
            // txtStatTermOther
            // 
            this.txtStatTermOther.Location = new System.Drawing.Point(399, 136);
            this.txtStatTermOther.Name = "txtStatTermOther";
            this.txtStatTermOther.ReadOnly = true;
            this.txtStatTermOther.Size = new System.Drawing.Size(34, 20);
            this.txtStatTermOther.TabIndex = 27;
            this.txtStatTermOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(347, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Other";
            // 
            // txtStatTermHandles
            // 
            this.txtStatTermHandles.Location = new System.Drawing.Point(399, 112);
            this.txtStatTermHandles.Name = "txtStatTermHandles";
            this.txtStatTermHandles.ReadOnly = true;
            this.txtStatTermHandles.Size = new System.Drawing.Size(34, 20);
            this.txtStatTermHandles.TabIndex = 25;
            this.txtStatTermHandles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(347, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Handles";
            // 
            // txtStatTermMemory
            // 
            this.txtStatTermMemory.Location = new System.Drawing.Point(399, 88);
            this.txtStatTermMemory.Name = "txtStatTermMemory";
            this.txtStatTermMemory.ReadOnly = true;
            this.txtStatTermMemory.Size = new System.Drawing.Size(34, 20);
            this.txtStatTermMemory.TabIndex = 23;
            this.txtStatTermMemory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(347, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Memory";
            // 
            // txtStatTermCPU
            // 
            this.txtStatTermCPU.Location = new System.Drawing.Point(399, 64);
            this.txtStatTermCPU.Name = "txtStatTermCPU";
            this.txtStatTermCPU.ReadOnly = true;
            this.txtStatTermCPU.Size = new System.Drawing.Size(34, 20);
            this.txtStatTermCPU.TabIndex = 21;
            this.txtStatTermCPU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(347, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "CPU";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Termination reasons";
            // 
            // txtStatCrashContrPct
            // 
            this.txtStatCrashContrPct.Location = new System.Drawing.Point(293, 136);
            this.txtStatCrashContrPct.Name = "txtStatCrashContrPct";
            this.txtStatCrashContrPct.ReadOnly = true;
            this.txtStatCrashContrPct.Size = new System.Drawing.Size(34, 20);
            this.txtStatCrashContrPct.TabIndex = 18;
            this.txtStatCrashContrPct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Crash contribution";
            // 
            // txtStatCrashPct
            // 
            this.txtStatCrashPct.Location = new System.Drawing.Point(293, 112);
            this.txtStatCrashPct.Name = "txtStatCrashPct";
            this.txtStatCrashPct.ReadOnly = true;
            this.txtStatCrashPct.Size = new System.Drawing.Size(34, 20);
            this.txtStatCrashPct.TabIndex = 16;
            this.txtStatCrashPct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtStatCrashCnt
            // 
            this.txtStatCrashCnt.Location = new System.Drawing.Point(236, 112);
            this.txtStatCrashCnt.Name = "txtStatCrashCnt";
            this.txtStatCrashCnt.ReadOnly = true;
            this.txtStatCrashCnt.Size = new System.Drawing.Size(51, 20);
            this.txtStatCrashCnt.TabIndex = 15;
            this.txtStatCrashCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Crashes";
            // 
            // txtStatFailPct
            // 
            this.txtStatFailPct.Location = new System.Drawing.Point(293, 88);
            this.txtStatFailPct.Name = "txtStatFailPct";
            this.txtStatFailPct.ReadOnly = true;
            this.txtStatFailPct.Size = new System.Drawing.Size(34, 20);
            this.txtStatFailPct.TabIndex = 13;
            this.txtStatFailPct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtStatFailCnt
            // 
            this.txtStatFailCnt.Location = new System.Drawing.Point(236, 88);
            this.txtStatFailCnt.Name = "txtStatFailCnt";
            this.txtStatFailCnt.ReadOnly = true;
            this.txtStatFailCnt.Size = new System.Drawing.Size(51, 20);
            this.txtStatFailCnt.TabIndex = 12;
            this.txtStatFailCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Failures";
            // 
            // txtStatSecPerDay
            // 
            this.txtStatSecPerDay.Location = new System.Drawing.Point(121, 136);
            this.txtStatSecPerDay.Name = "txtStatSecPerDay";
            this.txtStatSecPerDay.ReadOnly = true;
            this.txtStatSecPerDay.Size = new System.Drawing.Size(51, 20);
            this.txtStatSecPerDay.TabIndex = 10;
            this.txtStatSecPerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtStatAvgExecTime
            // 
            this.txtStatAvgExecTime.Location = new System.Drawing.Point(121, 112);
            this.txtStatAvgExecTime.Name = "txtStatAvgExecTime";
            this.txtStatAvgExecTime.ReadOnly = true;
            this.txtStatAvgExecTime.Size = new System.Drawing.Size(51, 20);
            this.txtStatAvgExecTime.TabIndex = 9;
            this.txtStatAvgExecTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtStatExecCnt
            // 
            this.txtStatExecCnt.Location = new System.Drawing.Point(121, 88);
            this.txtStatExecCnt.Name = "txtStatExecCnt";
            this.txtStatExecCnt.ReadOnly = true;
            this.txtStatExecCnt.Size = new System.Drawing.Size(51, 20);
            this.txtStatExecCnt.TabIndex = 7;
            this.txtStatExecCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtStatModified
            // 
            this.txtStatModified.Location = new System.Drawing.Point(121, 64);
            this.txtStatModified.Name = "txtStatModified";
            this.txtStatModified.ReadOnly = true;
            this.txtStatModified.Size = new System.Drawing.Size(109, 20);
            this.txtStatModified.TabIndex = 6;
            // 
            // txtStatCreated
            // 
            this.txtStatCreated.Location = new System.Drawing.Point(121, 40);
            this.txtStatCreated.Name = "txtStatCreated";
            this.txtStatCreated.ReadOnly = true;
            this.txtStatCreated.Size = new System.Drawing.Size(109, 20);
            this.txtStatCreated.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Exec.Time / Day (s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Avg.Exec.Time (ms)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last executed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "First executed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Execution Count";
            // 
            // dock
            // 
            this.dock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dock.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dock.Location = new System.Drawing.Point(13, 41);
            this.dock.Name = "dock";
            this.dock.Size = new System.Drawing.Size(1079, 669);
            this.dock.TabIndex = 32;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(67, 22);
            this.toolStripButton1.Text = "SaveDocks";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);

            //
            // tsmiHighlight
            //
            this.tsmiHighlight.Checked = true;
            this.tsmiHighlight.CheckOnClick = true;
            this.tsmiHighlight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiHighlight.Name = "tsmiHighlight";
            this.tsmiHighlight.Size = new System.Drawing.Size(202, 22);
            this.tsmiHighlight.Text = "Highlight identical cells";
            this.tsmiHighlight.Click += new System.EventHandler(this.tsmiHighlight_Click);
            // 
            // PluginTraceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dock);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.toolStripMain);
            this.Name = "PluginTraceViewer";
            this.Size = new System.Drawing.Size(1114, 728);
            this.ConnectionUpdated += new XrmToolBox.Extensibility.PluginControlBase.ConnectionUpdatedHandler(this.PluginTraceViewer_ConnectionUpdated);
            this.Load += new System.EventHandler(this.PluginTraceViewer_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.groupFilter.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            this.panelOperationFilter.ResumeLayout(false);
            this.panelOperationFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crmGridView)).EndInit();
            this.contextMenuGridView.ResumeLayout(false);
            this.splitContainerRight.Panel1.ResumeLayout(false);
            this.splitContainerRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).EndInit();
            this.splitContainerRight.ResumeLayout(false);
            this.groupTraceLog.ResumeLayout(false);
            this.groupTraceLog.PerformLayout();
            this.groupException.ResumeLayout(false);
            this.groupException.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelStatistics.ResumeLayout(false);
            this.groupStatistics.ResumeLayout(false);
            this.groupStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton tsbCloseThisTab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbAbout;
        private Xrm.CRMWinForm.CRMGridView crmGridView;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.NumericUpDown numRecords;
        private System.Windows.Forms.RadioButton rbModeAsync;
        private System.Windows.Forms.RadioButton rbModeSync;
        private System.Windows.Forms.RadioButton rbModeAll;
        private System.Windows.Forms.CheckBox chkExceptions;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.ComboBox comboMessage;
        private System.Windows.Forms.CheckBox chkMessage;
        private System.Windows.Forms.ComboBox comboPlugin;
        private System.Windows.Forms.CheckBox chkPlugin;
        private System.Windows.Forms.CheckBox checkDateTo;
        private System.Windows.Forms.CheckBox checkDateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.ComboBox comboEntity;
        private System.Windows.Forms.CheckBox chkEntity;
        private System.Windows.Forms.NumericUpDown numDurationMax;
        private System.Windows.Forms.NumericUpDown numDurationMin;
        private System.Windows.Forms.CheckBox chkRecords;
        private System.Windows.Forms.CheckBox chkDurationMax;
        private System.Windows.Forms.CheckBox chkDurationMin;
        private System.Windows.Forms.ToolStripButton buttonRetrieveLogs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton dropdownSave;
        private System.Windows.Forms.ToolStripMenuItem buttonSaveFilter;
        private System.Windows.Forms.ToolStripMenuItem buttonSaveLogs;
        private System.Windows.Forms.ToolStripDropDownButton buttonOpen;
        private System.Windows.Forms.ToolStripMenuItem buttonOpenFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem buttonOpenLogRecord;
        private System.Windows.Forms.Label labelTimeZone;
        private System.Windows.Forms.ContextMenuStrip contextMenuGridView;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteSelected;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteAll;
        private System.Windows.Forms.SplitContainer splitContainerRight;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.TextBox textException;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ToolStripMenuItem buttonOpenFXB;
        private System.Windows.Forms.ToolStripMenuItem buttonSaveQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox comboLogSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiCorrelation;
        private System.Windows.Forms.ToolStripMenuItem tsmiCorrelationSelectThis;
        private System.Windows.Forms.ToolStripMenuItem tsmiCorrelationId;
        private System.Windows.Forms.TextBox textCorrelationId;
        private System.Windows.Forms.CheckBox chkCorrelation;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterByCorrelation;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.Panel panelStatistics;
        private System.Windows.Forms.GroupBox groupStatistics;
        private System.Windows.Forms.TextBox txtStatSecPerDay;
        private System.Windows.Forms.TextBox txtStatAvgExecTime;
        private System.Windows.Forms.TextBox txtStatExecCnt;
        private System.Windows.Forms.TextBox txtStatModified;
        private System.Windows.Forms.TextBox txtStatCreated;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatFailPct;
        private System.Windows.Forms.TextBox txtStatFailCnt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStatCrashContrPct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStatCrashPct;
        private System.Windows.Forms.TextBox txtStatCrashCnt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStatTermOther;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtStatTermHandles;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStatTermMemory;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStatTermCPU;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripDropDownButton dropdownView;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewStatistics;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiWordWrap;
        private System.Windows.Forms.GroupBox groupTraceLog;
        private System.Windows.Forms.GroupBox groupException;
        private System.Windows.Forms.Panel panelOperationFilter;
        private System.Windows.Forms.RadioButton rbOperWF;
        private System.Windows.Forms.RadioButton rbOperPlugin;
        private System.Windows.Forms.RadioButton rbOperAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColCorrelation;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColStartTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColDuration;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColOperation;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColPlugin;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColDepth;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColMode;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColStage;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColRank;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColMessage;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColEntity;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColException;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColCorrelationId;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColRequestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn correlation;
        private System.Windows.Forms.DataGridViewTextBoxColumn performanceexecutionstarttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn performanceexecutionduration;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn typename;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepname;
        private System.Windows.Forms.DataGridViewTextBoxColumn depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn messagename;
        private System.Windows.Forms.DataGridViewTextBoxColumn primaryentity;
        private System.Windows.Forms.DataGridViewTextBoxColumn correlationid;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestid;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptionsummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn messagebody;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptiondetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColStep;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterBy;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterByEntity;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterByMessage;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterByPlugin;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPluginStats;
        private System.Windows.Forms.ToolStripMenuItem tsmiLocalTimes;
        private WeifenLuo.WinFormsUI.Docking.VS2005Theme vS2005Theme1;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dock;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem tsmiHighlight;
    }
}
