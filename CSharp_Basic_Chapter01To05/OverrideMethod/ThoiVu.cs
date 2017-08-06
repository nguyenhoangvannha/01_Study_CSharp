using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMethod
{
    class ThoiVu:NhanVien
    {
        public override int tinhLuong(int days)
        {
            return 5000 * days;
        }
    }
}
