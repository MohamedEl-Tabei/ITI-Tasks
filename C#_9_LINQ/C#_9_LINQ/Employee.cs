using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__9_LINQ
{
    internal class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public int DepId { get; set; }
        public Department Department { get; set; }

        public override string ToString()
        {
            return $"{Id}\t|{FirstName}\t{LastName}\t|{Age}\t|{Salary}\t|{DepId}";
        }
    }
}
