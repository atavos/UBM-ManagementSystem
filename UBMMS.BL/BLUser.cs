using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBMMS.DAL;

namespace UBMMS.BL
{
    public class BLUser
    {
        public BLUser()
        { }

        public user CheckUser(user u)
        {
            DALUser dal = new DALUser();
            return dal.Select(u);
        }
    }
}
