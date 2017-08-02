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
using UBMMS.Controller;
using UBMMS.DAL;

namespace UBMMS
{
    public partial class frmProductivity : Form
    {
        private user user;
        public frmProductivity()
        {
            InitializeComponent();
        }

        public frmProductivity(user u)
        {
            InitializeComponent();
            this.user = u;
            FillProductivityChart();
            FillTeamQueueChart();
            SetLists();
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
        }

        #region Events

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillUserProductivity();
            FillUserDetails();
        }
        #endregion

        #region Methods
        private void FillProductivityChart()
        {
            DALReports dal = new DALReports();

            DateTimeContinuousAxis horizontalAxis = new DateTimeContinuousAxis();
            horizontalAxis.MajorStepUnit = Telerik.Charting.TimeInterval.Day;
            horizontalAxis.MajorStep = 1;
            horizontalAxis.LabelFormat = "{0:ddd-dd}";
            horizontalAxis.Title = "Day";
            horizontalAxis.LabelFitMode = AxisLabelFitMode.Rotate;
            horizontalAxis.LabelRotationAngle = 310;

            LinearAxis verticalAxis = new LinearAxis();
            verticalAxis.AxisType = AxisType.Second;
            verticalAxis.MajorStep = 50;

            if (this.user.id_team == 2 || this.user.id_team == 3)
            {
                DataTable process = dal.DocumentsProcessedLastWeek(this.user);
                LineSeries line = new LineSeries();
                line.LegendTitle = (this.user.id_team == 2) ? "PROCESS" : "VERIFY";
                line.PointSize = new SizeF(0, 0);
                line.BorderWidth = 2;
                line.DataSource = process;
                line.ValueMember = "total";
                line.CategoryMember = "date";
                line.LabelDistanceToPoint = 7;
                line.ShowLabels = true;

                line.HorizontalAxis = horizontalAxis;
                line.VerticalAxis = verticalAxis;

                this.rdTeamProcess.Series.Add(line);
            }

            DataTable refers = dal.DocumentsReferredLastWeek(this.user);
            LineSeries line2 = new LineSeries();
            line2.LegendTitle = "REFER";
            line2.PointSize = new SizeF(0, 0);
            line2.BorderWidth = 2;
            line2.DataSource = refers;
            line2.ValueMember = "total";
            line2.CategoryMember = "date";
            line2.LabelDistanceToPoint = -7;
            line2.ShowLabels = true;

            line2.HorizontalAxis = horizontalAxis;
            line2.VerticalAxis = verticalAxis;

            this.rdTeamProcess.Series.Add(line2);

            this.rdTeamProcess.ShowLegend = true;
            this.rdTeamProcess.Title = "Team Productivity - Last 7 days";
            this.rdTeamProcess.ShowTitle = true;
            this.rdTeamProcess.ChartElement.LegendPosition = LegendPosition.Right;
            this.rdTeamProcess.ChartElement.LegendElement.StackElement.Orientation = Orientation.Vertical;
            this.rdTeamProcess.View.Palette = KnownPalette.Metro;

            CartesianArea area = this.rdTeamProcess.GetArea<CartesianArea>();
            area.ShowGrid = true;
            CartesianGrid grid = area.GetGrid<CartesianGrid>();
            grid.DrawHorizontalStripes = true;
            grid.DrawVerticalStripes = true;

        }

        private void FillTeamQueueChart()
        {
            DALReports dal = new DALReports();

            DataTable queue = dal.DocumentsPending(this.user);

            long total = queue.AsEnumerable().Sum(x => x.Field<long>("total"));
            decimal totalP = total;

            DataTable dt = new DataTable();
            dt.Columns.Add("Queue");
            dt.Columns.Add("Total");

            foreach (DataRow item in queue.Rows)
            {
                string queueName = (item[0].ToString() == "0") ? "Normal" : "Refer";
                decimal percent = Convert.ToDecimal(item[1].ToString());
                decimal result = (percent / totalP) * 100;
                //dt.Rows.Add(queueName, result.ToString("0.00"));
                dt.Rows.Add(queueName, percent);
            }

            PieSeries pie = new PieSeries();
            pie.ShowLabels = true;
            pie.RadiusFactor = 0.9f;
            pie.Range = new AngleRange(270, 360);

            foreach (DataRow item in dt.Rows)
            {
                pie.DataPoints.Add(new PieDataPoint(Convert.ToDouble(item[1].ToString()), item[0].ToString()));
            }
            rdTeamQueue.Series.Add(pie);
            rdTeamQueue.ShowLegend = true;
            rdTeamQueue.Title = "Documents per Queue";
            rdTeamQueue.ShowTitle = true;
            rdTeamQueue.View.Palette = KnownPalette.Metro;

            gdvTeamQueue.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gdvTeamQueue.DataSource = dt;
        }

        private void SetLists()
        {
            List<user> l = UBMMSController.SelectUsersByTeam(this.user.id_team);
            ddlEmployee.DataSource = l;
            ddlEmployee.DisplayMember = "user_name";
            ddlEmployee.ValueMember = "id_user";

            ddlEmployee.Text = "";
        }

