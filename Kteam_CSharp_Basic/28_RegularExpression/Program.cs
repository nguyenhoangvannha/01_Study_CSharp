﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _28_RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            groupRex();
            Console.ReadKey(true);
        }
        public static void basicRex()
        {
            Regex reg = new Regex(@"\d");
            Match result = reg.Match("hello102today 1234");
            //Cach 1
            Console.WriteLine(result.ToString());

            //Cach 2
            do
            {
                Console.WriteLine(result.ToString());
                result = result.NextMatch();
            } while (result != Match.Empty);

            //Cach 3
            foreach (Match item in reg.Matches("wtf000111helo33"))
            {
                Console.WriteLine(item);
            }
        }
        public static void groupRex()
        {
            Regex reg = new Regex(@"(?<day>\d+)/(?<month>\d+)/(?<year>\d+)");
            foreach(Match item in reg.Matches("13:11:59 hello445522 12/07/1998ddf"))
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine(item.Groups["day"]);
                Console.WriteLine(item.Groups["month"]);
                Console.WriteLine(item.Groups["year"]);
            }

        }
        public static void captureRex()
        {
            Regex RE = new Regex(@"(?<times>(\d|:)+)\s" + @"(?<company>\S+)\s" + @"(?<ip>(\d|\.)+)\s" + @"(?<company>\S+)");
            foreach (Match item in RE.Matches("10:30:15 IBM 192.168.1.2 INTEL"))
            {
                Console.WriteLine(" time: " + item.Groups["times"]);
                Console.WriteLine(" ip: " + item.Groups["ip"]);
                Console.Write(" company: ");
                /*
                    Lấy ra tất cả các capture bắt được trong group company và duyệt lần lượt chúng
                 * Sau đó ta có thể sử dụng hàm ToString() hoặc thuộc tính Value để lấy giá trị của Capture
                 */
                foreach (Capture i in item.Groups["company"].Captures)
                {
                    Console.Write(i.ToString() + " ");
                }

            }
        }
    }
}
