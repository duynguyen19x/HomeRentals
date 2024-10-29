using DataAccess.IDao;
using DataAccess.IDao.Business;
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
        public ILogoutDao LogoutDao => throw new NotImplementedException();

        public IUserDao UserDao => throw new NotImplementedException();

        public ICustomerDao CustomerDao => throw new NotImplementedException();

        public IHomeRentalDao HomeRentalDao => throw new NotImplementedException();

        public ICustomerHomeRentalDao CustomerHomeRentalDao => throw new NotImplementedException();

        public IDatabaseDao DatabaseDao => throw new NotImplementedException();
    }
}
