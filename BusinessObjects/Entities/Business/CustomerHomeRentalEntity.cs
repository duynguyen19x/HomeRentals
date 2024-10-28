using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Entities.Business
{
    /// <summary>
    /// Khách hàng thuê nhà
    /// </summary>
    public class CustomerHomeRentalEntity : Entity<Guid>
    {
        public string CustomerHomeRentalCode { get; set; }

        public Guid? CustomerId { get; set; }
        public Guid? HomeRentalId { get; set; }

        public DateTime RentalStartDate { get; set; } // Ngày bắt đầ thuê
        public DateTime RentalEndDate { get; set; } // Ngày hết hạn thuê

        public decimal Amount { get; set; } // Thành tiền
    }
}
