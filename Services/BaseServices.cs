using DataAccess.Dao;
using DataAccess.IDao;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BaseServices
    {
        static readonly string Provider = ConfigurationManager.AppSettings.Get("DataProvider");
        public static readonly IDaoFactory Factory = DaoFactories.GetFactory("");
    }
}
