using BusinessObjects.Dtos.Business;
using DataAccess.IDao.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.Dao.AdoNet.Reports
{
    public class ReportDao: IReportDao
    {
        public Result<IList<CustomerHomeRentalDto>> GetRpt001(DateTime fromDate, DateTime toDate)
        {
            var result = new Result<IList<CustomerHomeRentalDto>>();

            try
            {
                result.Items = DatabaseHelper.QueryStoredProcedure<CustomerHomeRentalDto>("Proc_GetRpt001", new
                {
                    FromDate = fromDate.Date,
                    ToDate = toDate.Date
                }).ToList();
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return result;
        }
    }
}
