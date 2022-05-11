using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    class Staff_Accountant:Staff_Main
    {
        private int Basic_Salary;
        private string Position;
        private int Working_Day;
        private float Bonus = 200;

        public Staff_Accountant()
        {
            Basic_Salary = 1000;
            Position = "null";
            Working_Day = 0;
            Bonus = 200;
        }
        public Staff_Accountant(string Name, string ID, int Age, string Sex, int Working_Day, int Basic_Salary, string Position, float Bonus)
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
            if (this.Working_Day>=30)
            {
                Tien = (this.Basic_Salary * this.Working_Day) + this.Bonus * 2;
            }
            else
            {
                Tien = (this.Basic_Salary * this.Working_Day) + this.Bonus * 0.5;
            }    
            return Tien;
        }
        
        public void WorkedDayMax(int Working_Day)
        {
  
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("Positon: "+ Position);
            Console.WriteLine("Salary: " + Salary(Working_Day));
            Console.WriteLine();
        }
     

    }

}
