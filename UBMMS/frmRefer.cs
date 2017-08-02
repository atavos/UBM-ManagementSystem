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
    public partial class frmRefer : Form
    {
        private string trackingID;
        private user user;
        List<team> teams;
        private DateTime opStart;
        public frmRefer()
        {
            InitializeComponent();
        }

        public frmRefer(string trackingID, user u, DateTime opStart)
        {
            InitializeComponent();
            this.trackingID = trackingID;
            lblDocument.Text = this.trackingID;
            this.user = u;
            this.opStart = opStart;
            SetLists();
        }

        #region Events
        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            string aux = ddlTeam.SelectedText;
            string aux2 = ddlTeam.SelectedValue.ToString();
        }

        private void ddlTeam_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                int team = (int)ddlTeam.SelectedItem.Value;

                List<refers_codes> refers = (from r in teams
                                             where r.id == team
                                             select r.refers_codes).First().ToList();

                List<RadListDataItem> list = new List<RadListDataItem>();
                foreach (refers_codes item in refers)
                {
                    list.Add(new RadListDataItem(item.code + " - " + item.description, item.code));
                }
                ddlReferCodes.DataSource = null;
                ddlReferCodes.Items.Clear();
                ddlReferCodes.DataSource = list;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnRefer_Click(object sender, EventArgs e)
        {
            try
            {
                int referTo = Convert.ToInt16(ddlTeam.SelectedValue.ToString());
                string referCode = "";
                string code = "";
                string referDesc = "";
                if (ddlReferCodes.Items.Count > 0)
                {
                    referCode = ddlReferCodes.SelectedValue.ToString();
                    string[] split = referCode.Split('-');
                    code = split[0].Replace(" ", "");
                    referDesc = split[1];
                }
                TimeSpan opDuration = DateTime.Now - opStart;
                UBMMSController.ReferDocument(this.trackingID, referTo, code, txtComments.Text, referDesc,  this.user, opDuration);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Document " + this.trackingID + " referred succesfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                this.Close();
                frmProcess.AddHistoricDocument(trackingID);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frmRefer_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        #endregion


        #region Methods

        private void SetLists()
        {
            DALTeam d = new DALTeam();
            teams = d.SelectAll().Where(x => x.id != 1 && x.id != 12).ToList();
            
            ddlTeam.DataSource = teams;
            ddlTeam.DisplayMember = "team_name";
            ddlTeam.ValueMember = "id";
            ddlTeam.Text = "";
        }

        #endregion


    }
}
