

using CompanyAPI.DAL;

namespace CompanyAPI.BL;

public class EmployeeDTO
{
    
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public decimal Salary { get; set; }
    public string? Address { get; set; }
    public string? Department { get; set; }
    public Guid DepartmentId { get; set; }
}
