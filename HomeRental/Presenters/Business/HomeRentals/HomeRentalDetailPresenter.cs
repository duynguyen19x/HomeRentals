using HomeRental.IViews.Business.HomeRentals;
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

namespace HomeRental.Presenters.Business.HomeRentals
{
    public class HomeRentalDetailPresenter : BasePresenter<IHomeRentalDetailViews>
    {
        IHomeRentalService _homeRentalService;

        public HomeRentalDetailPresenter(IHomeRentalDetailViews view) : base(view)
        {
            _homeRentalService = new HomeRentalService();
        }

        public Result<HomeRentalModel> GetById(Guid id)
        {
            return _homeRentalService.GetById(id);
        }

        public Result<Guid> Save()
        {
            return _homeRentalService.Save(new HomeRentalModel()
            {
                Id = View.Id,
                Code = View.Code,
                Address = View.Address,
                Description = View.Description,
                Area = View.Area,
                Facing = View.Facing,
                Floor = View.Floor,
                Price = View.Price
            });
        }
    }
}
