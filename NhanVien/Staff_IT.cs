using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    class Staff_IT : Staff_Main
    {
        private int Basic_Salary;
        private string Position;
        private int Working_Day;
        private float Bonus = 200;

        public int Basic_Salary1 { get => Basic_Salary; set => Basic_Salary = value; }
        public string Position1 { get => Position; set => Position = value; }
        public int Working_Day1 { get => Working_Day; set => Working_Day = value; }

        public Staff_IT()
        {
            Basic_Salary = 1000;
            Position = "null";
            Working_Day = 0;
            Bonus = 200;
        }
        public Staff_IT(string Name, string ID, int Age, string Sex, int Working_Day, int Basic_Salary, string Position, float Bonus)
        : base(Name, ID, Age, Sex)
        {
            this.Basic_Salary = Basic_Salary;
            this.Working_Day = Working_Day;
            this.Bonus = Bonus;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Enter Position: ");
            Position = Console.ReadLine();
            Console.Write("Enter Worked Day: ");
            do
            {
                this.Working_Day = Convert.ToInt32(Console.ReadLine());
                if (this.Working_Day <= 0 || this.Working_Day >= 32)
                {
                    Console.Write("Enter Worked Day Again: ");
                }
                else break;
            } while (true);
            Console.WriteLine();
        }
        public double Salary(int Working_Day)
        {
            double Tien;
            if (this.Working_Day == 30)
            {
                Tien = (this.Basic_Salary * this.Working_Day) + this.Bonus * 2;
            }
            else
            {
                Tien = (this.Basic_Salary * this.Working_Day) + this.Bonus * 0.5;
            }
            return Tien;
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("Positon: " + Position);
            Console.WriteLine("Worked Day: "+Working_Day);
            Console.WriteLine("Salary: " + Salary(Working_Day));
            Console.WriteLine();
        }

    }

}
