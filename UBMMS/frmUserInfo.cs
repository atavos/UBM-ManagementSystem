using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.WinControls.UI;

namespace UBMMS
{
    public partial class frmUserInfo : Form
    {
        private DataTable dt;
        private string user;
        private string process;
        public frmUserInfo()
        {
            InitializeComponent();
        }

        public frmUserInfo(DataTable dt, string user, string process, int total)
        {
            InitializeComponent();
            this.dt = dt;
            this.user = user;
            this.process = process;
            LoadData();
        }

        private void LoadData()
        {
            var result = from r in dt.AsEnumerable()
                         where r.Field<string>("user_name") == user && r.Field<string>("op_code") == process
                         select r;

            CartesianArea area = this.rdProductivity.GetArea<CartesianArea>();
            area.ShowGrid = true;
            LinearAxis verticalAcix = new LinearAxis();
            verticalAcix.AxisType = AxisType.Second;
            CategoricalAxis horizontalAxis = new CategoricalAxis();

            DataTable table2 = new DataTable();
            table2.Columns.Add("user_name");
            table2.Columns.Add("customer_name");
            table2.Columns.Add("op_code");
            table2.Columns.Add("total");
            table2.Columns.Add("average");


            foreach (DataRow row in result)
            {
                DataTable table = new DataTable();
                table.Columns.Add("user_name");
                table.Columns.Add("customer_name");
                table.Columns.Add("op_code");
                table.Columns.Add("total");
                table.Columns.Add("average");

                table.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
                table2.Rows.Add(row[0], row[1], row[2], row[3], row[4]);

                BarSeries bar = new BarSeries("total", "customer_name");
                bar.Name = row[2].ToString();
                bar.HorizontalAxis = horizontalAxis;
                bar.VerticalAxis = verticalAcix;
                bar.ShowLabels = true;
                bar.DataSource = table;
                bar.BackColor = Color.SteelBlue;
                bar.BorderColor = Color.SteelBlue;
                rdProductivity.Series.Add(bar);
            }

            //rdProductivity.Area.View.Palette = KnownPalette.Cold;
            gdvProductivityInfo.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gdvProductivityInfo.DataSource = table2;

        }
    }
}
