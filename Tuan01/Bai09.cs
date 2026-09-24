using System;

class MinMax
{
    // Bai 9: tham chieu out - tim max va min cua 3 so thuc
    public void Tim(double a, double b, double c, out double max, out double min)
    {
        max = a;
        min = a;

        if (b > max) max = b;
        if (c > max) max = c;

        if (b < min) min = b;
        if (c < min) min = c;
    }
}

class Bai09
{
    static void Main()
    {
        Console.Write("Nhap a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhap b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhap c: ");
        double c = double.Parse(Console.ReadLine());

        double max, min;
        MinMax obj = new MinMax();
        obj.Tim(a, b, c, out max, out min);

        Console.WriteLine("Gia tri lon nhat: " + max);
        Console.WriteLine("Gia tri nho nhat: " + min);
    }
}
