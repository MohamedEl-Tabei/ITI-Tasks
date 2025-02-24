using System.Text.RegularExpressions;

namespace struct_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees=new Employee[3];
            bool isError=false;
            for (int i = 0; i < employees.Length; i++) {
                #region name
                string name="";
                do {
                    //Regex.Match(name,Reg)
                    //String.IsNullOrEmpty(name)
                    //String.IsNullOrWhiteSpace(name)
                    try
                    {
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        isError = false;
                    }
                    catch {
                        isError = true;
                    }

                } while (isError);
                employees[i].setName(name);

                #endregion

                #region salary
                decimal salary = 0;
                do
                {
                    try
                    {
                        Console.Write("Salary: ");
                        salary = decimal.Parse(Console.ReadLine());
                        employees[i].setSalary(salary);
                        isError = false;
                    }
                    catch
                    {
                        isError = true;
                    }

                } while (isError);
                #endregion

                #region Security Level
                string str = "";
                do
                {
                    try
                    {
                        Console.Write("Security Level [1-guest, 2-Developer, 3-secretary, 4-DBA]: ");
                        str= Console.ReadLine();
                        SecurityLevel s = str == "1" ? SecurityLevel.guest : str == "2" ? SecurityLevel.Developer : str == "3" ? SecurityLevel.secretary : SecurityLevel.DBA;
                        employees[i].setSecurityLevel(s);
                        isError = false;
                        int num=int.Parse(str);
                        if(num<1||num>4) isError = true;
                    }
                    catch
                    {
                        isError = true;
                    }

                } while (isError);
                #endregion

                #region Gender
                str = "";
                do
                {
                    try
                    {
                        Console.Write("Gender [M,F]: ");
                        str = Console.ReadLine();
                        Gender g = str == "M" ? Gender.M : Gender.F;
                        employees[i].setGender(g);
                        isError = false;
                        if(str!="M"&&str!="F") isError = true;
                    }
                    catch
                    {
                        isError = true;
                    }

                } while (isError);
                #endregion

                #region Hire Date
                str = "";
                int day = 0;
                int month = 0;
                int year = 0;
                Console.WriteLine("Hire Date ");
                do
                {
                    try
                    {
                        Console.Write("day: ");
                        day = int.Parse(Console.ReadLine());
                        if(day<1||day>30)isError = true;
                        else isError = false;
                    }
                    catch
                    {
                        isError = true;
                    }
                    

                } while (isError);
                do
                {
                    try
                    {
                        Console.Write("month: ");
                        month = int.Parse(Console.ReadLine());
                        if (month < 1 || month > 12) isError = true;
                        else isError = false;
                    }
                    catch
                    {
                        isError = true;
                    }
                } while (isError);
                do
                {
                    Console.Write("year: ");
                    year = int.Parse(Console.ReadLine());
                   
                    if (year < 2000 || year > 2025) isError = true;
                    else isError = false;
                } while (isError);
                HireDate hd = new HireDate(day, month, year);
                employees[i].setHireDate(hd);
                #endregion


            }
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
