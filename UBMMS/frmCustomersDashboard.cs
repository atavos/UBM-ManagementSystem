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
    public partial class frmCustomersDashboard : Form
    {
        private DALReports dal;
        public frmCustomersDashboard()
        {
            InitializeComponent();
            dal = new DALReports();
            SetCustomers();
        }

        #region Events

        private void btnOK_Click(object sender, EventArgs e)
        {
            int id = (int)ddlCustomers.SelectedItem.Value;

            SetDocsPerTeamChart(id);
            SetAging(id);
            SetDocumentDetails(id);
        }

        private void gdvDocumentsDetails_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (gdvDocumentsDetails.SelectedRows.Count > 0)
            {
                string trackingId = gdvDocumentsDetails.SelectedRows[0].Cells[3].Value.ToString();
                if (trackingId != "")
                {
                    frmDocumentDetail frm = new frmDocumentDetail(trackingId);
                    frm.ShowDialog();
                }
            }
        }
        #endregion

        #region Methods
        private void SetDocsPerTeamChart(int id)
        {
            rdDocsPerTeam.Series.Clear();

            DataTable table = dal.DocumentsPerTeam(id);

            if (table.Rows.Count > 0)
            {
                rdDocsPerTeam.Title = "Documents per Team";
                rdDocsPerTeam.ShowTitle = true;

                foreach (DataRow item in table.Rows)
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
                    rdDocsPerTeam.Series.Add(b);
                }
                CartesianArea area = rdDocsPerTeam.GetArea<CartesianArea>();
                area.ShowGrid = true;
                area.Orientation = Orientation.Horizontal;

                //rdDocsPerTeam.Area.View.Palette = KnownPalette.Warm;
                rdDocsPerTeam.Area.View.Palette = KnownPalette.Metro;
            }
        }

        private void SetAging(int id)
        {
            rdSLA.Series.Clear();

            DataTable table = dal.Aging(id);
            if (table.Rows.Count > 0)
            {
                int in_sla, out_sla;
                in_sla = out_sla = 0;

                foreach (DataRow row in table.Rows)
                {
                    if (Convert.ToInt16(row["aging"].ToString()) > 3)
                        out_sla++;
                    else
                        in_sla++;
                }

                DataTable table_sla = new DataTable();
                table_sla.Columns.Add("status");
                table_sla.Columns.Add("total");

                table_sla.Rows.Add("In SLA", in_sla);
                table_sla.Rows.Add("Out SLA", out_sla);

                PieSeries pie = new PieSeries();
                pie.ShowLabels = true;
                pie.RadiusFactor = 0.9f;
                pie.Range = new AngleRange(270, 360);

                foreach (DataRow item in table_sla.Rows)
                {
                    pie.DataPoints.Add(new PieDataPoint(Convert.ToDouble(item[1].ToString()), item[0].ToString()));
                }
                rdSLA.Series.Add(pie);
                rdSLA.ShowLegend = true;
                rdSLA.Title = "SLA";
                rdSLA.ShowTitle = true;
                rdSLA.View.Palette = KnownPalette.Metro;
            }


        }

        private void SetCustomers()
        {
            DALCustomer dal = new DALCustomer();
            List<customer> list = dal.SelectAll();

            ddlCustomers.DisplayMember = "customer_name";
            ddlCustomers.ValueMember = "id";
            ddlCustomers.DataSource = list;
        }

        private void SetDocumentDetails(int id)
        {
            gdvDocumentsDetails.DataSource = null;
            lblTotalDocuments.Text = "";
            
            DataTable table = dal.DocumentsDetails(id);
            if(table.Rows.Count > 0)
            {
                lblTotalDocuments.Text = table.Rows.Count.ToString();
                gdvDocumentsDetails.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
                gdvDocumentsDetails.MultiSelect = true;
                gdvDocumentsDetails.DataSource = table;
            }
                
        }
        #endregion


    }
}
