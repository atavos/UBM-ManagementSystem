namespace UBMMS
{
    partial class frmReAssign
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlUsers = new Telerik.WinControls.UI.RadDropDownList();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gdvDocuments = new Telerik.WinControls.UI.RadGridView();
            this.btnReassign = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlUsers)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocuments.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReassign)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.923345F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.07665F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(885, 574);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.49144F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.50856F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ddlUsers, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(879, 28);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ddlUsers
            // 
            this.ddlUsers.Location = new System.Drawing.Point(105, 4);
            this.ddlUsers.Name = "ddlUsers";
            this.ddlUsers.Size = new System.Drawing.Size(276, 20);
            this.ddlUsers.TabIndex = 1;
            this.ddlUsers.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlUsers_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.gdvDocuments, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnReassign, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 37);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.57304F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.426967F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(879, 534);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // gdvDocuments
            // 
            this.gdvDocuments.BackColor = System.Drawing.SystemColors.Control;
            this.gdvDocuments.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdvDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvDocuments.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gdvDocuments.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gdvDocuments.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gdvDocuments.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.gdvDocuments.MasterTemplate.AllowAddNewRow = false;
            this.gdvDocuments.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "tracking_id";
            gridViewTextBoxColumn1.HeaderText = "Tracking ID";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 110;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "customer_name";
            gridViewTextBoxColumn2.HeaderText = "Customer";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn2.Width = 209;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "id_project_code";
            gridViewTextBoxColumn3.HeaderText = "Project Code";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 117;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "document_type";
            gridViewTextBoxColumn4.HeaderText = "Document Type";
            gridViewTextBoxColumn4.Name = "column4";
            gridViewTextBoxColumn4.Width = 108;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.EnableHeaderCheckBox = true;
            gridViewCheckBoxColumn1.HeaderText = "Select";
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "column5";
            gridViewCheckBoxColumn1.Width = 70;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "referred";
            gridViewTextBoxColumn5.HeaderText = "Referred";
            gridViewTextBoxColumn5.Name = "column6";
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "op_date";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.HeaderText = "Uploaded";
            gridViewDateTimeColumn1.Name = "column7";
            gridViewDateTimeColumn1.Width = 100;
            this.gdvDocuments.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn5,
            gridViewDateTimeColumn1});
            sortDescriptor1.PropertyName = "column2";
            this.gdvDocuments.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.gdvDocuments.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gdvDocuments.Name = "gdvDocuments";
            this.gdvDocuments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gdvDocuments.Size = new System.Drawing.Size(873, 483);
            this.gdvDocuments.TabIndex = 0;
            this.gdvDocuments.Text = "radGridView1";
            // 
            // btnReassign
            // 
            this.btnReassign.Location = new System.Drawing.Point(3, 492);
            this.btnReassign.Name = "btnReassign";
            this.btnReassign.Size = new System.Drawing.Size(110, 24);
            this.btnReassign.TabIndex = 1;
            this.btnReassign.Text = "Save";
            this.btnReassign.Click += new System.EventHandler(this.btnReassign_Click);
            // 
            // frmReAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 574);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmReAssign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reassign Documents";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlUsers)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocuments.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReassign)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDropDownList ddlUsers;
        private Telerik.WinControls.UI.RadGridView gdvDocuments;
        private Telerik.WinControls.UI.RadButton btnReassign;
    }
}