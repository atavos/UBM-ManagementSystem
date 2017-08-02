using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;
using UBMMS.Controller;
using UBMMS.DAL;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace UBMMS
{
    public partial class frmProcess : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        private user user;
        private List<customer> listCustomer;
        private List<log_documents> logs;
        private DateTime opStart;
        private string documentPath;
        public frmProcess()
        {
            InitializeComponent();
            SetToolWindows();
        }

        public frmProcess(user u)
        {
            InitializeComponent();
            this.user = u;
            SetToolWindows();
            ShowSSTEM();
            //LoadImage();
            GetAllDocumentsByUser();
            SetLists();
            LoadProjectCodesDDL(false);
            SetWaitingBar();
        }

        #region Methods
        private void SetToolWindows()
        {
            DockWindow[] windows = radDock1.DockWindows.ToolWindows;

            foreach (DockWindow item in windows)
            {
                item.DockState = DockState.AutoHide;
            }
        }

        private void GetAllDocumentsByUser()
        {
            bool queue = false;
            if (rbtRefer.IsChecked)
            {
                queue = true;
            }
            gdvDocuments.DataSource = null;
            gdvDocuments.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gdvDocuments.DataSource = UBMMSController.GetAllDocumentsByUser(this.user, queue);

            foreach (GridViewDataColumn item in gdvDocuments.Columns)
            {
                item.BestFit();
            }

            GetAllLogs();
        }

        //private void OpenDocumentImage()
        //{
        //    imageForm = new frmDocumentImage();
        //    Screen[] sc;
        //    sc = Screen.AllScreens;
        //    if (sc.Count() > 1)
        //    {
        //        imageForm.Left = sc[1].Bounds.Width;
        //        imageForm.Top = sc[1].Bounds.Height;
        //        imageForm.StartPosition = FormStartPosition.Manual;
        //        imageForm.Location = sc[1].Bounds.Location;
        //        System.Drawing.Point p = new System.Drawing.Point(sc[1].Bounds.Location.X, sc[1].Bounds.Location.Y);
        //        imageForm.Location = p;
        //        imageForm.WindowState = FormWindowState.Maximized;
        //    }
        //    else
        //    {
        //        imageForm.Left = sc[0].Bounds.Width;
        //        imageForm.Top = sc[0].Bounds.Height;
        //        imageForm.StartPosition = FormStartPosition.Manual;
        //        imageForm.Location = sc[0].Bounds.Location;
        //        System.Drawing.Point p = new System.Drawing.Point(sc[0].Bounds.Location.X, sc[0].Bounds.Location.Y);
        //        imageForm.Location = p;
        //        imageForm.WindowState = FormWindowState.Normal;
        //    }
        //    imageForm.Show();
        //}

        /// <summary>
        /// Preenche a informação de clientes com faturas pendentes para o time do usuário.
        /// </summary>
        private void SetLists()
        {
            listCustomer = UBMMSController.GetAllActiveCustomers();
            ddlCustomers.DisplayMember = "customer_name";
            ddlCustomers.DataSource = listCustomer;

            bool queue;
            if (rbtRefer.IsChecked)
                queue = true;
            else
                queue = false;
            ddlCustomers.Text = "";
            DataTable dt = UBMMSController.CustomersWithPendingDocuments(this.user, queue);
            ddlCustomers2.DropDownMinSize = new Size(279, 150);
            ddlCustomers2.MultiColumnComboBoxElement.AutoCompleteMode = AutoCompleteMode.Suggest;
            ddlCustomers2.AutoSizeDropDownToBestFit = true;
            ddlCustomers2.DataSource = dt;
            ddlCustomers2.Text = "";
            ddlProjectCodes.DataSource = null;
            ddlDocumentType.DataSource = null;
            rbt10.IsChecked = true;
        }

        /// <summary>
        /// Carrega o SSTEM no form
        /// </summary>
        private void ShowSSTEM()
        {
            const int WM_SYSCOMMAND = 0x112;
            const int SC_MINIMIZE = 0xF020;
            const int SC_MAXIMIZE = 0xF030;

            if (user.sstem_bat == null)
            {
                return;
            }

            try
            {
                Process p = Process.Start(
                           new ProcessStartInfo()
                           {
                               FileName = @"c:\" + user.sstem_bat,
                               //FileName = @"C:\MAP_fernando.oliveira.BAT",
                               WindowStyle = ProcessWindowStyle.Minimized
                           });
                Thread.Sleep(500);
                IntPtr value = SetParent(p.MainWindowHandle, pnlSSTEM.Handle);
                SendMessage(p.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The system cannot open S/STEM.\nPlease check if the map batch is present on (C:).\nBatch name: " + this.user.sstem_bat, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Converte arquivo tiff para PDF
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
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

        private void LoadProjectCodesDDL(bool queue)
        {
            if(ddlCustomers2.Text == "")
            {
                return;
            }
            string customerName = ddlCustomers2.Text;
            ddlProjectCodes.DropDownMinSize = new Size(279, 150);
            ddlProjectCodes.MultiColumnComboBoxElement.AutoCompleteMode = AutoCompleteMode.Suggest;
            ddlProjectCodes.AutoSizeDropDownToBestFit = true;

            ddlProjectCodes.DataSource = null;
            ddlProjectCodes.DataSource = UBMMSController.GetProjectCodesInfo(customerName, user, queue);

            ddlProjectCodes.Text = "";
            ddlDocumentType.Text = "";
        }

        private void LoadDocumentType()
        {
            bool queue = false;
            if (rbtRefer.IsChecked)
            {
                queue = true;
            }

            string projectCode = ddlProjectCodes.Text;
            ddlDocumentType.DropDownMinSize = new Size(279, 150);
            ddlDocumentType.MultiColumnComboBoxElement.AutoCompleteMode = AutoCompleteMode.Suggest;
            ddlDocumentType.AutoSizeDropDownToBestFit = true;

            ddlDocumentType.DataSource = null;
            ddlDocumentType.DataSource = UBMMSController.GetDocumentTypeInfo(projectCode, user, queue);
        }

        /// <summary>
        /// Preenche a tabela de Log com base no Tracking ID selecionado na tabela de queue.
        /// </summary>
        /// <param name="trackingID"></param>
        private void GetLog(string trackingID)
        {
            gdvLog.DataSource = null;
            txtReferComments.Text = null;
            //gdvLog.DataSource = UBMMSController.SelectLogsByTrackingID(trackingID);
            gdvLog.DataSource = UBMMSController.SelectLog(trackingID);
            
            // organiza a tabela log em ordem decrescente usando a coluna3, data, como critério.
            Telerik.WinControls.Data.SortDescriptor descriptor = new Telerik.WinControls.Data.SortDescriptor();
            descriptor.PropertyName = "column3";
            descriptor.Direction = ListSortDirection.Descending;
            this.gdvLog.MasterTemplate.SortDescriptors.Add(descriptor);
            this.gdvLog.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }

        private void GetAllLogs()
        {
            List<string> ids = new List<string>();
            foreach (GridViewRowInfo item in gdvDocuments.Rows)
            {
                ids.Add(item.Cells[0].Value.ToString());
            }

            logs = UBMMSController.SelectLogsByRangeOfIDs(ids);
        }

        private void GetDocument()
        {
            try
            {
                string trackingID = gdvDocuments.SelectedRows[0].Cells[0].Value.ToString();
                string path = UBMMSController.GetDocumentImage(trackingID);

                //armazena o caminho da imagem atual
                this.documentPath = path;
                GetLog(trackingID);
                //LoadImage();
                opStart = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }

        /// <summary>
        /// carrega na tela o documento PDF selecionado
        /// </summary>
        /// <param name="trackingID"></param>
        public void LoadImage(string trackingID)
        {
            try
            {
                if (documentPath != "")
                {
                    if (!chkImageModal.Checked)
                    {
                        if(Path.GetExtension(documentPath).ToLower() ==".tif")
                        {
                            documentPath = ConvertImage(documentPath);
                        }
                        
                        PdfReader pdfReader = new PdfReader(documentPath);
                        int numPages = pdfReader.NumberOfPages;
                        UBMMSController.UpdateNumPages(trackingID, numPages);
                        this.pdfViewer.src = documentPath;

                    }
                    else
                    {
                        Process.Start(documentPath);
                    }
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

        /// <summary>
        /// Atualiza a lista de historico de documentos
        /// </summary>
        /// <param name="documentID"></param>
        public static void AddHistoricDocument(string documentID)
        {
            Properties.Settings.Default.Document5 = Properties.Settings.Default.Document4;
            Properties.Settings.Default.Document4 = Properties.Settings.Default.Document3;
            Properties.Settings.Default.Document3 = Properties.Settings.Default.Document2;
            Properties.Settings.Default.Document2 = Properties.Settings.Default.Document1;
            Properties.Settings.Default.Document1 = documentID;
            
        }

        /// <summary>
        /// Set the UI for the Download Waiting Bar
        /// </summary>
        private void SetWaitingBar()
        {
            rwbDownload.Left = (pdfViewer.ClientRectangle.Width - rwbDownload.Width) / 2;
            rwbDownload.Top = (pdfViewer.ClientRectangle.Height - rwbDownload.Height) / 2;
            rwbDownload.Size = new System.Drawing.Size(200, 200);
            rwbDownload.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.DotsSpinner;
            //rwbDownload.StartWaiting();
            int radius = 20;
            int elementCount = 5;
            for (int i = 0; i < 4; i++)
            {
                radius += 10;
                elementCount += 1;
                DotsSpinnerWaitingBarIndicatorElement dsi = new DotsSpinnerWaitingBarIndicatorElement();
                rwbDownload.WaitingIndicators.Add(dsi);
                dsi.Radius = radius;
                dsi.ElementCount = elementCount;
                dsi.RotationDirection = (RotationDirection)(i % 2);
            }
            DotsLineWaitingBarIndicatorElement dli = new DotsLineWaitingBarIndicatorElement();
            rwbDownload.WaitingIndicators.Add(dli);
            dli.PositionOffset = new SizeF(0, 50);
            DotsLineWaitingBarIndicatorElement dli1 = new DotsLineWaitingBarIndicatorElement();
            rwbDownload.WaitingIndicators.Add(dli1);
            dli1.WaitingDirection = Telerik.WinControls.ProgressOrientation.Left;
            dli1.PositionOffset = new SizeF(0, -50);
            DotsLineWaitingBarIndicatorElement dli2 = new DotsLineWaitingBarIndicatorElement();
            rwbDownload.WaitingIndicators.Add(dli2);
            dli2.WaitingDirection = Telerik.WinControls.ProgressOrientation.Bottom;
            dli2.PositionOffset = new SizeF(50, 0);
            DotsLineWaitingBarIndicatorElement dli4 = new DotsLineWaitingBarIndicatorElement();
            rwbDownload.WaitingIndicators.Add(dli4);
            dli4.WaitingDirection = Telerik.WinControls.ProgressOrientation.Top;
            dli4.PositionOffset = new SizeF(-50, 0);
            rwbDownload.Location = new Point(10, 10);
            //rwbDownload.WaitingIndicators[0].Text = "Downloading " + gdvDocuments.SelectedRows[0].Cells[0].Value.ToString();
            this.Controls.Add(rwbDownload);
        }
        #endregion

        #region Events

        
        private void gdvDocuments_CellClick(object sender, GridViewCellEventArgs e)
        {
            GetLog(gdvDocuments.SelectedRows[0].Cells[0].Value.ToString());


            //if(gdvDocuments.SelectedRows.Count > 0)
            //{
            //    try
            //    {

            //        string trackingID = gdvDocuments.SelectedRows[0].Cells[0].Value.ToString();
            //        GetLog(trackingID);
            //        string path = UBMMSController.GetDocumentImage(trackingID);
            //        this.documentPath = path;
            //        LoadImage(trackingID);
            //        opStart = DateTime.Now;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    finally
            //    {
            //    }
            //}
            if (!bwDownloadInvoice.IsBusy)
            {
                pdfViewer.Visible = false;
                bwDownloadInvoice.RunWorkerAsync();

                rwbDownload.BringToFront();
                rwbDownload.WaitingIndicators[0].Text = "Downloading " + gdvDocuments.SelectedRows[0].Cells[0].Value.ToString();
                rwbDownload.StartWaiting();

            }
            else
            {
                //bwDownloadInvoice.CancelAsync();
                
                //pdfViewer.Visible = false;
                //bwDownloadInvoice.RunWorkerAsync();

                //rwbDownload.BringToFront();
                //rwbDownload.WaitingIndicators[0].Text = "Downloading " + gdvDocuments.SelectedRows[0].Cells[0].Value.ToString();
                //rwbDownload.StartWaiting();
            }
        }

        private void ddlCustomers_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                if (rbtRefer.IsChecked)
                    LoadProjectCodesDDL(true);
                else
                    LoadProjectCodesDDL(false);
                ddlDocumentType.DataSource = null;
                ddlDocumentType.Text = "";
                ddlProjectCodes.Text = "";
            }
            catch(Exception ex)
            {

            }
        }

        private void ddlCustomers2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtRefer.IsChecked)
                    LoadProjectCodesDDL(true);
                else
                    LoadProjectCodesDDL(false);
                ddlDocumentType.DataSource = null;
                ddlDocumentType.Text = "";
                ddlProjectCodes.Text = "";
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAssignDocuments_Click(object sender, EventArgs e)
        {
            bool queue = false;

            if (ddlDocumentType.Text == "")
            {
                MessageBox.Show("Select document type.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int numberDocuments = 0;
            if (rbt10.IsChecked)
            {
                numberDocuments = 10;
            }
            else if (rbt25.IsChecked)
            {
                numberDocuments = 25;
            }
            else if (rbt50.IsChecked)
            {
                numberDocuments = 50;
            }

            if (rbtRefer.IsChecked)
                queue = true;
            else
                queue = false;

            try
            {
                UBMMSController.AssignDocuments(ddlCustomers2.Text, ddlProjectCodes.Text, ddlDocumentType.Text, numberDocuments, user, queue);
                GetAllDocumentsByUser();
                if (rbtRefer.IsChecked)
                    LoadProjectCodesDDL(true);
                else
                    LoadProjectCodesDDL(false);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdvDocuments.SelectedRows.Count > 0)
                {
                    string id = gdvDocuments.SelectedRows[0].Cells[0].Value.ToString();
                    if (MessageBox.Show("You are saving the document " + id + " and will remove it from your queue.\nAre you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        TimeSpan opDuration = DateTime.Now - opStart;
                        string trackingID = gdvDocuments.SelectedRows[0].Cells[0].Value.ToString();
                        UBMMSController.SaveDocument(trackingID, user, opDuration);
                        GetAllDocumentsByUser();
                        gdvLog.DataSource = null;
                        lblReferDescription.Text = "";
                        txtReferComments.Text = "";
                        MessageBox.Show("Invoice saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //LoadImage();
                        AddHistoricDocument(id);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefer_Click(object sender, EventArgs e)
        {
            if (gdvDocuments.SelectedRows.Count > 0)
            {
                TimeSpan opDuration = DateTime.Now - opStart;
                string trackingID = gdvDocuments.SelectedRows[0].Cells[0].Value.ToString();
                frmRefer form = new frmRefer(trackingID, this.user, this.opStart);
                if(form.ShowDialog() == DialogResult.OK)
                {
                    GetAllDocumentsByUser();
                    gdvLog.DataSource = null;
                }
                lblReferDescription.Text = "";
                txtReferComments.Text = "";
            }
        }

        private void btnAddInformation_Click(object sender, EventArgs e)
        {
            if (gdvDocuments.SelectedRows.Count > 0)
            {
                string trackingID = gdvDocuments.SelectedRows[0].Cells[0].Value.ToString();
                frmAddInformation form = new frmAddInformation(trackingID, this.user, opStart);
                form.ShowDialog();
                GetAllLogs();
                GetLog(trackingID);
                AddHistoricDocument(trackingID);
            }


        }

        private void ddlProjectCodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDocumentType();
        }

        /// <summary>
        /// Classifica o documento selecionado, finalizando o ciclo de vida. O ID do documento é a seleção atual do gdvDocumentos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClassify_Click(object sender, EventArgs e)
        {
            if (gdvDocuments.SelectedRows.Count > 0)
            {
                string trackingID = gdvDocuments.SelectedRows[0].Cells[0].Value.ToString();
                if (MessageBox.Show("You are classifing the document "+ trackingID + " and will remove it from your queue.\nThe document will NOT be available for any other team\nAre you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        TimeSpan opDuration = DateTime.Now - this.opStart;
                        UBMMSController.ClassifyDocument(trackingID, this.user, opDuration);
                        GetAllDocumentsByUser();
                        MessageBox.Show("Document has been classified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The system encountered a failure:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a document to classify.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbtRefer_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (rbtRefer.IsChecked)
            {
                SetLists();
                LoadProjectCodesDDL(true);
                GetAllDocumentsByUser();
                ddlDocumentType.DataSource = null;
            }
            gdvLog.DataSource = null;
            lblReferDescription.Text = "";
            txtReferComments.Text = "";
        }

        private void rbtNormal_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (rbtNormal.IsChecked)
            {
                SetLists();
                LoadProjectCodesDDL(false);
                GetAllDocumentsByUser();
                ddlDocumentType.DataSource = null;
            }
            gdvLog.DataSource = null;
            lblReferDescription.Text = "";
            txtReferComments.Text = "";
        }

        private void gdvLog_CellClick(object sender, GridViewCellEventArgs e)
        {
            //if (gdvLog.SelectedRows.Count > 0)
            //{
            //    try
            //    {
            //        long id = Convert.ToInt64(gdvLog.SelectedRows[0].Cells[3].Value.ToString());
            //        log_documents log = (from l in logs
            //                             where l.id == id
            //                             select l).First();
            //        lblReferDescription.Text = log.op_description;
            //        txtReferComments.Text = log.op_refer_comments;
            //    }
            //    catch(Exception ex)
            //    { }
            //}
           

        }




        #endregion

        private void bwDownloadInvoice_DoWork(object sender, DoWorkEventArgs e)
        {
            if (bwDownloadInvoice.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                if (gdvDocuments.SelectedRows.Count > 0)
                {
                    try
                    {
                        string trackingID = gdvDocuments.SelectedRows[0].Cells[0].Value.ToString();

                        string path = UBMMSController.GetDocumentImage(trackingID);
                        this.documentPath = path;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                    }
                }
            }
        }

        private void bwDownloadInvoice_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //string trackingID = gdvDocuments.SelectedRows[0].Cells[0].Value.ToString();
            
            
            LoadImage(gdvDocuments.SelectedRows[0].Cells[0].Value.ToString());
            opStart = DateTime.Now;
            rwbDownload.StopWaiting();
            pdfViewer.Visible = true;
        }
    }
}
