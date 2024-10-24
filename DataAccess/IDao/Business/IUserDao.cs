using BusinessObjects.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.IDao.Business
{
    public interface IUserDao
    {
        Result<IList<UserEntity>> GetUsers();
    }
}
