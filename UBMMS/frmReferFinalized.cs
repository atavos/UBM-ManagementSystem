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

namespace UBMMS
{
    public partial class frmReferFinalized : Form
    {
        private user user;
        private DateTime opStart;
        public frmReferFinalized()
        {
            InitializeComponent();
        }

        public frmReferFinalized(user u)
        {
            InitializeComponent();
            this.user = u;
            gdvDocuments.Columns[0].IsVisible = false;
            gdvDocuments.Columns[1].IsVisible = false;
            gdvDocuments.Columns[2].IsVisible = false;
            gdvDocuments.Columns[3].IsVisible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> docs = new List<string>();
            this.opStart = DateTime.Now;
            if (rbSimple.IsChecked)
            {
                docs.Add(txtTrackingID.Text);
            }
            else if(rbList.IsChecked)
            { }

            List<document> result = UBMMSController.SelectDocuments(docs);
            gdvDocuments.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gdvDocuments.DataSource = result;

            gdvDocuments.Columns[0].IsVisible = true;
            gdvDocuments.Columns[1].IsVisible = true;
            gdvDocuments.Columns[2].IsVisible = true;
            gdvDocuments.Columns[3].IsVisible = true;
        }

        private void btnRefer_Click(object sender, EventArgs e)
        {
            string trackingID = txtTrackingID.Text;
            frmRefer form = new frmRefer(trackingID, this.user, this.opStart);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.Dispose();
                this.Close();
            }
        }
    }
}
