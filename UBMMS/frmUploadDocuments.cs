using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using UBMMS.Controller;
using UBMMS.DAL;

namespace UBMMS
{
    public partial class frmUploadDocuments : Form
    {
        private user user;
        public frmUploadDocuments()
        {
            InitializeComponent();
        }

        public frmUploadDocuments(user user)
        {
            InitializeComponent();
            this.user = user;
        }

        #region Events
        private void btnOpenFile_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                DALExcel dal = new DALExcel();
                DataTable dt = dal.ReadExcel(openFileDialog1.FileName, "xlsx");
                gdvDocuments.DataSource = dt;

                foreach (GridViewColumn item in gdvDocuments.Columns)
                {
                    item.BestFit();
                    item.Width = 250;
                }

                this.gdvDocuments.GroupDescriptors.Add(new GridGroupByExpression("PROJECT_CODE as ProjectCode format \"{0}: {1}\" Group By ProjectCode"));
                this.gdvDocuments.GroupDescriptors.Add(new GridGroupByExpression("DOCUMENT_TYPE as DocumentType format \"{0}: {1}\" Group By DocumentType"));
            }
        }

        /// <summary>
        /// Insert documents to MS using spreadsheet source
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUploadDocuments_Click(object sender, EventArgs e)
        {
            try
            {
                List<document> list = new List<document>();
                foreach (GridViewDataRowInfo item in gdvDocuments.Rows)
                {
                    string projectCode = item.Cells[0].Value.ToString();
                    string trackingId = item.Cells[1].Value.ToString().Substring(0, 8);
                    string documentType = item.Cells[2].Value.ToString();

                    document doc = new document();
                    doc.tracking_id = trackingId;
                    doc.id_project_code = projectCode;
                    doc.document_type = documentType;
                    list.Add(doc);
                }
                UBMMSController.InsertDocument(list, user);

                MessageBox.Show("Document(s) uploaded succesfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gdvDocuments.DataSource = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ":\n" + ex.InnerException.InnerException.Message);
            }
        }

        private void radGridView1_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            if (e.SummaryItem.Name == "DOCUMENT_TYPE")
            {
                int count = e.Group.ItemCount;
                int docs = 0;

                foreach (GridViewRowInfo row in e.Group)
                {
                    docs++;
                }
                e.FormatString = String.Format("{0}: {1} document(s).", e.Value, docs);
            }
        }

        private void btnDownloadTemplate_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
