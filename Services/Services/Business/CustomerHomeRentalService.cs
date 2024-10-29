using BusinessObjects.Dtos.Business;
using BusinessObjects.Entities.Business;
using HomeRentals.Models.Business;
using Services.IServices.Business;
using System;
using System.Collections.Generic;
using Utilities;

namespace Services.Services.Business
{
    public class CustomerHomeRentalService : BaseServices, ICustomerHomeRentalService
    {
        public CustomerHomeRentalService()
        {
        }

        public Result<IList<CustomerHomeRentalModel>> GetAlls(DateTime? fromDate, DateTime? toDate, int rented, Guid? customerHomeRentalCurrentId)
        {
            var sustomerHomeRentals = Factory.CustomerHomeRentalDao.GetAlls(fromDate, toDate, rented, customerHomeRentalCurrentId);
            return new Result<IList<CustomerHomeRentalModel>>()
            {
                Items = ObjectMapper.Map<IList<CustomerHomeRentalModel>>(sustomerHomeRentals.Items)
            };
        }

        public Result<Guid> Save(CustomerHomeRentalModel customerHomeRental)
        {
            var customerHomeRentalEntity = ObjectMapper.Map<CustomerHomeRentalEntity>(customerHomeRental);
            return Factory.CustomerHomeRentalDao.Save(customerHomeRentalEntity);
        }

        public Result<CustomerHomeRentalModel> GetById(Guid id)
        {
            var result = Factory.CustomerHomeRentalDao.GetById(id);

            return new Result<CustomerHomeRentalModel>()
            {
                Success = result.Success,
                Message = result.Message,
                Items = ObjectMapper.Map<CustomerHomeRentalModel>(result.Items)
            };
        }

        public Result<bool> DeleteById(Guid id)
        {
            return Factory.CustomerHomeRentalDao.DeleteById(id);
        }
    }
}
