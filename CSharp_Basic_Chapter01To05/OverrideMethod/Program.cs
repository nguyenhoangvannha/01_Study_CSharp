using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ThoiVu tv = new ThoiVu();
            Console.Write(tv.tinhLuong(1));
            NhanVien nv = new ThoiVu();
            Console.WriteLine("\n" + nv.tinhLuong(1));
        }
    }
}
