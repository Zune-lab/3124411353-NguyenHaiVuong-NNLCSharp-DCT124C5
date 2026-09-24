using System;

namespace Lab02
{
    class SinhVien
    {
        public string HoTen;
        public int NamSinh;

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
        }

        public void XuatTuoi()
        {
            // Dùng năm hiện tại trừ đi năm sinh cho chuẩn
            int tuoi = DateTime.Now.Year - NamSinh;
            Console.WriteLine($"=> Sinh vien {HoTen} hien tai {tuoi} tuoi.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BAI 1.1: TINH TUOI ---");
            SinhVien sv = new SinhVien();

            // Gán sẵn data để test
            sv.HoTen = "Nguyen Van A";
            sv.NamSinh = 2004;
            Console.WriteLine($"Da nhap: {sv.HoTen}, sinh nam {sv.NamSinh}");

            sv.XuatTuoi();
            Console.ReadLine();
        }
    }
}
