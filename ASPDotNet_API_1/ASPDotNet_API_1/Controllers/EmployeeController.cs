using ASPDotNet_API_1.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNet_API_1.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class EmployeeController
    {
        private readonly static List<Employee> employees = Employee.GetEmployees();


        #region Get
        [HttpGet]
        public Ok<List<Employee>> Get()
        {
            return TypedResults.Ok(employees);
        }
        #endregion

        #region Get By Id
        [HttpGet("{id}", Name = nameof(GetById))]
        public Results<NotFound<string>, Ok<Employee>> GetById(Guid id)
        {
            var employee = employees.FirstOrDefault(x => x.Id == id);
            if (employee is null) return TypedResults.NotFound("Invalid Id");
            return TypedResults.Ok(employee);

        }
        #endregion

        #region Create 
        [HttpPost]
        public CreatedAtRoute<Employee> Create(Employee newEmployee)
        {
            newEmployee.Id = Guid.NewGuid();
            employees.Add(newEmployee);
            return TypedResults.CreatedAtRoute(newEmployee, nameof(GetById), new { id = newEmployee.Id });
        }
        #endregion

        #region Update
        [HttpPut("{id}")]
        public Results<NoContent, NotFound, BadRequest> Update(Guid id, Employee newData)
        {
            if (newData.Id != id) return TypedResults.BadRequest();
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee is null) return TypedResults.NotFound();

            employee.Name = newData.Name;
            employee.Salary = newData.Salary;
            return TypedResults.NoContent();

        }
        #endregion

        #region Delete
        [HttpDelete("{id}")]
        public Results<NotFound, NoContent> Delete(Guid id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee is null) return TypedResults.NotFound();

            employees.Remove(employee);
            return TypedResults.NoContent();
        }
        #endregion
    }
}
