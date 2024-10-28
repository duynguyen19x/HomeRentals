using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeRental.IViews.Business.CustomerHomeRentals
{
    public interface ICustomerHomeRentalDetailViews : IView
    {
        Guid? Id { get; set; }

        string CustomerHomeRentalCode { get; set; }

        Guid? CustomerId { get; set; }
        Guid? HomeRentalId { get; set; }

        DateTime? RentalStartDate { get; set; } // Ngày bắt đầ thuê
        DateTime? RentalEndDate { get; set; } // Ngày hết hạn thuê

        string CustomerCode { get; set; }
        string CustomerName { get; set; }

        string HomeRentalCode { get; set; } // Mã nhà
        decimal HomeRentalPrice { get; set; } // Giá thuê
        decimal HomeRentalArea { get; set; } // Diện tích
        int HomeRentalFloor { get; set; } // Tầng
        int HomeRentalFacing { get; set; } // Hướng
        string HomeRentalFacingName { get; set; } // Hướng

        decimal Amount { get; set; }
    }
}
