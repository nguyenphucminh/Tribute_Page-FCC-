using System;

namespace TimKiem
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Nhap so phan tu cua mang");
        string s = Console.ReadLine();
        int x = Int32.Parse(s);
        int[] a = new int[x];
        Console.WriteLine("Nhap gia tri cua cac phan tu :");
        for (int i = 0; i < x; i++)
        {
            string s1 = Console.ReadLine();
            a[i] = Int32.Parse(s1);
        }
        Array.Sort(a); //SAP XEP MANG A
        Console.WriteLine("Mang duoc sap xep : ");
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine("{0}", a[i]);
        }
        Console.WriteLine("Nhap phan tu muon tim : ");
        string s3 = Console.ReadLine(); //NHAP GIA TRI DANG CHUOI//
        int x2 = Int32.Parse(s3); //CHUYEN CHUOI VE DANG SO//
        int x3 = Array.BinarySearch(a, (Object)x2); //TIM KIEM NHI PHAN//
        Console.WriteLine("Vi tri : {0}", x3+1);
        Console.WriteLine("Phan tu thu {0} la {1}", x3+1, a[x3]);
        Console.Read();
        }
    }
}
