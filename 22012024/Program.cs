using System;
using System.Collections.Generic;

public class Giay
{
    public int GiayId { get; set; }
    public string TenGiay { get; set; }
    public string ThuongHieu { get; set; }
    public int Size { get; set; }
    public string MauSac { get; set; }
    public double Gia { get; set; }
    public int TonKho { get; set; }

    public Giay(int giayId, string tenGiay, string thuongHieu, int size, string mauSac, double gia, int tonKho)
    {
        GiayId = giayId;
        TenGiay = tenGiay;
        ThuongHieu = thuongHieu;
        Size = size;
        MauSac = mauSac;
        Gia = gia;
        TonKho = tonKho;
    }
}

public class Program
{
    static List<Giay> DanhSachGiay = new List<Giay>();

    static void Main()
    {
        int luaChon;
        do
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Cua hang ban giay NET101");
            Console.WriteLine("1. Them moi mot doi Giay");
            Console.WriteLine("2. Danh sach Giay");
            Console.WriteLine("3. Mua Giay");
            Console.WriteLine("4. Thoat");
            Console.WriteLine("------------------------");

            luaChon = Convert.ToInt32(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    ThemGiay();
                    break;
                case 2:
                    XemDanhSachGiay();
                    break;
                case 3:
                    MuaGiay();
                    break;
                case 4:
                    Console.WriteLine("Cam on ban da su dung dich vu cua chung toi!");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                    break;
            }
        } while (luaChon != 4);
    }

    static void ThemGiay()
    {
        Console.WriteLine("Nhap thong tin giay:");
        Console.Write("Nhap ID giay: ");
        int giayId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap ten giay: ");
        string tenGiay = Console.ReadLine();
        Console.Write("Nhap thuong hieu: ");
        string thuongHieu = Console.ReadLine();
        Console.Write("Nhap size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap mau sac: ");
        string mauSac = Console.ReadLine();
        Console.Write("Nhap gia: ");
        double gia = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap so luong ton kho: ");
        int tonKho = Convert.ToInt32(Console.ReadLine());

        Giay giay = new Giay(giayId, tenGiay, thuongHieu, size, mauSac, gia, tonKho);
        DanhSachGiay.Add(giay);
    }

    static void XemDanhSachGiay()
    {
        Console.WriteLine("Danh sach giay:");
        foreach (Giay giay in DanhSachGiay)
        {
            Console.WriteLine($"ID: {giay.GiayId}, Ten: {giay.TenGiay}, Thuong hieu: {giay.ThuongHieu}, Size: {giay.Size}, Mau sac: {giay.MauSac}, Gia: {giay.Gia}, Ton kho: {giay.TonKho}");
        }
    }

    static void MuaGiay()
    {
        Console.Write("Nhap ID giay muon mua: ");
        int giayId = Convert.ToInt32(Console.ReadLine());
        Giay giay = DanhSachGiay.Find(g => g.GiayId == giayId);
        if (giay != null)
        {
            Console.Write("Nhap so luong muon mua: ");
            int soLuong = Convert.ToInt32(Console.ReadLine());
            if (soLuong <= giay.TonKho)
            {
                giay.TonKho -= soLuong;
                Console.WriteLine("Mua hang thanh cong!");
            }
            else
            {
                Console.WriteLine("So luong ton kho khong du!");
            }
        }
        else
        {
            Console.WriteLine("Khong tim thay giay!");
        }
    }
}
