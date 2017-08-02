namespace UBMMS
{
    partial class frmCustomersDashboard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlCustomers = new Telerik.WinControls.UI.RadDropDownList();
            this.btnOK = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rdSLA = new Telerik.WinControls.UI.RadChartView();
            this.rdDocsPerTeam = new Telerik.WinControls.UI.RadChartView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.gdvDocumentsDetails = new Telerik.WinControls.UI.RadGridView();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalDocuments = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdSLA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdDocsPerTeam)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocumentsDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocumentsDetails.MasterTemplate)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1123, 595);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ddlCustomers, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOK, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1117, 29);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ddlCustomers
            // 
            this.ddlCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddlCustomers.Location = new System.Drawing.Point(68, 3);
            this.ddlCustomers.Name = "ddlCustomers";
            this.ddlCustomers.Size = new System.Drawing.Size(344, 23);
            this.ddlCustomers.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(418, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(74, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1117, 554);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.rdSLA, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rdDocsPerTeam, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(552, 548);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // rdSLA
            // 
            this.rdSLA.AreaType = Telerik.WinControls.UI.ChartAreaType.Pie;
            this.rdSLA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdSLA.Location = new System.Drawing.Point(3, 3);
            this.rdSLA.Name = "rdSLA";
            this.rdSLA.ShowGrid = false;
            this.rdSLA.Size = new System.Drawing.Size(546, 268);
            this.rdSLA.TabIndex = 0;
            this.rdSLA.Text = "radChartView1";
            // 
            // rdDocsPerTeam
            // 
            this.rdDocsPerTeam.AreaDesign = cartesianArea1;
            this.rdDocsPerTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdDocsPerTeam.Location = new System.Drawing.Point(3, 277);
            this.rdDocsPerTeam.Name = "rdDocsPerTeam";
            this.rdDocsPerTeam.ShowGrid = false;
            this.rdDocsPerTeam.Size = new System.Drawing.Size(546, 268);
            this.rdDocsPerTeam.TabIndex = 1;
            this.rdDocsPerTeam.Text = "radChartView2";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.gdvDocumentsDetails, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(561, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(553, 548);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // gdvDocumentsDetails
            // 
            this.gdvDocumentsDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvDocumentsDetails.Location = new System.Drawing.Point(3, 103);
            // 
            // 
            // 
            this.gdvDocumentsDetails.MasterTemplate.AllowAddNewRow = false;
            this.gdvDocumentsDetails.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gdvDocumentsDetails.Name = "gdvDocumentsDetails";
            this.gdvDocumentsDetails.ReadOnly = true;
            this.gdvDocumentsDetails.Size = new System.Drawing.Size(547, 442);
            this.gdvDocumentsDetails.TabIndex = 0;
            this.gdvDocumentsDetails.Text = "radGridView1";
            this.gdvDocumentsDetails.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gdvDocumentsDetails_CellClick);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(547, 94);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblTotalDocuments);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 88);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalDocuments
            // 
            this.lblTotalDocuments.AutoSize = true;
            this.lblTotalDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDocuments.ForeColor = System.Drawing.Color.White;
            this.lblTotalDocuments.Location = new System.Drawing.Point(2, 43);
            this.lblTotalDocuments.Name = "lblTotalDocuments";
            this.lblTotalDocuments.Size = new System.Drawing.Size(0, 24);
            this.lblTotalDocuments.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total number of documents:";
            // 
            // frmCustomersDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 595);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmCustomersDashboard";
            this.Text = "Customer\'s Dashboard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdSLA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdDocsPerTeam)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocumentsDetails.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocumentsDetails)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDropDownList ddlCustomers;
        private Telerik.WinControls.UI.RadButton btnOK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Telerik.WinControls.UI.RadChartView rdSLA;
        private Telerik.WinControls.UI.RadChartView rdDocsPerTeam;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Telerik.WinControls.UI.RadGridView gdvDocumentsDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalDocuments;
        private System.Windows.Forms.Label label2;
    }
}