using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;
using static C__9_LINQ.Repository;
namespace C__9_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int queryNum = 1;
            Console.WriteLine($"-----------------Query ({queryNum++})-----------------");
            #region 1.First 4 Employees in the List Using Method Syntax[fluent syntax].
            Employees.Take(4).Print();
            #endregion


            Console.WriteLine($"\n-----------------Query ({queryNum++})-----------------");
            #region 2.First 3 Employees in the List with Salary more than 5000 Using Method Syntax[fluent syntax].
            Employees.Where(e=>e.Salary>5000).Take(3).Print();
            #endregion


            Console.WriteLine($"\n-----------------Query ({queryNum++})-----------------");
            #region 3.Last 4 Employees in the List Using Method Syntax[fluent syntax].
            Employees.TakeLast(4).Print();
            #endregion
           
            
            Console.WriteLine($"\n-----------------Query ({queryNum++})-----------------");
            #region 4.Second 2 Employees in the List Using Method Syntax[fluent syntax].
            Employees.Take(2).Print();

            #endregion


            Console.WriteLine($"\n-----------------Query ({queryNum++})-----------------");
            #region  5.All Employees While Name length< 5 Using Method Syntax[fluent syntax].
            Employees.TakeWhile(e => e.FirstName.Length < 5).Print();
            #endregion


            Console.WriteLine($"\n-----------------Query ({queryNum++})-----------------");
            #region  6.Distinct Employees.Hint: (Using IEqualityComparer) Using Method Syntax[fluent syntax].
            Employees.Distinct(new EmployeeComparer()).Print();
            #endregion


            Console.WriteLine($"\n-----------------Query ({queryNum++})-----------------");
            #region 7.Name and Id of All Employees Using Method Syntax[fluent syntax].
            Employees.Select(e => new { name = e.FirstName, id = e.Id }).Print();
            #endregion


            Console.WriteLine($"\n-----------------Query ({queryNum++})-----------------");
            #region  8.Name and Id of All Employees Using Query Syntax.
            (
                from emp in Employees
                select new { name = emp.FirstName, id = emp.Id }
            ).Print();
            #endregion


            Console.WriteLine($"\n-----------------Query ({queryNum++})-----------------");
            #region 9.Name and DeptName of All Employees Using Query Syntax.
            (
                from emp in Employees
                join dpt in Departments
                on emp.DepId equals dpt.Id
                select new { name = emp.FirstName, department = dpt.Name }
            ).Print();
            #endregion


            Console.WriteLine($"\n-----------------Query ({queryNum++})-----------------");
            #region 10.Name and DeptName of All Employees Using Method Syntax[fluent syntax].
            Employees.Join(Departments, e => e.DepId, d => d.Id, (e, d) => new { name = e.FirstName, department = d.Name })
                .Print();
            #endregion
            
            
            Console.WriteLine($"\n-----------------Query ({queryNum++})-----------------");
            #region 11.All Employees Group by DeptName Using Method Syntax[fluent syntax].
            Employees.Join(Departments, e => e.DepId, d => d.Id, (e, d) => new {  e, department = d.Name })
                .GroupBy(ed => ed.department).Print();
            #endregion


            Console.WriteLine($"\n-----------------Query ({queryNum++})-----------------");
            #region 12.All Employees Group by DeptName Using Query Syntax.
            (
                from emp in Employees
                join dpt in Departments
                on emp.DepId equals dpt.Id
                group new { emp, department = dpt.Name } by dpt.Name
            ).Print();
            #endregion



            Console.WriteLine($"\n-----------------Query ({queryNum++})-----------------");
            #region 13.Min Salary, Max Salary, Avg Salary.
            string[] q13 =
            {
                $"Min Salary = {Employees.Min(e => e.Salary)}",
                $"Max Salary = {Employees.Max(e => e.Salary)}",
                $"Avg Salary = {Employees.Average(e => e.Salary)}"
            };
            q13.Print();
            
            #endregion



            Console.WriteLine($"\n-----------------Query ({queryNum++})-----------------");
            #region 14.Employee Where Salary<Avg Salary.
            Employees.Where(e => e.Salary < Employees.Average(e => e.Salary)).Print();
            #endregion


            Console.WriteLine($"\n-----------------Query ({queryNum++})-----------------");
            #region 15.Create two lists of int and try Expect, Concat, Union, Intersect.
            var l1 = new List<int> { 1, 2, 3, 4, 5 };
            var l2 = new List<int> { 3, 4, 5, 6, 7 };

            l1.Except(l2).Print();
            l1.Concat(l2).Print();
            l1.Union(l2).Print();
            l1.Intersect(l2).Print();

            #endregion

            
            Console.WriteLine($"\n-----------------Query ({queryNum++})-----------------");
            #region 16.Create list of Phone Number and Names and try Zip Operator.
            var names = Employees.Select(e => e.FirstName);
            var phones = Employees.Select(e => $"010{e.Salary}");

            names.Zip(phones, (n, p) => new { Name = n, Phone = p }).Print();
            #endregion

        }
    }
}
