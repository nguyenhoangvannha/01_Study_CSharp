using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_StaffsManager
{
    class Program
    {
        enum NV
        {
            GD = 25,
            TP = 15,
            PP = 5,
            NV = 0,
        }
        static void Main(string[] args)
        {
            int a = (int)NV.GD;
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
