using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_OverLoading
{
    class Program
    {
        public int cong(int a, int b)
        {
            return a + b;
        }
        public int cong(params int []arr)
        {
            int tong = 0;
            foreach(int item in arr)
            {
                tong += item;
            }
            return tong;
        }
        //public T cong<T>(T a, T b)
        //{
        //    return (T)a + (T)b;
        //}

        static void Main(string[] args)
        {
            NhanVien nv = new NhanVienThoiVu();
            NhanVienThoiVu tv = new NhanVienThoiVu();
            nv.overloadingMethod();
            tv.overloadingMethod();

            Console.ReadKey(true);
        }
    }
}
