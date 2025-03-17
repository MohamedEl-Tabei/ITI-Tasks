using CompanyAPI.BL;
using CompanyAPI.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
#region Add Services
builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddDALServices(builder.Configuration);
builder.Services.AddBLServices(builder.Configuration);
#endregion
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
