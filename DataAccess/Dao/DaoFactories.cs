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
            // return the requested DaoFactory

            switch (dataProvider.ToLower())
            {
                case "DaoFactory": return new AdoNet.DaoFactory();
                case "EntityFramework": return new EntityFramework.DaoFactory();

                default: return new AdoNet.DaoFactory();
            }
        }
    }
}
