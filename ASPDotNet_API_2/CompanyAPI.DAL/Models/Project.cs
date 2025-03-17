namespace CompanyAPI.DAL;

public class Project
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public Department? Department { get; set; }

    #region Foreign Keys
    public Guid DepartmentId { get; set; }
    #endregion
}
