using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class PhuongThuc
    {
        public int NhapSo()
        {
            int so;
            so = Convert.ToInt32(Console.ReadLine());
            return so;
        }

        public int NhapDuong()
        {
            int so;
            do
            {
                Console.Write("Nhap so phan tu: ");
                so = Convert.ToInt32(Console.ReadLine());

            }
            while (so <= 0);
            return so;
        }

        public void NhapMang(int[] a)
        {
            for(int i=0; i < a.Length; i++)
            {
                Console.Write("a[{0}]: ", i+1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void XuatMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a[{0}]: {1}", i+1, a[i]);
            }
        }
        
        public int TongPhanTu(int[] a )
        {
            int tong=0;
            for(int i=0; i<a.Length;i++)
            {
                tong += a[i];
            }
            return tong;
        }
        public int MaxMang(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (max < a[i]) max = a[i];
            }
            return max;
        }
        public int MinMang(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (min > a[i]) min = a[i];
            }
            return min;
        }
        //MaxCoSan
        public int Max(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                max = Math.Max(max, a[i]);
            }
            return max;
        }
    }
}
