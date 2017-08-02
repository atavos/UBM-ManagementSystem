using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace UBMMS.DAL
{
    public class DALTeam
    {
        public DALTeam()
        { }

        public List<team> SelectAll()
        {
            using (ubmmsEntities db = new ubmmsEntities())
            {
                List<team> list = (from t in db.teams.Include(r=>r.refers_codes)
                                  select t).ToList();

                return list;
            }
        }
    }
}
