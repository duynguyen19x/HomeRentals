using Services.IServices.Systems;
using Services.Services.Systems;
using Utilities;

namespace HomeRental.Presenters.Systems
{
    public class DatabasePresenter
    {
        private readonly IDatabaseService _databaseService;

        public DatabasePresenter()
        {
            _databaseService = new DatabaseService();
        }

        public Result<bool> CreateDatabase(string server, string databaseName, string userName, string password)
        {
            return _databaseService.CreateDatabase(server, databaseName, userName, password);
        }
        public Result<bool> RestoreDatabase(string server, string userName, string password, string databaseName, string backupFilePath)
        {
            return _databaseService.RestoreDatabase(server, userName, password, databaseName, backupFilePath);
        }
        public Result<bool> BackupDatabase(string server, string userName, string password, string databaseName, string backupFilePath)
        {
            return _databaseService.BackupDatabase(server, userName, password, databaseName, backupFilePath);
        }
    }
}
