using DevExpress.XtraEditors;
using HomeRental.IViews.Business.CustomerHomeRentals;
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
    public partial class FrmCustomerHomeRentals : DevExpress.XtraEditors.XtraForm, ICustomerHomeRentalViews
    {
        public FrmCustomerHomeRentals()
        {
            InitializeComponent();
        }

        #region Member
        public IList<CustomerHomeRentalModel> CustomerHomeRentals
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException();
        }

        #endregion

        #region Function
        private void FrmCustomerHomeRentals_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}