namespace CompanyAPI.DAL;

public class Employee
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public decimal Salary { get; set; }
    public string? Address { get; set; }
    public virtual Department? Department { get; set; }
    #region Foreign keys
    public Guid DepartmentId { get; set; }
    #endregion 
}
