using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            #region Query1: Display numbers without any repeated Data and sorted  
            var q1 = numbers.Distinct().Order();
            q1.Print("Query1: Display numbers without any repeated Data and sorted");
            #endregion


            #region Query2: using Query1  result and show each number and it’s multiplication
            q1.Select(n => new { Number = n, Muliply = n * n })
                .Print("Query2: using Query1  result and show each number and it’s multiplication");
            #endregion

            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
            #region Query1: Select names with length equal 3.
            names.Where(name => name.Length == 3).Print("Query1: Select names with length equal 3.");

            (
                from n in names
                where n.Length == 3
                select n
                ).Print("Query1: Select names with length equal 3.");
            #endregion


            #region Query2: Select names that contains “a” letter (Capital or Small )then sort them by length
            names.Where(n => n.ToLower().Contains('a')).OrderBy(n=>n.Length).Print("Query2: Select names that contains “a” letter (Capital or Small )then sort them by length");
            
            (
                from n in names
                where n.ToLower().Contains('a')
                orderby n.Length
                select n
                ).Print("Query2: Select names that contains “a” letter (Capital or Small )then sort them by length");
            #endregion


            #region Query3: Display the first 2 names  
            names.Take(2).Print("Query3: Display the first 2 names  ");
            #endregion


            List<Student> students = new List<Student>(){
                new Student(){ ID=1, FirstName="Ali", LastName="Mohammed",subjects=new Subject[]{ new Subject(){ Code=22,Name="EF"}, new Subject(){Code=33,Name="UML"}}},
                new Student(){ ID=2, FirstName="Mona", LastName="Gala",subjects=new Subject []{ new Subject(){ Code=22,Name="EF"}, new Subject (){Code=34,Name="XML"},new Subject (){ Code=25, Name="JS"}}},
                new Student(){ ID=3, FirstName="Yara", LastName="Yousf", subjects=new Subject[]{ new Subject (){ Code=22,Name="EF"}, new Subject (){ Code=25,Name="JS"}}},
                new Student(){ ID=1, FirstName="Ali", LastName="Ali", subjects=new Subject []{  new Subject (){ Code=33,Name="UML"}}},
            };
            #region Query1: Display Full name and number of subjects for each student as follow  
            students.Select(s => new { FullName = $"{s.FirstName} {s.LastName}", subjectsNum = s.subjects.Length })
                .Print("Query1: Display Full name and number of subjects for each student as follow ");
            #endregion


            #region Query2: Write a query which orders the elements in the list by FirstName Descending then by LastName Ascending and result of query displays only first names and last names for the elements in list as follow
            students.OrderByDescending(s => s.FirstName).ThenBy(s => s.LastName)
                .Select(s=>$"{s.FirstName} {s.LastName}")
                .Print("Query2: Write a query which orders the elements in the list by FirstName Descending then by LastName Ascending and result of query displays only first names and last names for the elements in list as follow ");
            #endregion

            #region Query3: Display each student and student’s subject as follow (use selectMany) 
            students.SelectMany(s => s.subjects, (s, sb) => new { Name = $"{s.FirstName} {s.LastName}", Subject = sb.Name })
                .Print("Query3: Display each student and student’s subject as follow (use selectMany)");
            #endregion

            #region Query4: Display each student and student’s subject as follow (use GroupBy) 
            var q4= students.SelectMany(s => s.subjects, (s, sb) => new { Name = $"{s.FirstName} {s.LastName}", Subject = sb.Name })
                .GroupBy(sb=>sb.Name);
            Console.WriteLine("Query4: Display each student and student’s subject as follow (use GroupBy)");
            foreach(var s in q4)
            {
                Console.WriteLine(s.Key);
                foreach(var sb in s)
                    Console.WriteLine($"\t{sb.Subject}");

            }

            #endregion

        }
    }
}
