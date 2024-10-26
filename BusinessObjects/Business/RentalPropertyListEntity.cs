using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Business
{
    /// <summary>
    /// Danh mục nhà cho thuê
    /// </summary>
    public class RentalPropertyListEntity : Entity<Guid>
    {
        public string Code { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Price { get; set; } // Giá thuê
        public string Area { get; set; } // Diện tích
        public string Floor { get; set; } // Tầng
        public string Orientation { get; set; } // Hướng
    }
}
