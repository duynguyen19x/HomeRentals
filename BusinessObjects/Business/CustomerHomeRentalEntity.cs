using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Business
{
    /// <summary>
    /// Khách hàng thuê nhà
    /// </summary>
    public class CustomerHomeRentalEntity : Entity<Guid>
    {
        public Guid? CustomerId { get; set; }
        public Guid? RentalPropertyId { get; set; }

        public DateTime RentalStartDate { get; set; } // Ngày bắt đầ thuê
        public DateTime RentalEndDate { get; set; } // Ngày hết hạn thuê
    }
}
