using HomeRentals.Models.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Services.IServices.Reports
{
    public interface IReportService
    {
        Result<IList<CustomerHomeRentalModel>> GetRpt001(DateTime fromDate, DateTime toDate);
        Result<IList<CustomerHomeRentalModel>> GetRpt002();
        Result<IList<CustomerHomeRentalModel>> GetRpt003();
    }
}
