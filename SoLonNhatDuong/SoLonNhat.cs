using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoLonNhatDuong
{
    class SoLonNhat
    {
        public int NhapMotSo()
        {
            int so;
            so = Convert.ToInt32(Console.ReadLine());
            return so;
        }
       public int SoMax(int n)
        {
            int x;
            int max = 0;
            int i = 0;
            do
            {
                Console.Write("Nhap so thu {0}: ", i + 1);
                x = Convert.ToInt32(Console.ReadLine());
                if (max < x)
                {
                    max = x;
                }
                i++;
            }
            while (i <= n);
            return max;
        }
    }
}
