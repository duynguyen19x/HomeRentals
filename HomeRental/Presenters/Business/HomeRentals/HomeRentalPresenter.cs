using HomeRental.IViews.Business.HomeRentals;
using HomeRental.IViews.Business.User;
using HomeRentals.Models.Business;
using Services.IServices.Business;
using Services.Services.Business;
using System;
using System.Collections.Generic;
using Utilities;

namespace HomeRental.Presenters.Business.HomeRentals
{
    public class HomeRentalPresenter : BasePresenter<IHomeRentalViews>
    {
        IHomeRentalService _homeRentalService;

        public HomeRentalPresenter(IHomeRentalViews view) : base(view)
        {
            _homeRentalService = new HomeRentalService();
        }

        public Result<IList<HomeRentalModel>> GetAlls()
        {
            return _homeRentalService.GetAlls();
        }

        public Result<bool> DeleteById(Guid id)
        {
            return _homeRentalService.DeleteById(id);
        }
    }
}
