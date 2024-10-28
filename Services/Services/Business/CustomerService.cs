using BusinessObjects.Entities.Business;
using HomeRentals.Models.Business;
using Services.IServices.Business;
using System;
using System.Collections.Generic;
using Utilities;

namespace Services.Services.Business
{
    public class CustomerService : BaseServices, ICustomerService
    {
        public Result<IList<CustomerModel>> GetAlls()
        {
            var Customers = Factory.CustomerDao.GetAlls();
            return new Result<IList<CustomerModel>>()
            {
                Items = ObjectMapper.Map<IList<CustomerModel>>(Customers.Items)
            };
        }

        public Result<Guid> Save(CustomerModel customer)
        {
            var customerEntity = ObjectMapper.Map<CustomerEntity>(customer);
            return Factory.CustomerDao.Save(customerEntity);
        }

        public Result<CustomerModel> GetById(Guid id)
        {
            var result = Factory.CustomerDao.GetById(id);

            return new Result<CustomerModel>()
            {
                Success = result.Success,
                Message = result.Message,
                Items = ObjectMapper.Map<CustomerModel>(result.Items)
            };
        }

        public Result<bool> DeleteById(Guid id)
        {
            return Factory.CustomerDao.DeleteById(id);
        }
    }
}
