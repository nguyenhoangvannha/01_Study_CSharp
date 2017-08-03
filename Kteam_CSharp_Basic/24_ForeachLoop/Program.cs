using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInt = new int[12];
            Random rand = new Random();
            for(int i = 0;i < 12; i++)
            {
                arrInt[i] = rand.Next(10, 140);
            }

            foreach (int temp in arrInt)
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }
    }
}
