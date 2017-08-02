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
    public partial class frmAddInformation : Form
    {
        private string trackingID = "";
        private user u;
        private DateTime opStart;
        public frmAddInformation()
        {
            InitializeComponent();
        }

        public frmAddInformation(string trackingID, user u, DateTime opStart)
        {
            InitializeComponent();
            this.trackingID = trackingID;
            this.u = u;
            this.opStart = opStart;
        }

        private void btnSaveInformation_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan opDuration = DateTime.Now - opStart;
                UBMMSController.AddInformation(trackingID, u, txtReferComments.Text, opDuration);
                MessageBox.Show("The information was added to the document: " + trackingID, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
