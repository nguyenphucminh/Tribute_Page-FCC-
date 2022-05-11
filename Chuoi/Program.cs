using System;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cac cach tao chuoi trong C#");
            Console.WriteLine("-------------------------------------");

            //su dung phep gan hang chuoi va toan tu noi chuoi
            string fname, lname;
            fname = "Nguyen Phuc";
            lname = "Minh";

            string fullname = fname + " " + lname;
            Console.WriteLine("Ho va ten: {0}", fullname);

            //su dung constructor cua lop string
            char[] kitu = { 'H', 'e', 'l', 'l', 'o' };
            string chuoidai = new string(kitu);
            Console.WriteLine("\nLoi chao bang tieng Anh: {0}", chuoidai);

            //tu cac phuong thuc ma tra ve mot chuoi
            string[] sarray = { "Phuc Minh", "xin", "chao", "cac", "ban" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("\nThong diep: {0}", message);

            Console.WriteLine();
            //Nhập Chuỗi:
            Console.Write("Nhap Ho Ten:");
            String x = Console.ReadLine();
            Console.WriteLine("Ho Ten: " + x);

            //Chuỗi Thường:
            x = x.ToLower();
            Console.WriteLine("Chu Thuong: " + x);

            //Chuỗi Hoa
            x = x.ToUpper();
            Console.WriteLine("Chu Hoa:" + x);

            //Lấy Khoảng Kí Tự
            //VD: x = ABCDEF->x = ABCD    NOTE: (0, 1): A
            x = x.Substring(0, 1);
            Console.WriteLine("Khoang Ki Tu: " + x);

            //Lấy Từ Đầu Tiên Trong Chuỗi
            //VD: X = anh yeu em -> anh
            Console.Write("Nhap Chuoi:");
            string a = Console.ReadLine();
            int first = a.IndexOf(' ');
            string y = a.Substring(0, first);
            Console.WriteLine("Tu Dau Tien: " + y);

            //Lấy Từ Cuối Cùng
            //VD: X = anh yeu em -> em
            Console.Write("Nhap Chuoi:");
            string b = Console.ReadLine();
            int last = b.LastIndexOf(' ');
            string z = b.Substring(last + 1);
            Console.WriteLine("Tu Cuoi Cung: " + z);

            //Thay Thế Chuỗi
            //VD: anh yeu em->ghet->anh ghet em
            Console.Write("Nhap Chuoi: ");
            string c = Console.ReadLine();
            Console.Write("Nhap Tu Cu: ");
            string tucu = Console.ReadLine();
            Console.Write("Nhap Tu Moi: ");
            string tumoi = Console.ReadLine();
            c = c.Replace(tucu, tumoi); //NOTE: x = x.Replace("yeu", "ghet").Replace("anh", "String.Empty").Replace....Console.WriteLine("Chuoi Moi: " + x);
            Console.WriteLine("Ta Co: " + c);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
