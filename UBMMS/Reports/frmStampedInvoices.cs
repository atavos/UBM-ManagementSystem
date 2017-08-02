using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.Pivot.Core;
using Telerik.Pivot.Core.Aggregates;
using Telerik.WinControls.Export;
using Telerik.WinControls.UI;
using UBMMS.DAL;


namespace UBMMS.Reports
{
    public partial class frmStampedInvoices : Form
    {
        
        DataTable dtInvoicesStamped;
        DALReports dal = new DALReports();
        private bool pvtFirstRun = true;

        #region Methods
        public frmStampedInvoices()
        {
            InitializeComponent();
            SetDropDownLists();
        }

        /// <summary>
        /// set drop downs UI
        /// </summary>
        private void SetDropDownLists()
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

        }

        /// <summary>
        /// set the pvtcenters formatting 
        /// </summary>
        private void CentrePivotSettings()
        {
            if (pvtFirstRun == true)
            {
                pvtCenters.Refresh();
                pvtCenters.RowGroupDescriptions.Add(new DateTimeGroupDescription() { PropertyName = "Date Loaded", Step = DateTimeStep.Month, GroupComparer = new GroupNameComparer() });
                pvtCenters.ColumnGroupDescriptions.Add(new PropertyGroupDescription() { PropertyName = "Centre Name", GroupComparer = new GrandTotalComparer() });
                pvtCenters.RowGroupDescriptions.Add(new PropertyGroupDescription() { PropertyName = "Doc Type", GroupComparer = new GrandTotalComparer() });
                pvtCenters.AggregateDescriptions.Add(new PropertyAggregateDescription() { PropertyName = "Document ID", AggregateFunction = AggregateFunctions.Count });

            }
            pvtCenters.DataSource = dtInvoicesStamped;
            pvtCenters.DataMember = "Doc Type";

        }

        /// <summary>
        /// set the pvtcustomers formatting
        /// </summary>
        private void CustomerPivotSettings()
        {
            if (pvtFirstRun == true)
            {
                pvtCustomers.Refresh();
                pvtCustomers.RowGroupDescriptions.Add(new DateTimeGroupDescription() { PropertyName = "Date Loaded", Step = DateTimeStep.Month, GroupComparer = new GroupNameComparer() });
                pvtCustomers.ColumnGroupDescriptions.Add(new PropertyGroupDescription() { PropertyName = "Doc Type", GroupComparer = new GrandTotalComparer() });
                pvtCustomers.RowGroupDescriptions.Add(new PropertyGroupDescription() { PropertyName = "Customer", GroupComparer = new GrandTotalComparer() });
                pvtCustomers.AggregateDescriptions.Add(new PropertyAggregateDescription() { PropertyName = "Document ID", AggregateFunction = AggregateFunctions.Count });
            }
            pvtCustomers.DataSource = dtInvoicesStamped;
            pvtCustomers.DataMember = "Doc Type";
        }
        #endregion Methods

        #region events
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //set the hours for the query
            DateTime from = dtpFrom.Value/*.Date + new TimeSpan(00, 00, 00)*/;
            DateTime to = dtpTo.Value/*.Date + new TimeSpan(23, 59, 59)*/;

            double Limite = (dtpTo.Value - dtpFrom.Value).TotalDays;

