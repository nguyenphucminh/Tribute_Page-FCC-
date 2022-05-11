using System;

namespace PhuongTrinhBac2
{
    class Program
    {
        static void Main(string[] args)
        {
            PhuongTrinh pt = new PhuongTrinh();
            int Select = 0;

            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Phuong Trinh Bac 2");
                Console.WriteLine("0. Thoat Chuong Trinh");
                Console.WriteLine("--------------------------");
                Console.Write("Chon: ");
                Select = int.Parse(Console.ReadLine());
                switch (Select)
                {
                    case 1:
                        pt.Output();
                        pt.TinhNghiem();
                        break;
                    case 2:
                        // code block
                        break;
                    default:
                        // code block
                        break;
                }
            } while (Select!= 0);
        }
    }
}
