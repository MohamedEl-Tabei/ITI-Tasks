using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SocialMediaApi.DAL;

public static class DAL
{
    public static void AddDALServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IRepositories,Repositories>();
        services.AddScoped<IUserRepository,UserRepository>();


        services.AddDbContext<MyContext>(options =>
        {
            options
            .UseSqlServer(configuration.GetConnectionString("dev"))
            .UseSeeding((context, _) =>
            {
                if (!context.Set<User>().Any())
                {
                    var users = new List<User>()
                    {
                        new User(){Name="Mohamed",Email="Mohamed@gmail.com",},
                        new User(){Name="Ahmed",Email="Ahmed@gmail.com",},
                        new User(){Name="Ali",Email="Ali@gmail.com",},
                        new User(){Name="Admin",Email="Admin@gmail.com"},
                    };
                    context.Set<User>().AddRange(users);
                    context.SaveChanges();
                }
            });
        });
    }
}
