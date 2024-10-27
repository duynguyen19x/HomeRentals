﻿using HomeRentals.Models.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeRental.IViews.Business.User
{
    public interface IUserViews : IView
    {
        IList<UserModel> Users { get; set; }
    }
}
