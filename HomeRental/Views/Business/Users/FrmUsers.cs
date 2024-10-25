using HomeRental.IViews.Business.User;
using HomeRental.Presenters.Business;
using HomeRentals.Models.Business;
using System;
using System.Collections.Generic;
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
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmUserDetails(Utilities.Enum.ActionModeType.Add, null);
            frm.ShowDialog();

            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var userSelected = grvUsers.GetFocusedRow() as UserModel;
            if (userSelected != null)
            {
                var frm = new FrmUserDetails(Utilities.Enum.ActionModeType.Edit, userSelected.Id);
                frm.ShowDialog();

                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void FrmUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoadData()
        {
            Users = _userPresenter.GetUsers().Items;
        }
        #endregion
    }
}