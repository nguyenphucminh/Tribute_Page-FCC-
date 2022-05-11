using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac2
{
    class PhuongTrinh
    {
        private int A;
        private int B;
        private int C;
        private float Del;

        public PhuongTrinh()
        {
            A = 0;
            B = 0;
            C = 0;
        }
        public PhuongTrinh(int a, int b, int c)
        {
            a = A;
            b = B;
            c = C;
        }

        public int A1 { get => A; set => A = value; }
        public int B1 { get => B; set => B = value; }
        public int C1 { get => C; set => C = value; }
        public float Del1 { get => Del; set => Del = value; }

        public void Output()
        {
            Console.Write("Nhap A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Nhap B: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Nhap C: ");
            C = int.Parse(Console.ReadLine());
        }

        public void TinhNghiem()
        {
            double x1, x2;
            double Del = B*B - 4*A*C;
            if (Del <=0)
            {
                Console.WriteLine(" Phuong Trinh Vo Nghiem");
            } 
            else if(Del==0)
            {
                x1 = x2 = -B / (2 * A);
                Console.WriteLine("Phuong trinh da cho co nghiem kep X= {0}",x1);
            }
            else
            {
                Del = Math.Sqrt(Del);
                x1 = ((B * (-1) + Del)) / (2 * A);
                x2 = ((B * (-1) - Del)) / (2 * A);
                Console.WriteLine("Nghiem Cua Phuong Trinh:");
                Console.WriteLine("X1= {0}", x1);
                Console.WriteLine("X2= {0}", x2);
            }
        }

    }
}

