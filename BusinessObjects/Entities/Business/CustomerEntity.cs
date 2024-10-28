using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Entities.Business
{
    /// <summary>
    /// Danh mục khách hàng
    /// </summary>
    public class CustomerEntity : Entity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public int Gender { get; set; }
        public string PhoneNumber { get; set; }
    }
}
