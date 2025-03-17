using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CompanyAPI.BL;

public static class BLExtensions
{
    public static void AddBLServices(this IServiceCollection services, IConfiguration configuration )
    {
        services.AddScoped<IEmployeeService, EmployeeServices>();
    }
}
