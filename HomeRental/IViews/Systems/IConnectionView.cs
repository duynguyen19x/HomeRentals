using HomeRental.Models.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeRental.IViews.Systems
{
    public interface IConnectionView : IView
    {
        string ServerName { get; set; }
        string DatabaseName { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
    }
}
