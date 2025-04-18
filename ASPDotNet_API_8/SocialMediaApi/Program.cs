using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Localization;
using Microsoft.IdentityModel.Tokens;
using Scalar.AspNetCore;
using SocialMediaApi.BL;
using SocialMediaApi.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region Services
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddDALServices(builder.Configuration);
builder.Services.AddBLServices();


builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(
    options =>
    {
        var secretKey = builder.Configuration.GetValue<string>("secretKey");
        var secretKeyInBytes = Encoding.UTF8.GetBytes(secretKey);
        var key = new SymmetricSecurityKey(secretKeyInBytes);
        options.TokenValidationParameters = new()
        {
            ValidateAudience = false,
            ValidateIssuer = false,
            IssuerSigningKey = key,
        };
    }

    );
builder.Services.AddIdentityCore<User>(options =>
{
    options.Password.RequiredLength = 8;

    options.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<MyContext>();


builder.Services.AddAuthorization(options =>
{
    options.AddPolicy(
        "ForAdminOnly",
        builder => builder.
        RequireClaim(ClaimTypes.Role, "Admin")
        .RequireClaim(ClaimTypes.NameIdentifier)
        );
    options.AddPolicy(
       "ForUser",
       builder => builder.
       RequireClaim(ClaimTypes.Role, "User")
       .RequireClaim(ClaimTypes.NameIdentifier)
       );
}
    );
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
