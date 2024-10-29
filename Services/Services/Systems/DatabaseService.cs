using Services.IServices.Systems;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Services.Services.Systems
{
    public class DatabaseService : BaseServices, IDatabaseService
    {
        public Result<bool> RestoreDatabase(string server, string userName, string password, string databaseName, string backupFilePath)
        {
            return Factory.DatabaseDao.RestoreDatabase(server, userName, password, databaseName, backupFilePath);
        }
        public Result<bool> BackupDatabase(string server, string userName, string password, string databaseName, string backupFilePath)
        {
            return Factory.DatabaseDao.BackupDatabase(server, userName, password, databaseName, backupFilePath);
        }
    }
}
