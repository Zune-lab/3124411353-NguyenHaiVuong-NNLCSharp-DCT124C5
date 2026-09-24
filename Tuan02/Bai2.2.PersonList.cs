using System;
using System.Collections.Generic;

namespace Lab02
{
    class Person
    {
        private string id;
        private string name;
        private int yob;
        private int yod;

        public Person() { id = ""; name = ""; yob = 0; yod = 0; }

        public Person(string id, string name, int yob, int yod)
        {
            this.id = id; this.name = name; this.yob = yob; this.yod = yod;
        }

        public Person(Person p)
        {
            this.id = p.id; this.name = p.name; this.yob = p.yob; this.yod = p.yod;
        }

        public void Input()
        {
            Console.Write("Nhap ma so: ");
            id = Console.ReadLine();
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            yob = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam mat (0 neu con song): ");
            yod = int.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.Write($"[{id}] {name} - Sinh nam: {yob} | ");
            if (IsLiving())
                Console.WriteLine("Tinh trang: Con song");
            else
                Console.WriteLine($"Da mat nam: {yod}");
        }

        public bool IsLiving()
        {
            return yod == 0;
        }
    }

    // Lớp PersonList: quản lý một danh sách nhiều Person
    class PersonList
    {
        private List<Person> ds; // Field: danh sách các Person

        // Default constructor
        public PersonList()
        {
            ds = new List<Person>();
        }

        // Copy constructor
        public PersonList(PersonList p)
        {
            ds = new List<Person>();
            foreach (Person x in p.ds)
                ds.Add(new Person(x)); // Copy sâu, dùng lại copy constructor của Person
        }

        // Nhập dữ liệu cho cả danh sách
        public void Input()
        {
            Console.Write("Nhap so nguoi can quan ly: ");
            int n = int.Parse(Console.ReadLine());
            ds = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"--- Nhap nguoi thu {i + 1} ---");
                Person p = new Person();
                p.Input();
                ds.Add(p);
            }
        }

        // Xuất toàn bộ danh sách
        public void Output()
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("Danh sach rong.");
                return;
            }
            foreach (Person p in ds)
                p.Output();
        }

        // Thêm một Person vào danh sách
        public void Add(Person x)
        {
            ds.Add(x);
        }

        // Trả về một PersonList mới chỉ gồm những người còn sống
        public PersonList LivingPeople()
        {
            PersonList ketQua = new PersonList();
            foreach (Person p in ds)
            {
                if (p.IsLiving())
                    ketQua.Add(new Person(p)); // Thêm bản copy để tránh đụng vào dữ liệu gốc
            }
            return ketQua;
        }
    }

    class TestPersonList
    {
        static void Main()
        {
            Console.WriteLine("--- BAI 2.2: PERSONLIST ---");

            PersonList dsNguoi = new PersonList();
            // Gán sẵn data để test cho nhanh
            dsNguoi.Add(new Person("SV01", "Hoang Anh", 2004, 0));
            dsNguoi.Add(new Person("LS01", "Tran Hieu", 1950, 2015));
            dsNguoi.Add(new Person("SV02", "Le Van B", 2003, 0));

            Console.WriteLine("Danh sach tat ca:");
            dsNguoi.Output();

            // Test copy constructor
            PersonList dsCopy = new PersonList(dsNguoi);
            Console.WriteLine("\nDanh sach copy:");
            dsCopy.Output();

            // Test LivingPeople()
            PersonList dsConSong = dsNguoi.LivingPeople();
            Console.WriteLine("\nDanh sach nhung nguoi con song:");
            dsConSong.Output();

            Console.ReadLine();
        }
    }
}
