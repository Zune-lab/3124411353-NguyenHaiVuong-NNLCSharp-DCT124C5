using System;

namespace Lab02
{
    class Person
    {
        private string id;
        private string name;
        private int yob;
        private int yod;

        // Constructor mặc định
        public Person() { id = ""; name = ""; yob = 0; yod = 0; }

        // Constructor có tham số để gán data cho lẹ
        public Person(string id, string name, int yob, int yod)
        {
            this.id = id; this.name = name; this.yob = yob; this.yod = yod;
        }

        // Copy constructor
        public Person(Person p)
        {
            this.id = p.id; this.name = p.name; this.yob = p.yob; this.yod = p.yod;
        }

        // Input() -- FIX: bổ sung hàm nhập từ bàn phím
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
            // Nếu năm mất = 0 nghĩa là vẫn còn sống
            return yod == 0;
        }
    }

    class TestPerson
    {
        static void Main()
        {
            // FIX: minh hoạ Input() thật sự nhập từ bàn phím
            Person p1 = new Person();
            Console.WriteLine("Nhap thong tin nguoi thu 1:");
            p1.Input();

            Person p2 = new Person("LS01", "Tran Hieu", 1950, 2015);

            Console.WriteLine("\nTEST PERSON");
            p1.Output();
            p2.Output();

            // Test copy constructor
            Person p3 = new Person(p1);
            Console.WriteLine("\nBan copy cua p1:");
            p3.Output();

            Console.ReadLine();
        }
    }
}
