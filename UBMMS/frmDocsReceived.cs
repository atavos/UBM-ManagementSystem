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
using UBMMS.DAL;

namespace UBMMS
{
    public partial class frmDocsReceived : Form
    {
        private DateTimeContinuousAxis horizontalAxis;
        private RadItemDragDropManager dragDropMan1;
        int day, month, year = 0;
        public frmDocsReceived()
        {
            InitializeComponent();
            SetHorizontalAxis();
            SetupDocsActual();
            SetupDocsTarget();
            LoadChart();
           // dragDropMan1 = new RadItemDragDropManager(this.radListBox1, this.radListBox1.Items, this.radListBox2, this.radListBox2.Items);
        }

        private void SetupDocsActual()
        {
            DateTime firstDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);
            DateTime nextDay = firstDay.AddMonths(1);

            string from = "'" + firstDay.Year + "-" + firstDay.Month + "-" + firstDay.Day + "'";
            string to = "'" + nextDay.Year + "-" + nextDay.Month + "-" + nextDay.Day + "'";

            DALReports dal = new DALReports();
            DataTable dt = dal.DocumentsReceivedPerMonthTotal(from, to);
            DataTable dtAllDays = new DataTable();
            dtAllDays.Columns.Add("date", firstDay.GetType());
            dtAllDays.Columns.Add("total");

            for(int i = 1; i<= lastDay.Day; i++)
            {
                DateTime d = new DateTime(firstDay.Year, firstDay.Month, i);
                DataRow r = (from data in dt.AsEnumerable()
                            where data.Field<DateTime>("date") == d
                            select data).FirstOrDefault();
                if (r == null)
                    dtAllDays.Rows.Add(d, 0);
                else
                    dtAllDays.Rows.Add(Convert.ToDateTime(r[0].ToString()), r[1]);

            }

            //AreaSeries docsActualMonth = new AreaSeries();
            BarSeries docsActualMonth = new BarSeries();
            docsActualMonth.LegendTitle = "Actual";
            docsActualMonth.BackColor = Color.FromArgb(100, Color.FromArgb(27, 157, 222));
            docsActualMonth.BorderColor = Color.FromArgb(27, 157, 222);
            //naturalGas.DataMember = "date";
            docsActualMonth.ValueMember = "total";
            docsActualMonth.CategoryMember = "date";
            docsActualMonth.DataSource = dtAllDays;
            //naturalGas.VerticalAxis = verticalAxis;
            docsActualMonth.HorizontalAxis = horizontalAxis;
            docsActualMonth.ShowLabels = true;

            rdDocsTarget.Series.Add(docsActualMonth);

            CartesianArea area = this.rdDocsTarget.GetArea<CartesianArea>();
            area.ShowGrid = true;
            CartesianGrid grid = area.GetGrid<CartesianGrid>();
            grid.DrawHorizontalStripes = true;
            grid.DrawVerticalStripes = true;
        }

        private void SetupDocsTarget()
        {
            DateTime firstDay = new DateTime(DateTime.Now.Year, DateTime.Now.AddMonths(-1).Month, 1);
            DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);
            DateTime nextDay = firstDay.AddMonths(1);

            string from = "'" + firstDay.Year + "-" + firstDay.Month + "-" + firstDay.Day + "'";
            string to = "'" + nextDay.Year + "-" + nextDay.Month + "-" + nextDay.Day + "'";

            DALReports dal = new DALReports();
            DataTable dt = dal.DocumentsReceivedPerMonthTotal(from, to);
            DataTable dtAllDays = new DataTable();
            dtAllDays.Columns.Add("date", firstDay.GetType());
            dtAllDays.Columns.Add("total");

            for (int i = 1; i <= lastDay.Day; i++)
            {
                DateTime d = new DateTime(firstDay.Year, firstDay.Month, i);
                DataRow r = (from data in dt.AsEnumerable()
                             where data.Field<DateTime>("date") == d
                             select data).FirstOrDefault();

                int lastTargetDay = nextDay.AddMonths(1).AddDays(-1).Day;
                if (d.Day <= lastTargetDay)
                {
                    DateTime d2 = new DateTime(d.Year, d.Month + 1, d.Day);
                    if (r == null)
                        dtAllDays.Rows.Add(d2, 0);
                    else
                    {
                        DateTime aux = Convert.ToDateTime(r[0].ToString());
                        DateTime aux2 = new DateTime(aux.Year, aux.Month + 1, aux.Day);
                        dtAllDays.Rows.Add(aux2, r[1]);
                    }
                }

            }

