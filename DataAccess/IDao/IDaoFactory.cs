using DataAccess.IDao.Business;
using DataAccess.IDao.Reports;
using DataAccess.IDao.Systems;

namespace DataAccess.IDao
{
    public interface IDaoFactory
    {
        ILoginDao LoginDao { get; }
        ILogoutDao LogoutDao { get; }
        IDatabaseDao DatabaseDao { get; }
        IUserDao UserDao { get; }
        ICustomerDao CustomerDao { get; }
        IHomeRentalDao HomeRentalDao { get; }
        ICustomerHomeRentalDao CustomerHomeRentalDao { get; }
        IReportDao ReportDao { get; }
    }
}
