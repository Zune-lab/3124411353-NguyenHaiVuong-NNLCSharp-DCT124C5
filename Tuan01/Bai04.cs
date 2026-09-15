using System;

class Bai04
{
    static void Main()
    {
        Console.Write("Nhap so nguyen x: ");
        string strX = Console.ReadLine();
        Console.Write("Nhap so nguyen y: ");
        string strY = Console.ReadLine();

        // dung TryParse thay vi Parse de khong bi crash khi nhap sai,
        // TryParse tra ve false neu chuoi khong phai so nguyen
        int x, y;
        bool okX = int.TryParse(strX, out x);
        bool okY = int.TryParse(strY, out y);

        if (!okX || !okY)
        {
            Console.WriteLine("Loi: x hoac y khong phai la so nguyen!");
            return;
        }

        // giong bai 3, tinh x^y bang cach nhan don
        long ketQua = 1;
        for (int i = 0; i < y; i++)
            ketQua *= x;

        Console.WriteLine($"Ket qua {x} mu {y} la: {ketQua}");
    }
}
