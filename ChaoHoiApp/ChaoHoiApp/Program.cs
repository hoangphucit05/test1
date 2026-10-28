
using System;

class Program
{
    static void Main(string[] args)
    {
        string hoTen;
        int tuoi;
        double chieuCao;
        float canNang;
        bool daTotNghiep;

        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine() ?? "";

        Console.Write("Nhap tuoi: ");
        tuoi = int.Parse(Console.ReadLine()!);

        Console.Write("Nhap chieu cao (m): ");
        chieuCao = double.Parse(Console.ReadLine()!);

        Console.Write("Nhap can nang (kg): ");
        canNang = float.Parse(Console.ReadLine()!);

        Console.Write("Da tot nghiep (true/false): ");
        daTotNghiep = bool.Parse(Console.ReadLine()!);

        Console.WriteLine("\nTHONG TIN CA NHAN");
        Console.WriteLine("Họ tên: " + hoTen);
        Console.WriteLine("Tuổi: " + tuoi);
        Console.WriteLine("Chiều cao: " + chieuCao + " m");
        Console.WriteLine("Cân nặng: " + canNang + " kg");
        Console.WriteLine("Đã tốt nghiệp: " + daTotNghiep);
    }
}
