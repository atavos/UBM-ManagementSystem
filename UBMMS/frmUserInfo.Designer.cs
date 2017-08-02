namespace UBMMS
{
    partial class frmUserInfo
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
            this.rdProductivity = new Telerik.WinControls.UI.RadChartView();
            this.gdvProductivityInfo = new Telerik.WinControls.UI.RadGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdProductivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProductivityInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProductivityInfo.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rdProductivity, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gdvProductivityInfo, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.1452F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.8548F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(507, 489);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rdProductivity
            // 
            this.rdProductivity.AreaDesign = cartesianArea1;
            this.rdProductivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdProductivity.Location = new System.Drawing.Point(3, 3);
            this.rdProductivity.Name = "rdProductivity";
            this.rdProductivity.ShowGrid = false;
            this.rdProductivity.Size = new System.Drawing.Size(501, 293);
            this.rdProductivity.TabIndex = 0;
            this.rdProductivity.Text = "radChartView1";
            // 
            // gdvProductivityInfo
            // 
            this.gdvProductivityInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvProductivityInfo.Location = new System.Drawing.Point(3, 302);
            // 
            // 
            // 
            this.gdvProductivityInfo.MasterTemplate.AllowAddNewRow = false;
            this.gdvProductivityInfo.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gdvProductivityInfo.Name = "gdvProductivityInfo";
            this.gdvProductivityInfo.ReadOnly = true;
            this.gdvProductivityInfo.Size = new System.Drawing.Size(501, 184);
            this.gdvProductivityInfo.TabIndex = 1;
            this.gdvProductivityInfo.Text = "radGridView1";
            this.gdvProductivityInfo.ThemeName = "TelerikMetroBlue";
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Info";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdProductivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProductivityInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProductivityInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadChartView rdProductivity;
        private Telerik.WinControls.UI.RadGridView gdvProductivityInfo;
    }
}