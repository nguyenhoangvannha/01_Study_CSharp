using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67_HoaDonBanXe
{
    class Car
    {
        public static readonly int PHU_THU_XE_DEN = 5;
        public static readonly int THUE = 200;
        public string CarColor { get; set; }
        public int Cost { get; set; }
        public int Price { get
            {
                if (CarColor == "Black")
                {
                    return Cost + (int)((PHU_THU_XE_DEN + THUE) *0.01*Cost);
                }
                else return Cost + (int)((0 + THUE) * 0.01 * Cost);
            }
        }
    }
}
