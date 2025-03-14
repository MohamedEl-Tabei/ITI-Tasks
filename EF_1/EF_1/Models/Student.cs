using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1.Models
{
    internal class Student
    {
        public int Id { get; set; }
        [MaxLength(20),MinLength(3)]
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public Student(string name,int age,decimal salary,int departmentId) {
            Name = name;
            Age = age;
            Salary = salary;
            DepartmentId = departmentId;
        }

        public override string ToString() => $"{Id}\t |\t {Name}\t |\t {Age}\t |\t {Salary}\t |\t {DepartmentId}\t |\t {Department}";
    }
}
