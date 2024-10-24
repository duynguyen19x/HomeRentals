using DataAccess.IDao;
using DataAccess.IDao.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao.EntityFramework
{
    public class DaoFactory : IDaoFactory
    {
        public ILoginDao LoginDao => throw new NotImplementedException();
    }
}
