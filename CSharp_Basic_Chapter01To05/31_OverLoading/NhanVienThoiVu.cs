using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_OverLoading
{
    class NhanVienThoiVu:NhanVien
    {
        
        
        public NhanVienThoiVu():base()
        {
            Console.WriteLine("Constructer of deliver");
        }

        public new int overloadingMethod()
        {
            Console.WriteLine("base deliver");
            return 2;
        }
    }
}
