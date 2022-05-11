using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    class Staff_Main
    {
        private string Name;
        private string ID;
        private string Sex;
        private int Age;
        private double Salary;

        public Staff_Main()
        {
            Name = "null";
            ID = "null";
            Age = 0;
            Sex = "null";
            Salary = 0;
        }
        public Staff_Main(string Name, string ID, int Age, string Sex)
        {
            this.Name = Name;
            this.ID = ID;
            this.Age =Age;
            this.Sex = Sex;
        }
        public string Name1 { get => Name; set => Name = value; }
        public string ID1 { get => ID; set => ID = value; }
        public int Age1 { get => Age; set => Age = value; }
        public double Salary1 { get => Salary; set => Salary = value; }
        public string Sex1 { get => Sex; set => Sex = value; }

        public virtual void Input()
        {
            Console.Write("Enter Employee Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Employee ID: ");
            ID = Console.ReadLine();
            Console.Write("Enter Age: ");
            Age =Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Sex: ");
            while (true)
            {
                Sex = Console.ReadLine();
                if (string.Equals(Sex, "Male", StringComparison.OrdinalIgnoreCase)
                || string.Equals(Sex, "Female", StringComparison.OrdinalIgnoreCase)
                || string.Equals(Sex, "male", StringComparison.OrdinalIgnoreCase)
                || string.Equals(Sex, "female", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                Console.Write("Enter Sex Again: ");
            }
        }
        public virtual void Output()
        {
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("ID: "+ID);
            Console.WriteLine("Age: "+Age);
            Console.WriteLine("Sex: "+Sex);
        }
    }
    
}
