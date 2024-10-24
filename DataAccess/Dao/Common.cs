using DataAccess.IDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao
{
    public class Common
    {
        public static IDaoFactory DaoFactory { get; set; }
    }
}
