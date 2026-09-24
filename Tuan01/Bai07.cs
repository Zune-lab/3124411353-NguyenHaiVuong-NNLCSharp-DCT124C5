using System;

class KiemTraSo
{
    // Bai 7: phuong thuc bool - kiem tra n co phai so nguyen to khong
    public bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;

        // thu chia n cho tat ca cac so tu 2 den n-1
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}

class Bai07
{
    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        KiemTraSo obj = new KiemTraSo();
        if (obj.LaSoNguyenTo(n))
            Console.WriteLine(n + " la so nguyen to");
        else
            Console.WriteLine(n + " khong phai la so nguyen to");
    }
}
