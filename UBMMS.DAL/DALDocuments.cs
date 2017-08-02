using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.IO;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;

namespace UBMMS.DAL
{
    public class DALDocuments
    {
        private string _InfoLCMServer;
        public DALDocuments()
        {
            //Em caso de mudança de senha, favor alterar também a variável de mesmo nome em DAL.Reports
            _InfoLCMServer = "";
        }

        public void AssignDocuments(string customerName, string projectCode, string documentType, int numberDocuments, user u, bool queue)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                int team = 0;

                var result = (from c in db.customers
                              from p in c.project_codes
                              from d in p.documents
                              from l in db.log_documents
                              where (c.customer_name == customerName && p.project_code == projectCode && d.document_type == documentType && d.id_user == null && d.id_team == u.id_team && d.finalized == false && d.referred == queue) && (d.tracking_id == l.tracking_id && l.op_code == "UPLOAD") && c.enabled==true orderby l.op_date ascending
                              select d).Take(numberDocuments).ToList();



                foreach (document item in result)
                {
                    log_documents l = new log_documents();
                    l.tracking_id = item.tracking_id;
                    l.op_code = "ASSIGN";
                    l.op_description = "Document assigned.";
                    l.op_user = u.id_user;
                    l.op_user_team = u.id_team;
                    l.op_date = DateTime.Now;
                    db.log_documents.Add(l);
                    item.id_user = u.id_user;
                }
                db.SaveChanges();
            }
        }

        public void ClassifyDocument(string trackingID, user u, TimeSpan opDuration)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                document doc = (from d in db.documents
                               where d.tracking_id == trackingID
                               select d).First();
                doc.finalized = true;
                doc.id_user = null;

                log_documents l = new log_documents();
                l.tracking_id = trackingID;
                l.op_code = "CLASSIFY";
                l.op_description = "Document classified";
                l.op_date = DateTime.Now;
                l.op_user = u.id_user;
                l.op_user_team = u.id_team;
                l.action_time = opDuration;
                db.log_documents.Add(l);

                db.SaveChanges();
            }
        }

        public void UpdateNumPages(string trackingID, int numPages)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                document doc = (from d in db.documents
                                where d.tracking_id == trackingID
                                select d).FirstOrDefault();
                if(doc.num_pages == null || doc.num_pages == 0)
                {
                    doc.num_pages = numPages;
                    db.SaveChanges();
                }
            }
        }

        public object SelectAllByUser(user user, bool queue)
        {

            using (ubmmsEntities db = new ubmmsEntities())
            {
                var result = (from d in db.documents
                              join p in db.project_codes on d.id_project_code equals p.project_code
                              join c in db.customers on p.id_customer equals c.id
                              join l in db.log_documents on d.tracking_id equals l.tracking_id
                              where d.id_team == user.id_team && d.id_user == user.id_user && d.referred == queue && d.finalized == false && l.op_code == "UPLOAD"
                              select new { d.tracking_id, d.id_project_code, d.document_type, c.customer_name, l.op_date });
                return result.ToList();
            }
        }

        public object SelectDocumentsByUser(int idUser, bool queue)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                var result = (from d in db.documents
                              join p in db.project_codes on d.id_project_code equals p.project_code
                              join c in db.customers on p.id_customer equals c.id
                              where d.id_user == idUser && d.referred == queue && d.finalized == false
                              select new { d.tracking_id, d.id_project_code, d.document_type, c.customer_name });
                return result.ToList();
            }
        }

        public object SelectDocumentsByUserReassign(int idUser)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                //var result = (from d in db.documents
                //              join p in db.project_codes on d.id_project_code equals p.project_code
                //              join c in db.customers on p.id_customer equals c.id
                //              where d.id_user == idUser && d.finalized == false
                //              select new { d.tracking_id, d.id_project_code, d.document_type, c.customer_name, d.referred });

                var result = (from d in db.documents
                              join p in db.project_codes on d.id_project_code equals p.project_code
                              join c in db.customers on p.id_customer equals c.id
                              join l in db.log_documents on d.tracking_id equals l.tracking_id
                              where d.id_user == idUser && d.finalized == false && l.op_code=="UPLOAD"
                              select new { d.tracking_id, d.id_project_code, d.document_type, c.customer_name, d.referred, l.op_date });

                return result.ToList();
            }
        }


        /// <summary>
        /// Download the tracking id document from InfoLCM
        /// </summary>
        /// <param name="trackingID"></param>
        /// <returns></returns>
        public string GetDocumentImage(string trackingID)
        {
            try
            {
                Directory.CreateDirectory(@"C:\UBMMSTemp");
                string folder = trackingID.Substring(trackingID.Length - 4, 4);
                FTPClient ftp = new FTPClient(@"ftp://64.40.104.12", "Tiffsource", "Z4S89w5xPh");

                string[] info = ftp.directoryListDetailed(folder);
                string file = (from t in info
                              where t.Substring(t.Length - 12, 8) == trackingID
                              select t.Substring(t.Length - 12, 12)).First();

                ftp.download(folder + @"/" + file, @"C:\UBMMSTemp\" + file);
                return @"C:\UBMMSTemp\" + file;
            }
            catch (Exception ex)
            {
                throw new Exception("The document image could not be opened.\nPlease contact your support.");
            }
            return null;
        }

        public void SaveDocument(string trackingID, user user, TimeSpan opDuration)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                log_documents l = new log_documents();

                document result = (from d in db.documents
                             where d.tracking_id == trackingID
                             select d).First();
                l.op_user = user.id_user;
                l.op_user_team = user.id_team;
                l.op_date = DateTime.Now;
                l.tracking_id = result.tracking_id;
                l.action_time = opDuration;
                if (user.id_team == 2)
                {
                    result.id_team = 3;
                    result.id_user = null;
                    l.op_code = "PROCESS";
                    l.op_description = "Document processed.";
                }
                else if(user.id_team == 3)
                {
                    result.finalized = true;
                    result.id_user = null;
                    l.op_code = "VERIFY";
                    l.op_description = "Document verified.";
                }
                db.log_documents.Add(l);
                db.SaveChanges();
            }
        }

        public void ReassingDocument(List<string> docs, user u)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                List<document> result = (db.documents.Where(item => docs.Contains(item.tracking_id))).ToList();

                foreach (document item in result)
                {
                    log_documents l = new log_documents();
                    l.tracking_id = item.tracking_id;
                    l.op_code = "REASSIGN";
                    l.op_description = "Document reassigned";
                    l.op_date = DateTime.Now;
                    l.op_user = u.id_user;
                    l.op_user_team = u.id_team;
                    item.id_user = null;
                    db.log_documents.Add(l);
                }
                db.SaveChanges();
            }
        }

        public void InsertDocument(List<document> doc, user user)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                foreach (document item in doc)
                {
                    item.id_team = 2;
                    item.finalized = false;
                    item.referred = false;
                    db.documents.Add(item);

                    log_documents l = new log_documents();
                    l.tracking_id = item.tracking_id;
                    l.op_code = "UPLOAD";
                    l.op_description = "Document uploaded";
                    l.op_date = DateTime.Now;
                    l.op_user = user.id_user;
                    l.op_user_team = user.id_team;

                    db.log_documents.Add(l);
                }
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Salva documentos no banco do MS após checar se eles já existem
        /// </summary>
        /// <param name="doc">Lista de documentos</param>
        /// <param name="log">Informações para Log_Documents</param>
        /// <param name="user">Dados do usuário</param>
        /// <returns>Datatable com documentos que foram carregados e não carregados</returns>
        public DataTable UploadDocumentsFromInfo(List<document> doc, List<log_documents> log, user user)
        {
            DALLogDcouments doclog = new DALLogDcouments();
            DataTable output = new DataTable();
            output.Columns.Add("Tracking ID");
            output.Columns.Add("Project Code");
            output.Columns.Add("Status");
            using (ubmmsEntities db = new ubmmsEntities())
            {
                foreach (document item in doc)
                {
                    //check if the project is on MS and return specific information if not
                    if(db.project_codes.Any(t=>t.project_code==item.id_project_code)==false)
                    {
                        output.Rows.Add(item.tracking_id, item.id_project_code, "Project Code not on MS");
                    }
                    else
                    {
                        //check the status of the project code and if Inactive, remove the item from load
                        if(db.project_codes.Where(e => e.project_code == item.id_project_code).Select(e => e.enabled).FirstOrDefault()==false)
                        {
                            output.Rows.Add(item.tracking_id, item.id_project_code, "Project INACTIVE on MS");
                        }
                        else
                        {
                            //check if the current document is not already loaded on MS
                            if (db.documents.Any(t => t.tracking_id == item.tracking_id))
                            {
                                output.Rows.Add(item.tracking_id, item.id_project_code, "Duplicated");
                            }
                            else
                            {
                                db.documents.Add(item);

                                log_documents l = new log_documents();
                                l.tracking_id = item.tracking_id;
                                l.op_code = "UPLOAD";
                                l.op_description = "Document uploaded from InfoLCM";
                                int index = doc.IndexOf(item);
                                l.op_refer_comments = "Date Loaded to InfoLCM: " + log[doc.IndexOf(item)].op_refer_comments;
                                l.op_date = DateTime.Now;
                                l.op_user = user.id_user;
                                l.op_user_team = user.id_team;
                                db.log_documents.Add(l);

                                output.Rows.Add(item.tracking_id, item.id_project_code, "Loaded");
                            }
                        }

                    }
                    
                }
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return output;
        }

        public void ReferDocument(string trackingID, int referTo, string referCode, string referComments, string referDesc, user u, TimeSpan opDuration)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                document result = (from d in db.documents
                                   where d.tracking_id == trackingID
                                   select d).First();
                result.id_team = referTo;
                result.id_user = null;
                result.referred = true;
                result.finalized = false;

                log_documents l = new log_documents();
                l.tracking_id = trackingID;
                l.op_user = u.id_user;
                l.op_refer_code = referCode;
                l.op_code = "REFER";
                l.op_date = DateTime.Now;
                l.op_user_team = u.id_team;
                l.op_refer_comments = referComments;
                l.op_description = referDesc;
                l.action_time = opDuration;
                l.destination_team = referTo;
                db.log_documents.Add(l);

                db.SaveChanges();
            }
        }

        /// <summary>
        /// select a single document from the database
        /// </summary>
        /// <param name="docs"></param>
        /// <returns></returns>
        public List<document> SelectDocuments(List<string> docs)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                List<document> result = (db.documents.Where(item => docs.Contains(item.tracking_id))).ToList();
                return result;
            }
        }

        /// <summary>
        /// gets a list of documents for a specific customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>list document</returns>
        public List<document> GetDocumentsList(customer customervalue, DateTime from, DateTime to)
        {
            ubmmsEntities db = new ubmmsEntities();
            //List<document> docslist = db.documents.Where(c => c.project_codes.customer.Equals(customer.id)).ToList();

            var docslist = (from d in db.documents
                            join p in db.project_codes on d.id_project_code equals p.project_code
                            join c in db.customers on p.id_customer equals c.id
                            join l in db.log_documents on d.tracking_id equals l.tracking_id
                            where c.id == customervalue.id && l.op_code == "UPLOAD" &&  l.op_date >= @from && l.op_date <=@to
                            select d);


            return docslist.ToList();
        }

        public DataTable UpdateDocumentDetails (List<document> DocID, user u)
        {
            DataTable output = new DataTable();
            output.Columns.Add("Tracking ID");
            output.Columns.Add("Status");
            using (ubmmsEntities db = new ubmmsEntities())
            {
                
                foreach(document item in DocID)
                {
                    if(db.documents.Any(d => item.tracking_id.Contains(d.tracking_id))==true)
                    {
                        

                        if (db.project_codes.Any(p => item.id_project_code.Contains(p.project_code)) == true)
                        {
                            List<document> IdsToUpdate = db.documents.Where(d => item.tracking_id.Contains(d.tracking_id)).ToList();
                            //IdsToUpdate.ForEach(a => a.document_type = item.document_type);
                            //IdsToUpdate.ForEach(a => a.id_project_code = item.id_project_code);
                            IdsToUpdate.ForEach(a =>
                            {
                                a.document_type = item.document_type;
                                a.id_project_code = item.id_project_code;
                            });


                            log_documents l = new log_documents();
                            l.tracking_id = item.tracking_id;
                            l.op_code = "Documet Update";
                            l.op_description = "Update from Document Manager module";
                            l.op_refer_comments = "Values set by user are:\n" + item.document_type + "\n" + item.id_project_code;
                            l.op_date = DateTime.Now;
                            l.op_user = u.id_user;
                            l.op_user_team = u.id_team;
                            db.log_documents.Add(l);

                            output.Rows.Add(item.tracking_id, "Changes applied");

                            
                        }
                        else
                        {
                            output.Rows.Add(item.tracking_id, "Project Code Informed does not exist on MS");
                        }
                    }
                    else
                    {
                        output.Rows.Add(item.tracking_id, "Document ID does not exist on MS");
                    }
                    
                }
                
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    if(ex.InnerException.InnerException.HResult == -2147467259)
                    {
                        throw new Exception("Invalid Project Code, please review and try again");
                    }
                    else
                    {
                        throw new Exception(ex.InnerException.InnerException.Message);
                    }
                    
                }
                
            }
            return output;

        }
        /// <summary>
        /// Gets the documents uploaded in InfoLCM
        /// </summary>
        /// <param name="from">Start date with time</param>
        /// <param name="to">End date with time</param>
        /// <returns>Datatable</returns>
        public DataTable GetUploadedDocuments (DateTime from, DateTime to)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_InfoLCMServer))
            {
                string datefrom = from.ToString("yyyy-MM-dd HH:mm:ss");
                string dateto = to.ToString("yyyy-MM-dd HH:mm:ss");
                string query = "select t.TIFFileName as [Tracking ID], t.FileName as [File Name], t.ProjectCode as [Project Code], d.Doc_Type as [Document Type], t.EmailSubject as [Email Subject], t.DateTime_LoadedToInfoLCM as [Loaded to InfoLCM] from TULog t inner join Documents d on t.DocumentType = d.doc_id WHERE t.isSaved = 1 AND t.DateTime_LoadedToInfoLCM BETWEEN '" + from.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + to.ToString("yyyy-MM-dd HH:mm:ss") + "';";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    //SqlDataReader dr = cmd.ExecuteReader();
                    //dt.Load(dr);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

    }
}