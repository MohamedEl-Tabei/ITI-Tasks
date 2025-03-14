using EF_1;
using EF_1.Context;
using EF_1.Models;
using Microsoft.EntityFrameworkCore;

#region Database
var db = new MyContext();
//db.Database.EnsureDeleted();
//db.Database.EnsureCreated();
#endregion

#region students
void AddStudents()
{
    db.Students.Add(new Student("Ali", 20, 1234,1));
    db.Students.Add(new Student("Ahmed", 31, 2234,1));
    db.Students.Add(new Student("Aya", 25, 3234,3));
    db.Students.Add(new Student("Hassen", 23, 3234,4));
    db.Students.Add(new Student("Omer", 32, 4234,5));
    db.Students.Add(new Student("Amr", 24, 2534,5));
    db.Students.Add(new Student("Alaa", 26, 7534,4));
    db.Students.Add(new Student("Basem", 26, 5534,1));
    db.Students.Add(new Student("Karim", 28, 6634,2));
    db.Students.Add(new Student("Ziad", 29, 7634,1));
}
//AddStudents();
#endregion


#region Department
void AddDepartments()
{
    db.Departments.Add(new Department("SD"));
    db.Departments.Add(new Department("UI"));
    db.Departments.Add(new Department("OS"));
    db.Departments.Add(new Department("BI"));
    db.Departments.Add(new Department("AI"));
}
//AddDepartments();
#endregion
//db.SaveChanges();
#region Part 01
db.Students.Print("3.Display all Students.");
db.Departments.Print("4.Display all Departments.");
db.Students.Include(S => S.Department).Print("5.Display Students With Department Name. [Using Include]");
db.Students.Include(S => S.Department).Where(S => S.DepartmentId == 1).Print("6.Display Students With Department Name in Department Id = 1. [Using Include]");
db.Students.Include(S => S.Department).Where(S=>S.DepartmentId==1).OrderByDescending(S=>S.Name).Print("7.Display all Students with DeptId =1 OrderBy Name descending.");
#endregion


#region Part 02
(
    from S in db.Students
    select S
    ).Print("1.Display all Student using LINQ Query Expression.");

db.Students.Print("2.Display all Student using LINQ Method Syntax [fluent syntax].");

(
    from S in db.Students
    where S.Age>30
    select S
    ).Print("3.Display all Students with Age > 30 using LINQ Query Expression.");

db.Students.Where(S=>S.Salary<5000).Print("4.Display all Students with Salary < 5000 using LINQ Method Syntax [fluent syntax].");

(
    from S in db.Students
    where S.DepartmentId==1 && S.Salary>4000
    orderby S.Name descending
    select S
    ).Print("5.Display all Students with DepartmentId = 1 and salary > 4000 OrderBy Name descending using LINQ Query Expression.");

db.Students.Where(S=>S.DepartmentId==1 && S.Name.ToLower().Contains("m")).OrderBy(S=>S.Salary).Print("6.Display all Students with DepartmentId = 1 and Name Contains ‘m’ OrderBy Salary Ascending using LINQ Method Syntax [fluent syntax].");

Console.WriteLine($"\n7.Find First Student with Salary more than 5000. (using First) ->\n {db.Students.First(S => S.Salary > 5000)}");
Console.WriteLine($"\n8.Find Last Student in Department number 10. (LastOrDefault) ->\n {db.Students.OrderBy(S=>S.Salary).LastOrDefault(S=>S.DepartmentId==10)}");
Console.WriteLine($"\n9.Find Student with Age equal 25. -> \n {db.Students.SingleOrDefault(S=>S.Age==25)}");
Console.WriteLine($"\n10.Find Student with DepartmentId equal 8. -> \n {db.Students.SingleOrDefault(S => S.DepartmentId == 8)}");
#endregion

//db.Departments.Add(new Department("S"));
//db.SaveChanges();
