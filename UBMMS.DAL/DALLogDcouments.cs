using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace UBMMS.DAL
{
    public class DALLogDcouments
    {
        public DALLogDcouments()
        { }

        public List<log_documents> SelectByTrackingID(string trackingID)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                List<log_documents> result = (from l in db.log_documents
                                             where l.tracking_id == trackingID
                                             orderby l.op_date ascending
                                             select l).ToList();
                return result;
            }
        }

        public List<log_documents> SelectByRangeOfIDs(List<string> docs)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                List<log_documents> result = (from l in db.log_documents
                                             where docs.Contains(l.tracking_id)
                                             select l).ToList();
                return result;
            }
        }

        public object SelectLogByTrackingID(string trackingID)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                //var result = (from l in db.log_documents
                //              join t in db.teams on l.op_user_team equals t.id
                //              where l.tracking_id == trackingID
                //              select new { l.op_code, l.op_date, l.op_description, l.op_refer_code, l.op_refer_comments, t.team_name, l.id });

                var result = (from l in db.log_documents
                              from t in db.teams
                              .Where(w => w.id == l.destination_team).DefaultIfEmpty()
                              join t2 in db.teams on l.op_user_team equals t2.id
                              join t3 in db.users on l.op_user equals t3.id_user
                              where l.tracking_id == trackingID
                              select new { l.op_code, l.op_date, l.op_description, l.op_refer_code, l.op_refer_comments, t2.team_name, t3.user_name, destination_team=t.team_name, l.id }).ToList();

                return result.ToList();
            }
        }

        public void InsertInformation(string trackingID, user u, string information, TimeSpan Duration)
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                log_documents log = new log_documents();
                log.tracking_id = trackingID;
                log.op_code = "INFORMATION";
                log.op_description = "Information added";
                log.op_date = DateTime.Now;
                log.action_time = Duration;
                log.op_refer_comments = information;
                log.op_user = u.id_user;
                log.op_user_team = u.id_team;
                log.destination_team = u.id_team;

                db.log_documents.Add(log);

                db.SaveChanges();
            }
        }
    }
}
