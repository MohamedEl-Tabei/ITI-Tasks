using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Localization;
using Scalar.AspNetCore;
using SocialMediaApi.BL;
using SocialMediaApi.DAL;
using SocialMediaApi.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region Services
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddDALServices(builder.Configuration);
builder.Services.AddBLServices();
builder.Services.AddSingleton<CustomExceptionHandlingMiddleware>();

builder.Services.AddExceptionHandler<BuiltInExceptionHandlingMiddleware>();
builder.Services.AddProblemDetails();
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCulture = new[] { "en-US", "ar-EG" };
    options.SetDefaultCulture(supportedCulture[0]).AddSupportedCultures(supportedCulture).AddSupportedUICultures(supportedCulture);

});
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Images")),
    RequestPath="/api/static-files"
});
app.UseHttpsRedirection();
app.UseRequestLocalization();
app.UseAuthorization();
app.UseExceptionHandler();
app.MapControllers();

app.Run();
