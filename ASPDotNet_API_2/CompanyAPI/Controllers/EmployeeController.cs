using CompanyAPI.BL;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CompanyAPI;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;
    public EmployeeController(IEmployeeService service) => _employeeService = service;

    [HttpGet]
    public async Task<Ok<List<EmployeeDTO>>> GetAll() => TypedResults.Ok(await _employeeService.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<Results<NotFound,Ok<EmployeeDTO>>>GetById(Guid id)
    {
        var employee=await _employeeService.GetByIdAsync(id);
        if (employee is null) return TypedResults.NotFound();
        return TypedResults.Ok(employee);
    }
    [HttpPost]
    public async Task<Ok> Add( EmployeeDTOCreate employee)
    {

        _employeeService.Add(new EmployeeDTO { 
            Address=employee.Address,
            DepartmentId=employee.DepartmentId,
            Name=employee.Name,
            Salary = employee.Salary,
            Id = Guid.NewGuid(),
            Department="",

        });
        return TypedResults.Ok();
    }

    [HttpDelete("{id}")]
    public async Task<Results<NotFound, NoContent>> DeleteById(Guid id)
    {
        var employee = await _employeeService.GetByIdAsync(id);
        if (employee is null) return TypedResults.NotFound();
        _employeeService.Delete(id);

        return TypedResults.NoContent();
    }
}
