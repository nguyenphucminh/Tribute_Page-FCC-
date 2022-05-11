using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GiaiThua
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            ThamTri giaithua = new ThamTri();
            Console.Write("Nhap n: ");
            n = giaithua.NhapMotSo();
            Console.WriteLine("Giai thua cua so {0}: {1} ", n, giaithua.GiaiThua(n));
            Console.ReadLine();
            
        }
    }
}
