using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace C__9_LINQ
{
    internal static class Repository
    {
        public static List<Employee> Employees { get;  } = new List<Employee>() {
            new Employee { Id = 1,  FirstName = "Ali",  LastName = "Ahmed", Age = 25, Salary = 1234, DepId = 1 },
            new Employee { Id = 2,  FirstName = "Ali", LastName = "Mohamed",  Age = 25, Salary = 2234, DepId = 2 },
            new Employee { Id = 3,  FirstName = "Ahmed", LastName = "Mohamed",  Age = 46, Salary = 3234, DepId = 3 },
            new Employee { Id = 4,  FirstName = "Sara", LastName = "Mohamed",  Age = 18, Salary = 4234, DepId = 4 },
            new Employee { Id = 5,  FirstName = "Mai", LastName = "Mohamed",  Age = 30, Salary = 5234, DepId = 1 },
            new Employee { Id = 6,  FirstName = "Alaa", LastName = "Mohamed",  Age = 20, Salary = 6234, DepId = 2 },
            new Employee { Id = 7,  FirstName = "Basem",  LastName = "Mohamed", Age = 16, Salary = 7234, DepId = 3 },
            new Employee { Id = 8,  FirstName = "Omar", LastName = "Mohamed",  Age = 32, Salary = 8234, DepId = 4 },
            new Employee { Id = 9,  FirstName = "Amr", LastName = "Mohamed",  Age = 32, Salary = 9234, DepId = 1 },
            new Employee { Id = 10, FirstName= "Alaa",  LastName = "Mohamed", Age = 38, Salary = 10234, DepId = 2 },
        };

        public static List<Department> Departments { get;  } = new List<Department>()
        {
            new Department { Id = 1, Name = "SD"},
            new Department { Id = 2, Name = "UI"},
            new Department { Id = 3, Name = "OS" },
            new Department { Id = 4, Name = "Mob"},
        };

      
    }
}
