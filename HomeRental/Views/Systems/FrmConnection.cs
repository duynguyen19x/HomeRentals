using HomeRental.IViews.Systems;
using HomeRental.Models.Systems;
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
    public partial class FrmConnection : Form, IConnectionView
    {
        public FrmConnection()
        {
            InitializeComponent();
        }

        #region Member
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {

        }

        private void btnConnectDatabase_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
