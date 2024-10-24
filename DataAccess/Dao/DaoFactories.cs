using DataAccess.IDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao
{
    public class DaoFactories
    {
        public static IDaoFactory GetFactory(string dataProvider)
        {
            IDaoFactory factory = Common.DaoFactory;

            if (factory == null)
            {
                switch (dataProvider.ToLower())
                {
                    case "adonet":
                        factory = new AdoNet.DaoFactory();
                        break;
                    case "entityframework":
                        factory = new EntityFramework.DaoFactory();
                        break;
                    default:
                        factory = new AdoNet.DaoFactory();
                        break;
                }

                Common.DaoFactory = factory;
            }

            return factory;
        }
    }
}
