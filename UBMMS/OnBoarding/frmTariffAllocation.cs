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

namespace UBMMS.OnBoarding
{
    public partial class frmTariffAllocation : Form
    {
        
        public frmTariffAllocation()
        {
            InitializeComponent();
            setData();
        }

        public void setData()
        {
            
            this.bindingSource1.DataSource = UBMMSController.GetAllCustomers();
            this.radDataEntry1.DataSource = bindingSource1;
            this.radBindingNavigator1.BindingSource = bindingSource1;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.bindingSource1.Current == null)
            {
                return;
            }

            //DataRowView dataRowView = this.bindingSource1.Current as DataRowView;

            List<customer> att = null;

            
            string namedireto = (bindingSource1.Current.GetType().GetProperty("customer_name").GetValue(bindingSource1.Current,null)).ToString();

            customer cust = new customer();

            cust = (customer)bindingSource1.Current;
            try
            {
                UBMMSController.CreateNewCustomer(cust);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
            
        }
    }
}
