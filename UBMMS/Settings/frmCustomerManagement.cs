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

namespace UBMMS.Settings
{
    public partial class frmCustomerManagement : RadForm
    {
        List<customer> CustomerList = UBMMSController.GetAllCustomersEagerLoad();
        private user userlogged;
        public frmCustomerManagement()
        {
            InitializeComponent();
        }
        public frmCustomerManagement(user u)
        {
            userlogged = u;
            InitializeComponent();
            CustomerListsBinder();
            
        }

        #region methods
        /// <summary>
        /// Gets the list of customers to feed the DDLCustomers
        /// </summary>
        private void CustomerListsBinder()
        {
            ddlCustomer.ValueMember = "id";
            ddlCustomer.DisplayMember = "customer_name";
            ddlCustomer.DataSource = CustomerList;

            ddlCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ddlCustomer.DropDownListElement.AutoCompleteSuggest.SuggestMode = Telerik.WinControls.UI.SuggestMode.Contains;
            ddlCustomer.DropDownListElement.AutoCompleteAppend.LimitToList = true;
        }

        /// <summary>
        /// Gets the list of projects codes based on the current selected customer and feeds the DLL projects
        /// </summary>
        private void ProjectListsBinder()
        {
            if (ddlCustomer.SelectedValue != null)
            {
                if (CustomerList.Where(x => x.id.Equals(ddlCustomer.SelectedValue)).Select(p => p.project_codes).FirstOrDefault().Count > 0)
                {
                    ddlProject.ValueMember = "project_code";
                    ddlProject.DisplayMember = "project_name";
                    ddlProject.DataSource = CustomerList.Where(x => x.id.Equals(ddlCustomer.SelectedValue)).Select(p => p.project_codes).FirstOrDefault();

                }
                else
                {
                    ddlProject.DataSource = null;
                    ddlProject.Text = "No Projects set for this Customer";
                }
            }
            else
            {
                ddlCustomer.SelectedValue = 0;
            }

            ddlProject.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ddlProject.DropDownListElement.AutoCompleteSuggest.SuggestMode = Telerik.WinControls.UI.SuggestMode.Contains;
            ddlProject.DropDownListElement.AutoCompleteAppend.LimitToList = true;
        }
        #endregion methods

