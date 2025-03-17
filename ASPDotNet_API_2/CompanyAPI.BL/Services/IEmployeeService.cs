namespace CompanyAPI.BL;

public interface IEmployeeService
{
    Task<List<EmployeeDTO>> GetAllAsync();
    Task<EmployeeDTO?> GetByIdAsync(Guid Id);
    void Add(EmployeeDTO entity);
    void Delete(Guid id);
}
