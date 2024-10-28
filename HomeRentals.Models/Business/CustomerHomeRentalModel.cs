using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeRentals.Models.Business
{
    public class CustomerHomeRentalModel : Entity<Guid?>
    {
        public string CustomerHomeRentalCode { get; set; }

        public Guid? CustomerId { get; set; }
        public Guid? HomeRentalId { get; set; }

        public DateTime? RentalStartDate { get; set; } // Ngày bắt đầ thuê
        public DateTime? RentalEndDate { get; set; } // Ngày hết hạn thuê

        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }

        public string HomeRentalCode { get; set; } // Mã nhà
        public string HomeRentalDescription { get; set; }
        public decimal HomeRentalPrice { get; set; } // Giá thuê
        public decimal HomeRentalArea { get; set; } // Diện tích
        public int HomeRentalFloor { get; set; } // Tầng
        public int HomeRentalFacing { get; set; } // Hướng
        public string HomeRentalFacingName { get; set; } // Hướng

        public decimal Amount { get; set; }
    }
}
