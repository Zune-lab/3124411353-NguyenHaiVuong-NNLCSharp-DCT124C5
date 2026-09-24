using System;
using System.Collections;

namespace Lab02
{
    class Point
    {
        private double x, y;
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }

        public Point() { x = 0; y = 0; }
        public Point(double x, double y) { this.x = x; this.y = y; }

        public void Input()
        {
            Console.Write("Nhap x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = double.Parse(Console.ReadLine());
        }

        public void Output() { Console.WriteLine(ToString()); }

        public override string ToString() { return $"({x}, {y})"; }
    }

    // Lớp ArrayPoint: dùng ArrayList để chứa các Point, có Indexer để truy cập theo chỉ số
    class ArrayPoint
    {
        private ArrayList list; // Field: ArrayList chứa các Point

        public ArrayPoint()
        {
            list = new ArrayList();
        }

        // Indexer: cho phép truy cập Point thứ i giống như mảng, vd: ap[0]
        public Point this[int i]
        {
            get
            {
                if (i < 0 || i >= list.Count)
                    throw new IndexOutOfRangeException("Chi so vuot ngoai pham vi ArrayPoint.");
                return (Point)list[i];
            }
            set
            {
                if (i < 0 || i >= list.Count)
                    throw new IndexOutOfRangeException("Chi so vuot ngoai pham vi ArrayPoint.");
                list[i] = value;
            }
        }

        public int Count { get { return list.Count; } }

        public void Add(Point p)
        {
            list.Add(p);
        }

        public void Output()
        {
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"Point[{i}] = {this[i]}");
        }
    }

    class TestArrayPoint
    {
        static void Main()
        {
            ArrayPoint ap = new ArrayPoint();
            ap.Add(new Point(1, 2));
            ap.Add(new Point(3, 4));
            ap.Add(new Point(-1, 5));

            Console.WriteLine("--- BAI 2.1: ARRAYPOINT ---");
            ap.Output();

            // Test truy cap qua indexer
            Console.WriteLine($"\nTruy cap qua indexer ap[1] = {ap[1]}");

            // Test gan lai gia tri qua indexer
            ap[1] = new Point(10, 10);
            Console.WriteLine($"Sau khi gan lai ap[1] = {ap[1]}");

            Console.ReadLine();
        }
    }
}
