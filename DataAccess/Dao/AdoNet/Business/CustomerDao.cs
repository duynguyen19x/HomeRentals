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
    internal class CustomerDao : ICustomerDao
    {
        public Result<IList<CustomerEntity>> GetCustomers()
        {
            var result = new Result<IList<CustomerEntity>>();

            try
            {
                result.Items = DatabaseHelper.QueryStoredProcedure<CustomerEntity>("Proc_GetCustomers").ToList();
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return result;
        }

        public Result<CustomerEntity> GetCustomerById(Guid id)
        {
            var result = new Result<CustomerEntity>();

            try
            {
                result.Items = DatabaseHelper.QuerySingleStoredProcedure<CustomerEntity>("Proc_GetCustomerById", new { Id = id });
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return result;
        }

        public Result<CustomerEntity> Save(CustomerEntity customer)
        {
            var result = new Result<CustomerEntity>();

            try
            {
                result.Success = DatabaseHelper.ExecuteStoredProcedure("Proc_CreateOrEditCustomer", customer) > 0;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }

            return result;
        }

        public Result<bool> DeleteCustomerById(Guid id)
        {
            var result = new Result<bool>();

            try
            {
                result.Success = DatabaseHelper.ExecuteStoredProcedure("Proc_DeleteCustomerById", new { Id = id }) > 0;
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
