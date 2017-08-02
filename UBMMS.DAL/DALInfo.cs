using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace UBMMS.DAL
{
    public class DALInfo
    {
        public DALInfo()
        { }

        public List<ProjectCodeInfo> GetProjectCodesInfo(string customerName, user user, bool queue)
        {
            int q = 0;
            if (queue)
                q = 1;
            using (ubmmsEntities db = new ubmmsEntities())
            {
                customer cust = (from c in db.customers
                                 where c.customer_name == customerName
                                 select c).First();
                var t1 = db.Database.SqlQuery<ProjectCodeInfo>("select d.id_project_code, p.project_name, count(d.tracking_id) as total from documents d join project_codes p on d.id_project_code = p.project_code where p.id_customer = " + cust.id.ToString() + " and d.id_team = "+ user.id_team.ToString() + " and d.id_user is null and d.referred = " + q + " and d.finalized = 0 group by d.id_project_code; ").ToList();
                return t1;
            }
        }

        public List<DocumentInfo> GetDocumentTypeInfo(string projectCode, user user, bool queue)
        {
            int q = 0;
            if (queue)
                q = 1;
            using (ubmmsEntities db = new ubmmsEntities())
            {
                var t1 = db.Database.SqlQuery<DocumentInfo>("select distinct documents.document_type, count(documents.tracking_id) as total from documents where documents.id_user is null and documents.id_team = " + user.id_team +" and documents.id_project_code = '"+ projectCode + "' and documents.finalized = 0 and documents.referred = " + q + " group by documents.document_type;").ToList();
                return t1;
            }
        }

    }
}
