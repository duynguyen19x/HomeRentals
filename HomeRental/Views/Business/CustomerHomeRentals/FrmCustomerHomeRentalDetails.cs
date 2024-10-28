using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using HomeRental.IViews.Business.CustomerHomeRentals;
using HomeRental.IViews.Business.Customers;
using HomeRental.Presenters.Business.Customer;
using HomeRental.Presenters.Business.CustomerHomeRentals;
using HomeRental.Presenters.Business.User;
using HomeRentals.Models.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Enum;

namespace HomeRental.Views.Business.CustomerHomeRentals
{
    public partial class FrmCustomerHomeRentalDetails : XtraForm, ICustomerViews, ICustomerHomeRentalViews, ICustomerHomeRentalDetailViews
    {
        CustomerPresenter _customerPresenter;
        CustomerHomeRentalDetailPresenter _customerHomeRentalDetailPresenter;
        CustomerHomeRentalPresenter _customerHomeRentalPresenter;

        public FrmCustomerHomeRentalDetails(ActionModeType action, Guid? id)
        {
            InitializeComponent();

            Action = action;
            Id = id;

            _customerPresenter = new CustomerPresenter(this);
            _customerHomeRentalPresenter = new CustomerHomeRentalPresenter(this);
            _customerHomeRentalDetailPresenter = new CustomerHomeRentalDetailPresenter(this);
        }

        #region Member
        ActionModeType _action;
        public ActionModeType Action
        {
            get => _action;
            set
            {
                _action = value;

                switch (_action)
                {
                    case ActionModeType.CheckOut:
                        {
                            dteToDate.Properties.ReadOnly = false;
                            spnAmount.Properties.ReadOnly = false;
                        }
                        break;
                    default:
                        {
                            dteToDate.Properties.ReadOnly = true;
                            spnAmount.Properties.ReadOnly = true;
                        }
                        break;
                }
            }
        }

        public IList<CustomerModel> Customers { get; set; } // Khách hàng
        public IList<CustomerHomeRentalModel> CustomerHomeRentals { get; set; } // Nhà chưa cho thuê

        public Guid? Id { get; set; }
        public string CustomerHomeRentalCode
        {
            get => (string)txtCustomerHomeRentalCode.EditValue;
            set => txtCustomerHomeRentalCode.EditValue = value;
        }
        public Guid? CustomerId
        {
            get => (Guid?)cbbCustomer.EditValue;
            set => cbbCustomer.EditValue = value;
        }
        public Guid? HomeRentalId
        {
            get => (Guid?)cbbHomeRental.EditValue;
            set => cbbHomeRental.EditValue = value;
        }
        public DateTime? RentalStartDate
        {
            get => (DateTime?)dteFromDate.EditValue;
            set => dteFromDate.EditValue = value;
        }
        public DateTime? RentalEndDate
        {
            get => (DateTime?)dteToDate.EditValue;
            set => dteToDate.EditValue = value;
        }
        public string CustomerCode
        {
            get => (string)txtCustomerName.EditValue;
            set => txtCustomerName.EditValue = value;
        }
        public string CustomerName
        {
            get => (string)txtCustomerName.EditValue;
            set => txtCustomerName.EditValue = value;
        }
        public string HomeRentalCode { get; set; }
        public decimal HomeRentalPrice
        {
            get => (decimal)spnHomeRentalPrice.EditValue;
            set => spnHomeRentalPrice.EditValue = value;
        }
        public decimal HomeRentalArea
        {
            get => (decimal)spnHomeRentalArea.EditValue;
            set => spnHomeRentalArea.EditValue = value;
        }
        public int HomeRentalFloor
        {
            get => Convert.ToInt32(spnHomeRentalFloor.EditValue);
            set => spnHomeRentalFloor.EditValue = value;
        }
        public int HomeRentalFacing { get; set; }
        public string HomeRentalFacingName
        {
            get => (string)txtHomeRentalFacingName.EditValue;
            set => txtHomeRentalFacingName.EditValue = value;
        }
        public decimal Amount
        {
            get => (decimal)spnAmount.EditValue;
            set => spnAmount.EditValue = value;
        }
        #endregion

