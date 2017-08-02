namespace UBMMS.Reports
{
    partial class frmStampedInvoices
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.btnExport = new Telerik.WinControls.UI.RadButton();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.dtpTo = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dtpFrom = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.docWinCenters = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.stcCentres = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.pvtCenters = new Telerik.WinControls.UI.RadPivotGrid();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.gdvCenters = new Telerik.WinControls.UI.RadGridView();
            this.docWinCustomers = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.stcCustomers = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel3 = new Telerik.WinControls.UI.SplitPanel();
            this.pvtCustomers = new Telerik.WinControls.UI.RadPivotGrid();
            this.splitPanel4 = new Telerik.WinControls.UI.SplitPanel();
            this.gdvCustomers = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            this.toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            this.documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            this.docWinCenters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stcCentres)).BeginInit();
            this.stcCentres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pvtCenters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCenters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCenters.MasterTemplate)).BeginInit();
            this.docWinCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stcCustomers)).BeginInit();
            this.stcCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel3)).BeginInit();
            this.splitPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pvtCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel4)).BeginInit();
            this.splitPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCustomers.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radDock1
            // 
            this.radDock1.ActiveWindow = this.docWinCenters;
            this.radDock1.Controls.Add(this.toolTabStrip1);
            this.radDock1.Controls.Add(this.documentContainer1);
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.IsCleanUpTarget = true;
            this.radDock1.Location = new System.Drawing.Point(0, 0);
            this.radDock1.MainDocumentContainer = this.documentContainer1;
            this.radDock1.Name = "radDock1";
            this.radDock1.Padding = new System.Windows.Forms.Padding(0);
            // 
            // 
            // 
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radDock1.Size = new System.Drawing.Size(1176, 618);
            this.radDock1.TabIndex = 0;
            this.radDock1.TabStop = false;
            this.radDock1.Text = "radDock1";
            this.radDock1.ThemeName = "TelerikMetroBlue";
            // 
            // toolWindow1
            // 
            this.toolWindow1.Caption = null;
            this.toolWindow1.Controls.Add(this.btnExport);
            this.toolWindow1.Controls.Add(this.btnSearch);
            this.toolWindow1.Controls.Add(this.dtpTo);
            this.toolWindow1.Controls.Add(this.dtpFrom);
            this.toolWindow1.Controls.Add(this.radLabel2);
            this.toolWindow1.Controls.Add(this.radLabel1);
            this.toolWindow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolWindow1.Location = new System.Drawing.Point(1, 30);
            this.toolWindow1.Name = "toolWindow1";
            this.toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.toolWindow1.Size = new System.Drawing.Size(296, 586);
            this.toolWindow1.Text = "Search Criteria";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(172, 111);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(110, 24);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(172, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 24);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(118, 45);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(164, 20);
            this.dtpTo.TabIndex = 1;
            this.dtpTo.TabStop = false;
            this.dtpTo.Text = "30 December 2016";
            this.dtpTo.Value = new System.DateTime(2016, 12, 30, 14, 34, 21, 4);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(118, 19);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(164, 20);
            this.dtpFrom.TabIndex = 1;
            this.dtpFrom.TabStop = false;
            this.dtpFrom.Text = "30 December 2016";
            this.dtpFrom.Value = new System.DateTime(2016, 12, 30, 14, 34, 21, 4);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(11, 45);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(88, 18);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Date Loaded To:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(11, 19);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(101, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Date Loaded From:";
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.CanUpdateChildIndex = true;
            this.toolTabStrip1.Controls.Add(this.toolWindow1);
            this.toolTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.Size = new System.Drawing.Size(298, 618);
            this.toolTabStrip1.SizeInfo.AbsoluteSize = new System.Drawing.Size(298, 200);
            this.toolTabStrip1.SizeInfo.SplitterCorrection = new System.Drawing.Size(98, 0);
            this.toolTabStrip1.TabIndex = 1;
            this.toolTabStrip1.TabStop = false;
            this.toolTabStrip1.ThemeName = "TelerikMetroBlue";
            // 
            // documentContainer1
            // 
            this.documentContainer1.Controls.Add(this.documentTabStrip1);
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.documentContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(874, 200);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-98, 0);
            this.documentContainer1.TabIndex = 2;
            this.documentContainer1.ThemeName = "TelerikMetroBlue";
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.CanUpdateChildIndex = true;
            this.documentTabStrip1.Controls.Add(this.docWinCenters);
            this.documentTabStrip1.Controls.Add(this.docWinCustomers);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.documentTabStrip1.SelectedIndex = 0;
            this.documentTabStrip1.Size = new System.Drawing.Size(874, 618);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            this.documentTabStrip1.ThemeName = "TelerikMetroBlue";
            // 
            // docWinCenters
            // 
            this.docWinCenters.Controls.Add(this.stcCentres);
            this.docWinCenters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docWinCenters.Location = new System.Drawing.Point(5, 32);
            this.docWinCenters.Name = "docWinCenters";
            this.docWinCenters.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.docWinCenters.Size = new System.Drawing.Size(864, 581);
            this.docWinCenters.Text = "Centers";
            // 
            // stcCentres
            // 
            this.stcCentres.Controls.Add(this.splitPanel1);
            this.stcCentres.Controls.Add(this.splitPanel2);
            this.stcCentres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stcCentres.IsCleanUpTarget = true;
            this.stcCentres.Location = new System.Drawing.Point(0, 0);
            this.stcCentres.Name = "stcCentres";
            this.stcCentres.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.stcCentres.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.stcCentres.Size = new System.Drawing.Size(864, 581);
            this.stcCentres.TabIndex = 0;
            this.stcCentres.TabStop = false;
            this.stcCentres.Text = "radSplitContainer1";
            this.stcCentres.ThemeName = "TelerikMetroBlue";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.pvtCenters);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.splitPanel1.Size = new System.Drawing.Size(309, 581);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.1408669F, 0F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-136, 0);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            this.splitPanel1.ThemeName = "TelerikMetroBlue";
            // 
            // pvtCenters
            // 
            this.pvtCenters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pvtCenters.Location = new System.Drawing.Point(0, 0);
            this.pvtCenters.Name = "pvtCenters";
            this.pvtCenters.Size = new System.Drawing.Size(309, 581);
            this.pvtCenters.TabIndex = 0;
            this.pvtCenters.Text = "radPivotGrid1";
            this.pvtCenters.Click += new System.EventHandler(this.pvtCenters_Click);
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.gdvCenters);
            this.splitPanel2.Location = new System.Drawing.Point(313, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.splitPanel2.Size = new System.Drawing.Size(551, 581);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.1408669F, 0F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(136, 0);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            this.splitPanel2.ThemeName = "TelerikMetroBlue";
            // 
            // gdvCenters
            // 
            this.gdvCenters.BackColor = System.Drawing.Color.Transparent;
            this.gdvCenters.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdvCenters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvCenters.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gdvCenters.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gdvCenters.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gdvCenters.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gdvCenters.MasterTemplate.AllowAddNewRow = false;
            this.gdvCenters.MasterTemplate.EnableFiltering = true;
            this.gdvCenters.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gdvCenters.Name = "gdvCenters";
            this.gdvCenters.ReadOnly = true;
            this.gdvCenters.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gdvCenters.Size = new System.Drawing.Size(551, 581);
            this.gdvCenters.TabIndex = 0;
            this.gdvCenters.Text = "radGridView1";
            this.gdvCenters.GroupSummaryEvaluate += new Telerik.WinControls.UI.GroupSummaryEvaluateEventHandler(this.gdvCenters_GroupSummaryEvaluate);
            // 
            // docWinCustomers
            // 
            this.docWinCustomers.Controls.Add(this.stcCustomers);
            this.docWinCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docWinCustomers.Location = new System.Drawing.Point(5, 32);
            this.docWinCustomers.Name = "docWinCustomers";
            this.docWinCustomers.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.docWinCustomers.Size = new System.Drawing.Size(864, 581);
            this.docWinCustomers.Text = "Customers";
            // 
            // stcCustomers
            // 
            this.stcCustomers.Controls.Add(this.splitPanel3);
            this.stcCustomers.Controls.Add(this.splitPanel4);
            this.stcCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stcCustomers.IsCleanUpTarget = true;
            this.stcCustomers.Location = new System.Drawing.Point(0, 0);
            this.stcCustomers.Name = "stcCustomers";
            this.stcCustomers.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.stcCustomers.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.stcCustomers.Size = new System.Drawing.Size(864, 581);
            this.stcCustomers.TabIndex = 1;
            this.stcCustomers.TabStop = false;
            this.stcCustomers.Text = "radSplitContainer1";
            this.stcCustomers.ThemeName = "TelerikMetroBlue";
            // 
            // splitPanel3
            // 
            this.splitPanel3.Controls.Add(this.pvtCustomers);
            this.splitPanel3.Location = new System.Drawing.Point(0, 0);
            this.splitPanel3.Name = "splitPanel3";
            // 
            // 
            // 
            this.splitPanel3.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.splitPanel3.Size = new System.Drawing.Size(377, 581);
            this.splitPanel3.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.06140351F, 0F);
            this.splitPanel3.SizeInfo.SplitterCorrection = new System.Drawing.Size(-59, 0);
            this.splitPanel3.TabIndex = 0;
            this.splitPanel3.TabStop = false;
            this.splitPanel3.Text = "splitPanel3";
            this.splitPanel3.ThemeName = "TelerikMetroBlue";
            // 
            // pvtCustomers
            // 
            this.pvtCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pvtCustomers.Location = new System.Drawing.Point(0, 0);
            this.pvtCustomers.Name = "pvtCustomers";
            this.pvtCustomers.Size = new System.Drawing.Size(377, 581);
            this.pvtCustomers.TabIndex = 0;
            this.pvtCustomers.Text = "radPivotGrid1";
            this.pvtCustomers.Click += new System.EventHandler(this.pvtCustomers_Click);
            // 
            // splitPanel4
            // 
            this.splitPanel4.Controls.Add(this.gdvCustomers);
            this.splitPanel4.Location = new System.Drawing.Point(381, 0);
            this.splitPanel4.Name = "splitPanel4";
            // 
            // 
            // 
            this.splitPanel4.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.splitPanel4.Size = new System.Drawing.Size(483, 581);
            this.splitPanel4.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.06140351F, 0F);
            this.splitPanel4.SizeInfo.SplitterCorrection = new System.Drawing.Size(59, 0);
            this.splitPanel4.TabIndex = 1;
            this.splitPanel4.TabStop = false;
            this.splitPanel4.Text = "splitPanel4";
            this.splitPanel4.ThemeName = "TelerikMetroBlue";
            // 
            // gdvCustomers
            // 
            this.gdvCustomers.BackColor = System.Drawing.Color.Transparent;
            this.gdvCustomers.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvCustomers.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gdvCustomers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gdvCustomers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gdvCustomers.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gdvCustomers.MasterTemplate.AllowAddNewRow = false;
            this.gdvCustomers.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.gdvCustomers.MasterTemplate.EnableFiltering = true;
            this.gdvCustomers.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gdvCustomers.Name = "gdvCustomers";
            this.gdvCustomers.ReadOnly = true;
            this.gdvCustomers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gdvCustomers.Size = new System.Drawing.Size(483, 581);
            this.gdvCustomers.TabIndex = 0;
            this.gdvCustomers.Text = "radGridView1";
            this.gdvCustomers.GroupSummaryEvaluate += new Telerik.WinControls.UI.GroupSummaryEvaluateEventHandler(this.gdvCustomers_GroupSummaryEvaluate);
            // 
            // frmStampedInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 618);
            this.Controls.Add(this.radDock1);
            this.Name = "frmStampedInvoices";
            this.Text = "Invoices Stamped";
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            this.toolWindow1.ResumeLayout(false);
            this.toolWindow1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            this.documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            this.docWinCenters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stcCentres)).EndInit();
            this.stcCentres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pvtCenters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvCenters.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCenters)).EndInit();
            this.docWinCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stcCustomers)).EndInit();
            this.stcCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel3)).EndInit();
            this.splitPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pvtCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel4)).EndInit();
            this.splitPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvCustomers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentWindow docWinCenters;
        private Telerik.WinControls.UI.RadSplitContainer stcCentres;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.RadPivotGrid pvtCenters;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadGridView gdvCenters;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.RadButton btnExport;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadDateTimePicker dtpTo;
        private Telerik.WinControls.UI.RadDateTimePicker dtpFrom;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.DocumentWindow docWinCustomers;
        private Telerik.WinControls.UI.RadSplitContainer stcCustomers;
        private Telerik.WinControls.UI.SplitPanel splitPanel3;
        private Telerik.WinControls.UI.RadPivotGrid pvtCustomers;
        private Telerik.WinControls.UI.SplitPanel splitPanel4;
        private Telerik.WinControls.UI.RadGridView gdvCustomers;
    }
}