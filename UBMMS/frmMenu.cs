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
using UBMMS.Controller;
using Telerik.WinControls.UI.Docking;
using System.IO;
using System.Diagnostics;


namespace UBMMS
{
    public partial class frmMenu : Form
    {
        private user userLogged;
        private int numDocuments = 0;
        public frmMenu()
        {
            InitializeComponent();
            Login();
            SetTempFolders();
            this.dckMenu.ShowToolCloseButton = false;
            DeveloperMode();
            ShowDesktopAlert();
            timerNewDocument.Start();
            radRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem = this.ribbonTab1;
        }

        #region Events

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Settings.frmCustomerManagement frm = new Settings.frmCustomerManagement(this.userLogged);
            frm.ShowDialog();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (CheckForm("Processing"))
            {
                frmProcess form = new frmProcess(this.userLogged);
                dckMenu.DockControl(form, DockPosition.Fill, DockType.Document);
                form.Show();
                ActivateWindow("Processing");
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (CheckForm("Processing"))
            {
                frmProcess form = new frmProcess(this.userLogged);
                dckMenu.DockControl(form, DockPosition.Fill, DockType.Document);
                form.Show();
                ActivateWindow("Processing");
            }
        }

        private void btnRat_Click(object sender, EventArgs e)
        {
            if (CheckForm("Processing"))
            {
                frmProcess form = new frmProcess(this.userLogged);
                dckMenu.DockControl(form, DockPosition.Fill, DockType.Document);
                form.Show();
                ActivateWindow("Processing");
            }
        }

        private void btnInvestigateDoc_Click(object sender, EventArgs e)
        {
            if (CheckForm("Processing"))
            {
                frmProcess form = new frmProcess(this.userLogged);
                dckMenu.DockControl(form, DockPosition.Fill, DockType.Document);
                form.Show();
                ActivateWindow("Processing");
            }
        }

