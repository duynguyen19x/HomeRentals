using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeRental.IViews.Business.HomeRentals
{
    public interface IHomeRentalDetailViews
    {
        Guid? Id { get; set; }
        string Code { get; set; }
        string Address { get; set; }
        string Description { get; set; }
        decimal Price { get; set; } // Giá thuê
        decimal Area { get; set; } // Diện tích
        int Floor { get; set; } // Tầng
        int Facing { get; set; } // Hướng
    }
}
