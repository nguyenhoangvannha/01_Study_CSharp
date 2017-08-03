using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            //int value = 100;
            //Console.Write(value + "\n");
            //increaseValue(ref value);
            //Console.WriteLine(value);
            //Console.ReadKey(true);

            int value;
            outMethod(out value);
            Console.WriteLine(value);
            Console.ReadKey(true);
        }
        private static void increaseValue(ref int a)
        {
            a++;
        }
        private static void outMethod(out int a)
        {
            a = 10;
        }
    }
}
