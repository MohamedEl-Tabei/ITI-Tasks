

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CompanyAPI.DAL;

public static class DALExtensions
{

    public static void AddDALServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionStr = configuration.GetConnectionString("dev");
        services.AddDbContext<CompanyContext>(options => options
        .UseSqlServer(connectionStr)
        .UseSeeding((context, _) =>
        {
            #region Department
            if (context.Set<Department>().Any()) return;
            var departments = new List<Department>
            {
                new Department{Id=Guid.NewGuid(),Name="HR"},
                new Department{Id=Guid.NewGuid(),Name="IT"},
                new Department{Id=Guid.NewGuid(),Name="SD"},
            };
            context.AddRange(departments);
            context.SaveChanges();
            #endregion
        }).UseSeeding((context, _) =>
        {
            #region Employee
            if (context.Set<Employee>().Any()) return;
            var employees = new List<Employee>
            {
                new Employee{Id=Guid.NewGuid(),Name="Ali",DepartmentId=Guid.Parse("17642D82-5F9C-40D0-9282-4A61BD1792AD"),Address="ISM",Salary=5000},
                new Employee{Id=Guid.NewGuid(),Name="Ahmed",DepartmentId=Guid.Parse("25D4078F-758F-49E0-8C25-ABD219590FC9"),Address="ISM",Salary=7000},
                new Employee{Id=Guid.NewGuid(),Name="Amr",DepartmentId=Guid.Parse("17642D82-5F9C-40D0-9282-4A61BD1792AD"),Address="ISM",Salary=6000},
                new Employee{Id=Guid.NewGuid(),Name="Omer",DepartmentId=Guid.Parse("3DC4DBBD-F188-4F63-8514-FF0440706D17"),Address="ISM",Salary=3000},
            };
            context.AddRange(employees);
            context.SaveChanges();
            #endregion
        }));
        services.AddScoped<IRepository<Employee>, EmplyeeRepo>();
    
    }
}
