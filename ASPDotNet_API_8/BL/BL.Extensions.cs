using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace SocialMediaApi.BL;

public static class BL
{
    public static void AddBLServices(this IServiceCollection services)
    {
        services.AddScoped<IUserManager, UserManager>();
    }
}
