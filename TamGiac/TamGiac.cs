using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamGiac
{
    class TamGiac
    {
        private int a;
        private int b;
        private int c;
        private int CV;
        private string LoaiTG;
        private double DT;


        public double DT1 { get => DT; set => DT = value; }
        public int CV1 { get => CV; set => CV = value; }
        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }
        public string LoaiTG1 { get => LoaiTG; set => LoaiTG = value; }

        public void Nhap()
        {
            do
            {
                Console.Write("Nhap Canh A: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap Canh B: ");      
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap Canh C: ");
                c = Convert.ToInt32(Console.ReadLine());
                if (a + b < c && a + c < b && c + b < a)
                {
                    Console.WriteLine("Khong Phai La Tam Giac, Nhap Lai ");
                }
            }
            while (a + b < c && a + c < b && c + b < a);
        }
        public void Xuat()
        {
            int tmp=TimTamGiac(a,b,c);
            Console.WriteLine("Canh A: {0}",a);
            Console.WriteLine("Canh B: {0}",b);
            Console.WriteLine("Canh C: {0}",c);
            if(tmp == 1)
            {
                Console.WriteLine("Day La Tam giac Deu");
            }    
            else if(tmp==2)
            {
                Console.WriteLine("Day La Tam Giac Vuong Can");
            }    
            else if(tmp==3)
            {
                Console.WriteLine("Day La Tam Giac Can");
            }
            else if(tmp==4)
            {
                Console.WriteLine("Day La Tam Giac Vuong");
            }
            else if(tmp==5)
            {
                Console.WriteLine("Day La Tam Giac Thuong");
            }    
            else
            {
                Console.WriteLine("Day Khong phai Tam Giac");
            }
            Console.WriteLine("Chu Vi Tam Giac: {0}", ChuVi());
            Console.WriteLine("Dien Tich Tam Giac: {0}", DienTich());
        }

        public int ChuVi()
        {
            return a + b + c;
        }
        public double DienTich()
        {
            double p = ChuVi() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public int TimTamGiac(int a, int b, int c)
        {
            int x = a * a;
            int y = b * b;
            int z = c * c;

            if(a+b>c && a+c>b && c+b>a)
            {
                if(a==b || a==c || b==c)
                {
                    if(a==b && a==c)
                    {
                        return 1; //Tam Giac Deu
                    }
                    else
                    {
                        if (x == y + z || y == z + x || z == x + y)
                        {
                            return 2; //Tam Giac Vuong Can
                        }
                        else
                        {
                            return 3; //Tam Giac Can
                        } 
                        
                            
                    } 
                }
                else
                {
                    if(x == y + z || y == z + x || z == x + y)
                    {
                        return 4;//Tam Giac Vuong
                    }
                    else
                    {
                        return 5;//Tam Giac Thuong
                    }    
                }   
            }  
            else
            {
                return 0; //Khong Phai Tam giac
            }
        }
    }

}
