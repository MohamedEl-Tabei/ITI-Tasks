using ITI_API;
using ITI_API_BL;
using ITI_API_BL.DTO;
using ITI_API_DAL;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDALServices(builder.Configuration);
builder.Services.Configure<MyOptions>(builder.Configuration.GetSection(MyOptions.key));
builder.Services.AddBLServices();
builder.Services.AddSingleton<MiddlewareCountRequests>();
builder.Services.AddSingleton<FilterPrintArguements>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}
app.UseMiddleware<MiddlewareCountRequests>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
