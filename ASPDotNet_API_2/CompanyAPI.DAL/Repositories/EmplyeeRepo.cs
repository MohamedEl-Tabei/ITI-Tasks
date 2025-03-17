

using Microsoft.EntityFrameworkCore;

namespace CompanyAPI.DAL;

public class EmplyeeRepo :IRepository<Employee>
{
    private readonly CompanyContext Context;

    public EmplyeeRepo(CompanyContext context) => Context = context;



    public void Add(Employee entity) => Context.Set<Employee>().Add(entity);



    public void Delete(Employee entity) => Context.Employees.Remove(entity);

    public async Task<List<Employee>> GetAllAsync() => await Context.Set<Employee>().Include(e=>e.Department).ToListAsync();

    public async Task<Employee?> GetByIdAsync(Guid Id) => await Context.Set<Employee>().Include(e=>e.Department).FirstOrDefaultAsync(e=>e.Id==Id);
    public Employee? GetById(Guid Id) =>  Context.Set<Employee>().Include(e=>e.Department).FirstOrDefault(e=>e.Id==Id);

    public int SaveChanges() =>  Context.SaveChanges();
}
