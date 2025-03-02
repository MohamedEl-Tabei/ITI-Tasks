using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__4
{
    internal class Employee:IComparable
    {
        public static int Count { get; set; }
        //ID, name,security level, salary, hire date and Gender.
        public int Id { get;  }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public SecurityLevel SecurityLevel_ { get; set; }
        public Gender  Gender_ { get; set; }
        public HireDate HireDate_ { get; set; }
        static Employee()
        {
            Count = 0;
        }
        public Employee()
        {
            Count++;
            Id=Count;
            Name = "";
            Salary = 0;
            SecurityLevel_ = 0;
            Gender_ = Gender.M;
            HireDate_ = new HireDate(0,0,0);
        }
        public override string ToString()
        {
            return $"{Id} | {Name} | {Salary} | {SecurityLevel_} | {Gender_} | {HireDate_}";
        }

        public int CompareTo(object? obj)
        {
            Employee right = obj as Employee;
            int res;
            res = this.HireDate_.Year.CompareTo(right.HireDate_.Year);
            if (res == 0) res= this.HireDate_.Month.CompareTo(right.HireDate_.Month);
            if (res == 0) res= this.HireDate_.Day.CompareTo(right.HireDate_.Day);
            return res;
        }
    }
}