using DataAccess.Dao.AdoNet.Business;
using DataAccess.Dao.AdoNet.Systems;
using DataAccess.IDao.Business;
using DataAccess.IDao.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IDao
{
    public interface IDaoFactory
    {
        ILoginDao LoginDao { get; }
        IUserDao UserDao { get; }
        ICustomerDao CustomerDao { get; }
    }
}
