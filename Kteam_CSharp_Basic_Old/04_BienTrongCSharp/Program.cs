using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_BienTrongCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tên biến là một chuỗi ký tự liên kết(không có khoảng trắng) và không chứa ký tự đặc biệt.
            //Tên biến không được đặt bằng tiếng việt có dấu.
            //Tên không được bắt đầu bằng số.
            //Tên biến không được trùng nhau.
            //Tên biến không được trùng với từ khóa:
            string name;
            int age;
            string address;
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();
            Console.WriteLine(name);
            Console.Write("\nNhap tuoi: ");
            age = Console.Read() - 48;
            Console.WriteLine(age);
            Console.ReadKey(true);
        }
    }
}
