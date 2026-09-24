using System;

namespace Lab02
{
    class DonThuc
    {
        private double a;
        private int n;

        public DonThuc(double a, int n)
        {
            this.a = a;
            this.n = n < 0 ? 0 : n; // Theo đề n không âm
        }

        // a. Tính giá trị P(x) = a.x^n
        public double TinhGiaTri(double x)
        {
            return a * Math.Pow(x, n);
        }

        // b. Đạo hàm (hạ bậc)
        public DonThuc DaoHam()
        {
            if (n == 0) return new DonThuc(0, 0); // Hằng số đạo hàm = 0
            return new DonThuc(a * n, n - 1);
        }

        public override string ToString()
        {
            if (n == 0) return $"{a}";
            if (n == 1) return $"{a}x";
            return $"{a}x^{n}";
        }
    }

    class TestDonThuc
    {
        static void Main()
        {
            // Test đơn thức: 5x^3
            DonThuc dt = new DonThuc(5, 3);
            Console.WriteLine($"Don thuc: {dt}");

            // Thế x = 2 vào (kết quả sẽ là 5 * 2^3 = 40)
            Console.WriteLine($"Gia tri tai x=2: {dt.TinhGiaTri(2)}");

            // Đạo hàm của 5x^3 là 15x^2
            Console.WriteLine($"Dao ham: {dt.DaoHam()}");

            Console.ReadLine();
        }
    }
}
