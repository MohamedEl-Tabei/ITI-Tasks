
using CompanyAPI.DAL;

namespace CompanyAPI.BL;

public class EmployeeServices: IEmployeeService
{
    private readonly IRepository<Employee> Repositry;
    public EmployeeServices(IRepository<Employee> repository) => Repositry = repository;

    public void Add(EmployeeDTO entity)
    {
        var employee=new Employee() {
        
            Id=entity.Id,
            Address=entity.Address,
            DepartmentId=entity.DepartmentId,
            Name=entity.Name,
            Salary=entity.Salary,
            
        };
        Repositry.Add(employee);
        Repositry.SaveChanges();
    }

    public  void Delete(Guid id)
    {
        var employee= Repositry.GetById(id);
        if (employee is null) return;
        Repositry.Delete(employee);
        Repositry.SaveChanges();
    }

    public async Task<List<EmployeeDTO>> GetAllAsync()
    {
        var employees= await Repositry.GetAllAsync();
        return employees.Select( e=>
        new EmployeeDTO { 
            Address=e.Address,
            Id=e.Id,
            Department=  e.Department?.Name,
            Name=e.Name,
            Salary=e.Salary,
            DepartmentId=e.DepartmentId
        }).ToList();
    }

    public async Task<EmployeeDTO?> GetByIdAsync(Guid Id)
    {
        var employee=await Repositry.GetByIdAsync(Id);
        if(employee is null) return null;
        return new EmployeeDTO
        {
            Id=employee.Id,
            Department=employee.Department?.Name,
            Name=employee.Name,
            Salary=employee.Salary,
            Address=employee.Address,
            DepartmentId =employee.DepartmentId
        };
    }
}
