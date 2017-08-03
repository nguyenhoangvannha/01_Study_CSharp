using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_KieuDulieu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vùng nhớ Heap cho cấp phát động
            //Vùng nhớ stack cố định

            //Kiểu số nguyên
            byte b = 255; // 1 byte
            sbyte sb = -128; // 1 byte
            short s; //2 byte
            ushort us; //2 byte
            int i; //4 byte
            uint ui; // 4byte
            long l;//8 byte
            ulong ul; // 8 byte
            char c; //2 byte
           
            //Kiểu số thực
            float fl; // 4 byte phải có chữ f ở cuối
            double db; // 8 byte
            decimal dc; //8 bytecó chữ m ở cuối
            
            //Kiểu logic
            bool bl = false; //1 byte
            
            //Không thể gán null cho biến kiểu số nguyên hoặc số thực
            float? bienfloat = null;
        }
    }
}
