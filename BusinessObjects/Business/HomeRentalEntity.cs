using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Business
{
    public class HomeRentalEntity: Entity<Guid>
    {
        public string Code { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } // Giá thuê
        public decimal Area { get; set; } // Diện tích
        public int Floor { get; set; } // Tầng
        public int Facing { get; set; } // Hướng
    }
}
