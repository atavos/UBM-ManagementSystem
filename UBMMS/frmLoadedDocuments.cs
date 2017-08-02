using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UBMMS.Controller;
using UBMMS.DAL;
using Telerik.WinControls.Containers;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using System.IO;

namespace UBMMS
{
    public partial class frmLoadedDocuments : RadForm
    {
        private user user;
        public frmLoadedDocuments()
        {
            InitializeComponent();    
        }

        public frmLoadedDocuments(user u)
        {
            InitializeComponent();
            user = u;
            SetDateTimers();
            SetButton();
        }

        /// <summary>
        /// Restringe acesso para salvar documentos no MS
        /// </summary>
        private void SetButton()
        {
            if(user.id_team == 7 || user.id_team == 1)
            {
                btnSavetoMS.Enabled = true;
            }
            else
            {
                btnSavetoMS.Enabled = false;
            }
        }
        
        private void SetDateTimers()
        {
            dtpFrom.DateTimePickerElement.ShowTimePicker = true;
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.CustomFormat = "dd MMM yyyy HH:mm";
            (dtpFrom.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).DropDownMinSize = new Size(330, 350);
            dtpFrom.Value = DateTime.Now;

            dtpTo.DateTimePickerElement.ShowTimePicker = true;
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.CustomFormat = "dd MMM yyyy HH:mm";
            (dtpTo.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).DropDownMinSize = new Size(330, 350);
            dtpTo.Value = DateTime.Now;
        }

        private void btnGetDocuments_Click(object sender, EventArgs e)
        {           
            if(dtpFrom.Value<dtpTo.Value)
            {
                gdvDocuments.DataSource = UBMMSController.GetUploadedDocuments(dtpFrom.Value, dtpTo.Value);
            }
            else
            {
                MessageBox.Show("The date from is latter than the date to. Please review the selected period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void gdvDocuments_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            if(e.SummaryItem.Name =="Project Code")
            {
                int count = e.Group.ItemCount;
                e.FormatString = String.Format("{0}: {1} documents", e.Value,count );
            }
            if (e.SummaryItem.Name == "Document Type")
            {
                int count = e.Group.ItemCount;
                e.FormatString = String.Format("{0}: {1} documents", e.Value, count);
            }

        }

        private void btnSavetoMS_Click(object sender, EventArgs e)
        {
            List<log_documents> log = new List<log_documents>();
            List<document> doc = new List<document>();
            try
            {
                foreach(GridViewDataRowInfo item in gdvDocuments.Rows)
                {
                    document idoc = new document();
                    log_documents ilog = new log_documents();

                    idoc.tracking_id = item.Cells[0].Value.ToString();
                    idoc.id_project_code = item.Cells[2].Value.ToString();
                    idoc.document_type = item.Cells[3].Value.ToString();
                    idoc.id_team = 2;
                    idoc.finalized = false;
                    idoc.referred = false;

                    doc.Add(idoc);

                    ilog.tracking_id = idoc.tracking_id;
                    ilog.op_code = "Info Upload";
                    ilog.op_description = "Document Uploaded";
                    ilog.op_date = DateTime.Now;
                    ilog.op_user = user.id_user;
                    ilog.op_user_team = user.id_team;
                    ilog.op_refer_comments = item.Cells[5].Value.ToString();

                    log.Add(ilog);
                }
            }
           
            catch (Exception ex)
            {
                
            }
            DataTable output = UBMMSController.UploadDocumentsFromInfo(doc, log, user);
            gdvDocuments.DataSource = output;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (gdvDocuments.Rows.Count != 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV File (*.csv)|*.csv";
                try
                {
                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (StreamWriter sb = File.CreateText(sfd.FileName))
                        {
                            var headers = gdvDocuments.Columns.Cast<GridViewColumn>();
                            sb.WriteLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

                            foreach (GridViewRowInfo row in gdvDocuments.Rows)
                            {
                                var cells = row.Cells.Cast<GridViewCellInfo>();
                                sb.WriteLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
                            }
                        }
                        MessageBox.Show("Output exported to " + sfd.FileName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when trying to create " + sfd.FileName + "\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nothing to export, run the report first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    
    }
}
