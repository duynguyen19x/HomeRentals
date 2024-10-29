using DevExpress.XtraEditors;
using HomeRental.IViews.Business.HomeRentals;
using HomeRental.Presenters.Business.HomeRentals;
using HomeRental.Presenters.Business.User;
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
using Utilities.Enum;

namespace HomeRental.Views.Business.HomeRentals
{
    public partial class FrmHomeRentalDetails : DevExpress.XtraEditors.XtraForm, IHomeRentalDetailViews
    {
        HomeRentalDetailPresenter _homeRentalDetailPresenter;

        public FrmHomeRentalDetails(ActionModeType action, Guid? id)
        {
            InitializeComponent();
            Action = action;
            Id = id;

            _homeRentalDetailPresenter = new HomeRentalDetailPresenter(this);
        }

        #region Member
        public ActionModeType Action { get; set; }

        public Guid? Id { get; set; }
        public string Code
        {
            get => (string)txtCode.EditValue;
            set => txtCode.EditValue = value;
        }
        public string Address
        {
            get => (string)txtAddress.EditValue;
            set => txtAddress.EditValue = value;
        }
        public string Description
        {
            get => (string)txtDescription.EditValue;
            set => txtDescription.EditValue = value;
        }
        public decimal Price
        {
            get => (decimal)spnPrice.EditValue;
            set => spnPrice.EditValue = value;
        }
        public decimal Area
        {
            get => (decimal)spnArea.EditValue;
            set => spnArea.EditValue = value;
        }
        public int Floor
        {
            get => Convert.ToInt32(spnFloor.EditValue);
            set => spnFloor.EditValue = value;
        }
        public int Facing
        {
            get => (int)cbbFacing.SelectedIndex;
            set => cbbFacing.SelectedIndex = value;
        }
        #endregion

        private void FrmHomeRentalDetails_Load(object sender, EventArgs e)
        {
            if (Action == ActionModeType.Edit && Id != null)
            {
                var result = _homeRentalDetailPresenter.GetById(Id.GetValueOrDefault());
                if (result.Items != null)
                {
                    Id = result.Items.Id;
                    Code = result.Items.Code;
                    Address = result.Items.Address;
                    Description = result.Items.Description;
                    Area = result.Items.Area;
                    Facing = result.Items.Facing;
                    Floor = result.Items.Floor;
                    Price = result.Items.Price;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BeforeSave())
            {
                var result = _homeRentalDetailPresenter.Save();
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

            if (string.IsNullOrEmpty(Code) || string.IsNullOrWhiteSpace(Code))
                erros.Add("Mã nhà");

            if (erros.Count > 0)
            {
                MessageBox.Show(string.Format("[{0}] không được để trống!", string.Join(", ", erros)), "Thông báo");
                isSave = false;
                return isSave;
            }

            if (Area == 0)
            {
                MessageBox.Show($"Đơn giá phải lớn hơn 0!", "Thông báo");
                isSave = false;
                return isSave;
            }

            return isSave;
        }
    }
}