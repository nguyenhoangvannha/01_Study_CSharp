using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_OverLoading
{
    class NhanVien
    {
        private int Name { get; set;}

        public NhanVien()
        {
            Console.WriteLine("Contructer of base");
        }
        public int overloadingMethod()
        {
            Console.WriteLine("base method");
            return 1;
        }
    }
}
