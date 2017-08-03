using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DataConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 3;
            double c;
            c = 1.0*a / b;

            bool isSuccess;
            int Result;
            String data = "123";
            isSuccess = int.TryParse(data, out Result);

            int rel = Convert.ToInt32("2017");
        }
    }
}
/*
 * Cac cach chuyen doi
 * - Chuyen doi ngam dinh
 * - Chuyen doi tuong minh
 * - Su dung phuong thuc va lop ho tro san: Parse(), tryParse(), Convert
 * - Nguoi dung tu dinh nghia kieu chuyen doi
 */ 