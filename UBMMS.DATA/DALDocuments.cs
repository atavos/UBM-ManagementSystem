using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBMMS.DATA
{
    public class DALDocuments
    {
        public DALDocuments()
        { }

        public void AssignDocuments(string customerName, string projectCode, string documentType, int numberDocuments, user u)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                int team = 0;

                var result = (from c in db.customers
                              from p in c.project_codes
                              from d in p.documents
                              where c.customer_name == customerName && p.project_code == projectCode && d.document_type == documentType && d.sstem_user == null && d.id_team == u.id_team && d.finalized == false
                              select d).Take(numberDocuments).ToList();

                foreach (document item in result)
                {
                    item.sstem_user = u.sstem_user;
                }
                db.SaveChanges();
            }
        }

        public object SelectAllByUser(user user, bool queue)
        {

            using (ubmmsEntities db = new ubmmsEntities())
            {
                var result = (from d in db.documents
                              join p in db.project_codes on d.id_project_code equals p.project_code
                              join c in db.customers on p.id_customer equals c.id
                              where d.id_team == user.id_team && d.sstem_user == user.sstem_user && d.referred == queue && d.finalized == false
                              select new { d.tracking_id, d.id_project_code, d.document_type, c.customer_name });
                return result.ToList();
            }
        }

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

            }
            return null;
        }

        public void SaveDocument(string trackingID, user user)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {

                document result = (from d in db.documents
                                   where d.tracking_id == trackingID
                                   select d).First();
                if (user.id_team == 2)
                {
                    result.id_team = 3;
                    result.sstem_user = null;
                }
                else if (user.id_team == 3)
                {
                    result.finalized = true;
                    result.sstem_user = null;
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

                    log_documents log = new log_documents();
                    log.tracking_id = "teste";
                    db.log_documents.Add(log);
                }
                db.SaveChanges();
            }
        }

        public void ReferDocument(string trackingID, string referTo, user u)
        { }
    }
}
