using DevExpress.XtraEditors;
using HomeRental.IViews.Systems;
using HomeRental.Presenters.Systems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace HomeRental.Views.Systems
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm, ILoginView
    {
        public FrmLogin()
        {
            InitializeComponent();
            _loginPresenter = new LoginPresenter(this);
        }

        #region Member
        public LoginPresenter _loginPresenter { get; set; }

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

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            var serverName = string.Empty;
            var databaseName = string.Empty;
            var userName = string.Empty;
            var password = string.Empty;

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (ConfigurationManager.AppSettings["ServerName"] != null)
                serverName = config.AppSettings.Settings["ServerName"].Value;

            if (ConfigurationManager.AppSettings["DatabaseName"] != null)
                databaseName = config.AppSettings.Settings["DatabaseName"].Value;

            if (ConfigurationManager.AppSettings["UserName"] != null)
                userName = config.AppSettings.Settings["UserName"].Value;

            if (ConfigurationManager.AppSettings["Password"] != null)
                password = config.AppSettings.Settings["Password"].Value;

            var result = _loginPresenter.ConnectDatabase(serverName, databaseName, userName, password);
            if (!result.Success)
            {
                if (result.Message != null && result.Message.Contains("The server was not found or was not accessible"))
                    MessageBox.Show("Máy chủ không được tìm thấy hoặc không thể truy cập!", "Thông báo");
                else
                    MessageBox.Show(result.Message, "Thông báo");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var s = _loginPresenter.Authentication();

            this.Hide();

            var frm = new FrmMain();
            frm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSetupDatabase_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new FrmConnection();
            frm.ShowDialog();
            this.ShowDialog();
        }

        #endregion
    }
}