
using System;

namespace QuanLySachCoBan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cach 1: Constructor day du
            Sach sach1 = new Sach(
                "S001", "Lap trinh C#",
                "Nguyen Van A", 2023, 150000);

            // Cach 2: Constructor mac dinh
            Sach sach2 = new Sach();
            sach2.TenSach = "Co so du lieu";
            sach2.TacGia = "Tran Van B";
            sach2.NamXuatBan = 2022;

            // Cach 3: Object Initializer
            Sach sach3 = new Sach
            {
                TenSach = "Cau truc du lieu",
                TacGia = "Le Van C",
                NamXuatBan = 2024
            };

            Console.WriteLine("DANH SACH SACH");

            sach1.HienThiThongTin();
            sach2.HienThiThongTin();
            sach3.HienThiThongTin();

            Console.WriteLine("\nTHONG TIN TOM TAT:");
            Console.WriteLine(sach1.ToString());

            Console.WriteLine("\nKIEM TRA NAM XUAT BAN:");

            try
            {
                sach1.NamXuatBan = 1800;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
        }
    }
}
