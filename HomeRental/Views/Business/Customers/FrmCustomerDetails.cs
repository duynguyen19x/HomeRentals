using HomeRental.IViews.Business.Customers;
using HomeRental.Presenters.Business.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Utilities.Enum;

namespace HomeRental.Views.Business.Customers
{
    public partial class FrmCustomerDetails : DevExpress.XtraEditors.XtraForm, ICustomerDetailViews
    {
        CustomerDetailPresenter _customerDetailPresenter;

        public FrmCustomerDetails(ActionModeType action, Guid? id)
        {
            InitializeComponent();
            Action = action;
            Id = id;

            _customerDetailPresenter = new CustomerDetailPresenter(this);
        }

        #region Member
        public ActionModeType Action { get; set; }

        public Guid? Id { get; set; }
        public string CustomerCode
        {
            get => (string)txtCode.EditValue;
            set => txtCode.EditValue = value;
        }
        public string CustomerName
        {
            get => (string)txtName.EditValue;
            set => txtName.EditValue = value;
        }
        public string Address
        {
            get => (string)txtAddress.EditValue;
            set => txtAddress.EditValue = value;
        }
        public DateTime DOB
        {
            get => (DateTime)deDob.EditValue;
            set => deDob.EditValue = value;
        }
        public int Gender
        {
            get => (int)cbbGender.SelectedIndex;
            set => cbbGender.SelectedIndex = value;
        }
        public string PhoneNumber
        {
            get => (string)txtPhoneNumber.EditValue;
            set => txtPhoneNumber.EditValue = value;
        }
        #endregion

        private void FrmCustomerDetails_Load(object sender, EventArgs e)
        {
            if (Action == ActionModeType.Edit && Id != null)
            {
                var result = _customerDetailPresenter.GetById(Id.GetValueOrDefault());
                if (result.Items != null)
                {
                    Id = result.Items.Id;
                    Address = result.Items.Address;
                    DOB = result.Items.DOB;
                    Gender = result.Items.Gender;
                    PhoneNumber = result.Items.PhoneNumber;
                    CustomerCode = result.Items.Code;
                    CustomerName = result.Items.Name;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BeforeSave())
            {
                var result = _customerDetailPresenter.Save();
                if (result.Success)
                {
                    MessageBox.Show("Lưu thông công!", "Thông báo");
                    Id = result.Items;
                }
                else if (result.Message != null)
                    MessageBox.Show("Lưu không thành công!" + "\n" + result.Message, "Thông báo");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool BeforeSave()
        {
            var isSave = true;

            var erros = new List<string>();

            if (string.IsNullOrEmpty(CustomerCode) || string.IsNullOrWhiteSpace(CustomerCode))
                erros.Add("Mã khách hàng");
            if (string.IsNullOrEmpty(CustomerName) || string.IsNullOrWhiteSpace(CustomerName))
                erros.Add("Tên khách hàng");

            if (erros.Count > 0)
            {
                MessageBox.Show(string.Format("[{0}] không được để trống!", string.Join(",", erros)), "Thông báo");
                isSave = false;
                return isSave;
            }

            if (DOB.Date >= DateTime.Today)
            {
                MessageBox.Show($"Ngày sinh {DOB.Date.ToString("dd/MM/yyyy")} phải nhỏ hơn ngày hiện tại {DateTime.Today.ToString("dd/MM/yyyy")}", "Thông báo");
                isSave = false;
                return isSave;
            }

            return isSave;
        }
    }
}