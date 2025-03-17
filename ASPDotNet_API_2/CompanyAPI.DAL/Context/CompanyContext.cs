using Microsoft.EntityFrameworkCore;

namespace CompanyAPI.DAL;

public class CompanyContext:DbContext
{

    #region Inject Configrations
    public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) { }
    #endregion
    #region DbSet
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Project> Projects => Set<Project>(); //get table that map project class
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CompanyContext).Assembly); //use all IentityConfiguration in assembly
    }
}
