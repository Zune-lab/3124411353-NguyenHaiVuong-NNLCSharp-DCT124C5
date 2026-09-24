using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    // Lớp DaySo: chứa mảng 1 chiều n số nguyên
    class DaySo
    {
        private int[] a; // Field: mảng chứa các số nguyên
        private int n;   // Số lượng phần tử

        // a. Các loại Constructor

        // Constructor mặc định: dãy rỗng
        public DaySo()
        {
            n = 0;
            a = new int[0];
        }

        // Constructor tạo dãy gồm n phần tử, giá trị mặc định = 0
        public DaySo(int n)
        {
            this.n = n < 0 ? 0 : n;
            a = new int[this.n];
        }

        // Constructor tạo dãy từ một mảng int có sẵn
        public DaySo(int[] arr)
        {
            n = arr.Length;
            a = (int[])arr.Clone(); // Clone để tránh 2 đối tượng cùng trỏ chung 1 mảng
        }

        // Constructor sao chép
        public DaySo(DaySo d)
        {
            n = d.n;
            a = (int[])d.a.Clone();
        }

        public int Count { get { return n; } }

        // b. Indexer để truy cập phần tử thứ i trong dãy
        public int this[int i]
        {
            get
            {
                if (i < 0 || i >= n)
                    throw new IndexOutOfRangeException("Chi so vuot ngoai pham vi day so.");
                return a[i];
            }
            set
            {
                if (i < 0 || i >= n)
                    throw new IndexOutOfRangeException("Chi so vuot ngoai pham vi day so.");
                a[i] = value;
            }
        }

        // c. Nhập dãy số
        public void Input()
        {
            Console.Write("Nhap so luong phan tu n: ");
            n = int.Parse(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        // c. Xuất dãy số
        public void Output()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[ ");
            for (int i = 0; i < n; i++)
            {
                sb.Append(a[i]);
                if (i < n - 1) sb.Append(", ");
            }
            sb.Append(" ]");
            Console.WriteLine(sb.ToString());
        }

        // d. Tìm các số chẵn trong dãy, trả về 1 DaySo mới chỉ chứa các số chẵn
        public DaySo TimSoChan()
        {
            List<int> ketQua = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                    ketQua.Add(a[i]);
            }
            return new DaySo(ketQua.ToArray());
        }
    }

    class TestDaySo
    {
        static void Main()
        {
            Console.WriteLine("--- BAI 2.3: DAY SO NGUYEN ---");

            // Test constructor tu mang co san
            DaySo d1 = new DaySo(new int[] { 5, 8, 3, 12, 7, 10, 1 });
            Console.Write("Day so d1: ");
            d1.Output();

            // Test indexer
            Console.WriteLine($"Phan tu d1[2] = {d1[2]}");
            d1[2] = 99;
            Console.Write("Sau khi sua d1[2] = 99: ");
            d1.Output();

            // Test copy constructor
            DaySo d2 = new DaySo(d1);
            Console.Write("Day so d2 (copy cua d1): ");
            d2.Output();

            // Test tim so chan
            DaySo soChan = d1.TimSoChan();
            Console.Write("Cac so chan trong d1: ");
            soChan.Output();

            Console.ReadLine();
        }
    }
}
