using NhapNhap;
using System;

namespace Struct_SV
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap So Luong Hoc Sinh: ");
            n = int.Parse(Console.ReadLine());

            SinhVien[] sv = new SinhVien[n];
            for(int i=0; i<n;i++)
            {
                Console.WriteLine("Nhap Thong Tin Sinh Vien Thu {0}: ", (i + 1));
                sv[i] = new SinhVien();
                sv[i].Nhap();
            }
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Danh Xuat Sinh Vien");
                sv[i].Xuat();
            }
        }
    }
}
