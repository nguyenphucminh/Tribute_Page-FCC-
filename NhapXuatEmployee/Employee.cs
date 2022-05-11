using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapXuatEmployee
{
    class Employee
    {
        private string Name;
        private int ID;
        private int YOB;
        private double Salary_Level;
        private double Salary_Basic;

        public Employee()
        {
            this.Name = "null";
            this.ID = 0;
            this.YOB = 0;
            this.Salary_Level = 0;
            this.Salary_Basic = 1000;
        }

        public string Name1 { get => Name; set => Name = value; }
        public int ID1 { get => ID; set => ID = value; }
        public int YOB1 { get => YOB; set => YOB = value; }
        public double Salary_Level1 { get => Salary_Level; set => Salary_Level = value; }
        public double Salary_Basic1 { get => Salary_Basic; set => Salary_Basic = value; }

        public double GetInCome()
        {
            return  Salary_Basic *Salary_Level1 ;
        }

        public void Input()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter ID: ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Age: ");
            YOB =Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Level Salary (1-6): ");
            do
            {
                Salary_Level = Convert.ToDouble(Console.ReadLine());
                if (Salary_Level > 6 || Salary_Level < 1)
                {
                    Console.Write("Enter Level Salary Again: ");
                }
            } while (Salary_Level > 6 || Salary_Level < 1);
        }
        public void Output()
        {
            Console.WriteLine("Name: {0}",Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", YOB);
            Console.WriteLine("Level Salary: {0}", Salary_Level);
            Console.WriteLine("Total Salary: {0}", GetInCome());
            Console.WriteLine();
        }
    }
}
