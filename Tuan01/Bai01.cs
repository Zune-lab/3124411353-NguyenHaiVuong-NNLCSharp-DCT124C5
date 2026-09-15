using System;

namespace Bai01_NhapXuatHoTen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap ho ten
            Console.Write("Nhap ho ten: ");
            string hoTen = Console.ReadLine();

            // Xuat ra man hinh
            Console.WriteLine("Xin chao " + hoTen);

            Console.ReadKey();
        }
    }
}