        private void btnReferVerifiedDoc_Click(object sender, EventArgs e)
        {
            if (this.userLogged.user_level>1)
            {
                frmReferFinalized form = new frmReferFinalized(this.userLogged);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("You don't have permission to refer verified documents, please contact you supervisor or manager.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDocumentHistory_Click(object sender, EventArgs e)
        {
            frmDocumentDetail form = new frmDocumentDetail();
            form.ShowDialog();
        }
        private void btnProductivity_Click(object sender, EventArgs e)
        {
            if (this.userLogged.user_level > 1)
            {
                if (CheckForm("Productivity Report"))
                {
                    frmProductivity form = new frmProductivity(this.userLogged);
                    dckMenu.DockControl(form, DockPosition.Fill, DockType.Document);
                    form.Show();
                    ActivateWindow("Productivity Report");
                }
            }
            else
            {
                MessageBox.Show("You don't have permission to access this report.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAZL_Click(object sender, EventArgs e)
        {
            if (this.userLogged.user_level > 1)
            {
                if (CheckForm("AZL"))
                {
                    frmAZL form = new frmAZL();
                    dckMenu.DockControl(form, DockPosition.Fill, DockType.Document);
                    form.Show();
                    ActivateWindow("AZL");
                }
            }
            else
            {
                MessageBox.Show("You don't have permission to access this report.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDocumentsReceived_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This report is under construction!\nCheck back soon.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (this.userLogged.user_level > 1)
            {
                if (CheckForm("Documents Received"))
                {
                    frmDocsReceived form = new frmDocsReceived();
                    dckMenu.DockControl(form, DockPosition.Fill, DockType.Document);
                    form.Show();
                    ActivateWindow("Documents Received");
                }
            }
            else
            {
                MessageBox.Show("I am sorry, you don't have permission to access this information.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnCustomersDashboard_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This report is under construction!\nCheck back soon.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (this.userLogged.id_team == 10 || this.userLogged.user_level == 2)
            {
                if (CheckForm("Customer's Dashboard"))
                {
                    frmCustomersDashboard form = new frmCustomersDashboard();
                    dckMenu.DockControl(form, DockPosition.Fill, DockType.Document);
                    form.Show();
                    ActivateWindow("Customer's Dashboard");
                }
            }
            else
            {
                MessageBox.Show("I am sorry, you don't have permission to access this information.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPilotDashboard_Click(object sender, EventArgs e)
        {
            if (this.userLogged.id_team == 1)
            {
                if (CheckForm("Dashboard"))
                {
                    frmPortal form = new frmPortal();
                    dckMenu.DockControl(form, DockPosition.Fill, DockType.Document);
                    form.Show();
                    ActivateWindow("Dashboard");
                }
            }
            else
            {
                MessageBox.Show("You don't have permission to access this report.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dckMenu_TransactionCommitted(object sender, RadDockTransactionEventArgs e)
        {
            if (e.Transaction.TransactionType == DockTransactionType.Close)
            {
                Form docForm = null;
                HostWindow hostWin = e.Transaction.RemovedWindows[0] as HostWindow;
                if (hostWin != null)
                {
                    Form f = hostWin.Content as Form;
                    if (f != null)
                    {
                        f.Close();
                        if(f.Name == "frmInput")
                        {
                            foreach (Form item in Application.OpenForms)
                            {
                                if(item.Name == "frmDocumentImage")
                                {
                                    docForm = item;
                                }
                            }
                        }
                        if(docForm != null)
                        {
                            docForm.Dispose();
                            docForm.Close();
                        }
                    }
                }
            }
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form docForm = null;
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "frmDocumentImage")
                {
                    docForm = item;
                }
            }

            if (docForm != null)
            {
                docForm.Dispose();
                docForm.Close();
            }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string item in Directory.GetDirectories(@"C:\UBMMSTemp"))
            {
                foreach (string item2 in Directory.GetFiles(item))
                {
                    File.Delete(item2);
                }

                foreach (string item3 in Directory.GetFiles(@"C:\UBMMSTemp"))
                {
                    File.Delete(item3);
                }
                Directory.Delete(item);
            }

        }

        private void btnUploadDoc_Click(object sender, EventArgs e)
        {
            frmUploadDocuments frm = new frmUploadDocuments(this.userLogged);
            frm.ShowDialog();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            bool edit = false;
            if (this.userLogged.user_level>1)
            {
                frmAddUser form = new frmAddUser(this.userLogged,edit);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("I am sorry, you don't have permission to access this information.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }          
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            bool edit = true;
            frmAddUser form = new frmAddUser(this.userLogged,edit);
            form.ShowDialog();
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Directory.CreateDirectory(@"C:\UBMMSTemp");
            Directory.CreateDirectory(@"C:\UBMMSTemp\tif");
        }

        private void btnReassign_Click(object sender, EventArgs e)
        {
            if (this.userLogged.user_level > 1)
            {
                frmReAssign form = new frmReAssign(this.userLogged);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("You don't have permission to reassign documents.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOutstandingInvoices_Click(object sender, EventArgs e)
        {
            if (this.userLogged.id_team == 1)
            {
                if (CheckForm("Outstanding Invoices"))
                {
                    Reports.frmOutstandingInvoices form = new Reports.frmOutstandingInvoices();
                    dckMenu.DockControl(form, DockPosition.Fill, DockType.Document);
                    form.Show();
                    ActivateWindow("Outstanding Invoices");
                }
            }
            else
            {
                MessageBox.Show("You don't have permission to reassign documents.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCustomerProductivity_Click(object sender, EventArgs e)
        {
            
        }

        private void timerNewDocument_Tick(object sender, EventArgs e)
        {
            ShowDesktopAlert();
        }
        private void btnUserDashboard_Click(object sender, EventArgs e)
        {

        }
        private void bteGroupInvoices_Click(object sender, EventArgs e)
        {
            if (this.userLogged.id_team == 1)
            {
                if (CheckForm("Group Invoices"))
                {
                    OnBoarding.frmGroupInvoices form = new OnBoarding.frmGroupInvoices(this.userLogged);
                    dckMenu.DockControl(form, DockPosition.Fill, DockType.Document);
                    form.Show();
                    ActivateWindow("Group Invoices");
                }
            }
            else
            {
                MessageBox.Show("You don't have permission to access this report.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bteTariffAllocation_Click(object sender, EventArgs e)
        {
            if(this.userLogged.id_team ==1 /*|| this.userLogged.id_team == 5*/)
            {
                if (CheckForm("Tariff Allocation"))
                {
                    OnBoarding.frmTariffAllocation form = new OnBoarding.frmTariffAllocation();
                    dckMenu.DockControl(form, DockPosition.Fill, DockType.Document);
                    form.Show();
                    ActivateWindow("Tariff Allocation");
                }
            }
            else
            {
                MessageBox.Show("You don't have permission to acess this report.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rmiUserManual_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"\\sbrdocs\Documentos\UBMMS\Documentos\Manual\ManualdoUsuario.pdf");
            }
            catch (Exception)
            {
                MessageBox.Show("It was not possible to locate the user manual, please contact Software & Tools team", "Manual not found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Atualiza o texto dos radmenuitens History
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiHistory_DropDownOpening(object sender, CancelEventArgs e)
        {
            if (Properties.Settings.Default.Document1 != "")
            {
                rmiHDocument1.Text = Properties.Settings.Default.Document1;
            }
            else
            {
                rmiHDocument1.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }
            if (Properties.Settings.Default.Document2 != "")
            {
                rmiHDocument2.Text = Properties.Settings.Default.Document2;
            }
            else
            {
                rmiHDocument2.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }

            if (Properties.Settings.Default.Document3 != "")
            {
                rmiHDocument3.Text = Properties.Settings.Default.Document3;
            }
            else
            {
                rmiHDocument3.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }

            if (Properties.Settings.Default.Document4 != "")
            {
                rmiHDocument4.Text = Properties.Settings.Default.Document4;
            }
            else
            {
                rmiHDocument4.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }

            if (Properties.Settings.Default.Document5 != "")
            {
                rmiHDocument5.Text = Properties.Settings.Default.Document5;
            }
            else
            {
                rmiHDocument5.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }
        }

        private void OpenfromHistoric(object sender, EventArgs e)
        {
            Telerik.WinControls.UI.RadMenuItem documentID = (Telerik.WinControls.UI.RadMenuItem)sender;
            if (documentID.Text != String.Empty)
            {
                frmDocumentDetail form = new frmDocumentDetail(documentID.Text);
                form.Show();
            }
        }

        private void btnLoadedDocuments_Click(object sender, EventArgs e)
        {
            if (userLogged.id_team == 7 || userLogged.id_team == 1)
            {
                frmLoadedDocuments frm = new frmLoadedDocuments(userLogged);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You don't have permission to acess this report.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInvoicesStamped_Click(object sender, EventArgs e)
        {
            if (CheckForm("Invoices Stamped"))
            {
                Reports.frmStampedInvoices form = new Reports.frmStampedInvoices();
                dckMenu.DockControl(form, DockPosition.Fill, DockType.Document);
                form.Show();
                ActivateWindow("Invoices Stamped");
            }
        }

        private void btnDocManager_Click(object sender, EventArgs e)
        {
            if(userLogged.id_team == 7  || userLogged.id_team ==1)
            {
                if (CheckForm("Document Manager"))
                {
                    frmDocumentManager form = new frmDocumentManager(userLogged);
                    dckMenu.DockControl(form, DockPosition.Fill, DockType.Document);
                    form.Show();
                    ActivateWindow("Document Manager");
                }
            }
            else
            {
                MessageBox.Show("Document Manager is under testing and will be released soon", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        #endregion

        #region Methods

        /// <summary>
        /// Ativa os botões do menu com base no id_tem do usuário logado 
        /// </summary>
        public void Login()
        {
            using (frmLogin f = new frmLogin())
            {
                var result = f.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.userLogged = f.User;
                    if(this.userLogged.email == "admin" || this.userLogged.email == "input")
                    {
                        btnPilotDashboard.Enabled = true;
                    }
                    if(userLogged.id_team == 2)
                    {
                        btnVer.Enabled = false;
                        btnRat.Enabled = false;
                        btnUploadDoc.Enabled = false;
                        btnInvestigateDoc.Enabled = false;
                        btnLoadedDocuments.Enabled = false;
                    }
                    else if(userLogged.id_team == 3)
                    {
                        btnInput.Enabled = false;
                        btnRat.Enabled = false;
                        btnUploadDoc.Enabled = false;
                        btnInvestigateDoc.Enabled = false;
                        btnLoadedDocuments.Enabled = false;
                    }
                    else if (userLogged.id_team == 5)
                    {
                        btnVer.Enabled = false;
                        btnInput.Enabled = false;
                        btnUploadDoc.Enabled = false;
                        btnInvestigateDoc.Enabled = false;
                        btnLoadedDocuments.Enabled = false;
                    }
                    else if (userLogged.id_team == 7)
                    {
                        btnInput.Enabled = false;
                        btnVer.Enabled = false;
                        btnRat.Enabled = false;
                        btnInvestigateDoc.Enabled = true;
                        btnLoadedDocuments.Enabled = true;
                    }
                    else if (userLogged.id_team == 4)
                    {
                        btnInput.Enabled = false;
                        btnVer.Enabled = false;
                        btnRat.Enabled = false;
                        btnUploadDoc.Enabled = false;
                        btnInvestigateDoc.Enabled = true;
                        btnLoadedDocuments.Enabled = false;
                    }
                    else if (userLogged.id_team == 6)
                    {
                        btnInput.Enabled = false;
                        btnVer.Enabled = false;
                        btnRat.Enabled = false;
                        btnUploadDoc.Enabled = false;
                        btnInvestigateDoc.Enabled = true;
                        btnLoadedDocuments.Enabled = false;
                    }
                    else if (userLogged.id_team == 9)
                    {
                        btnInput.Enabled = false;
                        btnVer.Enabled = false;
                        btnRat.Enabled = false;
                        btnUploadDoc.Enabled = false;
                        btnInvestigateDoc.Enabled = true;
                        btnLoadedDocuments.Enabled = false;
                    }
                    else if (userLogged.id_team == 10)
                    {
                        btnInput.Enabled = false;
                        btnVer.Enabled = false;
                        btnRat.Enabled = false;
                        btnUploadDoc.Enabled = false;
                        btnInvestigateDoc.Enabled = true;
                        btnLoadedDocuments.Enabled = false;
                    }
                    else if (userLogged.id_team == 11)
                    {
                        btnInput.Enabled = false;
                        btnVer.Enabled = false;
                        btnRat.Enabled = false;
                        btnUploadDoc.Enabled = false;
                        btnInvestigateDoc.Enabled = true;
                        btnLoadedDocuments.Enabled = false;
                    }
                }
                else
                {
                    this.Close();
                }
            }
        }

        private bool CheckForm(string formName)
        {
            foreach (DockWindow item in dckMenu.DockWindows.DocumentWindows)
            {
                if (item.Text == formName)
                {
                    dckMenu.ActivateWindow(item);
                    return false;
                }
            }

            return true;
        }

        private void ActivateWindow(string formName)
        {
            foreach (DockWindow item in dckMenu.DockWindows.DocumentWindows)
            {
                if (item.Text == formName)
                {
                    dckMenu.ActivateWindow(item);
                }
            }
        }

        private void SetTempFolders()
        {
            bw.RunWorkerAsync();
        }

        /// <summary>
        /// Carrega a notificação com o número de faturas disponíveis para o time do usuário
        /// </summary>
        private void ShowDesktopAlert()
        {
            int height = 25;     //define a altura da janela de alerta - Minimo de 25 para quando houver somente 1 ou 2 itens. No tema MetroBlue, cada linha de texto tem 16px de altura
            DataTable dt = UBMMSController.DocumentsTeam(this.userLogged);
            string caption = "Number of documents per customer:";
            string content = "Queue status on " + DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToShortTimeString() + "\n\n";
            
            if(dt.Rows.Count>0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    height = height + 16;       //incrementos de 16 px para cada linha de texto.
                    content = content + item[0].ToString() + ": " + item[1].ToString() + "\n";
                }
            }
            else
            {
                height = height + 50;
                content = content + "No outstanding invoices for your team\n";
            }           

            this.dskNewDocument.CaptionText = caption;
            this.dskNewDocument.ContentText = content;
            this.dskNewDocument.FixedSize = new Size(380, height + 50);
            this.dskNewDocument.Show();
        }

        /// <summary>
        /// Metodo para ocultar itens de menu que ainda estão em desenvolvimento
        /// </summary>
        private void DeveloperMode()
        {
            if (userLogged.id_team != 1)
            {
                ribbonTab5.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;  //oculta command bar Onboarding
                btnOutstandingInvoices.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
                //btnDocManager.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }
        }



        #endregion

        
    }
}
