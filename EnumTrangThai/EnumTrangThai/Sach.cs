
using System;

namespace QuanLySachCoBan
{
    public class Sach
    {
        private string _maSach;
        private string _tenSach;
        private string _tacGia;
        private int _namXuatBan;
        private double _giaBan;

        public Sach(string maSach, string tenSach,
                    string tacGia, int namXuatBan,
                    double giaBan)
        {
            _maSach = maSach;
            TenSach = tenSach;
            _tacGia = tacGia;
            NamXuatBan = namXuatBan;
            _giaBan = giaBan;
        }

        public Sach()
        {
            _maSach = "S000";
            _tenSach = "Chua co ten";
            _tacGia = "Chua ro";
            _namXuatBan = DateTime.Now.Year;
            _giaBan = 0;
        }

        public string MaSach
        {
            get { return _maSach; }
        }

        public string TenSach
        {
            get { return _tenSach; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(
                        "Ten sach khong duoc rong!");

                _tenSach = value;
            }
        }

        public string TacGia
        {
            get { return _tacGia; }
            set { _tacGia = value; }
        }

        public int NamXuatBan
        {
            get { return _namXuatBan; }
            set
            {
                if (value < 1900 ||
                    value > DateTime.Now.Year)
                    throw new ArgumentOutOfRangeException(
                        nameof(NamXuatBan),
                        "Nam xuat ban khong hop le!");

                _namXuatBan = value;
            }
        }

        public double GiaBan
        {
            get { return _giaBan; }
        }

        public void HienThiThongTin()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Ma sach: " + MaSach);
            Console.WriteLine("Ten sach: " + TenSach);
            Console.WriteLine("Tac gia: " + TacGia);
            Console.WriteLine("Nam xuat ban: " + NamXuatBan);
            Console.WriteLine("Gia ban: " + GiaBan + " VND");
            Console.WriteLine("---------------------------");
        }

        public override string ToString()
        {
            return $"{MaSach} - {TenSach} - {TacGia} - {NamXuatBan}";
        }
    }
}
