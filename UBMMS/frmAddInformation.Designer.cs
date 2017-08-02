namespace UBMMS
{
    partial class frmAddInformation
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtReferComments = new System.Windows.Forms.RichTextBox();
            this.btnSaveInformation = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtReferComments, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveInformation, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(603, 340);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtReferComments
            // 
            this.txtReferComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReferComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtReferComments.Location = new System.Drawing.Point(3, 3);
            this.txtReferComments.MaxLength = 255;
            this.txtReferComments.Name = "txtReferComments";
            this.txtReferComments.Size = new System.Drawing.Size(597, 299);
            this.txtReferComments.TabIndex = 4;
            this.txtReferComments.Text = "";
            // 
            // btnSaveInformation
            // 
            this.btnSaveInformation.Location = new System.Drawing.Point(3, 308);
            this.btnSaveInformation.Name = "btnSaveInformation";
            this.btnSaveInformation.Size = new System.Drawing.Size(110, 24);
            this.btnSaveInformation.TabIndex = 5;
            this.btnSaveInformation.Text = "Save";
            this.btnSaveInformation.Click += new System.EventHandler(this.btnSaveInformation_Click);
            // 
            // frmAddInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 340);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Information";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox txtReferComments;
        private Telerik.WinControls.UI.RadButton btnSaveInformation;
    }
}