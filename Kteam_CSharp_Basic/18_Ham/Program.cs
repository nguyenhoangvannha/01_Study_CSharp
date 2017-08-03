using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Ham
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine(a);
            changeA(a);
            Console.WriteLine(a);
        }
        private static void changeA(int a)
        {
            a = a + 1111;
        }
    }
}
