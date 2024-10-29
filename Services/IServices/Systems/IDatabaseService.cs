using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Services.IServices.Systems
{
    public interface IDatabaseService
    {
        Result<bool> RestoreDatabase(string server, string userName, string password, string databaseName, string backupFilePath);
        Result<bool> BackupDatabase(string server, string userName, string password, string databaseName, string backupFilePath);
    }
}