        private void FillUserProductivity()
        {
            DateTime dt1, dt2;
            string dateFrom, dateTo;
            gdvUserProductivity.MultiSelect = true;

            if (ddlEmployee.SelectedItem != null)
            {
                int idUser;
                bool res = int.TryParse(ddlEmployee.SelectedItem.Value.ToString(), out idUser);
                if (res)
                {
                    rdUserProductivity.View.Series.Clear();
                    rdUserProductivity.View.Axes.Clear();
                    DALReports dal = new DALReports();
                    dt1 = dtpFrom.Value;
                    dt2 = dtpTo.Value;

                    dateFrom = dt1.Year.ToString() + "-" + dt1.Month.ToString() + "-" + dt1.Day.ToString() + " 00:00:00";
                    dateTo = dt2.Year.ToString() + "-" + dt2.Month.ToString() + "-" + dt2.Day.ToString() + " 23:59:00";

                    DataTable dtProd = dal.UserProductivitySummary(idUser, dateFrom, dateTo);
                    gdvUserProductivity.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
                    gdvUserProductivity.DataSource = dtProd;

                    //DataTable dtProd2 = dal.UserProductivityRange(idUser, dateFrom, dateTo);

                    //var processes = from r in dtProd2.AsEnumerable()
                    //              where r.Field<string>("op_code") == "PROCESS" || r.Field<string>("op_code") == "VERIFY"
                    //              select r;
                    //var refers = from r in dtProd2.AsEnumerable()
                    //              where r.Field<string>("op_code") == "REFER" 
                    //              select r;

                    DateTimeContinuousAxis horizontalAxis = new DateTimeContinuousAxis();
                    horizontalAxis.MajorStepUnit = Telerik.Charting.TimeInterval.Day;
                    horizontalAxis.MajorStep = 1;
                    horizontalAxis.LabelFormat = "{0:ddd-dd}";
                    horizontalAxis.Title = "Day";
                    horizontalAxis.LabelFitMode = AxisLabelFitMode.Rotate;
                    horizontalAxis.LabelRotationAngle = 310;

                    DataTable tb1 = new DataTable();
                    tb1 = dal.UserProductivityRangeProcess(idUser, dateFrom, dateTo);

                    BarSeries bar = new BarSeries();
                    bar.DataSource = tb1;
                    bar.ValueMember = "total";
                    bar.CategoryMember = "date";
                    bar.LegendTitle = "Process/Verify";

                    LinearAxis verticalAxis = new LinearAxis();
                    verticalAxis.AxisType = Telerik.Charting.AxisType.Second;
                    verticalAxis.Title = "Number of documents";

                    
                    bar.HorizontalAxis = horizontalAxis;
                    bar.VerticalAxis = verticalAxis;
                    bar.ShowLabels = true;
                    bar.BackColor = Color.SteelBlue;
                    


                    DataTable tb2 = new DataTable();
                    tb2 = dal.UserProductivityRangeRefer(idUser, dateFrom, dateTo);
                        

                    BarSeries bar2 = new BarSeries();
                    bar2.ValueMember = "total";
                    bar2.CategoryMember = "date";
                    bar2.LegendTitle = "Refer";
                    bar2.DataSource = tb2;


                    bar2.HorizontalAxis = horizontalAxis;
                    bar2.VerticalAxis = verticalAxis;
                    bar2.ShowLabels = true;
                    bar2.BackColor = Color.LightSkyBlue;
                    bar2.BorderColor = Color.LightSkyBlue;

                    rdUserProductivity.Series.Add(bar);
                    rdUserProductivity.Series.Add(bar2);
                    rdUserProductivity.ShowLegend = true;
                }
            }
        }

        private void FillUserDetails()
        {
            DateTime dt1, dt2;
            string dateFrom, dateTo;
            gdvUserDetails.MultiSelect = true;

            if (ddlEmployee.SelectedItem != null)
            {
                int idUser;
                bool res = int.TryParse(ddlEmployee.SelectedItem.Value.ToString(), out idUser);
                if (res)
                {
                    this.gdvUserDetails.DataSource = null;
                    this.gdvUserDetails.Groups.Dispose();
                    DALReports dal = new DALReports();
                    dt1 = dtpFrom.Value;
                    dt2 = dtpTo.Value;

                    dateFrom = dt1.Year.ToString() + "-" + dt1.Month.ToString() + "-" + dt1.Day.ToString() + " 00:00:00";
                    dateTo = dt2.Year.ToString() + "-" + dt2.Month.ToString() + "-" + dt2.Day.ToString() + " 23:59:00";

                    DataTable dtProd = dal.UserProductivityByCustomer(idUser, dateFrom, dateTo);
                    gdvUserDetails.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
                    gdvUserDetails.DataSource = dtProd;
                    

                    this.gdvUserDetails.GroupDescriptors.Add(new GridGroupByExpression("op_code as op_code format \"{0}: {1}\" Group By op_code"));
                    this.gdvUserDetails.MasterTemplate.ExpandAllGroups();

                }
            }
        }
        #endregion


    }
}
