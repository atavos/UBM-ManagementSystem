namespace UBMMS
{
    partial class frmUploadDocuments
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new Telerik.WinControls.UI.RadButton();
            this.gdvDocuments = new Telerik.WinControls.UI.RadGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUploadDocuments = new Telerik.WinControls.UI.RadButton();
            this.btnDownloadTemplate = new Telerik.WinControls.UI.RadButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocuments.MasterTemplate)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUploadDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownloadTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gdvDocuments, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.06616F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.93385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(877, 444);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(871, 65);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select file:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnOpenFile, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(78, 13);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(790, 29);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(586, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(595, 3);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(110, 23);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // gdvDocuments
            // 
            this.gdvDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvDocuments.Location = new System.Drawing.Point(3, 74);
            // 
            // 
            // 
            this.gdvDocuments.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.gdvDocuments.Name = "gdvDocuments";
            this.gdvDocuments.Size = new System.Drawing.Size(871, 316);
            this.gdvDocuments.TabIndex = 1;
            this.gdvDocuments.Text = "radGridView1";
            this.gdvDocuments.ThemeName = "TelerikMetroBlue";
            this.gdvDocuments.GroupSummaryEvaluate += new Telerik.WinControls.UI.GroupSummaryEvaluateEventHandler(this.radGridView1_GroupSummaryEvaluate);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnUploadDocuments, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnDownloadTemplate, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 396);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(871, 45);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btnUploadDocuments
            // 
            this.btnUploadDocuments.Location = new System.Drawing.Point(3, 3);
            this.btnUploadDocuments.Name = "btnUploadDocuments";
            this.btnUploadDocuments.Size = new System.Drawing.Size(94, 24);
            this.btnUploadDocuments.TabIndex = 0;
            this.btnUploadDocuments.Text = "Upload";
            this.btnUploadDocuments.Click += new System.EventHandler(this.btnUploadDocuments_Click);
            // 
            // btnDownloadTemplate
            // 
            this.btnDownloadTemplate.Location = new System.Drawing.Point(103, 3);
            this.btnDownloadTemplate.Name = "btnDownloadTemplate";
            this.btnDownloadTemplate.Size = new System.Drawing.Size(110, 24);
            this.btnDownloadTemplate.TabIndex = 1;
            this.btnDownloadTemplate.Text = "Download template";
            this.btnDownloadTemplate.Click += new System.EventHandler(this.btnDownloadTemplate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmUploadDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 444);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmUploadDocuments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload Documents";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocuments.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocuments)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnUploadDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownloadTemplate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Telerik.WinControls.UI.RadButton btnOpenFile;
        private Telerik.WinControls.UI.RadGridView gdvDocuments;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Telerik.WinControls.UI.RadButton btnUploadDocuments;
        private Telerik.WinControls.UI.RadButton btnDownloadTemplate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
    }
}