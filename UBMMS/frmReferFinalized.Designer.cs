namespace UBMMS
{
    partial class frmReferFinalized
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rbSimple = new Telerik.WinControls.UI.RadRadioButton();
            this.rbList = new Telerik.WinControls.UI.RadRadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTrackingID = new Telerik.WinControls.UI.RadTextBox();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.gdvDocuments = new Telerik.WinControls.UI.RadGridView();
            this.btnRefer = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbSimple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbList)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrackingID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocuments.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefer)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gdvDocuments, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRefer, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 373);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search method:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.54321F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.45679F));
            this.tableLayoutPanel2.Controls.Add(this.rbSimple, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbList, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(105, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(402, 24);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // rbSimple
            // 
            this.rbSimple.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbSimple.Location = new System.Drawing.Point(3, 3);
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.Size = new System.Drawing.Size(54, 18);
            this.rbSimple.TabIndex = 0;
            this.rbSimple.Text = "Simple";
            this.rbSimple.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // rbList
            // 
            this.rbList.Enabled = false;
            this.rbList.Location = new System.Drawing.Point(69, 3);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(37, 18);
            this.rbList.TabIndex = 1;
            this.rbList.TabStop = false;
            this.rbList.Text = "List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tracking ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.60493F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.39506F));
            this.tableLayoutPanel3.Controls.Add(this.txtTrackingID, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSearch, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(105, 35);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(402, 29);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // txtTrackingID
            // 
            this.txtTrackingID.Location = new System.Drawing.Point(3, 3);
            this.txtTrackingID.Name = "txtTrackingID";
            this.txtTrackingID.Size = new System.Drawing.Size(281, 20);
            this.txtTrackingID.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.Location = new System.Drawing.Point(290, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gdvDocuments
            // 
            this.gdvDocuments.BackColor = System.Drawing.SystemColors.Control;
            this.gdvDocuments.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdvDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvDocuments.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gdvDocuments.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gdvDocuments.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gdvDocuments.Location = new System.Drawing.Point(105, 71);
            // 
            // 
            // 
            this.gdvDocuments.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "tracking_id";
            gridViewTextBoxColumn1.HeaderText = "Tracking ID";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 110;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "id_project_code";
            gridViewTextBoxColumn2.HeaderText = "Project Code";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 94;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "document_type";
            gridViewTextBoxColumn3.HeaderText = "Document Type";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 130;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "finalized";
            gridViewCheckBoxColumn1.HeaderText = "Verified";
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "column4";
            gridViewCheckBoxColumn1.Width = 57;
            this.gdvDocuments.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCheckBoxColumn1});
            this.gdvDocuments.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gdvDocuments.Name = "gdvDocuments";
            this.gdvDocuments.ReadOnly = true;
            this.gdvDocuments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gdvDocuments.Size = new System.Drawing.Size(402, 267);
            this.gdvDocuments.TabIndex = 7;
            this.gdvDocuments.Text = "radGridView1";
            // 
            // btnRefer
            // 
            this.btnRefer.Location = new System.Drawing.Point(105, 345);
            this.btnRefer.Name = "btnRefer";
            this.btnRefer.Size = new System.Drawing.Size(110, 24);
            this.btnRefer.TabIndex = 8;
            this.btnRefer.Text = "Refer";
            this.btnRefer.Click += new System.EventHandler(this.btnRefer_Click);
            // 
            // frmReferFinalized
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 373);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReferFinalized";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refer Document";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbSimple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbList)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrackingID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocuments.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadRadioButton rbSimple;
        private Telerik.WinControls.UI.RadRadioButton rbList;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadTextBox txtTrackingID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadGridView gdvDocuments;
        private Telerik.WinControls.UI.RadButton btnRefer;
    }
}