using System;

namespace Lab02
{
    class Point
    {
        private double x, y;
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }

        // Default constructor
        public Point() { x = 0; y = 0; }
        public Point(double x, double y) { this.x = x; this.y = y; }

        // Method Input/Output để nhập xuất toạ độ (x, y) -- FIX: bổ sung 2 hàm này
        public void Input()
        {
            Console.Write("Nhap x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }

        // Đa năng hóa toán tử
        public static Point operator +(Point a, Point b) => new Point(a.x + b.x, a.y + b.y);
        public static Point operator -(Point a, Point b) => new Point(a.x - b.x, a.y - b.y);
        public static Point operator -(Point a) => new Point(-a.x, -a.y);

        // a. Khoảng cách (cách 1: phương thức thành viên)
        public double KhoangCach(Point khac)
        {
            return Math.Sqrt(Math.Pow(this.x - khac.x, 2) + Math.Pow(this.y - khac.y, 2));
        }

        // a. Khoảng cách (cách 2: phương thức tĩnh)
        public static double KhoangCach(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
        }

        // b. Trung điểm (thành viên)
        public Point TrungDiem(Point khac)
        {
            return new Point((this.x + khac.x) / 2, (this.y + khac.y) / 2);
        }

        // b. Trung điểm (tĩnh)
        public static Point TrungDiem(Point p1, Point p2)
        {
            return new Point((p1.x + p2.x) / 2, (p1.y + p2.y) / 2);
        }
    }

    class TestPoint
    {
        static void Main()
        {
            // FIX: minh hoạ Input() thật sự nhập từ bàn phím
            Point A = new Point();
            Console.WriteLine("Nhap toa do diem A:");
            A.Input();

            Point B = new Point();
            Console.WriteLine("Nhap toa do diem B:");
            B.Input();

            Console.Write("Diem A: "); A.Output();
            Console.Write("Diem B: "); B.Output();

            Console.WriteLine($"A + B = {A + B}");
            Console.WriteLine($"Doi dau A = {-A}");
            Console.WriteLine($"Khoang cach A va B (goi thuong): {A.KhoangCach(B)}");
            Console.WriteLine($"Khoang cach A va B (goi static): {Point.KhoangCach(A, B)}");
            Console.WriteLine($"Trung diem cua A va B: {Point.TrungDiem(A, B)}");
            Console.ReadLine();
        }
    }
}
