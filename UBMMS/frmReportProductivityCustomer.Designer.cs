namespace UBMMS
{
    partial class frmReportProductivityCustomer
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
            this.dtpToDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dtpFromDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.rrbAll = new Telerik.WinControls.UI.RadRadioButton();
            this.rrbGroupsInfoLCM = new Telerik.WinControls.UI.RadRadioButton();
            this.rrbIndividualCustomer = new Telerik.WinControls.UI.RadRadioButton();
            this.ddlCustomer = new Telerik.WinControls.UI.RadDropDownList();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReport = new Telerik.WinControls.UI.RadButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.documentContainer2 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rgvSummary = new Telerik.WinControls.UI.RadGridView();
            this.rgvDetails = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            this.toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbGroupsInfoLCM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbIndividualCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer2)).BeginInit();
            this.documentContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            this.documentWindow1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvSummary.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDetails.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radDock1
            // 
            this.radDock1.ActiveWindow = this.toolWindow1;
            this.radDock1.CausesValidation = false;
            this.radDock1.Controls.Add(this.toolTabStrip1);
            this.radDock1.Controls.Add(this.documentContainer2);
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.IsCleanUpTarget = true;
            this.radDock1.Location = new System.Drawing.Point(0, 0);
            this.radDock1.MainDocumentContainer = this.documentContainer2;
            this.radDock1.Name = "radDock1";
            // 
            // 
            // 
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radDock1.Size = new System.Drawing.Size(1051, 577);
            this.radDock1.TabIndex = 2;
            this.radDock1.TabStop = false;
            this.radDock1.Text = "radDock1";
            this.radDock1.ThemeName = "TelerikMetroBlue";
            // 
            // toolWindow1
            // 
            this.toolWindow1.Caption = null;
            this.toolWindow1.Controls.Add(this.dtpToDate);
            this.toolWindow1.Controls.Add(this.dtpFromDate);
            this.toolWindow1.Controls.Add(this.rrbAll);
            this.toolWindow1.Controls.Add(this.rrbGroupsInfoLCM);
            this.toolWindow1.Controls.Add(this.rrbIndividualCustomer);
            this.toolWindow1.Controls.Add(this.ddlCustomer);
            this.toolWindow1.Controls.Add(this.label2);
            this.toolWindow1.Controls.Add(this.btnReport);
            this.toolWindow1.Controls.Add(this.label4);
            this.toolWindow1.Controls.Add(this.label3);
            this.toolWindow1.Controls.Add(this.label1);
            this.toolWindow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.toolWindow1.Location = new System.Drawing.Point(1, 30);
            this.toolWindow1.Name = "toolWindow1";
            this.toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Hidden;
            this.toolWindow1.Size = new System.Drawing.Size(301, 535);
            this.toolWindow1.Text = "Report Criteria";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(91, 166);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(191, 20);
            this.dtpToDate.TabIndex = 3;
            this.dtpToDate.TabStop = false;
            this.dtpToDate.Text = "07 December 2016";
            this.dtpToDate.Value = new System.DateTime(2016, 12, 7, 8, 20, 48, 950);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(91, 140);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(191, 20);
            this.dtpFromDate.TabIndex = 2;
            this.dtpFromDate.TabStop = false;
            this.dtpFromDate.Text = "07 December 2016";
            this.dtpFromDate.Value = new System.DateTime(2016, 12, 7, 8, 20, 48, 950);
            // 
            // rrbAll
            // 
            this.rrbAll.Location = new System.Drawing.Point(91, 62);
            this.rrbAll.Name = "rrbAll";
            this.rrbAll.Size = new System.Drawing.Size(33, 18);
            this.rrbAll.TabIndex = 0;
            this.rrbAll.Text = "All";
            this.rrbAll.CheckStateChanged += new System.EventHandler(this.rrbAll_CheckStateChanged);
            // 
            // rrbGroupsInfoLCM
            // 
            this.rrbGroupsInfoLCM.Location = new System.Drawing.Point(91, 38);
            this.rrbGroupsInfoLCM.Name = "rrbGroupsInfoLCM";
            this.rrbGroupsInfoLCM.Size = new System.Drawing.Size(117, 18);
            this.rrbGroupsInfoLCM.TabIndex = 0;
            this.rrbGroupsInfoLCM.Text = "Groups by InfoLCM";
            this.rrbGroupsInfoLCM.CheckStateChanged += new System.EventHandler(this.rrbGroupsInfoLCM_CheckStateChanged);
            // 
            // rrbIndividualCustomer
            // 
            this.rrbIndividualCustomer.Location = new System.Drawing.Point(91, 14);
            this.rrbIndividualCustomer.Name = "rrbIndividualCustomer";
            this.rrbIndividualCustomer.Size = new System.Drawing.Size(120, 18);
            this.rrbIndividualCustomer.TabIndex = 0;
            this.rrbIndividualCustomer.Text = "Individual Customer";
            this.rrbIndividualCustomer.CheckStateChanged += new System.EventHandler(this.rrbIndividualCustomer_CheckStateChanged);
            // 
            // ddlCustomer
            // 
            this.ddlCustomer.Enabled = false;
            this.ddlCustomer.Location = new System.Drawing.Point(91, 97);
            this.ddlCustomer.Name = "ddlCustomer";
            this.ddlCustomer.Size = new System.Drawing.Size(191, 20);
            this.ddlCustomer.TabIndex = 1;
            this.ddlCustomer.Text = "radDropDownList1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Report Type";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(172, 208);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(110, 24);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "To Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "From Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer:";
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.CanUpdateChildIndex = true;
            this.toolTabStrip1.CausesValidation = false;
            this.toolTabStrip1.Controls.Add(this.toolWindow1);
            this.toolTabStrip1.Location = new System.Drawing.Point(5, 5);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.Size = new System.Drawing.Size(303, 567);
            this.toolTabStrip1.SizeInfo.AbsoluteSize = new System.Drawing.Size(303, 200);
            this.toolTabStrip1.SizeInfo.SplitterCorrection = new System.Drawing.Size(103, 0);
            this.toolTabStrip1.TabIndex = 1;
            this.toolTabStrip1.TabStop = false;
            this.toolTabStrip1.ThemeName = "TelerikMetroBlue";
            // 
            // documentContainer2
            // 
            this.documentContainer2.Controls.Add(this.documentTabStrip1);
            this.documentContainer2.Name = "documentContainer2";
            // 
            // 
            // 
            this.documentContainer2.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.documentContainer2.SizeInfo.AbsoluteSize = new System.Drawing.Size(1025, 200);
            this.documentContainer2.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer2.SizeInfo.SplitterCorrection = new System.Drawing.Size(-103, 0);
            this.documentContainer2.TabIndex = 2;
            this.documentContainer2.ThemeName = "TelerikMetroBlue";
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.CanUpdateChildIndex = true;
            this.documentTabStrip1.Controls.Add(this.documentWindow1);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.documentTabStrip1.SelectedIndex = 0;
            this.documentTabStrip1.Size = new System.Drawing.Size(734, 567);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            this.documentTabStrip1.ThemeName = "TelerikMetroBlue";
            // 
            // documentWindow1
            // 
            this.documentWindow1.Controls.Add(this.tableLayoutPanel1);
            this.documentWindow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentWindow1.Location = new System.Drawing.Point(5, 32);
            this.documentWindow1.Name = "documentWindow1";
            this.documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.documentWindow1.Size = new System.Drawing.Size(724, 530);
            this.documentWindow1.Text = "Report Output";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rgvSummary, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rgvDetails, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(724, 530);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // rgvSummary
            // 
            this.rgvSummary.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.rgvSummary.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvSummary.Name = "rgvSummary";
            this.rgvSummary.Size = new System.Drawing.Size(356, 239);
            this.rgvSummary.TabIndex = 5;
            this.rgvSummary.Text = "radGridView1";
            // 
            // rgvDetails
            // 
            this.rgvDetails.Location = new System.Drawing.Point(365, 3);
            // 
            // 
            // 
            this.rgvDetails.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgvDetails.Name = "rgvDetails";
            this.rgvDetails.Size = new System.Drawing.Size(355, 239);
            this.rgvDetails.TabIndex = 6;
            this.rgvDetails.Text = "radGridView1";
            // 
            // frmReportProductivityCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 577);
            this.Controls.Add(this.radDock1);
            this.Name = "frmReportProductivityCustomer";
            this.Text = "Customer Productivity";
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            this.toolWindow1.ResumeLayout(false);
            this.toolWindow1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbGroupsInfoLCM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbIndividualCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer2)).EndInit();
            this.documentContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            this.documentWindow1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgvSummary.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDetails.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.RadRadioButton rrbAll;
        private Telerik.WinControls.UI.RadRadioButton rrbGroupsInfoLCM;
        private Telerik.WinControls.UI.RadRadioButton rrbIndividualCustomer;
        private Telerik.WinControls.UI.RadDropDownList ddlCustomer;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton btnReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer2;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.RadDateTimePicker dtpToDate;
        private Telerik.WinControls.UI.RadDateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadGridView rgvSummary;
        private Telerik.WinControls.UI.RadGridView rgvDetails;
    }
}