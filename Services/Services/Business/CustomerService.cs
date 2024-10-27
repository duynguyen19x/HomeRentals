using BusinessObjects.Business;
using HomeRentals.Models.Business;
using Services.IServices.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Services.Services.Business
{
    public class CustomerService : BaseServices, ICustomerService
    {
        public Result<IList<CustomerModel>> GetCustomers()
        {
            var Customers = Factory.CustomerDao.GetCustomers();
            return new Result<IList<CustomerModel>>()
            {
                Items = ObjectMapper.Map<IList<CustomerModel>>(Customers.Items)
            };
        }

        public Result<Guid> Save(CustomerModel Customer)
        {
            var CustomerEntity = ObjectMapper.Map<CustomerEntity>(Customer);
            return Factory.CustomerDao.Save(CustomerEntity);
        }

        public Result<CustomerModel> GetCustomerById(Guid id)
        {
            var result = Factory.CustomerDao.GetCustomerById(id);

            return new Result<CustomerModel>()
            {
                Success = result.Success,
                Message = result.Message,
                Items = ObjectMapper.Map<CustomerModel>(result.Items)
            };
        }

        public Result<bool> DeleteCustomerById(Guid id)
        {
            return Factory.CustomerDao.DeleteCustomerById(id);
        }
    }
}
