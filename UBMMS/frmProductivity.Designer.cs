namespace UBMMS
{
    partial class frmProductivity
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
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblTeamData = new System.Windows.Forms.TableLayoutPanel();
            this.rdTeamProcess = new Telerik.WinControls.UI.RadChartView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rdTeamQueue = new Telerik.WinControls.UI.RadChartView();
            this.gdvTeamQueue = new Telerik.WinControls.UI.RadGridView();
            this.tblUserData = new System.Windows.Forms.TableLayoutPanel();
            this.tblCriteria = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlEmployee = new Telerik.WinControls.UI.RadDropDownList();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dtpTo = new Telerik.WinControls.UI.RadDateTimePicker();
            this.tblUserProductivity = new System.Windows.Forms.TableLayoutPanel();
            this.rdUserProductivity = new Telerik.WinControls.UI.RadChartView();
            this.gdvUserProductivity = new Telerik.WinControls.UI.RadGridView();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.gdvUserDetails = new Telerik.WinControls.UI.RadGridView();
            this.tblMain.SuspendLayout();
            this.tblTeamData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdTeamProcess)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdTeamQueue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTeamQueue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTeamQueue.MasterTemplate)).BeginInit();
            this.tblUserData.SuspendLayout();
            this.tblCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo)).BeginInit();
            this.tblUserProductivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdUserProductivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUserProductivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUserProductivity.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUserDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUserDetails.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tblMain.Controls.Add(this.tblTeamData, 0, 0);
            this.tblMain.Controls.Add(this.tblUserData, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(1389, 601);
            this.tblMain.TabIndex = 0;
            // 
            // tblTeamData
            // 
            this.tblTeamData.ColumnCount = 1;
            this.tblTeamData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTeamData.Controls.Add(this.rdTeamProcess, 0, 0);
            this.tblTeamData.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tblTeamData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTeamData.Location = new System.Drawing.Point(4, 4);
            this.tblTeamData.Name = "tblTeamData";
            this.tblTeamData.RowCount = 3;
            this.tblTeamData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblTeamData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblTeamData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblTeamData.Size = new System.Drawing.Size(479, 593);
            this.tblTeamData.TabIndex = 0;
            // 
            // rdTeamProcess
            // 
            this.rdTeamProcess.AreaDesign = cartesianArea1;
            this.rdTeamProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdTeamProcess.Location = new System.Drawing.Point(3, 3);
            this.rdTeamProcess.Name = "rdTeamProcess";
            this.rdTeamProcess.ShowGrid = false;
            this.rdTeamProcess.Size = new System.Drawing.Size(473, 231);
            this.rdTeamProcess.TabIndex = 0;
            this.rdTeamProcess.Text = "radChartView1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rdTeamQueue, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gdvTeamQueue, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 240);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(473, 171);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // rdTeamQueue
            // 
            this.rdTeamQueue.AreaType = Telerik.WinControls.UI.ChartAreaType.Pie;
            this.rdTeamQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdTeamQueue.Location = new System.Drawing.Point(3, 3);
            this.rdTeamQueue.Name = "rdTeamQueue";
            this.rdTeamQueue.ShowGrid = false;
            this.rdTeamQueue.Size = new System.Drawing.Size(230, 165);
            this.rdTeamQueue.TabIndex = 1;
            this.rdTeamQueue.Text = "radChartView1";
            // 
            // gdvTeamQueue
            // 
            this.gdvTeamQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvTeamQueue.Location = new System.Drawing.Point(239, 3);
            // 
            // 
            // 
            this.gdvTeamQueue.MasterTemplate.AllowAddNewRow = false;
            this.gdvTeamQueue.MasterTemplate.AllowColumnReorder = false;
            this.gdvTeamQueue.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gdvTeamQueue.Name = "gdvTeamQueue";
            this.gdvTeamQueue.ReadOnly = true;
            this.gdvTeamQueue.Size = new System.Drawing.Size(231, 165);
            this.gdvTeamQueue.TabIndex = 2;
            this.gdvTeamQueue.Text = "radGridView1";
            // 
            // tblUserData
            // 
            this.tblUserData.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblUserData.ColumnCount = 1;
            this.tblUserData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblUserData.Controls.Add(this.tblCriteria, 0, 0);
            this.tblUserData.Controls.Add(this.tblUserProductivity, 0, 1);
            this.tblUserData.Controls.Add(this.gdvUserDetails, 0, 2);
            this.tblUserData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblUserData.Location = new System.Drawing.Point(490, 4);
            this.tblUserData.Name = "tblUserData";
            this.tblUserData.RowCount = 3;
            this.tblUserData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblUserData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblUserData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblUserData.Size = new System.Drawing.Size(895, 593);
            this.tblUserData.TabIndex = 1;
            // 
            // tblCriteria
            // 
            this.tblCriteria.ColumnCount = 8;
            this.tblCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tblCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tblCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tblCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tblCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblCriteria.Controls.Add(this.dtpTo, 6, 0);
            this.tblCriteria.Controls.Add(this.label1, 0, 0);
            this.tblCriteria.Controls.Add(this.ddlEmployee, 1, 0);
            this.tblCriteria.Controls.Add(this.label2, 3, 0);
            this.tblCriteria.Controls.Add(this.label3, 5, 0);
            this.tblCriteria.Controls.Add(this.dtpFrom, 4, 0);
            this.tblCriteria.Controls.Add(this.btnSearch, 7, 0);
            this.tblCriteria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCriteria.Location = new System.Drawing.Point(4, 4);
            this.tblCriteria.Name = "tblCriteria";
            this.tblCriteria.RowCount = 1;
            this.tblCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCriteria.Size = new System.Drawing.Size(887, 29);
            this.tblCriteria.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ddlEmployee
            // 
            this.ddlEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddlEmployee.Location = new System.Drawing.Point(78, 3);
            this.ddlEmployee.Name = "ddlEmployee";
            this.ddlEmployee.Size = new System.Drawing.Size(244, 20);
            this.ddlEmployee.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(378, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "From:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(553, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "To:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(428, 3);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(119, 20);
            this.dtpFrom.TabIndex = 4;
            this.dtpFrom.TabStop = false;
            this.dtpFrom.Text = "9/21/2016";
            this.dtpFrom.Value = new System.DateTime(2016, 9, 21, 11, 19, 20, 887);
            // 
            // dtpTo
            // 
            this.dtpTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(603, 3);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(119, 20);
            this.dtpTo.TabIndex = 5;
            this.dtpTo.TabStop = false;
            this.dtpTo.Text = "9/21/2016";
            this.dtpTo.Value = new System.DateTime(2016, 9, 21, 11, 19, 20, 887);
            // 
            // tblUserProductivity
            // 
            this.tblUserProductivity.ColumnCount = 2;
            this.tblUserProductivity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tblUserProductivity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblUserProductivity.Controls.Add(this.rdUserProductivity, 0, 0);
            this.tblUserProductivity.Controls.Add(this.gdvUserProductivity, 1, 0);
            this.tblUserProductivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblUserProductivity.Location = new System.Drawing.Point(4, 40);
            this.tblUserProductivity.Name = "tblUserProductivity";
            this.tblUserProductivity.RowCount = 1;
            this.tblUserProductivity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblUserProductivity.Size = new System.Drawing.Size(887, 271);
            this.tblUserProductivity.TabIndex = 1;
            // 
            // rdUserProductivity
            // 
            this.rdUserProductivity.AreaDesign = cartesianArea2;
            this.rdUserProductivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdUserProductivity.Location = new System.Drawing.Point(3, 3);
            this.rdUserProductivity.Name = "rdUserProductivity";
            this.rdUserProductivity.ShowGrid = false;
            this.rdUserProductivity.Size = new System.Drawing.Size(570, 265);
            this.rdUserProductivity.TabIndex = 0;
            this.rdUserProductivity.Text = "radChartView1";
            // 
            // gdvUserProductivity
            // 
            this.gdvUserProductivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvUserProductivity.Location = new System.Drawing.Point(579, 3);
            // 
            // 
            // 
            this.gdvUserProductivity.MasterTemplate.AllowAddNewRow = false;
            this.gdvUserProductivity.MasterTemplate.AllowColumnReorder = false;
            this.gdvUserProductivity.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gdvUserProductivity.Name = "gdvUserProductivity";
            this.gdvUserProductivity.ReadOnly = true;
            this.gdvUserProductivity.Size = new System.Drawing.Size(305, 265);
            this.gdvUserProductivity.TabIndex = 1;
            this.gdvUserProductivity.Text = "radGridView1";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(728, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gdvUserDetails
            // 
            this.gdvUserDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvUserDetails.Location = new System.Drawing.Point(4, 318);
            // 
            // 
            // 
            this.gdvUserDetails.MasterTemplate.AllowAddNewRow = false;
            this.gdvUserDetails.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.gdvUserDetails.Name = "gdvUserDetails";
            this.gdvUserDetails.ReadOnly = true;
            this.gdvUserDetails.Size = new System.Drawing.Size(887, 271);
            this.gdvUserDetails.TabIndex = 2;
            this.gdvUserDetails.Text = "radGridView1";
            // 
            // frmProductivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 601);
            this.Controls.Add(this.tblMain);
            this.Name = "frmProductivity";
            this.Text = "Productivity Report";
            this.tblMain.ResumeLayout(false);
            this.tblTeamData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdTeamProcess)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdTeamQueue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTeamQueue.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTeamQueue)).EndInit();
            this.tblUserData.ResumeLayout(false);
            this.tblCriteria.ResumeLayout(false);
            this.tblCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo)).EndInit();
            this.tblUserProductivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdUserProductivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUserProductivity.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUserProductivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUserDetails.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUserDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblTeamData;
        private Telerik.WinControls.UI.RadChartView rdTeamProcess;
        private Telerik.WinControls.UI.RadChartView rdTeamQueue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadGridView gdvTeamQueue;
        private System.Windows.Forms.TableLayoutPanel tblUserData;
        private System.Windows.Forms.TableLayoutPanel tblCriteria;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDropDownList ddlEmployee;
        private Telerik.WinControls.UI.RadDateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadDateTimePicker dtpFrom;
        private System.Windows.Forms.TableLayoutPanel tblUserProductivity;
        private Telerik.WinControls.UI.RadChartView rdUserProductivity;
        private Telerik.WinControls.UI.RadGridView gdvUserProductivity;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadGridView gdvUserDetails;
    }
}