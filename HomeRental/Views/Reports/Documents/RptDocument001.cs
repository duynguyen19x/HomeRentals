using DevExpress.XtraReports.UI;
using HomeRentals.Models.Business;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using Utilities.Commons;

namespace HomeRental.Views.Reports.Documents
{
    public partial class RptDocument001 : XtraReport
    {
        public RptDocument001(CustomerHomeRentalModel customerHomeRental)
        {
            InitializeComponent();

            txtDatetime.Text = string.Format(txtDatetime.Text, customerHomeRental.RentalStartDate.Value.Day, customerHomeRental.RentalStartDate.Value.Month, customerHomeRental.RentalStartDate.Value.Year);
            txtAdress.Text = string.Format(txtAdress.Text, UserSession.Address, UserSession.PhoneNumber);
            txtUserName.Text = string.Format(txtUserName.Text, UserSession.UserName);

            txtCustomerName.Text = string.Format(txtCustomerName.Text, customerHomeRental.CustomerName);
            txtCustomerAddress.Text = string.Format(txtCustomerAddress.Text, customerHomeRental.CustomerAddress, customerHomeRental.CustomerPhoneNumber);
            txtHomeRentalArea.Text = string.Format(txtHomeRentalArea.Text, customerHomeRental.HomeRentalArea, customerHomeRental.HomeRentalArea);
            txtHomeRentalPrice.Text = string.Format(txtHomeRentalPrice.Text, customerHomeRental.HomeRentalPrice);

            txtSignUserName.Text = UserSession.UserName;
            txtSignCustomerName.Text = customerHomeRental.CustomerName;
        }
    }
}
