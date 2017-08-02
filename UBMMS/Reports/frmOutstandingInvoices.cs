using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.Pivot.Core;
using Telerik.Pivot.Core.Aggregates;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using UBMMS.Controller;
using UBMMS.DAL;

namespace UBMMS.Reports
{
    public partial class frmOutstandingInvoices : Form
    {
        DataTable dtOutstandingInvoices;
        DataTable dtAllProjects;
        DataTable dtGroups;
        public frmOutstandingInvoices()
        {
            InitializeComponent();
            SetWaitingBar();
            backgroundWorker1.RunWorkerAsync();
            SetDropDowns();
        }
        #region methods

        private void BasicDatatables()
        {
            dtAllProjects = UBMMSController.InfoLCMProjects();
            dtGroups = UBMMSController.InfoLCMGroups();
        }

        private void SetDropDowns()
        {
            dtpTo.Value = DateTime.Now;
            dtpTo.MaxDate = DateTime.Now;
            dtpFrom.Value = DateTime.Now;

            dtpFrom.DateTimePickerElement.ShowTimePicker = true;
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Culture = CultureInfo.InvariantCulture;
            dtpFrom.CustomFormat = "dd MMM yyyy HH:mm";
            (dtpFrom.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).DropDownMinSize = new Size(330, 350);

            dtpTo.DateTimePickerElement.ShowTimePicker = true;
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Culture = CultureInfo.InvariantCulture;
            dtpTo.CustomFormat = "dd MMM yyyy HH:mm";
            (dtpTo.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).DropDownMinSize = new Size(330, 350);
            dtpTo.Value = DateTime.Now;

            //ddlFilter.AutoCompleteMode = AutoCompleteMode.Suggest;
            //ddlFilter.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            ddlFilter.DropDownStyle = RadDropDownStyle.DropDownList;
            ddlFilter.DropDownSizingMode = SizingMode.UpDown;
            ddlFilter.DropDownMinSize = new Size(150, 235);
        }

