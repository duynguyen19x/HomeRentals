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
        public string HomeRentalAddress { get; set; } // Địa chỉ
        public string HomeRentalDescription { get; set; } // Mô tả
        public decimal HomeRentalPrice { get; set; } // Giá thuê
        public decimal HomeRentalArea { get; set; } // Diện tích
        public int HomeRentalFloor { get; set; } // Tầng
        public int HomeRentalFacing { get; set; } // Hướng
        public string HomeRentalFacingName
        {
            get
            {
                string homeRentalFacingName = string.Empty;

                switch (HomeRentalFacing)
                {
                    case 0:
                        {
                            homeRentalFacingName = "Đông";
                        }
                        break;
                    case 1:
                        {
                            homeRentalFacingName = "Tây";
                        }
                        break;
                    case 2:
                        {
                            homeRentalFacingName = "Bắc";
                        }
                        break;
                    case 3:
                        {
                            homeRentalFacingName = "Nam";
                        }
                        break;
                    case 4:
                        {
                            homeRentalFacingName = "Đông Bắc";
                        }
                        break;
                    case 5:
                        {
                            homeRentalFacingName = "Tây Bắc";
                        }
                        break;
                    case 6:
                        {
                            homeRentalFacingName = "Tây Nam";
                        }
                        break;
                    case 7:
                        {
                            homeRentalFacingName = "Đông Nam";
                        }
                        break;
                }

                return homeRentalFacingName;
            }
        } // Hướng

        public decimal Amount { get; set; }
    }
}
