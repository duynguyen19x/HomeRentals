using BusinessObjects.Business;
using DataAccess.Dao.AdoNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.IDao.Business
{
    public interface IHomeRentalDao
    {
        Result<IList<HomeRentalEntity>> GetAlls();
        Result<HomeRentalEntity> GetById(Guid id);
        Result<Guid> Save(HomeRentalEntity customer);
        Result<bool> DeleteById(Guid id);
    }
}
