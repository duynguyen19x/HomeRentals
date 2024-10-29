using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.IDao.Systems
{
    public interface IDatabaseDao
    {
        Result<bool> RestoreDatabase(string server, string userName, string password, string databaseName, string backupFilePath);
        Result<bool> BackupDatabase(string server, string userName, string password, string databaseName, string backupFilePath);
    }
}
