using DevExpress.XtraEditors;
using HomeRental.IViews.Business.HomeRentals;
using HomeRental.Presenters.Business.Customer;
using HomeRental.Presenters.Business.HomeRentals;
using HomeRental.Views.Business.Customers;
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

namespace HomeRental.Views.Business.HomeRentals
{
    public partial class FrmHomeRentals : DevExpress.XtraEditors.XtraForm, IHomeRentalViews
    {
        HomeRentalPresenter _homeRentalPresenter;

        public FrmHomeRentals()
        {
            InitializeComponent();
            _homeRentalPresenter = new HomeRentalPresenter(this);
        }

        #region Member
        public IList<HomeRentalModel> HomeRentals
        {
            get => grcHomeRental.DataSource as IList<HomeRentalModel>;
            set
            {
                grcHomeRental.DataSource = value;
                grcHomeRental.RefreshDataSource();
            }
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmHomeRentalDetails(Utilities.Enum.ActionModeType.Add, null);
            frm.ShowDialog();

            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var homeRentalSelected = grvHomeRental.GetFocusedRow() as HomeRentalModel;
            if (homeRentalSelected != null)
            {
                var frm = new FrmHomeRentalDetails(Utilities.Enum.ActionModeType.Edit, homeRentalSelected.Id);
                frm.ShowDialog();

                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var homeRentalSelected = grvHomeRental.GetFocusedRow() as HomeRentalModel;
            if (homeRentalSelected != null && MessageBox.Show($"Bạn có muốn xóa nhà cho thuê mã {homeRentalSelected.Code} không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = _homeRentalPresenter.DeleteById(homeRentalSelected.Id.GetValueOrDefault());
                if (result.Success)
                {
                    LoadData();
                }
                else if (result.Message != null)
                {
                    MessageBox.Show("Xóa không thành công!" + "\n" + result.Message, "Thông báo");
                }
            }
        }

        private void FrmHomeRentals_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            HomeRentals = _homeRentalPresenter.GetAlls().Items;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}