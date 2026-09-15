using System;

class HoanVi
{
    // Bai 8: tham chieu ref - hoan vi hai so thuc
    public void Hoan(ref double a, ref double b)
    {
        double tam = a;
        a = b;
        b = tam;
    }
}

class Bai08
{
    static void Main()
    {
        Console.Write("Nhap a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhap b: ");
        double b = double.Parse(Console.ReadLine());

        HoanVi obj = new HoanVi();
        obj.Hoan(ref a, ref b);

        Console.WriteLine($"Sau khi hoan vi: a = {a}, b = {b}");
    }
}
