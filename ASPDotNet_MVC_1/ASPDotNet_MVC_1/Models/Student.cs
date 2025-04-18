namespace ASPDotNet_MVC_1.Models;

public class Student
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public string Email { get; set; }

    private static readonly List<Student> _students=new List<Student>()
    {
        new (){Id=Guid.NewGuid(),Name="Ali",Department="SD",Email="Ali@gmail.com"},
        new (){Id=Guid.NewGuid(),Name="Ahmed",Department="SD",Email="Ahmed@gmail.com"},
        new (){Id=Guid.NewGuid(),Name="Ziad",Department="UI",Email="Ziad@gmail.com"},
        new (){Id=Guid.NewGuid(),Name="Basem",Department="UI",Email="Basem@gmail.com"},
        new (){Id=Guid.NewGuid(),Name="Amr",Department="UI",Email="Amr@gmail.com"},
        new (){Id=Guid.NewGuid(),Name="Mohamed",Department="AI",Email="Mohamed@gmail.com"}
    };
    public static List<Student> GetStudents()=>_students;
}
