using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chương trình giải phương trình bậc nhất
            int a, b;
            string str1, str2;
            Console.WriteLine("================Giai phuong trinh bac nhat================");
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            str2 = Console.ReadLine();
            if (!int.TryParse(str2,out b))
            {
                Console.WriteLine("Ban nhap sai!");
            }
            else
            {
                Console.WriteLine("Phuong trinh ban nhap la: " + a + "x + " + b + " = " + 0);
                if (a == 0 && b!= 0) Console.WriteLine("Phuong trinh vo nghiem.");
                if (a == 0 && b == 0) Console.WriteLine("Phuong trinh co vo so nghiem.");
                if (a != 0)
                {
                    float Nghiem = (float)-b / a;
                    Console.WriteLine("Phuong trinh co nghiem la: x = " + Nghiem);
                }
            }
        }
    }
}
