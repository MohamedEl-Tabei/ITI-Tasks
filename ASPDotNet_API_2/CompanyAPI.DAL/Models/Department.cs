namespace CompanyAPI.DAL;

public class Department
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public ICollection<Employee>? Employees { get; set; }
    public ICollection<Project>? Projects { get; set; }
}