            if (Limite < 60)
            {
                dtInvoicesStamped = dal.DocumentsStamped(from, to);
                CentrePivotSettings();

                CustomerPivotSettings();

                pvtFirstRun = false;
            }
            else
            {
                MessageBox.Show("You cannot run this report for a period longer than 60 days.\nYou tried to run it for " + Math.Truncate(Limite) + " days.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void pvtCenters_Click(object sender, EventArgs e)
        {
            var rowGroups = pvtCenters.PivotGridElement.GetRowGroups();
            var colGroups = pvtCenters.PivotGridElement.GetColumnGroups();
            DataTable res = null;

            foreach (PivotGroupNode col in colGroups)
            {
                foreach (PivotGroupNode row in rowGroups)
                {
                    var temp = row.Parent;
                    DateTime period;
                    try
                    {
                        if (pvtCenters.PivotGridElement.IsCellSelected(row, col))
                        {

                            //checa se nao é a celula com o grandtotal do pivot
                            if (col.Name != "GrandTotal" && row.Name != "GrandTotal")
                            {
                                //pega o mes da celula selecionada
                                period = Convert.ToDateTime("2016/" + DateTime.ParseExact(row.Parent.Name, "MMMM", CultureInfo.CurrentCulture).Month + "/01");


                                if (row.Name.Contains("Total") == false) // linha com doc type e center name ( nao é coluna grand total)
                                {
                                    res = (from rows in dtInvoicesStamped.AsEnumerable()
                                           where rows.Field<string>("Centre Name") == col.Name &&
                                           (rows.Field<string>("Doc Type") == row.Name
                                           && rows.Field<DateTime>("Date Loaded").Month == period.Month)
                                           select rows).CopyToDataTable();
                                    //MessageBox.Show("esperado doc type e centro, resultado = r." + row.Name + " c." + col.Name);
                                }
                                else if (row.Name.Contains("Total") == true) //linha de total do mes e coluna com centro
                                {
                                    res = (from rows in dtInvoicesStamped.AsEnumerable()
                                           where rows.Field<string>("Centre Name") == col.Name &&
                                           rows.Field<DateTime>("Date Loaded").Month == period.Month
                                           select rows).CopyToDataTable();
                                    //MessageBox.Show("esperado total mes e centro, resultado = r." + row.Name + " c." + col.Name);
                                }
                                else
                                {
                                    //MessageBox.Show("Inesperado, resultado = r." + row.Name + " c." + col.Name);
                                }

                            }
                            else if (col.Name == "GrandTotal" && row.Name != "GrandTotal")
                            {
                                period = Convert.ToDateTime("2016/" + DateTime.ParseExact(row.Parent.Name, "MMMM", CultureInfo.CurrentCulture).Month + "/01");
                                if (row.Name.Contains("Total") == false) // coluna de grand total e linha de document type
                                {
                                    res = (from rows in dtInvoicesStamped.AsEnumerable()
                                           where rows.Field<DateTime>("Date Loaded").Month == period.Month &&
                                           rows.Field<string>("Doc Type") == row.Name
                                           select rows).CopyToDataTable();
                                    //MessageBox.Show("Coluna de grand total" + col.Name + " e linha de document type " + row.Name);
                                }
                                else
                                {
                                    res = (from rows in dtInvoicesStamped.AsEnumerable()
                                           where rows.Field<DateTime>("Date Loaded").Month == period.Month
                                           select rows).CopyToDataTable();
                                    //MessageBox.Show("Coluna de grand total " + col.Name + "e lina de total " + row.Name);
                                }
                            }
                            else if (col.Name != "GrandTotal" && row.Name == "GrandTotal")
                            {
                                res = (from rows in dtInvoicesStamped.AsEnumerable()
                                       where rows.Field<string>("Centre Name") == col.Name
                                       select rows).CopyToDataTable();

                            }
                            else
                            {
                                res = dtInvoicesStamped;
                            }
                            gdvCenters.DataSource = res;
                            gdvCenters.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;
                            gdvCenters.BestFitColumns(BestFitColumnMode.AllCells);
                        }
                    }

                    catch (Exception)
                    {
                        //MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void pvtCustomers_Click(object sender, EventArgs e)
        {
            var rowGroups = pvtCustomers.PivotGridElement.GetRowGroups();
            var colGroups = pvtCustomers.PivotGridElement.GetColumnGroups();

            foreach (PivotGroupNode col in colGroups)
            {
                foreach (PivotGroupNode row in rowGroups)
                {
                    if (row.Group != null && col.Group != null)
                    {
                        var Value = this.pvtCustomers.PivotGridElement.GetAggregateValue(row.Group, col.Group, false, false);

                        try
                        {
                            
                            if (pvtCustomers.PivotGridElement.IsCellSelected(row, col))
                            {
                                DateTime period;
                                DataTable res = new DataTable();

                                //checa se nao é a celula com o grandtotal do pivot
                                if (col.Name != "GrandTotal" && row.Name != "GrandTotal")
                                {
                                    //pega o mes da celula selecionada
                                    period = Convert.ToDateTime("2016/" + DateTime.ParseExact(row.Parent.Name, "MMMM", CultureInfo.CurrentCulture).Month + "/01");

                                    if (row.Name.Contains("Total") == false) // linha com doc type e center name ( nao é coluna grand total)
                                    {
                                        res = (from rows in dtInvoicesStamped.AsEnumerable()
                                               where rows.Field<string>("Doc Type") == col.Name &&
                                               (rows.Field<string>("Customer") == row.Name
                                               && rows.Field<DateTime>("Date Loaded").Month == period.Month)
                                               select rows).CopyToDataTable();
                                        //MessageBox.Show("esperado doc type e centro, resultado = r." + row.Name + " c." + col.Name);
                                    }
                                    else if (row.Name.Contains("Total") == true) //linha de total do mes e coluna com centro
                                    {
                                        res = (from rows in dtInvoicesStamped.AsEnumerable()
                                               where rows.Field<string>("Doc Type") == col.Name &&
                                               rows.Field<DateTime>("Date Loaded").Month == period.Month
                                               select rows).CopyToDataTable();
                                        //MessageBox.Show("esperado total mes e centro, resultado = r." + row.Name + " c." + col.Name);
                                    }
                                    else
                                    {
                                        //MessageBox.Show("Inesperado, resultado = r." + row.Name + " c." + col.Name);
                                    }

                                }
                                else if (col.Name == "GrandTotal" && row.Name != "GrandTotal")
                                {
                                    period = Convert.ToDateTime("2016/" + DateTime.ParseExact(row.Parent.Name, "MMMM", CultureInfo.CurrentCulture).Month + "/01");
                                    if (row.Name.Contains("Total") == false) // coluna de grand total e linha de document type
                                    {
                                        res = (from rows in dtInvoicesStamped.AsEnumerable()
                                               where rows.Field<DateTime>("Date Loaded").Month == period.Month &&
                                               rows.Field<string>("Customer") == row.Name
                                               select rows).CopyToDataTable();
                                        //MessageBox.Show("Coluna de grand total" + col.Name + " e linha de document type " + row.Name);
                                    }
                                    else
                                    {
                                        res = (from rows in dtInvoicesStamped.AsEnumerable()
                                               where rows.Field<DateTime>("Date Loaded").Month == period.Month
                                               select rows).CopyToDataTable();
                                        //MessageBox.Show("Coluna de grand total " + col.Name + "e lina de total " + row.Name);
                                    }
                                }
                                else if (col.Name != "GrandTotal" && row.Name == "GrandTotal")
                                {
                                    res = (from rows in dtInvoicesStamped.AsEnumerable()
                                           where rows.Field<string>("Doc Type") == col.Name
                                           select rows).CopyToDataTable();
                                }
                                else
                                {
                                    res = dtInvoicesStamped;
                                }
                                gdvCustomers.DataSource = res;
                                gdvCustomers.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;
                                gdvCustomers.BestFitColumns(BestFitColumnMode.AllCells);

                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string[] file;
            Telerik.WinControls.UI.Export.PivotExportToExcelML exporterCenters = new Telerik.WinControls.UI.Export.PivotExportToExcelML(pvtCenters);
            Telerik.WinControls.UI.Export.PivotExportToExcelML exporterCustomers = new Telerik.WinControls.UI.Export.PivotExportToExcelML(pvtCustomers);
            exporterCenters.SheetName = "Centers";
            exporterCustomers.SheetName = "Customers";

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel ML|*.xls";
            saveFileDialog1.Title = "Export to File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    file = saveFileDialog1.FileName.Split('.');

                    exporterCenters.RunExport(file[0] + " - Centers Summary.xls");
                    exporterCustomers.RunExport(file[0] + " - Customers Summary.xls");

                    saveGridView(saveFileDialog1.FileName);

                    MessageBox.Show("Successfully exported", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch{}
                
            }

        }

        /// <summary>
        /// Exporta os gridviews
        /// </summary>
        /// <param name="filepath"></param>
        private void saveGridView(string filepath)
        {
            if (gdvCenters.Rows.Count > 0)
            {
                if (filepath != "")
                {
                    string ffilepath = filepath.Split('.')[0];
                    using (StreamWriter sb = File.CreateText(ffilepath + " - Center Details.csv"))
                    {
                        var headers = gdvCenters.Columns.Cast<GridViewColumn>();
                        sb.WriteLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

                        foreach (GridViewRowInfo row in gdvCenters.Rows)
                        {
                            var cells = row.Cells.Cast<GridViewCellInfo>();
                            sb.WriteLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
                        }
                    }

                }
                else
                {

                }
            }

            if (gdvCustomers.Rows.Count > 0)
            {
                if (filepath != "")
                {
                    string ffilepath = filepath.Split('.')[0];
                    using (StreamWriter sb = File.CreateText(ffilepath + " - Customers Details.csv"))
                    {
                        var headers = gdvCustomers.Columns.Cast<GridViewColumn>();
                        sb.WriteLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

                        foreach (GridViewRowInfo row in gdvCustomers.Rows)
                        {
                            var cells = row.Cells.Cast<GridViewCellInfo>();
                            sb.WriteLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
                        }
                    }

                }
                else
                {

                }

            }
        }

        private void gdvCustomers_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            if (e.SummaryItem.Name == e.Group.GroupDescriptor.GroupNames[0].PropertyName)
            {
                e.FormatString = String.Format("{0}: {1} items", e.Value, e.Group.ItemCount);
            }
        }

        private void gdvCenters_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            if (e.SummaryItem.Name == e.Group.GroupDescriptor.GroupNames[0].PropertyName)
            {
                e.FormatString = String.Format("{0}: {1} items", e.Value, e.Group.ItemCount);
            }
        }
        #endregion events
    }
}
