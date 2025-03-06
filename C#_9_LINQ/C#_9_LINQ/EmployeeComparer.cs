using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__9_LINQ
{
    internal class EmployeeComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y) => x.LastName == y.LastName;

        public int GetHashCode([DisallowNull] Employee obj) => obj.LastName.GetHashCode();
        
    }
}
