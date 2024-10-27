using HomeRental.IViews.Business.Customers;
using HomeRental.IViews.Business.User;
using HomeRentals.Models.Business;
using Services.IServices.Business;
using Services.Services.Business;
using System;
using System.Collections.Generic;
using Utilities;

namespace HomeRental.Presenters.Business.Customer
{
    public class CustomerPresenter : BasePresenter<ICustomerViews>
    {
        ICustomerService _customerService;

        public CustomerPresenter(ICustomerViews view) : base(view)
        {
            _customerService = new CustomerService();
        }

        public Result<IList<CustomerModel>> GetCustomers()
        {
            return _customerService.GetCustomers();
        }

        public Result<bool> DeleteCustomerById(Guid id)
        {
            return _customerService.DeleteCustomerById(id);
        }
    }
}
