using HomeRentals.Models.Business;
using Services.IServices.Reports;
using Services.Services.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace HomeRental.Presenters.Reports
{
    public class ReportPresenter
    {
        IReportService _reportService;

        public ReportPresenter() 
        {
            _reportService = new ReportService();
        }

        public Result<IList<CustomerHomeRentalModel>> GetRpt001(DateTime fromDate, DateTime toDate)
        {
            return _reportService.GetRpt001(fromDate, toDate);
        }

        public Result<IList<CustomerHomeRentalModel>> GetRpt002()
        {
            return _reportService.GetRpt002();
        }

        public Result<IList<CustomerHomeRentalModel>> GetRpt003()
        {
            return _reportService.GetRpt003();
        }
    }
}
