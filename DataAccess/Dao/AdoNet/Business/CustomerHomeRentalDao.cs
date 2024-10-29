using BusinessObjects.Dtos.Business;
using BusinessObjects.Entities.Business;
using DataAccess.IDao.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.Dao.AdoNet.Business
{
    public class CustomerHomeRentalDao : ICustomerHomeRentalDao
    {
        public Result<IList<CustomerHomeRentalDto>> GetAlls(DateTime? fromDate, DateTime? toDate, int rented, Guid? customerHomeRentalCurrentId)
        {
            var result = new Result<IList<CustomerHomeRentalDto>>();

            try
            {
                result.Items = DatabaseHelper.QueryStoredProcedure<CustomerHomeRentalDto>("Proc_GetCustomerHomeRentals", new
                {
                    Rented = rented,
                    FromDate = fromDate,
                    ToDate = toDate,
                    CustomerHomeRentalCurrentId = customerHomeRentalCurrentId
                }).ToList();
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return result;
        }

        public Result<CustomerHomeRentalDto> GetById(Guid id)
        {
            var result = new Result<CustomerHomeRentalDto>();

            try
            {
                result.Items = DatabaseHelper.QuerySingleStoredProcedure<CustomerHomeRentalDto>("Proc_GetCustomerHomeRentalById", new { Id = id });
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return result;
        }

        public Result<Guid> Save(CustomerHomeRentalEntity customerHomeRental)
        {
            var result = new Result<Guid>();

            try
            {
                result.Items = DatabaseHelper.QuerySingleStoredProcedure<Guid>("Proc_CreateOrEditCustomerHomeRental", customerHomeRental);
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
                result.Success = DatabaseHelper.ExecuteStoredProcedure("Proc_DeleteCustomerHomeRentalById", new { Id = id }) > 0;
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
