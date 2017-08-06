using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMethod
{
    class NhanVien
    {
        public virtual int tinhLuong(int days)
        {
            return 10000 * days;
        }
    }
}
