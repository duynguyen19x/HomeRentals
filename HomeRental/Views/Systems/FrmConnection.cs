using HomeRental.IViews.Systems;
using HomeRental.Presenters.Systems;
using HomeRentals.Models.Systems;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HomeRental.Views.Systems
{
    public partial class FrmConnection : Form, IConnectionView
    {
        public FrmConnection()
        {
            InitializeComponent();
            _connectionPresenter = new ConnectionPresenter(this);
        }

        #region Member
        ConnectionPresenter _connectionPresenter;

        public string ServerName
        {
            get => (string)txtServerName.EditValue;
            set => txtServerName.EditValue = value;
        }
        public string DatabaseName
        {
            get => (string)txtDatabaseName.EditValue;
            set => txtDatabaseName.EditValue = value;
        }
        public string UserName
        {
            get => (string)txtUserName.EditValue;
            set => txtUserName.EditValue = value;
        }
        public string Password
        {
            get => (string)txtPassword.EditValue;
            set => txtPassword.EditValue = value;
        }
        #endregion

        #region Function
        private void FrmConnection_Load(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (ConfigurationManager.AppSettings["ServerName"] != null)
                ServerName = config.AppSettings.Settings["ServerName"].Value;

            if (ConfigurationManager.AppSettings["DatabaseName"] != null)
                DatabaseName = config.AppSettings.Settings["DatabaseName"].Value;

            if (ConfigurationManager.AppSettings["UserName"] != null)
                UserName = config.AppSettings.Settings["UserName"].Value;

            if (ConfigurationManager.AppSettings["Password"] != null)
                Password = config.AppSettings.Settings["Password"].Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {

        }

        private void btnConnectDatabase_Click(object sender, EventArgs e)
        {
            var result = _connectionPresenter.ConnectDatabase();
            if (!result.Success)
            {
                if (result.Message != null && result.Message.Contains("The server was not found or was not accessible"))
                    MessageBox.Show("Máy chủ không được tìm thấy hoặc không thể truy cập!", "Thông báo");
                else
                    MessageBox.Show(result.Message, "Thông báo");
            }
            else
            {
                // Mở file cấu hình
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                if (ConfigurationManager.AppSettings["ServerName"] == null)
                    config.AppSettings.Settings.Add("ServerName", ServerName);
                else
                    config.AppSettings.Settings["ServerName"].Value = ServerName;

                if (ConfigurationManager.AppSettings["DatabaseName"] == null)
                    config.AppSettings.Settings.Add("DatabaseName", DatabaseName);
                else
                    config.AppSettings.Settings["DatabaseName"].Value = DatabaseName;

                if (ConfigurationManager.AppSettings["UserName"] == null)
                    config.AppSettings.Settings.Add("UserName", UserName);
                else
                    config.AppSettings.Settings["UserName"].Value = UserName;

                if (ConfigurationManager.AppSettings["Password"] == null)
                    config.AppSettings.Settings.Add("Password", Password);
                else
                    config.AppSettings.Settings["Password"].Value = Password;

                // Lưu thay đổi
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                MessageBox.Show("Kết nối cơ sở dữ liệu thành công!", "Thông báo");
            }
        }

        #endregion
    }
}
