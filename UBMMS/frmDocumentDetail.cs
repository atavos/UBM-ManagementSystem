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
using UBMMS.Controller;
using UBMMS.DAL;

namespace UBMMS
{
    public partial class frmDocumentDetail : Form
    {
        private List<log_documents> logs;
        public frmDocumentDetail()
        {
            InitializeComponent();
        }
        /// <summary>
        /// recebe o trackingID e executa a busca
        /// </summary>
        /// <param name="documentID"></param>
        public frmDocumentDetail(string documentID)
        {
            InitializeComponent();
            txtTrackingID.Text = documentID;
            btnSearch.PerformClick();
        }
        #region Methods
        private void GetLog(string trackingID)
        {
            gdvLog.DataSource = null;
            //gdvLog.DataSource = UBMMSController.SelectLogsByTrackingID(trackingID);
            gdvLog.DataSource = UBMMSController.SelectLog(trackingID);
        }

        private void GetAllLogs()
        {
            List<string> ids = new List<string>();
            ids.Add(txtTrackingID.Text);

            logs = UBMMSController.SelectLogsByRangeOfIDs(ids);
        }
        #endregion

        #region Events
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetLog(txtTrackingID.Text);
            GetAllLogs();
        }

        private void gdvLog_Click(object sender, EventArgs e)   
        {
            if (gdvLog.SelectedRows.Count > 0)
            {
                try
                {
                    long id = Convert.ToInt64(gdvLog.SelectedRows[0].Cells[3].Value.ToString());
                    log_documents log = (from l in logs
                                         where l.id == id
                                         select l).First();
                    lblReferDescription.Text = log.op_description;
                    txtReferComments.Text = log.op_refer_comments;
                }
                catch (Exception ex)
                { }
            }
        }
        #endregion



    }
}
