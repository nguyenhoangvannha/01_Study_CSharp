using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chương trình ra số ngày trong tháng không phải năm nhuận
            string thang;
            Console.WriteLine("===Chuong trinh tim so ngay trong thang===");
            Console.Write("Nhap thang: ");
            thang = Console.ReadLine();
            string songay;
            switch(thang)
            {
                //case "1": songay = "31"; break;
                //case "2": songay = "28"; break;
                //case "3": songay = "31"; break;
                //case "4": songay = "30"; break;
                //case "5": songay = "31"; break;
                //case "6": songay = "30"; break;
                //case "7": songay = "31"; break;
                //case "8": songay = "31"; break;
                //case "9": songay = "30"; break;
                //case "10": songay = "31"; break;
                //case "11": songay = "30"; break;
                //case "12": songay = "31"; break;
                case "2": songay = "28"; break;
                case "1":
                case "3":
                case "5": 
                case "7": 
                case "8": 
                case "10":
                case "12": songay = "31"; break;
                case "4":
                case "6":
                case "9":
                case "11": songay = "30"; break;
                default: songay = "0"; break;
            }
            if (songay == "0") Console.WriteLine("Thang ban nhap khong ton tai.");
            else Console.WriteLine("Thang ban nhap co " + songay + " ngay.");
        }
    }
}
