using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Enum;

namespace HomeRentals.Models.Business
{
    public class CustomerModel : Entity<Guid?>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public int Gender { get; set; }
        public string GenderName
        {
            get
            {
                string genderName = string.Empty;
                switch ((GenderType)Gender)
                {
                    case GenderType.None:
                        genderName = "Không xác định";
                        break;
                    case GenderType.Male:
                        genderName = "Nam";
                        break;
                    case GenderType.Famale:
                        genderName = "Nữ";
                        break;
                }
                return genderName;
            }
        }
        public string PhoneNumber { get; set; }
    }
}
