﻿using DataAccess.Dao.AdoNet.Business;
using DataAccess.Dao.AdoNet.Systems;
using DataAccess.IDao;
using DataAccess.IDao.Business;
using DataAccess.IDao.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao.AdoNet
{
    public class DaoFactory : IDaoFactory
    {
        public ILoginDao LoginDao => new LoginDao();
        public IUserDao UserDao => new UserDao();
        public ICustomerDao CustomerDao => new CustomerDao();
    }
}
