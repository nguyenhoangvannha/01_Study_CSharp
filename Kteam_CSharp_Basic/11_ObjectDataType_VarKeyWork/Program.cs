using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ObjectDataType_VarKeyWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //object khong can khoi tao khi khai bao
            //object duoc xac dinh kieu khi chuong trinh bien dich
            // Boxing: chuyen tu du lieu gia tri sang kieu tham chieu
            int value = 100;
            Object objValue = value;

            //Unboxing
            int returl = (int)objValue;


            //var can khoi tao khi khai bao
            //Tu khoa var: tao bien ma khong can biet kieu du lieu
            //var khong phai kieu du lieu, dung de duyet mang va truy van linQ
            var varBool = true;
            
        }
    }
}
