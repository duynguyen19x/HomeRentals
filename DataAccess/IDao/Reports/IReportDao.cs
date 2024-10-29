using BusinessObjects.Dtos.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.IDao.Reports
{
    public interface IReportDao
    {
        Result<IList<CustomerHomeRentalDto>> GetRpt001(DateTime fromDate, DateTime toDate);
    }
}
