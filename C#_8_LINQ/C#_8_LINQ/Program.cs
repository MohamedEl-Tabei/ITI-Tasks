using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Xml.Linq;
using System;

namespace C__8_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1;

            #region 1.Display all Student using LINQ Query Expression.
            var q1 = from item in Repository.Students
                     select item;
            #endregion

            #region 2.Display all Student using LINQ Method Syntax[fluent syntax].
            var q2 = Repository.Students.Where(s => true);
            #endregion

            #region 3.Display all Students with Age > 30 using LINQ Query Expression.
            var q3 = from student in Repository.Students
                     where student.Age > 30
                     select student;

            #endregion

            #region 4.Display all Students with Salary< 5000 using LINQ Method Syntax[fluent syntax].
            var q4=Repository.Students.Where(s => s.Salary<5000);
            #endregion

            #region 5.Display all Students with TrackId = 1 and salary > 4000 OrderBy Name descending using LINQ Query Expression.
            var q5 = from student in Repository.Students
                     where student.Salary > 4000 && student.TrackId == 1
                     orderby student.FirstName descending
                     select student;
            #endregion

            #region 6.Display all Students with TrackId = 1 and first name Contains ‘m’ OrderBy Salary Ascending using LINQ Method Syntax[fluent syntax].
            var q6 = Repository.Students.Where(s => s.TrackId == 1 && s.FirstName.Contains('m')).OrderBy(s => s.Salary);
            #endregion

            #region 7.Find First Student with Salary more than 5000.
            var q7 = Repository.Students.First(s => s.Salary > 5000);// if not Exist Throw Exception
            q7 = Repository.Students.First(s => s.Salary > 5000);// if not Exist return null
            #endregion

            #region 8.Find Last Student in Track number 10.
            //var q8 = Repository.Students.Last(s => s.TrackId == 10); // not exist throw exception
            var q8 = Repository.Students.LastOrDefault(s => s.TrackId == 10); // not exist return null
            #endregion

            #region 9.Find Student with Age equal 25. 
            //var q9 = Repository.Students.Single(s => s.Age == 25); //not exist or not single throw error
            //var q9 = Repository.Students.SingleOrDefault(s => s.Age == 25); //not exist return null not single throw error
            #endregion

            #region 10.Find Student with TrackId equal 8.
            //var q10 = Repository.Students.Single(s => s.TrackId == 8);//not exist or not single throw error
            //var q10 = Repository.Students.SingleOrDefault(s => s.TrackId == 8);//not exist return null not single throw error
            #endregion

            #region 11.Find Student in index 4.
            var q11 = Repository.Students.ElementAt(4);
            #endregion

            #region Print
            /*Console.WriteLine($"Query {count++}");
            q1.Print();
            Console.WriteLine($"Query {count++}");
            q2.Print();
            Console.WriteLine($"Query {count++}");
            q3.Print();
            Console.WriteLine($"Query {count++}");
            q4.Print();
            Console.WriteLine($"Query {count++}");
            q5.Print();
            Console.WriteLine($"Query {count++}");
            q6.Print();
            Console.WriteLine($"Query {count++}");
            Console.WriteLine(q7);
            Console.WriteLine($"Query {count++}");
            Console.WriteLine(q8);
            Console.WriteLine($"Query {count++}");
            Console.WriteLine(q9);
            Console.WriteLine($"Query {count++}");
            Console.WriteLine(q10);
            Console.WriteLine($"Query {count++}");
            Console.WriteLine(q11);*/
            #endregion

            #region 12.Ask the user for sorting method (by Name, Age, etc….) and sorting way(ASC.Or DESC.)…. And implement a function named FindStudentsSorted() that displays all Students sorted as the user requested.
            int selected = 0;

            string[] labels = { "FName", "LName", "Age", "Salary" };
            string str = "";
            int countLabel = 1;
            bool parsed=true;
            bool Continue = true;
            do
            {
                Console.Clear();
                countLabel = 1;

                Array.ForEach(labels, (s) => Console.WriteLine($"{countLabel++}-{s}"));
                Console.WriteLine("------------------------");
                Console.WriteLine("Select sorting method");
                parsed = int.TryParse(Console.ReadLine(), out selected);
                switch (selected)
                {
                    case 1:
                        
                        Repository.FindStudentsSorted(s => s.FirstName, Repository.getOrderWay()).Print();
                        break;
                    case 2:
                        Repository.FindStudentsSorted(s => s.LastName, Repository.getOrderWay()).Print();
                        break;
                    case 3:
                        Repository.FindStudentsSorted(s => s.Age, Repository.getOrderWay()).Print();
                        break;
                    case 4:
                        Repository.FindStudentsSorted(s => s.Salary, Repository.getOrderWay()).Print();
                        break;
                }
                Console.Write("to exit press Esc or any key to continue?");

            } while (!parsed || selected > 4 || Console.ReadKey().Key.ToString( )!=ConsoleKey.Escape.ToString());

            #endregion
        }
    }
}
