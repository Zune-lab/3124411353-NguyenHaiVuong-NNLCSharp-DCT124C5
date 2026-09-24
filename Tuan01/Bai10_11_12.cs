using System;

class XuLyChuoi
{
    // Bai 10: kiem tra chuoi doi xung
    public bool KiemTraDoiXung(string s)
    {
        string dao = DaoChuoi(s);
        if (s == dao)
            return true;
        else
            return false;
    }

    // Bai 11: dao nguoc chuoi
    public string DaoChuoi(string s)
    {
        string ketQua = "";
        for (int i = s.Length - 1; i >= 0; i--)
        {
            ketQua = ketQua + s[i];
        }
        return ketQua;
    }

    // Bai 12: chuyen chuoi thanh chu thuong / chu hoa, dem so tu
    public string ChuyenChuThuong(string s)
    {
        return s.ToLower();
    }

    public string ChuyenChuHoa(string s)
    {
        return s.ToUpper();
    }

    public int DemSoTu(string s)
    {
        string[] mangTu = s.Split(' ');
        int dem = 0;
        for (int i = 0; i < mangTu.Length; i++)
        {
            if (mangTu[i] != "")
                dem++;
        }
        return dem;
    }
}

class Bai10_11_12
{
    static void Main()
    {
        XuLyChuoi xl = new XuLyChuoi();

        Console.Write("Nhap mot chuoi: ");
        string s = Console.ReadLine();

        Console.WriteLine("Bai 10: kiem tra doi xung ");
        if (xl.KiemTraDoiXung(s))
            Console.WriteLine("Chuoi doi xung");
        else
            Console.WriteLine("Chuoi khong doi xung");

        Console.WriteLine(" Bai 11: dao chuoi ");
        Console.WriteLine("Chuoi dao: " + xl.DaoChuoi(s));

        Console.WriteLine(" Bai 12: chu hoa/thuong, dem tu ");
        Console.WriteLine("Chu thuong: " + xl.ChuyenChuThuong(s));
        Console.WriteLine("Chu hoa: " + xl.ChuyenChuHoa(s));
        Console.WriteLine("So tu trong chuoi: " + xl.DemSoTu(s));
    }
}
