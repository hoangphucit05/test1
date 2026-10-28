
using System;

Console.Write("Nhap ho ten day du: ");
string hoTen = Console.ReadLine() ?? "";

Console.WriteLine("\nDo dai chuoi: " + hoTen.Length);

Console.WriteLine("Chuoi chu HOA: " + hoTen.ToUpper());

Console.WriteLine("Chuoi chu thuong: " + hoTen.ToLower());

string chuoiTrim = hoTen.Trim();
Console.WriteLine("Chuoi sau khi Trim: " + chuoiTrim);

bool coNguyen = chuoiTrim.Contains("Nguyễn");
Console.WriteLine("Co chua tu Nguyen: " + coNguyen);

string[] cacTu = chuoiTrim.Split(
    ' ',
    StringSplitOptions.RemoveEmptyEntries
);

Console.WriteLine("\nCac tu sau khi tach:");
foreach (string tu in cacTu)
{
    Console.WriteLine(tu);
}

string chuoiGhep = String.Join("-", cacTu);
Console.WriteLine("\nChuoi sau khi ghep: " + chuoiGhep);
