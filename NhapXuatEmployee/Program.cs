using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NhapXuatEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> LIST = new List<Employee>();
            int n = 0;
            static void ShowMenu()
            {
                Console.WriteLine("1.Input Employee: ");
                Console.WriteLine("2.Output_Employee: ");
                Console.WriteLine("3.Exit_Program: ");
                Console.WriteLine("---------------------------------------------");
            }

            do
            {
                ShowMenu();
                Console.Write("Select Funtion: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                int i = 1;
                switch (n)
                {
                    case 1:
                        {
                            Employee NV = new Employee();
                            Console.WriteLine("Enter Employee [{0}] ", i);
                            NV.Input();
                            LIST.Add(NV);
                            i++;
                            Console.WriteLine("=============================================");
                            break;
                        }
                    case 2:
                        {
                            int j = 1;
                            foreach (Employee NV in LIST)
                            {
                                Console.WriteLine("Employee [{0}] ", j);
                                NV.Output();
                                j++;
                            }
                            Console.WriteLine("=============================================");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Task Completed");
                            Console.WriteLine("=============================================");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter Error, Enterback");
                            break;
                        }
                }
            } while (n != 3);

        }
    }
}
