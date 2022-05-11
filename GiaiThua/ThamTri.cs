using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiThua
{
    class ThamTri
    {
        public int NhapMotSo()
        {
            int so;
            do
            {
                so = Convert.ToInt32(Console.ReadLine());
            }
            while (so < 0);
            return so;
        }
        public long GiaiThua (int x)
        {
            long gt = 1;
            for (int i=1;i<=x;i++)
            {
                gt = gt * i;
            }
            return gt;
        }
    }
}
