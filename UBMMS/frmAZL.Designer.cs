namespace UBMMS
{
    partial class frmAZL
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
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.dtpDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gdvAZL = new Telerik.WinControls.UI.RadGridView();
            this.gdvIDs = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            this.toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            this.documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            this.documentWindow1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAZL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAZL.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvIDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvIDs.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radDock1
            // 
            this.radDock1.ActiveWindow = this.toolWindow1;
            this.radDock1.CausesValidation = false;
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
            this.radDock1.Size = new System.Drawing.Size(1350, 662);
            this.radDock1.TabIndex = 0;
            this.radDock1.TabStop = false;
            this.radDock1.Text = "radDock1";
            this.radDock1.ThemeName = "TelerikMetroBlue";
            // 
            // toolWindow1
            // 
            this.toolWindow1.Caption = null;
            this.toolWindow1.Controls.Add(this.btnSearch);
            this.toolWindow1.Controls.Add(this.dtpDate);
            this.toolWindow1.Controls.Add(this.label1);
            this.toolWindow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.toolWindow1.Location = new System.Drawing.Point(1, 30);
            this.toolWindow1.Name = "toolWindow1";
            this.toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Hidden;
            this.toolWindow1.Size = new System.Drawing.Size(301, 630);
            this.toolWindow1.Text = "AZL - Search Options";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(188, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 24);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(79, 35);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(219, 20);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.TabStop = false;
            this.dtpDate.Text = "10/5/2016";
            this.dtpDate.Value = new System.DateTime(2016, 10, 5, 10, 22, 26, 990);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select date: ";
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.CanUpdateChildIndex = true;
            this.toolTabStrip1.CausesValidation = false;
            this.toolTabStrip1.Controls.Add(this.toolWindow1);
            this.toolTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.Size = new System.Drawing.Size(303, 662);
            this.toolTabStrip1.SizeInfo.AbsoluteSize = new System.Drawing.Size(303, 200);
            this.toolTabStrip1.SizeInfo.SplitterCorrection = new System.Drawing.Size(103, 0);
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
            this.documentContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(1025, 200);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-103, 0);
            this.documentContainer1.TabIndex = 2;
            this.documentContainer1.ThemeName = "TelerikMetroBlue";
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
            this.documentTabStrip1.Size = new System.Drawing.Size(1043, 662);
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
            this.documentWindow1.Size = new System.Drawing.Size(1033, 625);
            this.documentWindow1.Text = "AZL";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.gdvAZL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gdvIDs, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1033, 625);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gdvAZL
            // 
            this.gdvAZL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvAZL.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.gdvAZL.MasterTemplate.AllowAddNewRow = false;
            this.gdvAZL.MasterTemplate.AllowColumnReorder = false;
            this.gdvAZL.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gdvAZL.Name = "gdvAZL";
            this.gdvAZL.ReadOnly = true;
            this.gdvAZL.Size = new System.Drawing.Size(768, 584);
            this.gdvAZL.TabIndex = 0;
            this.gdvAZL.Text = "radGridView1";
            this.gdvAZL.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gdvAZL_CellClick);
            // 
            // gdvIDs
            // 
            this.gdvIDs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvIDs.Location = new System.Drawing.Point(777, 3);
            // 
            // 
            // 
            this.gdvIDs.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gdvIDs.Name = "gdvIDs";
            this.gdvIDs.Size = new System.Drawing.Size(253, 584);
            this.gdvIDs.TabIndex = 1;
            this.gdvIDs.Text = "radGridView1";
            // 
            // frmAZL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 662);
            this.Controls.Add(this.radDock1);
            this.Name = "frmAZL";
            this.Text = "AZL";
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            this.toolWindow1.ResumeLayout(false);
            this.toolWindow1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            this.documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            this.documentWindow1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvAZL.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAZL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvIDs.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvIDs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.RadDateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadGridView gdvAZL;
        private Telerik.WinControls.UI.RadGridView gdvIDs;
    }
}