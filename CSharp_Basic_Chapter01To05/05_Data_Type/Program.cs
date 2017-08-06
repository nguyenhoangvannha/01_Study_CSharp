using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Data_Type
{
    class Program
    {
        public static int cong(ref int a)
        {
            return a++;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a = 100;
            Console.WriteLine(a);
            cong(ref a);
            Console.WriteLine(a);
            Console.ReadKey();
            DateTime date = new DateTime();
            date.ToString("dd/MM/yyyy");
            date = DateTime.Parse("13/07/2017");

            date = DateTime.Today;
            Console.WriteLine(date.ToString());
            Console.ReadKey();
        }

    }
}
