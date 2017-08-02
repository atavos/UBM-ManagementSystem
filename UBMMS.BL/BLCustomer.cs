using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBMMS.DAL;

namespace UBMMS.BL
{
    public class BLCustomer
    {
        public BLCustomer()
        { }

        public List<customer> SelectAll()
        {
            DALCustomer dal = new DALCustomer();
            return dal.SelectAll();
        }
    }
}
