using BusinessObjects.Business;
using DataAccess.IDao.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.Dao.AdoNet.Business
{
    public class UserDao : IUserDao
    {
        public Result<IList<UserEntity>> GetUsers()
        {
            var result = new Result<IList<UserEntity>>();

            try
            {
                result.Items = DatabaseHelper.QueryStoredProcedure<UserEntity>("Proc_GetUsers").ToList();
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return result;
        }
    }
}
