using System;

class BaSoNguyen
{
    // Bai 6: return gia tri - tim so lon nhat trong 3 so nguyen
    public int TimMax(int a, int b, int c)
    {
        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        return max;
    }
}

class Bai06
{
    static void Main()
    {
        Console.Write("Nhap a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Nhap c: ");
        int c = int.Parse(Console.ReadLine());

        BaSoNguyen obj = new BaSoNguyen();
        int max = obj.TimMax(a, b, c);
        Console.WriteLine("So lon nhat la: " + max);
    }
}
