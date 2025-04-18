using Microsoft.AspNetCore.Diagnostics;
using SocialMediaApi.BL;
using System.Net;


// Don't forget to use middleware in middlewares pipeline
// Don't forget to register the middleware in the Program.cs
// GOTO Line 33,55 program.cs
namespace SocialMediaApi.Middlewares;
public class CustomExceptionHandlingMiddleware : IMiddleware
{
    private readonly ILogger<CustomExceptionHandlingMiddleware> _logger;

    public CustomExceptionHandlingMiddleware(
        ILogger<CustomExceptionHandlingMiddleware> logger)
    {
        _logger = logger;
    }
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        //catch(MyCustomerException ex)
        //{

        //}
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            context.Response.StatusCode =
                (int)HttpStatusCode.BadGateway;
        }
    }
}

public class BuiltInExceptionHandlingMiddleware : IExceptionHandler
{
    private readonly ILogger<BuiltInExceptionHandlingMiddleware> _logger;

    public BuiltInExceptionHandlingMiddleware(
        ILogger<BuiltInExceptionHandlingMiddleware> logger)
    {
        _logger = logger;
    }
    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken)
    {
        if (exception is UserException businessException)
        {
            httpContext.Response.StatusCode =
                (int)HttpStatusCode.BadRequest;

            await httpContext.Response.WriteAsJsonAsync(
                businessException.Error.Select(e => new GeneralError
                {
                    Code = e.ErrorCode,
                    Message = e.ErrorMessage
                }));
        }
        else
        {
            _logger.LogError(exception, exception.Message);
            httpContext.Response.StatusCode =
                (int)HttpStatusCode.InternalServerError;
        }
        return true;
    }
}
