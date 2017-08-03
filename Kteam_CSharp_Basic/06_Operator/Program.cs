
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            String strSoNguyen;
            int SoNguyen;
            String KetQua;
            SoNguyen = Int32.Parse(Console.ReadLine());
            Console.WriteLine((SoNguyen % 2 == 0) ? "So chan!" : "So lE");
            Console.ReadKey(true);
        }
    }
}
