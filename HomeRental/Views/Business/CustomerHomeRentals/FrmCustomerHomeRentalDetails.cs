using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using HomeRental.IViews.Business.Customers;
using HomeRental.Presenters.Business.Customer;
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
    public partial class FrmCustomerHomeRentalDetails : XtraForm, ICustomerViews
    {
        CustomerPresenter _customerPresenter;

        public FrmCustomerHomeRentalDetails()
        {
            InitializeComponent();

            _customerPresenter = new CustomerPresenter(this);
        }

        #region Member
        public IList<CustomerModel> Customers { get; set; }
        #endregion

        private void FrmCustomerHomeRentalDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void InitData()
        {
            if (Customers == null)
                Customers = _customerPresenter.GetCustomers().Items;

            LoadCustomer();
        }

        private void LoadCustomer()
        {
            GridView view = cbbCustomer.Properties.View;

            var columnCustomer = new GridColumn[]
            {
                new GridColumn(){ FieldName = nameof(CustomerModel.Code) },
                new GridColumn(){ FieldName = nameof(CustomerModel.Name) },
            };

            view.Columns.AddRange(columnCustomer);
            cbbCustomer.Properties.DataSource = Customers;
            cbbCustomer.Properties.ValueMember = nameof(CustomerModel.Id);
            cbbCustomer.Properties.DisplayMember = nameof(CustomerModel.Code);
        }
    }
}