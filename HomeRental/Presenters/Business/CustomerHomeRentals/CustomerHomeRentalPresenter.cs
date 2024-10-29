using HomeRental.IViews.Business.CustomerHomeRentals;
using HomeRental.IViews.Business.Customers;
using HomeRentals.Models.Business;
using Services.IServices.Business;
using Services.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace HomeRental.Presenters.Business.CustomerHomeRentals
{
    public class CustomerHomeRentalPresenter : BasePresenter<ICustomerHomeRentalViews>
    {
        ICustomerHomeRentalService _customerHomeRentalService;

        public CustomerHomeRentalPresenter(ICustomerHomeRentalViews view) : base(view)
        {
            _customerHomeRentalService = new CustomerHomeRentalService();
        }

        public Result<IList<CustomerHomeRentalModel>> GetAlls(DateTime? fromDate, DateTime? toDate, int rented, Guid? customerHomeRentalCurrentId)
        {
            return _customerHomeRentalService.GetAlls(fromDate, toDate, rented, customerHomeRentalCurrentId);
        }

        public Result<bool> DeleteById(Guid id)
        {
            return _customerHomeRentalService.DeleteById(id);
        }
    }
}
