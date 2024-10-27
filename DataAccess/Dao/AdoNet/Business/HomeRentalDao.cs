using BusinessObjects.Business;
using DataAccess.IDao.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.Dao.AdoNet.Business
{
    public class HomeRentalDao : IHomeRentalDao
    {
        public Result<IList<HomeRentalEntity>> GetAlls()
        {
            var result = new Result<IList<HomeRentalEntity>>();

            try
            {
                result.Items = DatabaseHelper.QueryStoredProcedure<HomeRentalEntity>("Proc_GetHomeRentals").ToList();
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return result;
        }

        public Result<HomeRentalEntity> GetById(Guid id)
        {
            var result = new Result<HomeRentalEntity>();

            try
            {
                result.Items = DatabaseHelper.QuerySingleStoredProcedure<HomeRentalEntity>("Proc_GetHomeRentalById", new { Id = id });
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return result;
        }

        public Result<Guid> Save(HomeRentalEntity customer)
        {
            var result = new Result<Guid>();

            try
            {
                result.Items = DatabaseHelper.QuerySingleStoredProcedure<Guid>("Proc_CreateOrEditHomeRental", customer);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return result;
        }

        public Result<bool> DeleteById(Guid id)
        {
            var result = new Result<bool>();

            try
            {
                result.Success = DatabaseHelper.ExecuteStoredProcedure("Proc_DeleteHomeRentalById", new { Id = id }) > 0;
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