        #region events
        private void ddlCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ddlCustomer.Text != "")
            {
                swtCustomerStatus.SetToggleState(CustomerList.Where(x => x.id.Equals(ddlCustomer.SelectedValue)).Select(p => p.enabled).FirstOrDefault());
                txtCustomerCode.Text = CustomerList.Where(x => x.id.Equals(ddlCustomer.SelectedValue)).Select(p => p.sstem_code).FirstOrDefault();

                ProjectListsBinder();
            }
        }

        private void ddlProject_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (ddlProject.Text != "")
            {
                swtProjectAP.SetToggleState((CustomerList.Where(x => x.id.Equals(ddlCustomer.SelectedValue)).Select(p => p.project_codes).FirstOrDefault())
                .Where(y => y.project_code.Equals(ddlProject.SelectedValue)).Select(p => p.ap_enabled).FirstOrDefault());

                swtProjectStatus.SetToggleState((CustomerList.Where(x => x.id.Equals(ddlCustomer.SelectedValue)).Select(p => p.project_codes).FirstOrDefault())
                .Where(y => y.project_code.Equals(ddlProject.SelectedValue)).Select(p => p.enabled).FirstOrDefault());

                txtProjectCode.Text = (CustomerList.Where(x => x.id.Equals(ddlCustomer.SelectedValue)).Select(p => p.project_codes).FirstOrDefault())
                .Where(y => y.project_code.Equals(ddlProject.SelectedValue)).Select(p => p.project_code).FirstOrDefault();
            }
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            customer cust = new customer();

            cust.customer_name = txtEditCustomerName.Text;
            cust.sstem_code = txtEditCustomerCode.Text;
            cust.enabled = swtEditCustomerStatus.Value;
            cust.id = Convert.ToInt16(ddlCustomer.SelectedValue);

            if (txtEditCustomerCode.Text != "" && txtEditCustomerName.Text != "")
            {


                if (btnSaveCustomer.Text == "Add Customer")
                {
                    try
                    {
                        UBMMSController.CreateNewCustomer(cust);
                        MessageBox.Show("Customer Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("We could not complete the operation, report the error below to developers:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    try
                    {
                        UBMMSController.UpdateCustomer(cust);
                        MessageBox.Show("Customer Updated Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("We could not complete the operation, report the error below to developers:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                btnSaveCustomer.Text = "Add Customer";
                txtEditCustomerName.Text = "";
                txtEditCustomerCode.Text = "";

                CustomerList = UBMMSController.GetAllCustomersEagerLoad();
                CustomerListsBinder();
                ppeCustomer.PopupEditorElement.ClosePopup();
            }
            else
            {
                MessageBox.Show("All fields are required to create a customer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            btnSaveCustomer.Text = "Update Customer";
            txtEditCustomerName.Text = ddlCustomer.Text;
            txtEditCustomerCode.Enabled = false;
            txtEditCustomerCode.Text = txtCustomerCode.Text;
            swtEditCustomerStatus.Value = swtCustomerStatus.Value;

            ppeCustomer.PopupEditorElement.ShowPopup();
        }

        private void ppeCustomer_PopupClosing(object sender, RadPopupClosingEventArgs args)
        {
            txtEditCustomerName.Text = "";
            txtEditCustomerCode.Text = "";
            txtEditCustomerCode.Enabled = true;
        }


        private void btnAddProject_Click(object sender, EventArgs e)
        {
            project_codes proj = new project_codes();

            proj.project_name = txtEditProjectName.Text;
            proj.project_code = txtEditProjectCode.Text;
            proj.id_customer = Convert.ToInt16(ddlCustomer.SelectedValue);
            proj.ap_enabled = swtEditAPEnabled.Value;
            proj.enabled = swtEditProjectStatus.Value;
            if (txtEditProjectCode.Text != "" && txtEditProjectName.Text != "" && Convert.ToInt16(ddlCustomer.SelectedValue) >= 0)
            {


                if (btnAddProject.Text == "Add Project")
                {
                    try
                    {
                        UBMMSController.CreateNewProjectCode(proj);
                        MessageBox.Show("Project Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("We could not complete the operation, report the error below to developers:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    try
                    {
                        UBMMSController.UpdateProject(proj);
                        MessageBox.Show("Project Update", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("We could not complete the operation, report the error below to developers:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                btnAddProject.Text = "Add Project";
                txtEditCustomerName.Text = "";
                txtEditCustomerCode.Text = "";

                CustomerList = UBMMSController.GetAllCustomersEagerLoad();
                CustomerListsBinder();
                ppeProject.PopupEditorElement.ClosePopup();
            }
            else
            {
                MessageBox.Show("All fields are required to create a project code", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnUpdateProject_Click(object sender, EventArgs e)
        {
            btnAddProject.Text = "Update Project";
            txtEditProjectName.Text = ddlProject.Text;
            txtEditProjectCode.Enabled = false;
            txtEditProjectCode.Text = txtProjectCode.Text;
            swtEditAPEnabled.Value = swtProjectAP.Value;
            swtEditProjectStatus.Value = swtProjectStatus.Value;

            ppeProject.PopupEditorElement.ShowPopup();
        }

        private void ppeProject_PopupClosing(object sender, RadPopupClosingEventArgs args)
        {
            txtEditProjectCode.Enabled = true;
            txtEditProjectCode.Text = "";
            txtEditProjectName.Text = "";
            btnAddProject.Text = "Add Project";
        }

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            //restringe opções de salvar para usuários que não são autorizados
            if (userlogged.id_team!=6 && userlogged.id_team!=8)
            {
                ppeCustomer.Enabled = false;
                ppeProject.Enabled = false;
                btnUpdateCustomer.Enabled = false;
                btnUpdateProject.Enabled = false;
                btnAddProject.Enabled = false;
                btnSaveCustomer.Enabled = false;
            }
            else
            {
                ppeCustomer.Enabled = true;
                ppeProject.Enabled = true;
                btnUpdateCustomer.Enabled = true;
                btnUpdateProject.Enabled = true;
                btnAddProject.Enabled = true;
                btnSaveCustomer.Enabled = true;
            }
        }
        #endregion events



    }
}
