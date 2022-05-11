using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Class_SinhVien
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> List = new List<Student>();
            int n = 0;
            static void ShowMenu()
            {
                Console.WriteLine("1.Input_Student: ");
                Console.WriteLine("2.Output_Student: ");
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
                            Student stu = new Student();
                            Console.WriteLine("Enter Student [{0}] ",i);
                            stu.Input();
                            List.Add(stu);
                            i++;
                            Console.WriteLine("=============================================");
                            break;
                        }
                    case 2:
                        {
                            int j = 1;
                            foreach(Student stu in List)
                            {
                                Console.WriteLine("Student [{0}] " ,j);
                                stu.Output();
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
        class Student
        {
            string Name;
            string ID;
            string Sex;
            int Year_OB;
            double Mark_Math;
            double Mark_Literature;
            double Mark_English;
            double Mark_Average;
            
            public Student()
            {
                Name = "null";
                ID = "null";
                Sex = "null";
                Year_OB = 0;
                Mark_Math = 0;
                Mark_Literature = 0;
                Mark_English = 0;
                Mark_Average = 0;
            }
            public void Input()
            {
                Console.Write("Enter Name: ");
                Name = Console.ReadLine();
                Console.Write("Enter ID:");
                ID = Console.ReadLine();
                Console.Write("Enter Year Of Birth: ");
                Year_OB = Convert.ToInt32(Console.ReadLine());
                //SEX
                Console.Write("Enter Sex: ");
                while (true) 
                {
                    Sex = Console.ReadLine();
                    if (string.Equals(Sex, "Male", StringComparison.OrdinalIgnoreCase)
                    ||  string.Equals(Sex, "Female", StringComparison.OrdinalIgnoreCase)
                    ||  string.Equals(Sex, "male", StringComparison.OrdinalIgnoreCase)
                    ||  string.Equals(Sex, "female", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    Console.Write("Enter Sex Again: ");
                }
                //Mark_Math
                Console.Write("Enter Math Score: ");
                do
                {
                    Mark_Math = Convert.ToDouble(Console.ReadLine());
                    if(Mark_Math > 10 || Mark_Math < 0)
                    {
                        Console.Write("Enter Math Score Again: ");
                    }    
                } while (Mark_Math > 10 || Mark_Math < 0);
                //Mark_Literature
                Console.Write("Enter Literature Score: ");
                do
                {
                    Mark_Literature = Convert.ToDouble(Console.ReadLine());
                    if (Mark_Literature > 10 || Mark_Literature < 0)
                    {
                        Console.Write("Enter Literature Score Again: ");
                    }
                } while (Mark_Literature > 10 || Mark_Literature < 0);
                //Mark_English
                Console.Write("Enter English Score: ");
                do
                {
                    Mark_English = Convert.ToDouble(Console.ReadLine());
                    if (Mark_English > 10 || Mark_English < 0)
                    {
                        Console.Write("Enter English Score Again: ");
                    }
                } while (Mark_English > 10 || Mark_English < 0);
            }
            public double AVG()
            {
                return Mark_Average = Math.Round(((Mark_Math + Mark_Literature + Mark_English) / 3),2);
            }

            public void Output()
            {
                Console.WriteLine("Name: {0}",Name);
                Console.WriteLine("ID: {0}", ID);
                Console.WriteLine("Sex: {0}", Sex);
                Console.WriteLine("Year Of Birth: {0}", Year_OB);
                Console.WriteLine("Math Score: {0}", Mark_Math);
                Console.WriteLine("Literature Score: {0}", Mark_Literature);
                Console.WriteLine("English Score: {0}", Mark_English);
                Console.WriteLine("Average Score: {0}", AVG());
                Console.WriteLine();
            }
        }

        
    }
}
