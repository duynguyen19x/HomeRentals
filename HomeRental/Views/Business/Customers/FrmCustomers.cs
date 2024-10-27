using DevExpress.XtraEditors;
using HomeRental.IViews.Business.Customers;
using HomeRental.Presenters.Business.Customer;
using HomeRental.Presenters.Business.User;
using HomeRental.Views.Business.Users;
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

namespace HomeRental.Views.Business.Customers
{
    public partial class FrmCustomers : DevExpress.XtraEditors.XtraForm, ICustomerViews
    {
        CustomerPresenter _customerPresenter;

        public FrmCustomers()
        {
            InitializeComponent();
            _customerPresenter = new CustomerPresenter(this);
        }

        public IList<CustomerModel> Customers
        {
            get => grcCustomer.DataSource as IList<CustomerModel>;
            set
            {
                grcCustomer.DataSource = value;
                grcCustomer.RefreshDataSource();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmCustomerDetails(Utilities.Enum.ActionModeType.Add, null);
            frm.ShowDialog();

            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var customerSelected = grvCustomer.GetFocusedRow() as CustomerModel;
            if (customerSelected != null)
            {
                var frm = new FrmCustomerDetails(Utilities.Enum.ActionModeType.Edit, customerSelected.Id);
                frm.ShowDialog();

                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var customerSelected = grvCustomer.GetFocusedRow() as CustomerModel;
            if (customerSelected != null && MessageBox.Show($"Bạn có muốn xóa khách hàng {customerSelected.Name} không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = _customerPresenter.DeleteCustomerById(customerSelected.Id.GetValueOrDefault());
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

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            Customers = _customerPresenter.GetCustomers().Items;
        }
    }
}