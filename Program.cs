using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baitap2
{
    class Program
    {
        static void cau1()                                                    // Tổng của 2 số
        {
            Console.WriteLine("Cau 1");
            Console.WriteLine("Tong cua 2 so la: " + (15 + 17));
            Console.ReadLine();
        }
        static void cau2()                                                    // Hoán đổi vị trí của 2 số
        {
            Console.WriteLine("Cau 2");
            int so1, so2, tamp;
            Console.Write("Nhap so thu nhat: ");

            so1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            so2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            tamp = so1;
            so1 = so2;
            so2 = tamp;
            Console.WriteLine("Gia tri sau khi doi la: ");
            Console.WriteLine();
            Console.WriteLine("So thu nhat la: " + so1);
            Console.WriteLine("Gia tri so thu hai la: " + so2);
            Console.ReadLine();
        }
        static void cau3()                                                     // Tính trung bình cộng của 4 số
        {
            Console.WriteLine("Cau 3");
            double so1, so2, so3, so4;
            Console.Write("Nhap vao so thu nhat: ");
            so1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            so2 = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu ba: ");
            so3 = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu tu: ");
            so4 = double.Parse(Console.ReadLine());
            double S = (so1 + so2 + so3 + so4) / 4;
            Console.WriteLine("Gia tri trung bình cua bon so la: " + S);
            Console.ReadLine();
        }
        static void cau4()                                                     // Đảo ngược vị trí của 3 chữ cái
        {
            Console.WriteLine("Cau 4");                                            // tại sao số vẫn được
            String chu1, chu2, chu3;
            Console.Write("Nhap vao chu thu nhat: ");
            chu1 = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap vao chu thu hai: ");
            chu2 = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap vao chu thu ba: ");
            chu3 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ba chu cai sau khi da dao nguoc: " + chu3 + chu2 + chu1);
            Console.ReadLine();
        }
        public static void cau5()                                               // So sánh 2 số nhập từ bàn phím
        {
            Console.WriteLine("Cau 5");
            int so1, so2;
            Console.Write("Nhap vao so thu nhat: ");
            so1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            so2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (so1 == so2)
            {
                Console.WriteLine("2 so bang nhau");

            }
            else
            {
                Console.WriteLine("2 so khong bang nhau");
            }
            Console.ReadLine();
        }
        static void cau6()                                                      // Kiểm tra chẳn lẻ một số nhập từ bàn phím
        {
            Console.WriteLine("Cau 6");
            int a;
            Console.Write("Nhap vao so can kiem tra: ");
            a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("so " + a + " khong phai so chan, cung khong phai so le !");
            }
            if (a % 2 == 0)
            {
                Console.WriteLine("So " + a + " la so chan !");
            }
            else
            {
                Console.WriteLine("So " + a + " la so le !");
            }
            Console.ReadLine();
        }
        static void cau7()                                                        // Kiểm tra só dương, số âm
        {
            Console.WriteLine("Cau 7");
            int a;
            Console.Write("Nhap so can kiem tra: ");
            a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("So " + a + " la so duong !");
            }
            else if (a < 0)
            {
                Console.WriteLine("So " + a + " la so am !");
            }
            else
            {
                Console.WriteLine("So " + a + " la so khong am, cung khong duong !");
            }
            Console.ReadLine();
        }
        static void cau8()                                                          // Kiểm tra năm nhuận
        {
            Console.WriteLine("Cau 8");
            int kt_nam;
            Console.Write("Nhap nam can kiem tra: ");
            kt_nam = int.Parse(Console.ReadLine());
            if (kt_nam % 400 == 0)
            {
                Console.WriteLine("Nam " + kt_nam + " la nam nhuan!");
            }
            else if (kt_nam % 100 == 0)
            {
                Console.WriteLine("Nam " + kt_nam + " khong la nam nhuan!");
            }
            else if (kt_nam % 4 == 0)
            {
                Console.WriteLine("Nam " + kt_nam + " la nam nhuan!");
            }
            else
            {
                Console.WriteLine("Nam " + kt_nam + " khong la nam nhuan!");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            cau1();
            cau2();
            cau3();
            cau4();
            cau5();
            cau6();
            cau7();
            cau8();
        }
    }
}
