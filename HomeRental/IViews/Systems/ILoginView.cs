using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeRental.IViews.Systems
{
    public interface ILoginView : IView
    {
        string UserName { get; set; }
        string Password { get; set; }
    }
}
