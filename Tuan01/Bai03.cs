using System;

class Bai03
{
    static void Main()
    {
        Console.Write("Nhap so nguyen x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Nhap so nguyen y: ");
        int y = int.Parse(Console.ReadLine());

        // tinh x^y bang vong lap, tranh sai so cua Math.Pow
        long ketQua = 1;
        for (int i = 0; i < y; i++)
            ketQua *= x;

        Console.WriteLine($"Ket qua {x} mu {y} la: {ketQua}");
    }
}
