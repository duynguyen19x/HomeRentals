using DevExpress.XtraEditors;
using HomeRental.IViews.Business.CustomerHomeRentals;
using HomeRental.Presenters.Business.Customer;
using HomeRental.Presenters.Business.CustomerHomeRentals;
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

namespace HomeRental.Views.Business.CustomerHomeRentals
{
    public partial class FrmCustomerHomeRentals : XtraForm, ICustomerHomeRentalViews
    {
        CustomerHomeRentalPresenter _customerHomeRentalPresenter;

        public FrmCustomerHomeRentals()
        {
            InitializeComponent();

            _customerHomeRentalPresenter = new CustomerHomeRentalPresenter(this);
        }

        #region Member
        public IList<CustomerHomeRentalModel> CustomerHomeRentals
        {
            get => grcCustomerHomeRental.DataSource as IList<CustomerHomeRentalModel>;
            set
            {
                grcCustomerHomeRental.DataSource = value;
                grcCustomerHomeRental.RefreshDataSource();
            }
        }

        public DateTime FromDate
        {
            get => (DateTime)dteFromDate.EditValue;
            set => dteFromDate.EditValue = value;
        }
        public DateTime ToDate
        {
            get => (DateTime)dteToDate.EditValue;
            set => dteToDate.EditValue = value;
        }

        #endregion

        #region Function
        private void FrmCustomerHomeRentals_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            // Lấy ngày đầu tiên của tháng
            DateTime firstDayOfMonth = new DateTime(now.Year, now.Month, 1);
            // Lấy ngày cuối cùng của tháng
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            FromDate = firstDayOfMonth;
            ToDate = lastDayOfMonth;

            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmCustomerHomeRentalDetails(Utilities.Enum.ActionModeType.Add, null);
            frm.ShowDialog();

            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var customerHomeRentalSelected = grvCustomerHomeRental.GetFocusedRow() as CustomerHomeRentalModel;
            if (customerHomeRentalSelected != null)
            {
                var frm = new FrmCustomerHomeRentalDetails(Utilities.Enum.ActionModeType.Edit, customerHomeRentalSelected.Id);
                frm.ShowDialog();

                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var customerHomeRentalSelected = grvCustomerHomeRental.GetFocusedRow() as CustomerHomeRentalModel;
            if (customerHomeRentalSelected != null && MessageBox.Show($"Bạn có muốn xóa nhà cho thuê {customerHomeRentalSelected.CustomerHomeRentalCode} không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = _customerHomeRentalPresenter.DeleteById(customerHomeRentalSelected.Id.GetValueOrDefault());
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var customerHomeRentalSelected = grvCustomerHomeRental.GetFocusedRow() as CustomerHomeRentalModel;
            if (customerHomeRentalSelected != null)
            {
                var frm = new FrmCustomerHomeRentalDetails(Utilities.Enum.ActionModeType.CheckOut, customerHomeRentalSelected.Id);
                frm.ShowDialog();

                LoadData();
            }
        }

        private void LoadData()
        {
            CustomerHomeRentals = _customerHomeRentalPresenter.GetAlls(FromDate, ToDate, true).Items;
        }
        #endregion
    }
}