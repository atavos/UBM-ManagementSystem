namespace UBMMS
{
    partial class frmDocsReceived
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
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblDocsActualTarget = new System.Windows.Forms.TableLayoutPanel();
            this.rdDocsTarget = new Telerik.WinControls.UI.RadChartView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbActual = new Telerik.WinControls.UI.RadCheckBox();
            this.cbTarget = new Telerik.WinControls.UI.RadCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdDocsReceived = new Telerik.WinControls.UI.RadChartView();
            this.tblMain.SuspendLayout();
            this.tblDocsActualTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdDocsTarget)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdDocsReceived)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.tblDocsActualTarget, 0, 0);
            this.tblMain.Controls.Add(this.rdDocsReceived, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(1259, 650);
            this.tblMain.TabIndex = 0;
            // 
            // tblDocsActualTarget
            // 
            this.tblDocsActualTarget.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblDocsActualTarget.ColumnCount = 2;
            this.tblDocsActualTarget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tblDocsActualTarget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblDocsActualTarget.Controls.Add(this.rdDocsTarget, 0, 0);
            this.tblDocsActualTarget.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tblDocsActualTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDocsActualTarget.Location = new System.Drawing.Point(3, 3);
            this.tblDocsActualTarget.Name = "tblDocsActualTarget";
            this.tblDocsActualTarget.RowCount = 1;
            this.tblDocsActualTarget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDocsActualTarget.Size = new System.Drawing.Size(1253, 304);
            this.tblDocsActualTarget.TabIndex = 1;
            // 
            // rdDocsTarget
            // 
            this.rdDocsTarget.AreaDesign = cartesianArea1;
            this.rdDocsTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdDocsTarget.Location = new System.Drawing.Point(4, 4);
            this.rdDocsTarget.Name = "rdDocsTarget";
            this.rdDocsTarget.ShowGrid = false;
            this.rdDocsTarget.Size = new System.Drawing.Size(1056, 296);
            this.rdDocsTarget.TabIndex = 0;
            this.rdDocsTarget.Text = "radChartView1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1067, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.7651F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.2349F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(182, 296);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cbActual, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbTarget, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(176, 247);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cbActual
            // 
            this.cbActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbActual.Location = new System.Drawing.Point(3, 3);
            this.cbActual.Name = "cbActual";
            this.cbActual.Size = new System.Drawing.Size(170, 24);
            this.cbActual.TabIndex = 0;
            this.cbActual.Text = "Current Month";
            this.cbActual.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.cbActual_ToggleStateChanged);
            // 
            // cbTarget
            // 
            this.cbTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTarget.Location = new System.Drawing.Point(3, 33);
            this.cbTarget.Name = "cbTarget";
            this.cbTarget.Size = new System.Drawing.Size(170, 211);
            this.cbTarget.TabIndex = 1;
            this.cbTarget.Text = "Previous Month";
            this.cbTarget.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.cbTarget_ToggleStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "OPTIONS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdDocsReceived
            // 
            this.rdDocsReceived.AreaDesign = cartesianArea2;
            this.rdDocsReceived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdDocsReceived.Location = new System.Drawing.Point(3, 313);
            this.rdDocsReceived.Name = "rdDocsReceived";
            this.rdDocsReceived.ShowGrid = false;
            this.rdDocsReceived.Size = new System.Drawing.Size(1253, 304);
            this.rdDocsReceived.TabIndex = 2;
            this.rdDocsReceived.Text = "radChartView1";
            this.rdDocsReceived.Drill += new Telerik.WinControls.UI.DrillEventHandler(this.rdDocsReceived_Drill_1);
            // 
            // frmDocsReceived
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 650);
            this.Controls.Add(this.tblMain);
            this.Name = "frmDocsReceived";
            this.Text = "Documents Received";
            this.tblMain.ResumeLayout(false);
            this.tblDocsActualTarget.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdDocsTarget)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdDocsReceived)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private Telerik.WinControls.UI.RadChartView rdDocsTarget;
        private System.Windows.Forms.TableLayoutPanel tblDocsActualTarget;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadCheckBox cbActual;
        private Telerik.WinControls.UI.RadCheckBox cbTarget;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadChartView rdDocsReceived;
    }
}