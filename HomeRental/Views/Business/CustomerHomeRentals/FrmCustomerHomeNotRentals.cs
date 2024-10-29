using DevExpress.XtraEditors;
using HomeRental.IViews.Business.CustomerHomeRentals;
using HomeRental.Presenters.Business.CustomerHomeRentals;
using HomeRentals.Models.Business;
using System;
using System.Collections.Generic;

namespace HomeRental.Views.Business.CustomerHomeRentals
{
    public partial class FrmCustomerHomeNotRentals : XtraForm, ICustomerHomeRentalViews
    {
        CustomerHomeRentalPresenter _customerHomeRentalPresenter;

        public FrmCustomerHomeNotRentals()
        {
            InitializeComponent();

            _customerHomeRentalPresenter = new CustomerHomeRentalPresenter(this);
        }

        #region Member
        public IList<CustomerHomeRentalModel> CustomerHomeRentals
        {
            get => grcHomeRental.DataSource as IList<CustomerHomeRentalModel>;
            set
            {
                grcHomeRental.DataSource = value;
                grcHomeRental.RefreshDataSource();
            }
        }
        #endregion

        #region Function
        private void FrmCustomerHomeNotRentals_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            CustomerHomeRentals = _customerHomeRentalPresenter.GetAlls(null, null, 0, null).Items;
        }
        #endregion
    }
}