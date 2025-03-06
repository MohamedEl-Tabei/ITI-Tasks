using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace C__8_LINQ
{
    internal static class Repository
    {
        public static List<Student> Students { get; set; } = new List<Student>() {
            new Student { Id = 1,  FirstName = "Ali",  LastName = "Ahmed", Age = 25, Salary = 1234, TrackId = 1 },
            new Student { Id = 2,  FirstName = "Ali", LastName = "Mohamed",  Age = 25, Salary = 2234, TrackId = 2 },
            new Student { Id = 3,  FirstName = "Ahmed", LastName = "Mohamed",  Age = 46, Salary = 3234, TrackId = 3 },
            new Student { Id = 4,  FirstName = "Sara", LastName = "Mohamed",  Age = 18, Salary = 4234, TrackId = 4 },
            new Student { Id = 5,  FirstName = "Mai", LastName = "Mohamed",  Age = 30, Salary = 5234, TrackId = 1 },
            new Student { Id = 6,  FirstName = "Alaa", LastName = "Mohamed",  Age = 20, Salary = 6234, TrackId = 2 },
            new Student { Id = 7,  FirstName = "Basem",  LastName = "Mohamed", Age = 16, Salary = 7234, TrackId = 3 },
            new Student { Id = 8,  FirstName = "Omar", LastName = "Mohamed",  Age = 32, Salary = 8234, TrackId = 4 },
            new Student { Id = 9,  FirstName = "Amr", LastName = "Mohamed",  Age = 32, Salary = 9234, TrackId = 1 },
            new Student { Id = 10, FirstName= "Alaa",  LastName = "Mohamed", Age = 38, Salary = 10234, TrackId = 2 },
        };

        public static List<Track> Tracks { get; set; } = new List<Track>()
        {
            new Track { Id = 1, Name = "SD"},
            new Track { Id = 2, Name = "UI"},
            new Track { Id = 3, Name = "OS" },
            new Track { Id = 4, Name = "Mob"},
        };

        public static List<Student> FindStudentsSorted<T>(Func<Student,T> predicate,int orderWay)
        {
            //int orderWay = 0;
            //bool parsed = true;
            
            //Console.WriteLine("1- ASC");
            //Console.WriteLine("2- DESC");
            //Console.WriteLine("------------------------");
            //do
            //{
            //    parsed=int.TryParse(Console.ReadLine(), out orderWay );
            //} while ((orderWay != 1 && orderWay != 2) || !parsed);


            if (orderWay == 1)
                return Students.Where(s=>true).OrderBy(predicate).ToList();
            else
                return Students.Where(s => true).OrderByDescending(predicate).ToList();
        }

        public static  int getOrderWay()
        {
            int orderWay = 0;
            bool parsed = true;

            Console.WriteLine("1- ASC");
            Console.WriteLine("2- DESC");
            Console.WriteLine("------------------------");
            do
            {
                parsed = int.TryParse(Console.ReadLine(), out orderWay);
            } while ((orderWay != 1 && orderWay != 2) || !parsed);
            return orderWay;
        }
    }
}
