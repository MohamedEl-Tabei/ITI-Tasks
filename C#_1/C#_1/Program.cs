using System;
using System.Reflection;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace C__1
{
    internal class Program
    {
        static string[] menu = { "Get Employees","Add Employee","Get Employee By Id" ,"Delet All Employee", "Delet Employee By Id" ,"Exit"};
        static Employee[] employees = new Employee[10];
        static int EmployeeIndex()
        {
            Console.Clear();
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null && employees[i].getId() == id)
                {
                    return i;

                }
            }
            Console.WriteLine("Invalid Id");
            return -1;
        }
        static void Add10() {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == null)
                {
                    employees[i] = new Employee("name", "email", 10);
                }
            }

        }
        static void Main(string[] args)
        {
            //Add10();
            employees[4] = new Employee("Mohamed", "mohamed@gmail.com", 5000);
            ConsoleKeyInfo key;
            int cursor = 0;
            bool flag=true;
            string name;
            string email;
            int salary;
            int index;
            do
            {
                #region menu
                Console.Clear();
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.SetCursorPosition(30, 10 + i);
                    Console.ForegroundColor = (cursor == i) ? ConsoleColor.Green : ConsoleColor.White;
                    Console.WriteLine(menu[i]);
                }
                #endregion
                #region read Key
                key =Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        cursor = cursor > 0 ? cursor - 1 : menu.Length - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        cursor = cursor < menu.Length - 1 ? cursor + 1 : 0;
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        switch (cursor)
                        {
                            #region Get All Employees
                            case 0:
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("Id\t\t\tName\t\t\tSalary\t\t\tEmail");
                                    for (int i = 0; i < employees.Length; i++)
                                    {
                                        if (employees[i] != null)
                                            Console.WriteLine(employees[i].getEmployeeData());
                                    }
                                    key=Console.ReadKey();
                                } while(key.Key != ConsoleKey.Escape);
                                break;
                            #endregion
                            #region Add Employee
                            case 1:
                                do
                                {
                                    index=-1;
                                    Console.Clear();
                                    for (int i = 0; i<employees.Length; i++)
                                    {
                                        if(employees[i] == null)
                                        {
                                            index= i;
                                            break;
                                        }
                                    }
                                    if (index > -1)
                                    {
                                        Console.Write("Name: ");
                                        name = Console.ReadLine();
                                        Console.Write("Email: ");
                                        email = Console.ReadLine();
                                        Console.Write("Salary: ");
                                        salary = int.Parse(Console.ReadLine());
                                        employees[index]=new Employee(name, email, salary);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Array is full.");
                                    }
                                    key = Console.ReadKey();
                                }while(key.Key != ConsoleKey.Escape);
                                break;
                            #endregion
                            #region Get Employee By Id
                            case 2:
                                do
                                {
                                    Console.Clear();
                                    index = EmployeeIndex();

                                    if(index>-1)Console.Write(employees[index].getEmployeeData());
                                    
                                    key = Console.ReadKey();
                                }while(key.Key != ConsoleKey.Escape); 
                                break;
                            #endregion
                            #region Delet All Employee
                            case 3:
                                for (int i = 0; i < employees.Length; i++)
                                {
                                    employees[i] = null;
                                }
                                break;
                            #endregion
                            #region Delet Employee By Id
                            case 4:
                                index= EmployeeIndex();
                                if(index>-1)
                                {
                                    employees[index] = null;
                                }
                                break;
                            #endregion
                            #region Exit
                            case 5:
                                flag = false;
                                break;
                            #endregion
                        }
                        break;

                   case ConsoleKey.Escape:
                        flag = false;
                   break;
                }
                #endregion

            } while (flag);

        }
    }
}
