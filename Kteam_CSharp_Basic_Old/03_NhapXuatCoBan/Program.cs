using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_NhapXuatCoBan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Moi ban nhap ten: ");//In khong xuong dong
            Console.WriteLine(Console.ReadLine());//In xuong dong
            Console.WriteLine(10);
            Console.Write(Environment.NewLine);//Xuong dong
            Console.Write("f = " + 12.34f);//In ra kieu float
            Console.WriteLine("\n {0} + {1} = {2} + {3}", 1, 1, 1, "Thay chua");

            int a = Console.Read();//Đọc vào và trả về số
            Console.ReadLine(); //Đọc vào chuỗi
            Console.WriteLine(a);
            Console.WriteLine(Console.ReadLine());
            Console.ReadKey();//Mặc định là false
            Console.ReadKey(true); //Không hiển thị phím bấm lên màn hình
            Console.ReadKey(false); //Hiện phím bấm lên màn hình
        }
    }
}
