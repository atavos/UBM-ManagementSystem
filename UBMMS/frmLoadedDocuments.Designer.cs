namespace UBMMS
{
    partial class frmLoadedDocuments
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dtpFrom = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dtpTo = new Telerik.WinControls.UI.RadDateTimePicker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gdvDocuments = new Telerik.WinControls.UI.RadGridView();
            this.btnGetDocuments = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btnSavetoMS = new Telerik.WinControls.UI.RadButton();
            this.PanelContainer = new Telerik.WinControls.UI.DataEntryScrollablePanelContainer();
            this.btnExport = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocuments.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSavetoMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(12, 36);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(214, 20);
            this.dtpFrom.TabIndex = 0;
            this.dtpFrom.TabStop = false;
            this.dtpFrom.Text = "27 December 2016";
            this.dtpFrom.Value = new System.DateTime(2016, 12, 27, 14, 25, 38, 949);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(269, 36);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(215, 20);
            this.dtpTo.TabIndex = 1;
            this.dtpTo.TabStop = false;
            this.dtpTo.Text = "27 December 2016";
            this.dtpTo.Value = new System.DateTime(2016, 12, 27, 14, 25, 38, 949);
            // 
            // gdvDocuments
            // 
            this.gdvDocuments.BackColor = System.Drawing.SystemColors.Control;
            this.gdvDocuments.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdvDocuments.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gdvDocuments.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gdvDocuments.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gdvDocuments.Location = new System.Drawing.Point(12, 62);
            // 
            // 
            // 
            this.gdvDocuments.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.gdvDocuments.MasterTemplate.EnableFiltering = true;
            this.gdvDocuments.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gdvDocuments.Name = "gdvDocuments";
            this.gdvDocuments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gdvDocuments.Size = new System.Drawing.Size(776, 440);
            this.gdvDocuments.TabIndex = 3;
            this.gdvDocuments.Text = "radGridView1";
            this.gdvDocuments.GroupSummaryEvaluate += new Telerik.WinControls.UI.GroupSummaryEvaluateEventHandler(this.gdvDocuments_GroupSummaryEvaluate);
            // 
            // btnGetDocuments
            // 
            this.btnGetDocuments.Location = new System.Drawing.Point(503, 34);
            this.btnGetDocuments.Name = "btnGetDocuments";
            this.btnGetDocuments.Size = new System.Drawing.Size(110, 24);
            this.btnGetDocuments.TabIndex = 2;
            this.btnGetDocuments.Text = "View Documents";
            this.btnGetDocuments.Click += new System.EventHandler(this.btnGetDocuments_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(110, 18);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Date and Time From:";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(269, 12);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(97, 18);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Date and Time To:";
            // 
            // btnSavetoMS
            // 
            this.btnSavetoMS.Location = new System.Drawing.Point(653, 508);
            this.btnSavetoMS.Name = "btnSavetoMS";
            this.btnSavetoMS.Size = new System.Drawing.Size(110, 24);
            this.btnSavetoMS.TabIndex = 2;
            this.btnSavetoMS.Text = "Save to MS";
            this.btnSavetoMS.Click += new System.EventHandler(this.btnSavetoMS_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.AutoScroll = false;
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.None;
            this.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelContainer.Size = new System.Drawing.Size(298, 148);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(12, 508);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(110, 24);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export Data";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmLoadedDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSavetoMS);
            this.Controls.Add(this.btnGetDocuments);
            this.Controls.Add(this.gdvDocuments);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmLoadedDocuments";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loaded Documents";
            this.ThemeName = "TelerikMetroBlue";
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocuments.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSavetoMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDateTimePicker dtpFrom;
        private Telerik.WinControls.UI.RadDateTimePicker dtpTo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Telerik.WinControls.UI.RadGridView gdvDocuments;
        private Telerik.WinControls.UI.RadButton btnGetDocuments;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton btnSavetoMS;
        private Telerik.WinControls.UI.DataEntryScrollablePanelContainer PanelContainer;
        private Telerik.WinControls.UI.RadButton btnExport;
    }
}