using HomeRental.IViews.Business.Customers;
using HomeRental.IViews.Business.User;
using HomeRentals.Models.Business;
using Services.IServices.Business;
using Services.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace HomeRental.Presenters.Business.User
{
    public class CustomerDetailPresenter : BasePresenter<ICustomerDetailViews>
    {
        ICustomerService _customerService;

        public CustomerDetailPresenter(ICustomerDetailViews view) : base(view)
        {
            _customerService = new CustomerService();
        }

        public Result<CustomerModel> GetCustomerById(Guid id)
        {
            return _customerService.GetCustomerById(id);
        }

        public Result<CustomerModel> Save()
        {
            return _customerService.Save(new CustomerModel()
            {
                Id = View.Id,
                Address = View.Address,
                DOB = View.DOB,
                Gender = View.Gender,
                PhoneNumber = View.PhoneNumber,
                Code = View.CustomerCode,
                Name = View.CustomerName
            });
        }
    }
}
