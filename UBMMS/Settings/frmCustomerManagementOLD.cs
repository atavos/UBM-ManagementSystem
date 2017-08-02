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
using Telerik.WinControls.UI.Docking;
using UBMMS.Controller;
using UBMMS.DAL;

namespace UBMMS.Settings
{
    public partial class frmCustomerManagementOLD : Form
    {
        private List<customer> customers;
        public frmCustomerManagementOLD()
        {
            InitializeComponent();
        }
        public frmCustomerManagementOLD(user user)
        {
            InitializeComponent();
            CustomerContentBinder();
            SetDDLFeatures();
            CustomEvents();
            
    }

        /// <summary>
        /// create events for the Navigatiors buttons
        /// </summary>
        public void CustomEvents()
        {
            radBindingNavigator1AddNewItem.Click += RadBindingNavigator1AddNewItem_Click;
            radBindingNavigator2AddNewItem.Click += RadBindingNavigator2AddNewItem_Click;
        }
        private void RadBindingNavigator1AddNewItem_Click(object sender, EventArgs e)
        {
            btnSaveCustomer.Text = "Save";
            ddlCustomer.Text = "";
            UnbindProjectCode();
            UnbindCustomers();

            btnCustomerCancel.Enabled = true;

        }
        private void RadBindingNavigator2AddNewItem_Click(object sender, EventArgs e)
        {
            ddlProjectCode.Text = "";
            UnbindProjectCode();
        }


        /// <summary>
        /// Set ddl's visual features
        /// </summary>
        public void SetDDLFeatures()
        {
            ddlCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ddlCustomer.DropDownListElement.AutoCompleteSuggest.SuggestMode = Telerik.WinControls.UI.SuggestMode.Contains;
            ddlCustomer.DropDownListElement.AutoCompleteAppend.LimitToList = true;

            ddlProjectCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ddlProjectCode.DropDownListElement.AutoCompleteSuggest.SuggestMode = Telerik.WinControls.UI.SuggestMode.Contains;
            ddlProjectCode.DropDownListElement.AutoCompleteAppend.LimitToList = true;

        }

        /// <summary>
        /// binds the content of Customers Controls
        /// </summary>
        public void CustomerContentBinder()
        {
            bgsCustomers.DataSource = UBMMSController.GetAllCustomersEagerLoad();

            ddlCustomer.DisplayMember = "customer_name";
            ddlCustomer.ValueMember = "id";
            ddlCustomer.DataSource = bgsCustomers;
            
            radDataEntry1.DataSource = bgsCustomers;
            radBindingNavigator1.BindingSource = bgsCustomers;

            radBindingNavigator1DeleteItem.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;

        }

        public void UnbindCustomers()
        {
            customer cust = new customer();
            try
            {
                bgsCustomers.DataSource = cust;
            }
            catch (Exception ex)
            {

                throw;
            }
            
            ddlCustomer.DisplayMember = "customer_name";
            ddlCustomer.ValueMember = "id";
            ddlCustomer.DataSource = bgsCustomers;

            radDataEntry1.DataSource = bgsCustomers;
            radBindingNavigator1.BindingSource = bgsCustomers;

        }

        /// <summary>
        /// binds the contents of project controls
        /// </summary>
        /// <param name="bind"></param>
        private void ProjectContentBinder()
        {
            try
            {
                var projects = UBMMSController.GetAllCustomersEagerLoad().Where(x => x.id.Equals(ddlCustomer.SelectedValue)).Select(p => p.project_codes).FirstOrDefault();
                bgsProjects.DataSource = projects;
            }
            catch (Exception ex)
            {
                //throw;
            }
            ddlProjectCode.ValueMember = "project_code";
            ddlProjectCode.DisplayMember = "project_name";
            ddlProjectCode.DataSource = bgsProjects;
            radBindingNavigator2.BindingSource = bgsProjects;
            dteProjectCode.DataSource = bgsProjects;
        }

        private void UnbindProjectCode()
        {
            try
            {
                customer cust = new customer();
                bgsProjects.DataSource = cust;
                
            }
            catch (Exception ex)
            {
            }
            //ddlProjectCode.ValueMember = "project_code";
            //ddlProjectCode.DisplayMember = "project_name";
            ddlProjectCode.DataSource = null;
            dteProjectCode.DataSource = null;
            radBindingNavigator2.BindingSource = null;
        }


        #region events

       

        /// <summary>
        /// resets the binders datasource when the user cancel actions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadBindingNavigator1DeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CustomerContentBinder();
                ProjectContentBinder();
                btnSaveCustomer.Text = "Update";   
            }
            else
            {

            }
        }

        /// <summary>
        /// updates the binders for project code when the user changes active customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddlCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            if(ddlCustomer.Text!="")
            {
                ProjectContentBinder();
            }
            else
            {
                //UnbindProjectCode();
            }
            
        }
        
        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if(btnSaveCustomer.Text == "Update")
            {
                customer cust = new customer();

                cust = (customer)bgsCustomers.Current;
                DialogResult result = MessageBox.Show("You are changing Customer Details, this is not a reversible action", "Are you sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        UBMMSController.UpdateCustomer(cust);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                if (this.bgsCustomers.Current != null)
                {
                    customer cust = new customer();

                    cust = (customer)bgsCustomers.Current;

                    try
                    {
                        UBMMSController.CreateNewCustomer(cust);
                        btnSaveCustomer.Text = "Update";
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
            CustomerContentBinder();
            btnCustomerCancel.Enabled = false;
        }
        
        /// <summary>
        /// set UI for dataentry control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radDataEntry1_ItemInitialized(object sender, Telerik.WinControls.UI.ItemInitializedEventArgs e)
        {
            radDataEntry1.FitToParentWidth = true;
            if (e.Panel.Controls[1].Text == "id")
            {
                e.Panel.Enabled = false;
                e.Panel.Controls[1].Text = "Code";

            }
            if (e.Panel.Controls[1].Text == "project_codes")
            {
                e.Panel.Visible = false;
            }
            
            if (e.Panel.Controls[1].Text == "sstem_code")
            {    
                e.Panel.Controls[1].Text = "System Code";
            }
            if (e.Panel.Controls[1].Text == "customer_name")
            {
                e.Panel.Controls[1].Text = "Customer Name";
            }
        }

        /// <summary>
        /// set UI for dataentry control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dteProjectCode_ItemInitialized(object sender, ItemInitializedEventArgs e)
        {
            dteProjectCode.FitToParentWidth = true;
            if(e.Panel.Controls[1].Text=="customer")
            {
                e.Panel.Enabled = false;
                e.Panel.Visible = false;
            }
            if (e.Panel.Controls[1].Text == "documents")
            {
                e.Panel.Visible = false;
                e.Panel.Enabled = false;
            }
            if (e.Panel.Controls[1].Text == "project_code")
            {
                e.Panel.Controls[1].Text = "Project Code";
            }
            if (e.Panel.Controls[1].Text == "project_name")
            {
                e.Panel.Controls[1].Text = "Project Name";
            }
        }

        private void btnCustomerCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CustomerContentBinder();
                ProjectContentBinder();
                btnSaveCustomer.Text = "Update";
                btnCustomerCancel.Enabled = false;
            }
            else
            {

            }
        }

        private void btnProjectSave_Click(object sender, EventArgs e)
        {
            if(btnProjectSave.Text=="Update")
            {

            }
        }


        #endregion events
    }
}
