using System;

namespace Lab02
{
    class PhanSo
    {
        private int tu, mau;

        // Constructor mặc nhiên
        public PhanSo() { tu = 0; mau = 1; }

        // Constructor có tham số
        public PhanSo(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau == 0 ? 1 : mau; // Lỡ nhập mẫu = 0 thì gán tạm = 1 cho đỡ lỗi
            RutGon();
        }

        // Constructor sao chép -- FIX: bổ sung theo đúng yêu cầu đề
        public PhanSo(PhanSo p)
        {
            this.tu = p.tu;
            this.mau = p.mau;
        }

        // Hàm tìm ước chung lớn nhất (UCLN) để rút gọn
        private int UCLN(int a, int b)
        {
            a = Math.Abs(a); b = Math.Abs(b);
            while (a != b && a != 0 && b != 0)
            {
                if (a > b) a -= b; else b -= a;
            }
            return a;
        }

        public void RutGon()
        {
            if (tu == 0) { mau = 1; return; }
            int ucln = UCLN(tu, mau);
            tu /= ucln;
            mau /= ucln;
            // Chuẩn hóa để dấu âm luôn nằm ở tử số
            if (mau < 0) { mau = -mau; tu = -tu; }
        }

        public override string ToString()
        {
            return mau == 1 ? $"{tu}" : $"{tu}/{mau}"; // Mẫu = 1 thì in mỗi tử số thôi
        }

        // FIX: toán tử một ngôi +, -
        public static PhanSo operator +(PhanSo a) => new PhanSo(a.tu, a.mau);
        public static PhanSo operator -(PhanSo a) => new PhanSo(-a.tu, a.mau);

        // Các toán tử 2 ngôi
        public static PhanSo operator +(PhanSo a, PhanSo b) => new PhanSo(a.tu * b.mau + b.tu * a.mau, a.mau * b.mau);
        public static PhanSo operator -(PhanSo a, PhanSo b) => new PhanSo(a.tu * b.mau - b.tu * a.mau, a.mau * b.mau);
        public static PhanSo operator *(PhanSo a, PhanSo b) => new PhanSo(a.tu * b.tu, a.mau * b.mau);
        public static PhanSo operator /(PhanSo a, PhanSo b) => new PhanSo(a.tu * b.mau, a.mau * b.tu);

        // So sánh
        public static bool operator >(PhanSo a, PhanSo b) => a.tu * b.mau > b.tu * a.mau;
        public static bool operator <(PhanSo a, PhanSo b) => a.tu * b.mau < b.tu * a.mau;
        // FIX: bổ sung >=, <= theo đúng yêu cầu đề
        public static bool operator >=(PhanSo a, PhanSo b) => a.tu * b.mau >= b.tu * a.mau;
        public static bool operator <=(PhanSo a, PhanSo b) => a.tu * b.mau <= b.tu * a.mau;
        public static bool operator ==(PhanSo a, PhanSo b) => a.tu * b.mau == b.tu * a.mau;
        public static bool operator !=(PhanSo a, PhanSo b) => !(a == b);

        public override bool Equals(object obj) => base.Equals(obj);
        public override int GetHashCode() => base.GetHashCode();
    }

    class TestPhanSo
    {
        static void Main()
        {
            PhanSo ps1 = new PhanSo(1, 2); // 1/2
            PhanSo ps2 = new PhanSo(3, 4); // 3/4
            Console.WriteLine($"ps1 = {ps1}, ps2 = {ps2}");

            Console.WriteLine($"Cong: {ps1 + ps2}");
            Console.WriteLine($"Tru: {ps1 - ps2}");
            Console.WriteLine($"Nhan: {ps1 * ps2}");
            Console.WriteLine($"Chia: {ps1 / ps2}");

            // FIX: minh hoạ toán tử một ngôi
            Console.WriteLine($"Doi dau ps1 (-ps1): {-ps1}");
            Console.WriteLine($"Giu nguyen dau ps1 (+ps1): {+ps1}");

            // FIX: minh hoạ copy constructor
            PhanSo ps3 = new PhanSo(ps1);
            Console.WriteLine($"Ban copy cua ps1: {ps3}");

            // So sánh đầy đủ 6 toán tử
            Console.WriteLine($"So sanh ps1 > ps2 ?: {ps1 > ps2}");
            Console.WriteLine($"So sanh ps1 < ps2 ?: {ps1 < ps2}");
            Console.WriteLine($"So sanh ps1 >= ps2 ?: {ps1 >= ps2}");
            Console.WriteLine($"So sanh ps1 <= ps2 ?: {ps1 <= ps2}");
            Console.WriteLine($"So sanh ps1 == ps3 ?: {ps1 == ps3}");
            Console.WriteLine($"So sanh ps1 != ps2 ?: {ps1 != ps2}");

            Console.ReadLine();
        }
    }
}
