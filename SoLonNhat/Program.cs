using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SoLonNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;//hiển thị ký tự tiếng việt có dấu
            //phải gọi thư viện : using System.Text; thì mới dùng đc Console.OutputEncoding = Encoding.UTF8;
            TimSoLonNhat MAX = new TimSoLonNhat();
            int a, b, c, max;
            Console.Write("Nhap a: ");
            a = MAX.NhapMotSo();
            Console.Write("Nhap b: ");
            b = MAX.NhapMotSo();
            Console.Write("Nhap c: ");
            c = MAX.NhapMotSo();
            max = MAX.TimMax(a, b, c);
            Console.WriteLine("So Lon Nhat trong 3 so {0}, {1} va {2} la {3} ", a, b, c, max);
            Console.ReadLine();
        }
    }
}
