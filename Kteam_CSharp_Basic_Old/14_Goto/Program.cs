using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Goto
{
    class Program
    {
        static void Main(string[] args)
        {
            goto Label2;
            Label1:
            Console.WriteLine("Label 1");
            Label2:
            Console.WriteLine("Label 2");
            Console.ReadKey(true);
        }
    }
}
