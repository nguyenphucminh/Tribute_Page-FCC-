using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapNhap
{
    class SinhVien
    {
        //propfull + tab*2 =
        private string HoTen;
        private int NamSinh;
        private double Toan;
        private double Van;
        private double DTB;
        
        public SinhVien()
        {
            HoTen = "";
            NamSinh = 0;    
            Van = 0;
            Toan = 0;
            DTB = 0;
        }

        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public int NamSinh1 { get => NamSinh; set => NamSinh = value; }
        public double Toan1 { get => Toan; set => Toan = value; }
        public double Van1 { get => Van; set => Van = value; }
        public double DTB1 { get => DTB; set => DTB = value; }


        public void Nhap()
        {
            //Name
            Console.Write("Nhap Ho Ten: ");
            HoTen = Console.ReadLine();
            //Age
            Console.Write("Nhap Nam Sinh: ");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            //Toan
            do
            {
                Console.Write("Nhap Diem Toan: ");
                Toan = Convert.ToDouble(Console.ReadLine());

            } while (Toan > 10 || Toan < 0);

            //Van
            do
            {
                Console.Write("Nhap Diem Van: ");
                Van = Convert.ToDouble(Console.ReadLine());
            } while (Van > 10 || Van < 0);
   
        }
        public double DiemTrungBinh()
        {
            return DTB = Math.Round(((Van + Toan) / 2),2);
        }
        public void Xuat()
        {
            Console.WriteLine("Ho Ten: {0}", HoTen);
            Console.WriteLine("Nam Sinh: {0}", NamSinh);
            Console.WriteLine("Diem Toan: {0}", Toan);
            Console.WriteLine("Diem Van: {0}", Van);
            Console.WriteLine("DTB: {0}", DiemTrungBinh());    
        }


    }
}
