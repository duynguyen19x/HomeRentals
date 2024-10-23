using DataAccess.Dao.AdoNet.Systems;
using DataAccess.IDao;
using DataAccess.IDao.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao.AdoNet
{
    public class DaoFactory : IDaoFactory
    {
        public ILoginDao LoginDao => new LoginDao();
    }
}
