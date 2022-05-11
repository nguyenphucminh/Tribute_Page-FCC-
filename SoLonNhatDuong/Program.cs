using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoLonNhatDuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SoLonNhat sln = new SoLonNhat ();
            int n;
            Console.Write("Nhập n = "); 
            n =sln.NhapMotSo();
            Console.WriteLine("Số lớn nhất trong {0} vừa nhập là {1} ", n, sln.SoMax(n));
            Console.ReadLine();
        }
    }
}
