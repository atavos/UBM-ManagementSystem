using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UBMMS.DAL;

namespace UBMMS
{
    public partial class frmReportProductivityCustomer : Form
    {
        public frmReportProductivityCustomer()
        {
            InitializeComponent();
            ReportType();
            setBasicDates();
        }

        /// <summary>
        /// Checa o tipo de relatório que irá ser rodado
        /// </summary>
        public void ReportType()
        {
            if (rrbIndividualCustomer.IsChecked == true)
            {
                GetCustomers();
                ddlCustomer.Enabled = true;
            }
            else if (rrbGroupsInfoLCM.IsChecked == true)
            {
                //CHAMAR GRUPOS DO INFOLCM
                ddlCustomer.Enabled = false;
            }
            else
            {
                //CHAMAR METODO PARA GERAR RELATORIO TODOS OS CLIENTES
                ddlCustomer.Enabled = false;
            }

        }

        /// <summary>
        /// cosmetic method to set the from date to be today's less 30 days
        /// </summary>
        private void setBasicDates()
        {
            dtpFromDate.Value = DateTime.Now - TimeSpan.FromDays(30);
        }

        /// <summary>
        /// Preenche o dropdow ddlcustomer com os clientes 
        /// </summary>
        public void GetCustomers()
        {
            DALCustomer dal = new DALCustomer();
            List<customer> list = dal.SelectAll();

            ddlCustomer.DisplayMember = "customer_name";
            ddlCustomer.ValueMember = "id";
            ddlCustomer.DataSource = list;
        }


        #region events
        private void rrbIndividualCustomer_CheckStateChanged(object sender, EventArgs e)
        {
            ReportType();
        }
        private void rrbGroupsInfoLCM_CheckStateChanged(object sender, EventArgs e)
        {
            ReportType();
        }
        private void rrbAll_CheckStateChanged(object sender, EventArgs e)
        {
            ReportType();
        }


        #endregion events


    }
}
