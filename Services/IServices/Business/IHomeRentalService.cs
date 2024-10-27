using BusinessObjects.Business;
using HomeRentals.Models.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Services.IServices.Business
{
    public interface IHomeRentalService
    {
        Result<IList<HomeRentalModel>> GetAlls();

        Result<Guid> Save(HomeRentalModel homeRental);

        Result<HomeRentalModel> GetById(Guid id);

        Result<bool> DeleteById(Guid id);
    }
}
