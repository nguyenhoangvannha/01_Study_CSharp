﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_KieuDuLieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            //int a = null; // loi
            int? b = null;
            //Tru String cac kieu du lieu khac khong duoc co gia tri null
            Console.WriteLine("byte: {0} -- {1} \n\tsize: {2}", byte.MinValue, byte.MaxValue, sizeof(byte));
            Console.WriteLine("short: {0} -- {1} \n\tsize: {2}", short.MinValue, short.MaxValue, sizeof(short));
            Console.WriteLine("int: {0} -- {1} \n\tsize: {2}", int.MinValue, int.MaxValue, sizeof(int));
            Console.WriteLine("long: {0} -- {1} \n\tsize: {2}", long.MinValue, long.MaxValue, sizeof(long));
            Console.WriteLine("============================");
            Console.ReadKey(true);
        }
    }
}
