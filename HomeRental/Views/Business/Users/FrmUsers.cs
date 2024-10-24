using DevExpress.XtraEditors;
using HomeRental.IViews.Business;
using HomeRental.Presenters.Business;
using HomeRentals.Models.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeRental.Views.Business.Users
{
    public partial class FrmUsers : DevExpress.XtraEditors.XtraForm, IUserViews
    {
        UserPresenter _userPresenter;

        public FrmUsers()
        {
            InitializeComponent();
            _userPresenter = new UserPresenter(this);
        }

        #region Member
        public IList<UserModel> Users
        {
            get => grcUsers.DataSource as IList<UserModel>;
            set
            {
                grcUsers.DataSource = value;
                grcUsers.RefreshDataSource();
            }
        }
        #endregion

        #region Function
        private void FrmUsers_Load(object sender, EventArgs e)
        {
            Users = _userPresenter.GetUsers().Items;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void FrmUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion   
    }
}