using ITI_API_BL.DTO;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;
using ITI_API_BL;

namespace ITI_API.Middleware;

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
        if (exception is ValidationException businessException)
        {
            httpContext.Response.StatusCode =
                (int)HttpStatusCode.BadRequest;

            await httpContext.Response.WriteAsJsonAsync(
                businessException.Errors.Select(e => new ResultError
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
