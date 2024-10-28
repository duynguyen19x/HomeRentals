using HomeRental.IViews.Business.CustomerHomeRentals;
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
    public class CustomerHomeRentalDetailPresenter : BasePresenter<ICustomerHomeRentalDetailViews>
    {
        ICustomerHomeRentalService _customerHomeRentalService;

        public CustomerHomeRentalDetailPresenter(ICustomerHomeRentalDetailViews view) : base(view)
        {
            _customerHomeRentalService = new CustomerHomeRentalService();
        }

        public Result<CustomerHomeRentalModel> GetById(Guid id)
        {
            return _customerHomeRentalService.GetById(id);
        }

        public Result<Guid> Save()
        {
            return _customerHomeRentalService.Save(new CustomerHomeRentalModel()
            {
                Id = View.Id,
                CustomerHomeRentalCode = View.CustomerHomeRentalCode,
                CustomerId = View.CustomerId,
                CustomerCode = View.CustomerCode,
                CustomerName = View.CustomerName,
                HomeRentalArea = View.HomeRentalArea,
                HomeRentalCode = View.HomeRentalCode,
                HomeRentalFacing = View.HomeRentalFacing,
                HomeRentalFloor = View.HomeRentalFloor,
                HomeRentalId = View.HomeRentalId,
                Amount = View.Amount,
                HomeRentalPrice = View.HomeRentalPrice,
                RentalEndDate = View.RentalEndDate,
                RentalStartDate = View.RentalStartDate,
                HomeRentalFacingName = View.HomeRentalFacingName,
            });
        }
    }
}
