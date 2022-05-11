using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            PhuongThuc mang = new PhuongThuc();
            int n;
            n = mang.NhapDuong();
            int[] a = new int[n];

            Console.WriteLine("Nhap Mang");
            mang.NhapMang(a);
            Console.WriteLine("Xuat Mang");
            mang.XuatMang(a);

            Console.WriteLine("Mang Dao Chieu");
            Array.Reverse(a);
            mang.XuatMang(a);

            Console.WriteLine("Tong Cac Phan Tu Trong Mang");
            Console.WriteLine("Sum = {0}", mang.TongPhanTu(a));

            Console.WriteLine("So Lon Nhat Trong Mang");
            Console.WriteLine("Max = {0}", mang.Max(a));

            Console.WriteLine("So Nho Nhat Trong Mang");
            Console.WriteLine("Max = {0}", mang.MinMang(a));

            Console.WriteLine("Sap Xep Mang Tang Dan");
            Array.Sort<int>(a, new Comparison<int>((i1, i2) => i1.CompareTo(i2)));
            mang.XuatMang(a);

            Console.WriteLine("Sap Xep Mang Giam Dan");
            Array.Sort<int>(a, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
            mang.XuatMang(a);


        }
    }
}