        public void GetOustandingBills()
        {
            List<string> projectcodes = new List<string>();
            string status = ddlStatus.Text;

            //checa se o usuário selecionou linhas no gridview
            if (gdvSearch.SelectedRows.Count > 0)  //se sim, somente os project codes selecionados serão enviados
            {
                foreach (GridViewRowInfo item in gdvSearch.Rows)
                {
                    if (item.IsSelected)
                    {
                        string test = item.Cells[1].Value.ToString();
                        projectcodes.Add(item.Cells[1].Value.ToString());
                    }
                }
                dtOutstandingInvoices = UBMMSController.OutstandingInvoices(dtpFrom.Value, dtpTo.Value, projectcodes, status);
            }
            else //se não, todos os project codes são enviados
            {
                MessageBox.Show("No project codes selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }

        /// <summary>
        /// Configure UI of Waiting bar for Outstanding Invoices BW
        /// </summary>
        private void SetWaitingBar()
        {
            rwbCustomer.Size = new System.Drawing.Size(305, 30);
            DotsLineWaitingBarIndicatorElement dl1 = new DotsLineWaitingBarIndicatorElement();
            rwbCustomer.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.DotsLine;
            rwbCustomer.WaitingIndicators[0].Text = "Loading Projects";
            rwbCustomer.WaitingBarElement.TextElement.TextAlignment = ContentAlignment.MiddleCenter;
            rwbCustomer.WaitingIndicators[0].PositionOffset = new SizeF(0, -5);
            rwbCustomer.StartWaiting();
            //rwbCustomer.WaitingIndicators.Add(dl1);
            dl1.WaitingDirection = ProgressOrientation.Left;
            dl1.PositionOffset = new SizeF(0, 0);
            DotsLineWaitingBarIndicatorElement dl2 = new DotsLineWaitingBarIndicatorElement();
            rwbCustomer.WaitingIndicators.Add(dl2);
            dl2.WaitingDirection = ProgressOrientation.Left;
            dl2.PositionOffset = new SizeF(0, 0);


            radWaitingBar1.Left = (radGridView1.ClientRectangle.Width - radWaitingBar1.Width) / 2;
            radWaitingBar1.Top = (radWaitingBar1.ClientRectangle.Height - radWaitingBar1.Height) / 2;
            radWaitingBar1.Size = new System.Drawing.Size(200, 200);
            radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.DotsSpinner;
            //radWaitingBar1.StartWaiting();
            int radius = 20;
            int elementCount = 5;
            for (int i = 0; i < 4; i++)
            {
                radius += 10;
                elementCount += 1;
                DotsSpinnerWaitingBarIndicatorElement dsi = new DotsSpinnerWaitingBarIndicatorElement();
                radWaitingBar1.WaitingIndicators.Add(dsi);
                dsi.Radius = radius;
                dsi.ElementCount = elementCount;
                dsi.RotationDirection = (RotationDirection)(i % 2);
            }
            DotsLineWaitingBarIndicatorElement dli = new DotsLineWaitingBarIndicatorElement();
            radWaitingBar1.WaitingIndicators.Add(dli);
            dli.PositionOffset = new SizeF(0, 50);
            DotsLineWaitingBarIndicatorElement dli1 = new DotsLineWaitingBarIndicatorElement();
            radWaitingBar1.WaitingIndicators.Add(dli1);
            dli1.WaitingDirection = Telerik.WinControls.ProgressOrientation.Left;
            dli1.PositionOffset = new SizeF(0, -50);
            DotsLineWaitingBarIndicatorElement dli2 = new DotsLineWaitingBarIndicatorElement();
            radWaitingBar1.WaitingIndicators.Add(dli2);
            dli2.WaitingDirection = Telerik.WinControls.ProgressOrientation.Bottom;
            dli2.PositionOffset = new SizeF(50, 0);
            DotsLineWaitingBarIndicatorElement dli4 = new DotsLineWaitingBarIndicatorElement();
            radWaitingBar1.WaitingIndicators.Add(dli4);
            dli4.WaitingDirection = Telerik.WinControls.ProgressOrientation.Top;
            dli4.PositionOffset = new SizeF(-50, 0);
            radWaitingBar1.Location = new Point(10, 10);
            this.Controls.Add(radWaitingBar1);

        }
        #endregion methods

        #region events
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (ddlStatus.Text != "")
            {
                DialogResult r = MessageBox.Show("Running the report for " + gdvSearch.SelectedRows.Count.ToString() + " project codes\nAre you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r == DialogResult.OK)
                {
                    bw.RunWorkerAsync();

                    radWaitingBar1.StartWaiting();
                    btnSearch.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("You need to provide an invoce status", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void radGridView1_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            if (e.SummaryItem.Name == "Tracking ID")
            {
                int count = e.Group.ItemCount;
                e.FormatString = String.Format("{0}: {1} Status", e.Value, count);
            }
        }

        private void rbtGroup_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ddlFilter.Enabled = true;
            DataView view = new DataView(dtGroups);
            DataTable dt = new DataTable();
            dt = view.ToTable(true, "groupname", "uid");

            ddlFilter.DataSource = dt;
            ddlFilter.SelectedIndex = -1;
            ddlFilter.DisplayMember = "groupname";
            ddlFilter.ValueMember = "uid";
            gdvSearch.DataSource = null;
        }

        private void rbtAll_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            gdvSearch.DataSource = dtAllProjects;
            ddlFilter.Enabled = false;
        }

        private void ddlFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            gdvSearch.DataSource = null;
            if (rbtGroup.IsChecked == true)
            {
                try
                {
                    var filtered = dtGroups.AsEnumerable().Where(gr => gr.Field<string>("groupname").Contains(ddlFilter.Text)).CopyToDataTable();

                    gdvSearch.DataSource = filtered;
                }
                catch { }
            }
            if (ddlFilter.Text != "" && ddlFilter.Text!= "System.Data.DataRowView")
            {
                DialogResult r = MessageBox.Show("You want to select all the project codes for group " + ddlFilter.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    gdvSearch.SelectAll();
                }
            }
            lblProjectCodes.Text = "Number of Project Codes selected: " + gdvSearch.SelectedRows.Count.ToString();
        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BasicDatatables();
        }
        
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            rwbCustomer.StopWaiting();
            rwbCustomer.ResetWaiting();
            rwbCustomer.Visible = false;

            rbtAll.Enabled = true;
            rbtGroup.Enabled = true;
        }
        
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            GetOustandingBills();
        }
        
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            radGridView1.DataSource = dtOutstandingInvoices;
            radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;
            radGridView1.BestFitColumns(BestFitColumnMode.AllCells);

            radWaitingBar1.StopWaiting();
            btnSearch.Enabled = true;
            
        }
        
        private void gdvSearch_SelectionChanged(object sender, EventArgs e)
        {
            lblProjectCodes.Text = "Number of Project Codes selected: " + gdvSearch.SelectedRows.Count.ToString();
        }
        #endregion events

    }
}
