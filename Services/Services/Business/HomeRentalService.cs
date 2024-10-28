using BusinessObjects.Entities.Business;
using HomeRentals.Models.Business;
using Services.IServices.Business;
using System;
using System.Collections.Generic;
using Utilities;

namespace Services.Services.Business
{
    public class HomeRentalService : BaseServices, IHomeRentalService
    {
        public Result<IList<HomeRentalModel>> GetAlls()
        {
            var homeRentals = Factory.HomeRentalDao.GetAlls();
            return new Result<IList<HomeRentalModel>>()
            {
                Items = ObjectMapper.Map<IList<HomeRentalModel>>(homeRentals.Items)
            };
        }

        public Result<Guid> Save(HomeRentalModel homeRental)
        {
            var homeRentalEntity = ObjectMapper.Map<HomeRentalEntity>(homeRental);
            return Factory.HomeRentalDao.Save(homeRentalEntity);
        }

        public Result<HomeRentalModel> GetById(Guid id)
        {
            var result = Factory.HomeRentalDao.GetById(id);

            return new Result<HomeRentalModel>()
            {
                Success = result.Success,
                Message = result.Message,
                Items = ObjectMapper.Map<HomeRentalModel>(result.Items)
            };
        }

        public Result<bool> DeleteById(Guid id)
        {
            return Factory.HomeRentalDao.DeleteById(id);
        }
    }
}
