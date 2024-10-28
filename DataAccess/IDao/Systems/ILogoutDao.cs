﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.IDao.Systems
{
    public interface ILogoutDao
    {
        Result<bool> CloseConnectDatabase();
    }
}