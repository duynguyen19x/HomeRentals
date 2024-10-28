using DataAccess.Dao.AdoNet.Business;
using DataAccess.Dao.AdoNet.Systems;
using DataAccess.IDao;
using DataAccess.IDao.Business;
using DataAccess.IDao.Systems;

namespace DataAccess.Dao.AdoNet
{
    public class DaoFactory : IDaoFactory
    {
        public ILoginDao LoginDao => new LoginDao();
        public ILogoutDao LogoutDao => new LogoutDao();
        public IUserDao UserDao => new UserDao();
        public ICustomerDao CustomerDao => new CustomerDao();
        public IHomeRentalDao HomeRentalDao => new HomeRentalDao();
        public ICustomerHomeRentalDao CustomerHomeRentalDao => new CustomerHomeRentalDao();
    }
}
