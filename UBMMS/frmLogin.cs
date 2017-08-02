using System;
using System.Windows.Forms;
using UBMMS.Controller;
using UBMMS.DAL;

namespace UBMMS
{
    public partial class frmLogin : Form
    {
        public user User { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User = new user();
            User.email = txtEmail.Text;
            User.pass = txtPassword.Text;

            try
            {
                User = UBMMSController.CheckUser(User);
                if (User != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmail.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please inform email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                btnLogin.PerformClick();
            }
        }
    }
}
