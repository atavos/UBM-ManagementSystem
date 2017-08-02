using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using UBMMS.DAL;

namespace UBMMS
{
    public partial class frmPortal : Form
    {
        private DataTable docsDay;
        private DataTable dtAvgCustomer;
        int month;
        int year;
        int day;

        public frmPortal()
        {
            InitializeComponent();
            LoadChart();
            LoadTopData();
            LoadBacklog();
        }

        private void LoadTopData()
        {
            DALDashboard dal = new DALDashboard();
            DataTable dtTotal = dal.TotalDocs();

            if(dtTotal.Rows.Count > 0)
            {
                radLabel5.Text = dtTotal.Rows[0][0].ToString();
            }

            DataTable dtTotalToday = dal.TotalDocsToday();

            if (dtTotalToday.Rows.Count > 0)
            {
                radLabel6.Text = dtTotalToday.Rows[0][0].ToString();
            }

            DataTable dtTotalBacklog = dal.TotaBacklog();

            if (dtTotalBacklog.Rows.Count > 0)
            {
                radLabel7.Text = dtTotalBacklog.Rows[0][0].ToString();
            }

            DataTable dtTotalProcess = dal.TotalProcess();

            if (dtTotalProcess.Rows.Count > 0)
            {
                radLabel8.Text = dtTotalProcess.Rows[0][0].ToString();
            }

            DataTable dtTotalProcessToday = dal.TotalProcessToday();

            if (dtTotalProcessToday.Rows.Count > 0)
            {
                radLabel10.Text = dtTotalProcessToday.Rows[0][0].ToString();
            }

            DataTable dtProd = new DataTable();
            dtProd = dal.UserProductivityToday();
            dtAvgCustomer = dal.UserAVGToday();
            gdvProductivity.DataSource = dtProd;
            gdvProductivity.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.gdvProductivity.ScreenTipNeeded += new Telerik.WinControls.ScreenTipNeededEventHandler(radGridView1_ScreenTipNeeded);


        }

        private void LoadChart()
        {

            DALDashboard dal = new DALDashboard();
            docsDay = dal.DocsReceivedByMonth(2016, 10);

            BarSeries bar = new BarSeries();
            bar.ValueMember = "total";
            bar.CategoryMember = "date";
            bar.DataSource = docsDay;

            rdDocsReceived.Views.AddNew();
            rdDocsReceived.Title = "DOCUMENTS RECEIVED PER DAY";
            rdDocsReceived.ShowTitle = true;
            DrillDownController drillController = new DrillDownController();
            rdDocsReceived.Controllers.Add(drillController);
            rdDocsReceived.ShowDrillNavigation = true;

            DateTimeContinuousAxis horizontalAxis = new DateTimeContinuousAxis();
            horizontalAxis.MajorStepUnit = Telerik.Charting.TimeInterval.Day;
            horizontalAxis.MajorStep = 1;
            horizontalAxis.LabelFormat = "{0:ddd-dd}";
            horizontalAxis.Title = "Day";

            LinearAxis verticalAxis = new LinearAxis();
            verticalAxis.AxisType = Telerik.Charting.AxisType.Second;
            verticalAxis.Title = "Number of documents";

            bar.HorizontalAxis = horizontalAxis;
            bar.VerticalAxis = verticalAxis;
            bar.ShowLabels = true;
            bar.BackColor = Color.SteelBlue;
            rdDocsReceived.Series.Add(bar);

            CartesianArea area = rdDocsReceived.GetArea<CartesianArea>();
            area.ShowGrid = true;

            rdDocsReceived.ShowItemToolTips = true;
        }

        private void LoadBacklog()
        {
            DALDashboard dal = new DALDashboard();
            DataTable dt = dal.TotalBacklogPerTeam();
            rdBacklog.Title = "TEAM'S QUEUE";
            rdBacklog.ShowTitle = true;

            foreach (DataRow item in dt.Rows)
            {
                BarSeries b = new BarSeries("total", "team_name");
                DataTable tbl = new DataTable();
                tbl.Columns.Add("team_name");
                tbl.Columns.Add("total");
                tbl.Rows.Add(item[0].ToString(), item[1].ToString());

                b.DataSource = tbl;
                

                CategoricalAxis horizontal = new CategoricalAxis();
                horizontal.Title = "Team";

                //b.HorizontalAxis = horizontal;
                b.ShowLabels = true;
                rdBacklog.Series.Add(b);
            }
            CartesianArea area = rdBacklog.GetArea<CartesianArea>();
            area.ShowGrid = true;
            area.Orientation = Orientation.Horizontal;

            rdBacklog.Area.View.Palette = KnownPalette.Warm;
            
        }

