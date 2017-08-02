using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using UBMMS.Controller;
using UBMMS.DAL;


namespace UBMMS.OnBoarding
{
    public partial class frmGroupInvoices : Form
    {
        private user user;                  //dados do usuário logado
        private List<customer> listCustomers;//lista dos clientes com imagens
        private DateTime opStart;           //usado para produtividade
        private string documentPath;        //usado como referência do local do arquivo

        public frmGroupInvoices()
        {
            InitializeComponent();
            
        }
        public frmGroupInvoices(user u)
        {
            InitializeComponent();
            this.user = u;
            GetCustomerList();
        }

        #region events

        private void gdvDocuments_Click(object sender, EventArgs e)
        {
            if(gdvDocuments.RowCount>0)
            {
                GetBillImage(gdvDocuments.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        /// <summary>
        /// chama o método que busca informações no banco sobre o account informado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">ENTER</param>
        private void txbAccountNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetAccountDetails(txbAccountNumber.Text);
            }
        }

        private void txbAccountNumber_Leave(object sender, EventArgs e)
        {
            GetAccountDetails(txbAccountNumber.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbAccountNumber.Text != "" || txbSiteCode.Text != "" || txbSupplierName.Text != "")
            {
                GetAccountDetails(txbAccountNumber.Text);
            }
            else
            {
                MessageBox.Show("You need to provide a valid account number\nIf the invoice account number do not return site information, open a refer to On Board Team",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void ddlCustomer_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            GetProjectCodes();
        }


        private void btnRefer_Click(object sender, EventArgs e)
        {
            if (txbTrackingID.Text != "")
            {
                frmRefer form = new frmRefer(txbTrackingID.Text, user, opStart);
                form.Show();
            }
            else
            {
                MessageBox.Show("You do not have a Tracking ID selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        #endregion events



        #region methods

        /// <summary>
        /// Baixa o documento do FTP do InfoLCM e carrega na tela do usuário
        /// </summary>
        private void GetBillImage(string trackingID)
        {
            try
            {
                //trackingID = gdvDocuments.SelectedRows[0].Cells[0].Value.ToString();
                documentPath = UBMMSController.GetDocumentImage(trackingID);

                if (Path.GetExtension(documentPath).ToLower() == ".tif")
                {
                    documentPath = ConvertImage(documentPath);
                }

                PdfReader pdfReader = new PdfReader(documentPath);
                int numPages = pdfReader.NumberOfPages;
                UBMMSController.UpdateNumPages(trackingID, numPages);
                pdfDocument.LoadDocument(documentPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
            opStart = DateTime.Now;
        }

        /// <summary>
        /// Converte um arquivo TIFF em PDF usando o iTextSharp
        /// </summary>
        /// <param name="source">Caminho de origem do arquivo a ser convertido</param>
        /// <returns>caminho do arquivo convertido</returns>
        private string ConvertImage(string source)
        {
            string destination = "";
            try
            {               
                string newPDF = source.Replace("tif", "pdf");
                SautinSoft.PdfVision v = new SautinSoft.PdfVision();

                //especifica os parametros da conversão
                v.PageStyle.PageSize.Auto();

                destination = Path.ChangeExtension(source, ".pdf");
                int ret = v.ConvertImageFileToPDFFile(source, destination);
                return destination;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        private void GetCustomerList()
        {
            listCustomers = UBMMSController.GetAllCustomers();
            ddlCustomer.DisplayMember = "customer_name";
            ddlCustomer.ValueMember = "id";
            ddlCustomer.DataSource = listCustomers;
            ddlCustomer.SelectedIndex = -1;
        }

        private void GetProjectCodes()
        {
            if(ddlCustomer.SelectedIndex>-1 || ddlCustomer.Text!="")
            {
                //obtem os project codes com base no customer selecionado
                var projects = listCustomers.Where(x => x.id.Equals(ddlCustomer.SelectedValue)).Select(x => x.project_codes).FirstOrDefault();

                //alimenta o drop down de seleção
                ddlProjectCode.DisplayMember = "project_name";
                ddlProjectCode.ValueMember = "project_code";
                ddlProjectCode.DataSource = projects;
                ddlProjectCode.SelectedIndex = -1;

                //alimenta o drop down do usuário, caso seja necessário informar project code diferente para o documento.
                ddlUserProjectCode.DisplayMember = "project_name";
                ddlUserProjectCode.ValueMember = "project_code";
                ddlUserProjectCode.DataSource = projects;
                ddlUserProjectCode.SelectedIndex = -1;
            }
        }

        private void AssignDocuments()
        {

        }

        private void GetUserDocuments()
        {
            gdvDocuments.DataSource = null;
            gdvDocuments.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gdvDocuments.DataSource = UBMMSController.GetAllDocumentsByUser(this.user, false);

            foreach (GridViewDataColumn item in gdvDocuments.Columns)
            {
                item.BestFit();
            }
        }

        /// <summary>
        /// busca os dados do account informado no banco
        /// </summary>
        /// <param name="AccountNumber"></param>
        private void GetAccountDetails(string AccountNumber)
        {
            
        }


        #endregion methods
        
    }
}