            //AreaSeries docsActualMonth = new AreaSeries();
            LineSeries docsActualMonth = new LineSeries();
            docsActualMonth.LegendTitle = "Target";
            docsActualMonth.BackColor = Color.FromArgb(100, Color.FromArgb(245, 151, 0));
            docsActualMonth.BorderColor = Color.FromArgb(245, 151, 0);
            //naturalGas.DataMember = "date";
            docsActualMonth.ValueMember = "total";
            docsActualMonth.CategoryMember = "date";
            docsActualMonth.DataSource = dtAllDays;
            //naturalGas.VerticalAxis = verticalAxis;
            docsActualMonth.HorizontalAxis = horizontalAxis;
            //docsActualMonth.ShowLabels = true;

            rdDocsTarget.Series.Add(docsActualMonth);

            CartesianArea area = this.rdDocsTarget.GetArea<CartesianArea>();
            area.ShowGrid = true;
            CartesianGrid grid = area.GetGrid<CartesianGrid>();
            grid.DrawHorizontalStripes = true;
            grid.DrawVerticalStripes = true;
        }

        private void SetHorizontalAxis()
        {
            horizontalAxis = new DateTimeContinuousAxis();
            horizontalAxis.LabelFormat = "{0:ddd-dd}";
            horizontalAxis.VerticalLocation = AxisVerticalLocation.Bottom;
            horizontalAxis.MajorStep = 1;
            horizontalAxis.MajorStepUnit = TimeInterval.Day;
            horizontalAxis.LabelFitMode = AxisLabelFitMode.Rotate;
            horizontalAxis.LabelRotationAngle = 310;

            //rdDocsTarget.ShowLegend = true;
            rdDocsTarget.Title = "Docs Received in " + DateTime.Now.Month + "/" + DateTime.Now.Year + " : Current x Previous";
            rdDocsTarget.ShowTitle = true;

            this.cbActual.ButtonElement.TextElement.ForeColor = Color.FromArgb(27, 157, 222); 
            this.cbActual.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            this.cbTarget.ButtonElement.TextElement.ForeColor = Color.FromArgb(245, 151, 0);
            this.cbTarget.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            this.cbActual.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.cbTarget.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void cbActual_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.rdDocsTarget.Series.Count > 0)
            {
                this.rdDocsTarget.Series[0].IsVisible = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
                if (this.rdDocsTarget.Series[0].IsVisible)
                    this.rdDocsTarget.Series[0].ShowLabels = true;
                else
                    this.rdDocsTarget.Series[0].ShowLabels = false;
            }
        }

        private void cbTarget_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.rdDocsTarget.Series.Count > 1)
            {
                this.rdDocsTarget.Series[1].IsVisible = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
                if (this.rdDocsTarget.Series[1].IsVisible)
                    this.rdDocsTarget.Series[1].ShowLabels = true;
                else
                    this.rdDocsTarget.Series[1].ShowLabels = false;
            }
        }

        private void rdDocsReceived_Drill_1(object sender, DrillEventArgs e)
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
                    rdDocsReceived.Title = "Documents Received per Day";
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
                    rdDocsReceived.Title = "Documents Received per Customer";

                    horizontalAxis.LabelFitMode = Telerik.Charting.AxisLabelFitMode.Rotate;
                    horizontalAxis.LabelRotationAngle = 310;
                    horizontalAxis.Title = "Customer";
                    //rdDocsReceived.ShowTrackBall = true;
                    grid.DrawVerticalStripes = true;
                    //SetTrackBall();
                    break;
                case 2:
                    break;
            }
            e.View.Axes.Clear();
            series.HorizontalAxis = horizontalAxis;
            e.View.Series.Clear();
            e.View.Series.Add(series);
        }

        private void LoadChart()
        {

            DALReports dal = new DALReports();
            DataTable docsDay = dal.DocsReceivedByMonth(DateTime.Now.Year, DateTime.Now.Month);

            BarSeries bar = new BarSeries();
            bar.ValueMember = "total";
            bar.CategoryMember = "date";
            bar.DataSource = docsDay;

            rdDocsReceived.Views.AddNew();
            rdDocsReceived.Title = "Documents Received per Day";
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

    }
}
