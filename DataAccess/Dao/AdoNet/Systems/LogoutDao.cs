using BusinessObjects.Systems;
using DataAccess.IDao.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.Dao.AdoNet.Systems
{
    public class LogoutDao : ILogoutDao
    {
        public Result<bool> CloseConnectDatabase()
        {
            var result = new Result<bool>();

            try
            {
                DatabaseHelper.CloseConnection();
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
