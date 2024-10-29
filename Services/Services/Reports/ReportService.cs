using BusinessObjects.Dtos.Business;
using DataAccess.Dao.AdoNet;
using HomeRentals.Models.Business;
using Services.IServices.Business;
using Services.IServices.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Services.Services.Reports
{
    public class ReportService : BaseServices, IReportService
    {
        public Result<IList<CustomerHomeRentalModel>> GetRpt001(DateTime fromDate, DateTime toDate)
        {
            var result = Factory.ReportDao.GetRpt001(fromDate, toDate);

            return new Result<IList<CustomerHomeRentalModel>>()
            {
                Success = result.Success,
                Message = result.Message,
                Items = ObjectMapper.Map<IList<CustomerHomeRentalModel>>(result.Items)
            };
        }

        public Result<IList<CustomerHomeRentalModel>> GetRpt002()
        {
            var result = Factory.ReportDao.GetRpt002();

            return new Result<IList<CustomerHomeRentalModel>>()
            {
                Success = result.Success,
                Message = result.Message,
                Items = ObjectMapper.Map<IList<CustomerHomeRentalModel>>(result.Items)
            };
        }

        public Result<IList<CustomerHomeRentalModel>> GetRpt003()
        {
            var result = Factory.ReportDao.GetRpt003();

            return new Result<IList<CustomerHomeRentalModel>>()
            {
                Success = result.Success,
                Message = result.Message,
                Items = ObjectMapper.Map<IList<CustomerHomeRentalModel>>(result.Items)
            };
        }
    }
}
