using DevExpress.XtraEditors;
using HomeRental.IViews.Systems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeRental.Views.Systems
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm, ILoginView
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region Member
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

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnSetupDatabase_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}