        private void FrmCustomerHomeRentalDetails_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BeforeSave())
            {
                var result = _customerHomeRentalDetailPresenter.Save();
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

        private void InitData()
        {
            LoadCustomers();
            LoadCustomerHomeRentals();
        }

        private void LoadCustomers()
        {
            if (Customers == null)
                Customers = _customerPresenter.GetAlls().Items;

            GridView view = cbbCustomer.Properties.View;
            cbbCustomer.Properties.DataSource = Customers;
            cbbCustomer.Properties.ValueMember = nameof(CustomerModel.Id);
            cbbCustomer.Properties.DisplayMember = nameof(CustomerModel.Code);

            view.Columns.AddField(nameof(CustomerModel.Code));
            view.Columns.AddField(nameof(CustomerModel.Name));
            view.BestFitColumns();

            var columnCustomer = new GridColumn[]
            {
                new GridColumn(){ FieldName = nameof(CustomerModel.Code), Caption = "Mã khách hàng", Width = 100 },
                new GridColumn(){ FieldName = nameof(CustomerModel.Name), Caption = "Tên khách hàng", Width = 300  },
            };

            view.OptionsView.ShowIndicator = false;
            view.OptionsView.ShowGroupPanel = false;

            foreach (GridColumn gridColumn in view.Columns)
            {
                GridColumn xtraColumn = columnCustomer.Where(w => w.FieldName == gridColumn.FieldName)?.FirstOrDefault() ?? null;
                if (xtraColumn != null)
                {
                    gridColumn.Caption = xtraColumn.Caption;
                    gridColumn.Width = xtraColumn.Width;
                    gridColumn.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                    gridColumn.Visible = true;
                }
                else
                    gridColumn.Visible = false;
            }

            cbbCustomer.EditValueChanged += CbbCustomer_EditValueChanged;
        }

        private void LoadCustomerHomeRentals()
        {
            if (CustomerHomeRentals == null)
                CustomerHomeRentals = _customerHomeRentalPresenter.GetAlls((DateTime?)default, (DateTime?)default, false).Items;

            GridView view = cbbHomeRental.Properties.View;
            cbbHomeRental.Properties.DataSource = CustomerHomeRentals;
            cbbHomeRental.Properties.ValueMember = nameof(CustomerHomeRentalModel.Id);
            cbbHomeRental.Properties.DisplayMember = nameof(CustomerHomeRentalModel.HomeRentalCode);

            var columnCustomer = new GridColumn[]
            {
                new GridColumn(){ FieldName = nameof(CustomerHomeRentalModel.HomeRentalCode), Caption = "Mã nhà", Width = 100 },
                new GridColumn(){ FieldName = nameof(CustomerHomeRentalModel.HomeRentalDescription), Caption = "Mô tả nhà", Width = 300  },
            };

            view.Columns.AddField(nameof(CustomerHomeRentalModel.HomeRentalCode));
            view.Columns.AddField(nameof(CustomerHomeRentalModel.HomeRentalDescription));

            view.OptionsView.ShowIndicator = false;
            view.OptionsView.ShowGroupPanel = false;

            foreach (GridColumn gridColumn in view.Columns)
            {
                GridColumn xtraColumn = columnCustomer.Where(w => w.FieldName == gridColumn.FieldName)?.FirstOrDefault() ?? null;
                if (xtraColumn != null)
                {
                    gridColumn.Caption = xtraColumn.Caption;
                    gridColumn.Width = xtraColumn.Width;
                    gridColumn.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
                    gridColumn.Visible = true;
                }
                else
                    gridColumn.Visible = false;
            }

            cbbHomeRental.EditValueChanged += CbbHomeRental_EditValueChanged;
        }

        private bool BeforeSave()
        {
            var isSave = true;

            var erros = new List<string>();

            if (string.IsNullOrEmpty(CustomerHomeRentalCode) || string.IsNullOrWhiteSpace(CustomerHomeRentalCode))
                erros.Add("Mã thuê nhà");
            if (CustomerId == null || CustomerId == (Guid)default)
                erros.Add("Mã khách hàng");
            if (HomeRentalId == null || HomeRentalId == (Guid)default)
                erros.Add("Mã nhà");
            if (RentalStartDate == null || RentalStartDate == (DateTime)default)
                erros.Add("Ngày thuê nhà");

            if (erros.Count > 0)
            {
                MessageBox.Show(string.Format("[{0}] không được để trống!"), "Thông báo");
                isSave = false;
                return isSave;
            }

            if (RentalStartDate.Value.Date >= DateTime.Today)
            {
                MessageBox.Show($"Ngày thuê nhà {RentalStartDate.Value.ToString("dd/MM/yyyy")} phải nhỏ hơn ngày hiện tại {DateTime.Today.ToString("dd/MM/yyyy")}", "Thông báo");
                isSave = false;
                return isSave;
            }

            return isSave;
        }

        private void CbbCustomer_EditValueChanged(object sender, EventArgs e)
        {
            if (e is ChangingEventArgs even)
            {
                var customer = Customers?.FirstOrDefault(f => f.Id == (Guid)even.NewValue);
                if (customer != null)
                {
                    CustomerCode = customer.Code;
                    CustomerName = customer.Name;
                    return;
                }
            }

            CustomerCode = null;
            CustomerName = null;
        }

        private void CbbHomeRental_EditValueChanged(object sender, EventArgs e)
        {
            //if (e != null && e.NewValue != null)
            //{
            //    var customer = Customers?.FirstOrDefault(f => f.Id == (Guid)e.NewValue);
            //    if (customer != null)
            //    {
            //        CustomerCode = customer.Code;
            //        CustomerName = customer.Name;

            //        return;
            //    }
            //}
        }
    }
}