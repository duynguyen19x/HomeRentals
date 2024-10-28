using DataAccess.IDao.Business;
using DataAccess.IDao.Systems;

namespace DataAccess.IDao
{
    public interface IDaoFactory
    {
        ILoginDao LoginDao { get; }
        ILogoutDao LogoutDao { get; }
        IUserDao UserDao { get; }
        ICustomerDao CustomerDao { get; }
        IHomeRentalDao HomeRentalDao { get; }
        ICustomerHomeRentalDao CustomerHomeRentalDao { get; }
    }
}
