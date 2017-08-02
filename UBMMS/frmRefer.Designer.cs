namespace UBMMS
{
    partial class frmRefer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlReferCodes = new Telerik.WinControls.UI.RadDropDownList();
            this.ddlTeam = new Telerik.WinControls.UI.RadDropDownList();
            this.lblDocument = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefer = new Telerik.WinControls.UI.RadButton();
            this.txtComments = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlReferCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTeam)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefer)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ddlReferCodes, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ddlTeam, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDocument, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtComments, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 290);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Refer code:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Document:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ddlReferCodes
            // 
            this.ddlReferCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddlReferCodes.Location = new System.Drawing.Point(105, 71);
            this.ddlReferCodes.Name = "ddlReferCodes";
            this.ddlReferCodes.Size = new System.Drawing.Size(383, 29);
            this.ddlReferCodes.TabIndex = 6;
            // 
            // ddlTeam
            // 
            this.ddlTeam.Location = new System.Drawing.Point(105, 35);
            this.ddlTeam.Name = "ddlTeam";
            this.ddlTeam.Size = new System.Drawing.Size(234, 20);
            this.ddlTeam.TabIndex = 5;
            this.ddlTeam.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlTeam_SelectedIndexChanged);
            // 
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDocument.Location = new System.Drawing.Point(105, 1);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(383, 30);
            this.lblDocument.TabIndex = 11;
            this.lblDocument.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnRefer, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(105, 252);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(383, 34);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // btnRefer
            // 
            this.btnRefer.Location = new System.Drawing.Point(3, 3);
            this.btnRefer.Name = "btnRefer";
            this.btnRefer.Size = new System.Drawing.Size(94, 24);
            this.btnRefer.TabIndex = 0;
            this.btnRefer.Text = "Save";
            this.btnRefer.Click += new System.EventHandler(this.btnRefer_Click);
            // 
            // txtComments
            // 
            this.txtComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComments.Location = new System.Drawing.Point(105, 107);
            this.txtComments.MaxLength = 255;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(383, 138);
            this.txtComments.TabIndex = 10;
            this.txtComments.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(4, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 144);
            this.label5.TabIndex = 9;
            this.label5.Text = "Comments:";
            // 
            // frmRefer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 290);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRefer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refer Document";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRefer_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlReferCodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTeam)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadDropDownList ddlTeam;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadDropDownList ddlReferCodes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtComments;
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadButton btnRefer;
    }
}