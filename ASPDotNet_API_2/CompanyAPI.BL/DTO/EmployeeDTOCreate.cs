using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyAPI.BL;

public class EmployeeDTOCreate
{
    public string? Name { get; set; }
    public decimal Salary { get; set; }
    public string? Address { get; set; }
    public Guid DepartmentId { get; set; }
}
