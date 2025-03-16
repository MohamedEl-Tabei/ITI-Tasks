namespace ASPDotNet_API_1.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public static List<Employee> GetEmployees()=>new List<Employee>()
        {
            new Employee(){Id=Guid.NewGuid(),Name="Ali",Salary=5000},
            new Employee(){Id=Guid.NewGuid(),Name="Ahmed",Salary=7000},
            new Employee(){Id=Guid.NewGuid(),Name="Basem",Salary=8000},
            new Employee(){Id=Guid.NewGuid(),Name="Aya",Salary=4000},
            new Employee(){Id=Guid.NewGuid(),Name="Omer",Salary=6000},
            new Employee(){Id=Guid.NewGuid(),Name="Amr",Salary=4000},
        };
    }
}
