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
    public partial class frmReAssign : Form
    {
        private user user;
        public frmReAssign()
        {
            InitializeComponent();
        }

        public frmReAssign(user u)
        {
            InitializeComponent();
            this.user = u;
            SetLists();
        }

        #region Events
        private void ddlUsers_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            GetDocuments();
        }

        private void btnReassign_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> ids = new List<string>();
                foreach (GridViewRowInfo item in gdvDocuments.Rows)
                {
                    if (item.Cells[4].Value != null)
                    {
                        ids.Add(item.Cells[0].Value.ToString());
                    }
                }
                UBMMSController.ReassignDocuments(ids, this.user);
                GetDocuments();
                MessageBox.Show("Document(s) reassigned back to the team queue.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ":\n" + ex.InnerException.InnerException.Message );
            }

        }
        #endregion

        #region Methods
        private void SetLists()
        {
            List<user> l = UBMMSController.SelectUsersByTeam(this.user.id_team);
            ddlUsers.DataSource = l;
            ddlUsers.DisplayMember = "user_name";
            ddlUsers.ValueMember = "id_user";
            
            ddlUsers.Text = "";
        }

        private void GetDocuments()
        {
            if (ddlUsers.SelectedItem != null)
            {
                int idUser;
                bool res = int.TryParse(ddlUsers.SelectedItem.Value.ToString(), out idUser);
                if (res)
                {
                    object docs = UBMMSController.SelectDocumentsByUserReassign(idUser);
                    gdvDocuments.DataSource = docs;
                }
            }
        }

        #endregion


    }
}
