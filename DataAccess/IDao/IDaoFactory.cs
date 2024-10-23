using DataAccess.Dao.AdoNet.Systems;
using DataAccess.IDao.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IDao
{
    public interface IDaoFactory
    {
        public ILoginDao LoginDao {  get; }
    }
}
