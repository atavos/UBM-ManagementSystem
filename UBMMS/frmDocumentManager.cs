using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using UBMMS.Controller;
using UBMMS.DAL;

namespace UBMMS
{
    public partial class frmDocumentManager : Form
    {
        List<customer> CustomerList = UBMMSController.GetAllCustomersEagerLoad();
        private user userlogged;
        private bool BatchUpdate = false;
        private string currentImage;
        public frmDocumentManager(user user)
        {
            InitializeComponent();
            userlogged = user;
            ConfigureDateTimerLists();
            SetLists();
            swtViewImage.Value = false;
        }


        private void btnSearchUniqueId_Click(object sender, EventArgs e)
        {
            if(txbDocumentID.TextLength>=8)
            {
                SetGridViewColumns();

                btnBatchUpdate.Enabled = false;
                BatchUpdate = false;
                List<string> trackingid = new List<string>();
                trackingid.Add(txbDocumentID.Text);

                radGridView1.DataSource =  UBMMSController.SelectDocuments(trackingid);
            }
            else
            {
                MessageBox.Show("Tracking ID is too short, please review and try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetLoadedIds();
            
            btnBatchUpdate.Enabled = false;
            BatchUpdate = false;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            BatchUpdate = true;
            btnBatchUpdate.Enabled = true;

            radGridView1.DataSource = null;
            radGridView1.Rows.Clear();
            radGridView1.Columns.Clear();
            radGridView1.AutoGenerateColumns = true;

            ImportFromExcel();
            
        }

        private void btnBatchUpdate_Click(object sender, EventArgs e)
        {
            UpdateDocuments();
        }

        /// <summary>
        /// triggered when the user changes the value of a cell. Used to verify if changes will be applied to documents on the DB.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radGridView1_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            if(BatchUpdate == false)
            {
                UpdateDocuments();
            }
        }

        #region methods

        /// <summary>
        /// set UI for date time controls
        /// </summary>
        private void ConfigureDateTimerLists()
        {
            dtpTo.Value = DateTime.Now;
            dtpTo.MaxDate = DateTime.Now;
            dtpFrom.Value = DateTime.Now;

            dtpFrom.DateTimePickerElement.ShowTimePicker = true;
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Culture = CultureInfo.InvariantCulture;
            dtpFrom.CustomFormat = "dd MMM yyyy HH:mm";
            (dtpFrom.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).DropDownMinSize = new Size(330, 350);

            dtpTo.DateTimePickerElement.ShowTimePicker = true;
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Culture = CultureInfo.InvariantCulture;
            dtpTo.CustomFormat = "dd MMM yyyy HH:mm";
            (dtpTo.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).DropDownMinSize = new Size(330, 350);
            dtpTo.Value = DateTime.Now;

        }

        /// <summary>
        /// Set ui for the drop down list
        /// </summary>
        private void SetLists()
        {
            ddlCustomer.ValueMember = "id";
            ddlCustomer.DisplayMember = "customer_name";
            ddlCustomer.DataSource = CustomerList;

            ddlCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ddlCustomer.DropDownListElement.AutoCompleteSuggest.SuggestMode = Telerik.WinControls.UI.SuggestMode.Contains;
            ddlCustomer.DropDownListElement.AutoCompleteAppend.LimitToList = true;
        }

        /// <summary>
        /// Gets the documents loaded on MS as per selected criteria
        /// </summary>
        private void GetLoadedIds()
        {
            //radGridView1.DataSource = null;
            //radGridView1.Rows.Clear();
            //radGridView1.Columns.Clear();

            customer cust = CustomerList.Where(c => c.id.Equals(ddlCustomer.SelectedValue)).ToList().First();
            List<document> docs = UBMMSController.GetDocumentsList(cust, dtpFrom.Value, dtpTo.Value);

            SetGridViewColumns();
            radGridView1.DataSource = docs;

            
            radGridView1.Columns[0].ReadOnly = true;
        }

        /// <summary>
        /// Import a list of documents from the user computer to the document manager grid
        /// </summary>
        private void ImportFromExcel()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //txbDocumentID.Text = openFileDialog1.FileName;
                DALExcel dal = new DALExcel();
                DataTable dt = dal.ReadExcel(openFileDialog1.FileName, "xlsx");
                radGridView1.DataSource = dt;

                foreach (GridViewColumn item in radGridView1.Columns)
                {
                    item.BestFit();
                    item.Width = 250;
                }

            }
        }

        /// <summary>
        /// Request changes to documents on the DB
        /// </summary>
        private void UpdateDocuments()
        {
            List<document> doc = new List<document>();

            document d = new document();
            try
            {
                if (BatchUpdate == false)
                {

                    d.tracking_id = radGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    d.document_type = radGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    d.id_project_code = radGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    doc.Add(d);

                    DataTable dt = UBMMSController.UpdateDocumentDetails(doc, userlogged);

                    MessageBox.Show(dt.Rows[0].Field<string>(1) + " to Document ID " + dt.Rows[0].Field<string>(0));
                }
                else
                {
                    foreach (GridViewDataRowInfo item in radGridView1.Rows)
                    {
                        d.tracking_id = item.Cells[0].Value.ToString();
                        d.document_type = item.Cells[1].Value.ToString();
                        d.id_project_code = item.Cells[2].Value.ToString();

                        doc.Add(d);

                        radGridView1.DataSource = null;
                        radGridView1.DataSource = UBMMSController.UpdateDocumentDetails(doc, userlogged);
                    }
                    MessageBox.Show("Update complete");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Action not completed, reason below:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
        }

        private void SetGridViewColumns()
        {
            radGridView1.DataSource = null;
            radGridView1.Rows.Clear();
            radGridView1.Columns.Clear();

            GridViewTextBoxColumn id = new GridViewTextBoxColumn();
            id.Name = "tracking_id";
            id.HeaderText = "Document ID";
            id.FieldName = "tracking_id";
            radGridView1.MasterTemplate.Columns.Add(id);

            GridViewTextBoxColumn doctype = new GridViewTextBoxColumn();
            doctype.Name = "doc_type";
            doctype.HeaderText = "Document Type";
            doctype.FieldName = "document_type";
            radGridView1.MasterTemplate.Columns.Add(doctype);

            GridViewTextBoxColumn project = new GridViewTextBoxColumn();
            project.Name = "project_code";
            project.HeaderText = "Project Code";
            project.FieldName = "id_project_code";
            radGridView1.MasterTemplate.Columns.Add(project);



        }
        #endregion methods

        private void radGridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            LoadBillImage();
        }

        private void LoadBillImage()
        {
            
            if (swtViewImage.Value == true && currentImage != radGridView1.SelectedRows[0].Cells[0].Value.ToString())
            {
                currentImage = radGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string documentPath = UBMMSController.GetDocumentImage(currentImage); //caminho do arquivo no computador do usuário

                try
                {
                    if (documentPath != "")
                    {
                        if (Path.GetExtension(documentPath).ToLower() == ".tif")
                        {
                            documentPath = ConvertImage(documentPath);
                        }

                        // PdfReader pdfReader = new PdfReader(documentPath);
                        //this.pdfViewer.src = documentPath;
                        radPdfViewer1.LoadDocument(documentPath);
                        
                    }
                    else
                    {
                        MessageBox.Show("The document image could not be opened.\nPlease contact your support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The document image could not be opened.\nPlease contact your support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        private string ConvertImage(string source)
        {
            string destination;
            //if (Path.GetExtension(source).ToLower() == ".pdf")
            //{
            //    return source;
            //}

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
    }
}