        private void rdDocsReceived_Drill(object sender, Telerik.WinControls.UI.DrillEventArgs e)
        {
            DALDashboard dal = new DALDashboard();
            rdDocsReceived.ShowTrackBall = false;

            CartesianSeries series = new BarSeries();

            DateTimeCategoricalAxis horizontalAxis = new DateTimeCategoricalAxis();
            CartesianArea area = e.View.GetArea<CartesianArea>();
            area.ShowGrid = true;

            CartesianGrid grid = area.GetGrid<CartesianGrid>();
            grid.DrawHorizontalStripes = true;
            grid.DrawVerticalStripes = true;

            rdDocsReceived.ShowTrackBall = false;

            switch (e.Level)
            {
                case 0:
                    series.DataSource = dal.DocsReceivedByMonth(2016, 9);
                    rdDocsReceived.Title = "DOCUMENTS RECEIVED PER DAY";
                    break;
                case 1:
                    if (e.SelectedPoint != null)
                    {
                        DateTime date = Convert.ToDateTime(((DataRowView)e.SelectedPoint.DataItem)[0]);
                        day = date.Day;
                        month = date.Month;
                        year = date.Year;
                    }
                    series.ValueMember = "total";
                    series.CategoryMember = "customer_name";

                    series.DataSource = dal.DocsReceivedByDayCustomer(year, month, day);
                    series.ShowLabels = true;
                    rdDocsReceived.Title = "DOCUMENTS RECEIVED PER CUSTOMER";

                    horizontalAxis.LabelFitMode = Telerik.Charting.AxisLabelFitMode.Rotate;
                    horizontalAxis.LabelRotationAngle = 310;
                    horizontalAxis.Title = "Customer";
                    //rdDocsReceived.ShowTrackBall = true;
                    grid.DrawVerticalStripes = true;
                    //SetTrackBall();
                    break;
                case 2:
                    MessageBox.Show("foi");
                    break;
            }
            e.View.Axes.Clear();
            series.HorizontalAxis = horizontalAxis;
            e.View.Series.Clear();
            e.View.Series.Add(series);
        }

        private void SetTrackBall()
        {
            ChartTrackballController trackBallElement = new ChartTrackballController();
            //trackBallElement.Element.TextAlignment = ContentAlignment.MiddleCenter;
            //trackBallElement.Element.BorderColor = Color.Black;
            trackBallElement.Element.ForeColor = Color.Black;
            //trackBallElement.Element.BackColor = Color.White;
            trackBallElement.Element.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid;
            //trackBallElement.Element.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            trackBallElement.Element.Padding = new Padding(3, 0, 3, 3);
            trackBallElement.PointFormatString = "{0}:{1} documents";
            trackBallElement.TextNeeded += new TextNeededEventHandler(trackBallElement_TextNeeded);
            this.rdDocsReceived.Controllers.Add(trackBallElement);
        }

        private void ShowScreenTipForCell(GridDataCellElement cell)
        {
            DataRowView row = (DataRowView)cell.RowInfo.DataBoundItem;
            RadOffice2007ScreenTipElement screenTip = new RadOffice2007ScreenTipElement();
            screenTip.CaptionLabel.Margin = new Padding(3);
            //Image carImage = (Image)row["CarPicture"];
            //screenTip.MainTextLabel.Image = carImage;
            //screenTip.MainTextLabel.ImageAlignment = ContentAlignment.MiddleCenter;
            //screenTip.MainTextLabel.Margin = new Padding(1, 0, 1, 0);
            //screenTip.MainTextLabel.Padding = new Padding(0, 0, 0, 3);
            //String text =  String.Format("MaxSpeed: {0}mphAcceleration 0-62mph: {1}secHorse Power: {2} bhp",
            //        row["MaxSpeed"], row["Acceleration"], row["HorsePower"]);
            String text = row["user_name"] + " processed\n " + row["total"];
            screenTip.CaptionLabel.Text = text;
            screenTip.MainTextLabel.Text = string.Empty;
            screenTip.EnableCustomSize = false;
            cell.ScreenTip = screenTip;
        } 

        void trackBallElement_TextNeeded(object sender, TextNeededEventArgs e)
        {
            e.Text = "" + e.Points[0].DataPoint.Label.ToString() + "\ndocuments";
        }

        private void rdBacklog_Click(object sender, EventArgs e)
        {
            
        }

        private void radGridView1_ScreenTipNeeded(object sender, Telerik.WinControls.ScreenTipNeededEventArgs e)
        {
            //GridDataCellElement cell = e.Item as GridDataCellElement;
            //if (cell != null)
            //{
            //    this.ShowScreenTipForCell(cell);
            //}
        }

        private void gdvProductivity_CellClick(object sender, GridViewCellEventArgs e)
        {
            if(gdvProductivity.SelectedRows.Count> 0)
            {
                string user = gdvProductivity.SelectedRows[0].Cells[0].Value.ToString();
                string process = gdvProductivity.SelectedRows[0].Cells[2].Value.ToString();
                int total = Convert.ToInt16(gdvProductivity.SelectedRows[0].Cells[3].Value.ToString());
                frmUserInfo f = new frmUserInfo(this.dtAvgCustomer, user, process, total);
                f.ShowDialog();
            }
        }
    }
}
