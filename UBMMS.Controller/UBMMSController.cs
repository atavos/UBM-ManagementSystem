using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBMMS.DAL;

namespace UBMMS.Controller
{
    public static class UBMMSController
    {
        public static user CheckUser(user u)
        {
            DALUser dal = new DALUser();
            return dal.Select(u);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="queue"></param>
        /// <returns></returns>
        public static object GetAllDocumentsByUser(user user, bool queue)
        {
            DALDocuments dal = new DALDocuments();
            return dal.SelectAllByUser(user, queue);
        }

        public static object SelectDocumentsByUser(int idUser, bool queue)
        {
            DALDocuments dal = new DALDocuments();
            return dal.SelectDocumentsByUser(idUser, queue);
        }

        public static object SelectDocumentsByUserReassign(int idUser)
        {
            DALDocuments dal = new DALDocuments();
            return dal.SelectDocumentsByUserReassign(idUser);
        }


        public static void ReassignDocuments(List<string> ids, user u)
        {
            DALDocuments dal = new DALDocuments();
            dal.ReassingDocument(ids, u);
        }

        /// <summary>
        /// Select All Customers and includes other tables as project codes - lazy load
        /// </summary>
        /// <returns></returns>
        public static List<customer> GetAllCustomers()
        {
            DALCustomer dal = new DALCustomer();
            return dal.SelectAll();
        }

        /// <summary>
        /// Busca uma lista com todos os clientes ativos e suas dependencias
        /// </summary>
        /// <returns></returns>
        public static List<customer> GetAllActiveCustomers()
        {
            DALCustomer dal = new DALCustomer();
            return dal.SelectAllforActiveCustomers();
        }

        public static List<customer> GetAllCustomersEagerLoad()
        {
            DALCustomer dal = new DALCustomer();
            return dal.GetCustomersProjects();
        }

        public static void AssignDocuments(string customerName, string projectCode, string documentType, int numberDocuments, user u, bool queue)
        {
            DALDocuments dal = new DALDocuments();
            dal.AssignDocuments(customerName, projectCode, documentType, numberDocuments, u, queue);
        }

        /// <summary>
        /// download the document file from InfoLCM FTP
        /// </summary>
        /// <param name="trackingID"></param>
        /// <returns></returns>
        public static string GetDocumentImage(string trackingID)
        {
            DALDocuments dal = new DALDocuments();
            return dal.GetDocumentImage(trackingID);
        }

        public static void SaveDocument(string trackingID, user user, TimeSpan opDuration)
        {
            DALDocuments dal = new DALDocuments();
            dal.SaveDocument(trackingID, user, opDuration);
        }

        public static List<ProjectCodeInfo> GetProjectCodesInfo(string customerName, user user, bool queue)
        {
            DALInfo dal = new DALInfo();
            return dal.GetProjectCodesInfo(customerName, user, queue);
        }

        public static List<DocumentInfo> GetDocumentTypeInfo(string projectCode, user user, bool queue)
        {
            DALInfo dal = new DALInfo();
            return dal.GetDocumentTypeInfo(projectCode, user, queue);
        }

        public static void InsertDocument(List<document> doc, user user)
        {
            DALDocuments dal = new DALDocuments();
            dal.InsertDocument(doc, user);
        }

        
        public static List<log_documents> SelectLogsByTrackingID(string trackingID)
        {
            DALLogDcouments dal = new DALLogDcouments();
            return dal.SelectByTrackingID(trackingID);
        }

        public static object SelectLog(string trackingID)
        {
            DALLogDcouments dal = new DALLogDcouments();
            return dal.SelectLogByTrackingID(trackingID);
        }

        public static List<log_documents> SelectLogsByRangeOfIDs(List<string> docs)
        {
            DALLogDcouments dal = new DALLogDcouments();
            return dal.SelectByRangeOfIDs(docs);
        }

        public static void ReferDocument(string trackingID, int referTo, string referCode, string referComments, string referDesc, user u, TimeSpan opDuration)
        {
            DALDocuments dal = new DALDocuments();
            dal.ReferDocument(trackingID, referTo, referCode, referComments, referDesc, u, opDuration);
        }

        public static List<team> SelectAllTeams()
        {
            DALTeam dal = new DALTeam();
            return dal.SelectAll();
        }

        public static List<user> SelectUsersByTeam(int idTeam)
        {
            DALUser dal = new DALUser();
            return dal.SelectUsersByTeam(idTeam);
        }

        public static void ClassifyDocument(string trackingID, user u, TimeSpan opDuration)
        {
            DALDocuments dal = new DALDocuments();
            dal.ClassifyDocument(trackingID, u, opDuration);
        }

        /// <summary>
        /// Obtem a quantidade de documentos para os clientes ativos para o time do usuário
        /// </summary>
        /// <param name="user">objeto usuário logado</param>
        /// <returns>datatable</returns>
        public static DataTable DocumentsTeam(user user)
        {
            DALCustomer dal = new DALCustomer();
            return dal.DocumentsTeam(user);
        }

        public static void AddInformation(string trackingID, user u, string information, TimeSpan opDuration)
        {
            DALLogDcouments dal = new DALLogDcouments();
            dal.InsertInformation(trackingID, u, information, opDuration);
        }

        public static void CreateNewUser(user user)
        {
            DALUser dal = new DALUser();
            dal.CreateUser(user);
        }

        public static void UpdateExistinguser(user user)
        {
            DALUser dal = new DALUser();
            dal.UpdateUser(user);
        }

        public static void UpdateNumPages(string trackingID, int numPages)
        {
            DALDocuments dal = new DALDocuments();
            dal.UpdateNumPages(trackingID, numPages);
        }

        public static List<document> SelectDocuments(List<string> docs)
        {
            DALDocuments dal = new DALDocuments();
            return dal.SelectDocuments(docs);
        }

        public static DataTable CustomersWithPendingDocuments(user u, bool queue)
        {
            DALCustomer dal = new DALCustomer();
            return dal.CustomerWithPendingDocuments(u, queue);
        }

        /// <summary>
        /// Create a new customer
        /// </summary>
        /// <param name="customer"></param>
        public static void CreateNewCustomer( customer customer)
        {
            DALCustomer dal = new DALCustomer();
            dal.CreateNewCustomer(customer);
        }

        /// <summary>
        /// Update existing customer information
        /// </summary>
        /// <param name="customer"></param>
        public static void UpdateCustomer(customer customer)
        {
            DALCustomer dal = new DALCustomer();
            dal.UpdateCustomer(customer);
        }

        /// <summary>
        /// Cria um novo project Code no banco
        /// </summary>
        /// <param name="project">EF project_code</param>
        public static void CreateNewProjectCode(project_codes project)
        {
            DALCustomer dal = new DALCustomer();
            dal.CreateNewProjectCode(project);
        }

        /// <summary>
        /// Atualiza um project Code existente
        /// </summary>
        /// <param name="project">EF project_code</param>
        public static void UpdateProject(project_codes project)
        {
            DALCustomer dal = new DALCustomer();
            dal.UpdateProjectCode(project);
        }

        /// <summary>
        /// Get a datatable with the uploaded documents on InfoLCM
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public static DataTable GetUploadedDocuments(DateTime from, DateTime to)
        {
            DALDocuments dal = new DALDocuments();
            
            DataTable LoadedDocuments = dal.GetUploadedDocuments(from, to);
            //List<project_codes> projects = UBMMSController.GetAllCustomersEagerLoad().SelectMany(c => c.project_codes).ToList();

            //foreach (DataRow item in LoadedDocuments.Rows)
            //{
            //    var id = item[2];
                
            //    if (projects.Where(code => code.project_code == item[2].ToString() && code.enabled==true).FirstOrDefault() == null)
            //    {
            //        item.Delete();       
            //    }
            //}
            //LoadedDocuments.AcceptChanges();
            return LoadedDocuments;
        }

        public static DataTable UploadDocumentsFromInfo(List<document> doc, List<log_documents> log, user user)
        {
            DALDocuments dal = new DALDocuments();
            DataTable output = dal.UploadDocumentsFromInfo(doc, log, user);

            return output;
        }

        public static DataTable OutstandingInvoices(DateTime from, DateTime to, List<string> projectcodes, string status)
        {
            DALReports dal = new DALReports();
            DataTable output = dal.OutstandingInvoices(from, to, projectcodes, status);

            return output;
        }

        public static List<document> GetDocumentsList (customer customer, DateTime from, DateTime to)
        {
            DALDocuments dal = new DALDocuments();
            List<document> docsList = dal.GetDocumentsList(customer, from, to);

            return docsList;
        }

        public static DataTable UpdateDocumentDetails(List<document> DocID, user u)
        {
            DALDocuments dal = new DALDocuments();
            DataTable output = dal.UpdateDocumentDetails(DocID, u);

            return output;
        }

        /// <summary>
        /// Gets InfoLCM Projects information
        /// </summary>
        /// <returns>datatable</returns>
        public static DataTable InfoLCMProjects()
        {
            DALReports dal = new DALReports();
            DataTable dt = dal.InfoProjectCodes();
            return dt;
        }

        /// <summary>
        /// Get InfoLCM Groups along with project code
        /// </summary>
        /// <returns></returns>
        public static DataTable InfoLCMGroups()
        {
            DALReports dal = new DALReports();
            DataTable dt = dal.InfoGroups();
            return dt;
        }
    }
}
