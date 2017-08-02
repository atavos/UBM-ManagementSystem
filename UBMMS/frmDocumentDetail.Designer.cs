namespace UBMMS
{
    partial class frmDocumentDetail
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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tblDcoumentQueue = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblReferDescription = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReferComments = new System.Windows.Forms.RichTextBox();
            this.gdvLog = new Telerik.WinControls.UI.RadGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTrackingID = new Telerik.WinControls.UI.RadTextBox();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.tblDcoumentQueue.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvLog.MasterTemplate)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrackingID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tblDcoumentQueue
            // 
            this.tblDcoumentQueue.ColumnCount = 1;
            this.tblDcoumentQueue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDcoumentQueue.Controls.Add(this.tableLayoutPanel11, 0, 2);
            this.tblDcoumentQueue.Controls.Add(this.gdvLog, 0, 1);
            this.tblDcoumentQueue.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tblDcoumentQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDcoumentQueue.Location = new System.Drawing.Point(0, 0);
            this.tblDcoumentQueue.Name = "tblDcoumentQueue";
            this.tblDcoumentQueue.RowCount = 3;
            this.tblDcoumentQueue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblDcoumentQueue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDcoumentQueue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDcoumentQueue.Size = new System.Drawing.Size(715, 574);
            this.tblDcoumentQueue.TabIndex = 3;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel11.Controls.Add(this.lblReferDescription, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.txtReferComments, 0, 3);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 307);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 4;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(709, 264);
            this.tableLayoutPanel11.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(4, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(701, 30);
            this.label8.TabIndex = 2;
            this.label8.Text = "Refer comments:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReferDescription
            // 
            this.lblReferDescription.AutoSize = true;
            this.lblReferDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReferDescription.Location = new System.Drawing.Point(4, 32);
            this.lblReferDescription.Name = "lblReferDescription";
            this.lblReferDescription.Size = new System.Drawing.Size(701, 30);
            this.lblReferDescription.TabIndex = 1;
            this.lblReferDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(4, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(701, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Refer description:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReferComments
            // 
            this.txtReferComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReferComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtReferComments.Location = new System.Drawing.Point(4, 97);
            this.txtReferComments.Name = "txtReferComments";
            this.txtReferComments.ReadOnly = true;
            this.txtReferComments.Size = new System.Drawing.Size(701, 163);
            this.txtReferComments.TabIndex = 3;
            this.txtReferComments.Text = "";
            // 
            // gdvLog
            // 
            this.gdvLog.BackColor = System.Drawing.Color.White;
            this.gdvLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvLog.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gdvLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gdvLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gdvLog.Location = new System.Drawing.Point(3, 38);
            // 
            // 
            // 
            this.gdvLog.MasterTemplate.AllowAddNewRow = false;
            this.gdvLog.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "op_code";
            gridViewTextBoxColumn1.HeaderText = "Code";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 72;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "op_description";
            gridViewTextBoxColumn2.HeaderText = "Description";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 137;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "op_date";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "Date";
            gridViewDateTimeColumn1.Name = "column3";
            gridViewDateTimeColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewDateTimeColumn1.Width = 105;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "id";
            gridViewTextBoxColumn3.HeaderText = "Id";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "column4";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "user_name";
            gridViewTextBoxColumn4.HeaderText = "User Name";
            gridViewTextBoxColumn4.Name = "column5";
            gridViewTextBoxColumn4.Width = 135;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "team_name";
            gridViewTextBoxColumn5.HeaderText = "From Team";
            gridViewTextBoxColumn5.Name = "column6";
            gridViewTextBoxColumn5.Width = 137;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "destination_team";
            gridViewTextBoxColumn6.HeaderText = "To Team";
            gridViewTextBoxColumn6.Name = "column7";
            gridViewTextBoxColumn6.Width = 107;
            this.gdvLog.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.gdvLog.MasterTemplate.MultiSelect = true;
            sortDescriptor1.PropertyName = "column3";
            this.gdvLog.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.gdvLog.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gdvLog.Name = "gdvLog";
            this.gdvLog.ReadOnly = true;
            this.gdvLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gdvLog.Size = new System.Drawing.Size(709, 263);
            this.gdvLog.TabIndex = 0;
            this.gdvLog.Text = "radGridView1";
            this.gdvLog.Click += new System.EventHandler(this.gdvLog_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTrackingID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(709, 29);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tracking ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTrackingID
            // 
            this.txtTrackingID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTrackingID.Location = new System.Drawing.Point(103, 3);
            this.txtTrackingID.Name = "txtTrackingID";
            this.txtTrackingID.Size = new System.Drawing.Size(144, 23);
            this.txtTrackingID.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(253, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmDocumentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 574);
            this.Controls.Add(this.tblDcoumentQueue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDocumentDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document Details";
            this.tblDcoumentQueue.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvLog.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvLog)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrackingID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDcoumentQueue;
        private Telerik.WinControls.UI.RadGridView gdvLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblReferDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtReferComments;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox txtTrackingID;
        private Telerik.WinControls.UI.RadButton btnSearch;
    }
}