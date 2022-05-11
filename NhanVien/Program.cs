using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NhanVien
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<Staff_Accountant> ListAC = new List<Staff_Accountant>();
            List<Staff_IT> ListIT = new List<Staff_IT>();
            int Select=0;
            int i = 1;
            int x = 1;

            static void ShowMenu()
            {
                Console.WriteLine("________________________________");
                Console.WriteLine("1.Add A Staff Accountant        |");
                Console.WriteLine("2.Add A Staff IT                |");
                Console.WriteLine("3.Show Staff Accountants        |");
                Console.WriteLine("4.Show Staff IT                 |");
                Console.WriteLine("5.Sort Increase List IT(Name)   |");
                Console.WriteLine("6.Remove An Object IT(Name)     |");
                Console.WriteLine("7.Rename An Object IT(Name)     |");
                Console.WriteLine("8.Find Objects In List IT(Name) |");
                Console.WriteLine("9.Worked Day Max                |");
                Console.WriteLine("10.Exit Program                 |");
                Console.WriteLine("________________________________|");
            }

            do
            {
                ShowMenu();
                Console.Write("Select Funtion: ");
                Select =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                int j = 1;
                int y = 1;
                switch(Select)
                {
                    case 1:
                        {
                            Staff_Accountant SA = new Staff_Accountant();
                            Console.WriteLine("Enter Employee Accountant [{0}]",i);
                            SA.Input();
                            ListAC.Add(SA);
                            i++;
                            break;
                        }
                    case 2:
                        {
                            Staff_IT SIT = new Staff_IT();
                            Console.WriteLine("Enter Employee IT [{0}]", x);
                            SIT.Input();
                            ListIT.Add(SIT);
                            x++;
                            break;
                        }
                    case 3:
                        {
                            foreach(Staff_Accountant SA in ListAC)
                            {
                                Console.WriteLine("Employee Accountant [{0}] ",j);
                                SA.Output();
                                j++;
                            }    
                            break;
                        }
                    case 4:
                        {
                                foreach (Staff_IT SIT in ListIT)
                            {
                                Console.WriteLine("Employee IT [{0}] ", y);
                                SIT.Output();
                                y++;
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Sort Increase");
                            ListIT.Sort((x, y) => x.Name1.CompareTo(y.Name1));
                            //if u wanna get method Decrease Sort
                            //let's swap x and y on the right-hand side of the arrow =>.
                            foreach (Staff_IT SIT in ListIT)
                            {
                                Console.WriteLine("Employee IT [{0}]", y);
                                SIT.Output();
                                y++;
                            }
                            break;
                        }
                    case 6:
                        {
                            string IDRemove;
                            Console.Write("Enter ID Object Remove: ");
                            IDRemove = Console.ReadLine();
                            ListIT.RemoveAll(y => y.ID1 == IDRemove);
                            foreach (Staff_IT SIT in ListIT)
                            {
                                Console.WriteLine("Employee IT [{0}]", y);
                                SIT.Output();
                                y++;
                            }
                            x--;
                            break;
                        }
                    case 7:
                        {

                            string NameNew, NameOld ;
                            Console.Write("Enter Old Name: ");
                            NameOld = Console.ReadLine();
                            Console.Write("Enter New Name: ");
                            NameNew = Console.ReadLine();

                            var found = ListIT.FirstOrDefault(c => c.Name1 ==NameOld);
                            found.Name1 =NameNew;

                            foreach (Staff_IT SIT in ListIT)
                            {
                                Console.WriteLine("Employee IT [{0}]", y);
                                SIT.Output();
                                y++;
                            }
                            break;
                        }
                    case 8:
                        {
                            string NameFind;
                            Console.WriteLine("Enter Name To List: ");
                            NameFind = Console.ReadLine();

                            var index = ListIT.Find(item => item.Name1 == NameFind);
                            if (index == null)
                            {
                                Console.WriteLine("Not Name In List");
                                break;
                            }
                            else
                            {
                                var allDuplicates = ListIT.GroupBy(o => o.Name1).Where(g => g.Count() >= 1);
                                var dict = allDuplicates.ToDictionary(g => g.Key, g => g.ToList());
                                foreach (var o in dict[NameFind])
                                {
                                    Console.WriteLine("Employee IT [{0}]", y);
                                    o.Output();
                                    y++;
                                }
                                break;
                            }
                        }
                        
                    case 9:
                        {
                            int Day;
                            Console.Write("Enter The Number Of Day Max: ");
                            Day =Convert.ToInt32(Console.ReadLine());
                            var index = ListIT.GroupBy(item => item.Working_Day1).Where(g => g.Count() >= 1);
                            var dict = index.ToDictionary(g => g.Key, g => g.ToList());
                            foreach (var o in dict[Day])
                            {
                                Console.WriteLine("Employee IT [{0}]", y);
                                item.Output();
                                y++;
                            }
                            break;


                            break;
                        }

                    case 10:
                        {
                            Console.WriteLine("Task Completed");
                            Console.WriteLine("=======================");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter Error, Enterback");
                            break;
                        }
                }    

            } while(Select != 10);


        }
    }
}
