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
    public partial class frmAddUser : Form
    {
        private user userlogged;
        private bool edit;

        public frmAddUser(user u ,bool e)
        {
            InitializeComponent();
            SetLists();
            this.userlogged = u;
            this.edit = e;
            
            SetControlsBasedonEdit();
        }
        public frmAddUser()
        {
            InitializeComponent();
            SetLists();
        }

        #region Events
        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("These passwords don't match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            user user = new user();
            user.email = txtEmail.Text;
            try
            {
               // UBMMSController.CheckExistingUser(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Existing User Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
            string str = txtEmail.Text;
            int index = str.IndexOf('@');

            if (index > 0)
            {
                txtSSTEMBatch.Text = "MAP_" + str.Substring(0, index) + ".BAT";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            user user = new user();

            user.user_name = txtName.Text;
            user.email = txtEmail.Text;
            user.pass = txtPassword.Text;
            user.sstem_user = txtSSTEMUser.Text;
            user.sstem_bat = txtSSTEMBatch.Text;
            user.user_level = (chkSupervisor.Checked) ? 2 : 1;
            user.id_team = this.userlogged.id_team;


            if(user.pass!="")
            {
                if (this.edit == false)
                {
                    try
                    {
                        UBMMSController.CreateNewUser(user);
                        ClearControls();
                        MessageBox.Show("All done! I have created " + user.user_name + " login", "User Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        UBMMSController.UpdateExistinguser(user);
                        MessageBox.Show("User details updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Sorry, you need to provide a password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Methods

        private void SetControlsBasedonEdit()
        {
            if (edit== true)
            {
                txtEmail.Enabled = false;
                txtSSTEMBatch.Enabled = false;
                txtSSTEMUser.Enabled = false;
                
                chkSupervisor.Enabled = false;
                btnClear.Enabled = false;

                txtEmail.Text = userlogged.email;
                txtName.Text = userlogged.user_name;
                
                txtSSTEMUser.Text = userlogged.sstem_user;
                txtSSTEMBatch.Text = userlogged.sstem_bat;
            }
            ddlTeams.Enabled = false;
            ddlTeams.SelectedValue = userlogged.id_team;
        }

        private void SetLists()
        {
            List<team> teams = UBMMSController.SelectAllTeams();
            ddlTeams.DataSource = teams;
            ddlTeams.DisplayMember = "team_name";
            ddlTeams.ValueMember = "id";
            ddlTeams.Text = "";
            ddlTeams.AutoCompleteMode = AutoCompleteMode.Append;
            ddlTeams.DropDownListElement.AutoCompleteAppend.LimitToList = true;

        }

        private void ClearControls()
        {
            foreach (Control item in this.tableLayoutPanel1.Controls)
            {
                if (item is RadTextBoxControl)
                {
                    item.Text = "";
                }
                else if (item is RadCheckBox)
                {
                    ((RadCheckBox)item).Checked = false;
                }
                else if (item is RadDropDownList)
                {
                    item.Text = "";
                }
            }
        }
        #endregion
    }
}
