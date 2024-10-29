using DevExpress.XtraEditors;
using HomeRental.IViews.Business.User;
using HomeRental.Presenters.Business;
using HomeRental.Presenters.Business.User;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Utilities.Enum;

namespace HomeRental.Views.Business.Users
{
    public partial class FrmUserDetails : XtraForm, IUserDetailViews
    {
        UserDetailPresenter _userDetailPresenter;

        public FrmUserDetails(ActionModeType action, Guid? id)
        {
            InitializeComponent();

            Action = action;
            Id = id;

            _userDetailPresenter = new UserDetailPresenter(this);
        }

        #region Member
        public ActionModeType Action { get; set; }

        public Guid? Id { get; set; }

        public string UserName
        {
            get => (string)txtUsername.EditValue;
            set => txtUsername.EditValue = value;
        }

        public string Password
        {
            get => (string)txtPassword.EditValue;
            set => txtPassword.EditValue = value;
        }

        public string RePassword
        {
            get => (string)txtRePassword.EditValue;
            set => txtRePassword.EditValue = value;
        }

        public string Address
        {
            get => (string)txtAddress.EditValue;
            set => txtAddress.EditValue = value;
        }

        public string FirstName
        {
            get => (string)txtFirstName.EditValue;
            set => txtFirstName.EditValue = value;
        }

        public string LastName
        {
            get => (string)txtLastName.EditValue;
            set => txtLastName.EditValue = value;
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

        private void FrmUserDetails_Load(object sender, EventArgs e)
        {
            if (Action == ActionModeType.Edit && Id != null)
            {
                var result = _userDetailPresenter.GetById(Id.GetValueOrDefault());
                if (result.Items != null)
                {
                    Id = result.Items.Id;
                    UserName = result.Items.UserName;
                    Password = result.Items.Password;
                    RePassword = result.Items.Password;
                    Address = result.Items.Address;
                    FirstName = result.Items.FirstName;
                    LastName = result.Items.LastName;
                    DOB = result.Items.DOB;
                    Gender = result.Items.Gender;
                    PhoneNumber = result.Items.PhoneNumber;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BeforeSave())
            {
                var result = _userDetailPresenter.Save();
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

            if (string.IsNullOrEmpty(UserName) || string.IsNullOrWhiteSpace(UserName))
                erros.Add("Tên đăng nhập");
            if (string.IsNullOrEmpty(LastName) || string.IsNullOrWhiteSpace(LastName))
                erros.Add("Họ và tên đệm");
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrWhiteSpace(FirstName))
                erros.Add("Tên");
            if (string.IsNullOrEmpty(Password) || string.IsNullOrWhiteSpace(Password))
                erros.Add("Mật khẩu");

            if (erros.Count > 0)
            {
                MessageBox.Show(string.Format("[{0}] không được để trống!", string.Join(", ", erros)), "Thông báo");
                isSave = false;
                return isSave;
            }

            if (DOB.Date >= DateTime.Today)
            {
                MessageBox.Show($"Ngày sinh {DOB.Date.ToString("dd/MM/yyyy")} phải nhỏ hơn ngày hiện tại {DateTime.Today.ToString("dd/MM/yyyy")}", "Thông báo");
                isSave = false;
                return isSave;
            }

            if (Password != (string)txtRePassword.EditValue)
            {
                MessageBox.Show("Mật khẩu và Xác nhận mật khẩu không trừng khớp!", "Thông báo");
                isSave = false;
                return isSave;
            }

            return isSave;
        }
    }
}