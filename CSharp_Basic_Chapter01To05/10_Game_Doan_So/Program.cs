using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Game_Doan_So
{
    class Program
    {
        public static int showMenu()
        {
            int chon = -1;
            bool kiemtra = false;
            do
            {
                Console.WriteLine("================Trò chơi đoán số================");
                Console.WriteLine("1.Bắt đầu chơi.");
                Console.WriteLine("2.Thoát.");
                Console.Write("====Chọn: ");
                kiemtra = int.TryParse(Console.ReadLine(), out chon);
                if (!kiemtra || chon < 1 || chon > 2)
                {
                    Console.Write("Bạn nhập sai lựa chọn!\nMời nhập lại.");
                }
            } while (kiemtra == false || chon < 1 || chon > 2);
            return chon;
        }
        public static void runGame()
        {
            int chon = showMenu();
            Console.WriteLine();
            if(chon == 2)
            {
                return;
            } else
            {
                int soDoan = 0;
                int ketQua = new Random().Next(0, 501);
                int soLanDoan = 0;
                Console.WriteLine("Nhap mot so trong khoang tu 0 - 500");
                bool kiemtra = false;
                do
                {
                    kiemtra = int.TryParse(Console.ReadLine(), out soDoan);
                    if (!kiemtra)
                    {
                        Console.WriteLine("Bạn nhập sai mời nhập lại.");
                    }
                } while (!kiemtra);

                do
                {
                    soLanDoan++;
                    if (soDoan == ketQua)
                    {
                        Console.WriteLine("Bạn đoán đúng!\nThắng ^.^");
                        break;
                    }
                    else
                    {
                        if(soLanDoan > 7)
                        {
                            Console.WriteLine("Đoán sai quá 7 lần.\nBạn thua!\nKết quả là: " + ketQua);
                            break;
                        }
                        if (soDoan < ketQua)
                        {
                            Console.WriteLine("Số bạn đoán nhỏ hơn đáp án!\nMời nhập lại: ");
                        }
                        if (soDoan > ketQua)
                        {
                            Console.WriteLine("Số bạn đoán lớn hơn đáp án!\nMời nhập lại: ");
                        }
                        do
                        {
                            kiemtra = int.TryParse(Console.ReadLine(), out soDoan);
                            if (!kiemtra)
                            {
                                Console.WriteLine("Bạn nhập sai mời nhập lại.");
                            }
                        } while (!kiemtra);
                    }

                } while (true);
                runGame();
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            runGame();
        }
    }
}
