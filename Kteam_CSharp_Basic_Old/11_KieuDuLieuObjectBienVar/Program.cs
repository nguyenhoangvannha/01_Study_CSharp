using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_KieuDuLieuObjectBienVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Object obj = "NguyenNha";
            int a = 2017;
            Object objectValue = a; //boxing
            int newa = (int)objectValue; //unboxing

            //var khai bao mà không cần kiểu dữ liệu
            var varBool = true;
            // var x = null; không được bằng null 

        }
    }
}
