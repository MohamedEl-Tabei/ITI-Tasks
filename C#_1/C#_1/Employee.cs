using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__1
{
    internal class Employee
    {
        
        static int count;
        int Id;
        string Name;
        string Email;
        int Salary;
        static Employee()
        {
            count=0;
        }
        public Employee(string name, string email,int salary)
        {
            Id=count++;
            Name=name;
            Email=email;
            Salary=salary;
        }
        public string getEmployeeData() {
            return $"\n{Id}\t\t\t{Name}\t\t\t{Salary}\t\t\t{Email}";
        
        }
        public int getId() { 
        return Id;
        }

    }
}
