using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__8_LINQ
{
    internal class Student
    {
        //Class Student (Id, FirstName, LastName, Age, Salary, TrackId)
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public int TrackId { get; set; }
        public Track Track { get; set; }

        public override string ToString()
        {
            return $"{Id}\t|{FirstName}\t{LastName}\t|{Age}\t|{Salary}\t|{TrackId}";
        }
    }
}
