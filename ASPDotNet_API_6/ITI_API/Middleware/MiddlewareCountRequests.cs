
namespace ITI_API;

public class MiddlewareCountRequests : IMiddleware
{
    private readonly IConfiguration _configuration;
    private readonly ILogger<MiddlewareCountRequests> _logger;
    private  int count = 0;
    public MiddlewareCountRequests(IConfiguration configuration, ILogger<MiddlewareCountRequests> logger)
    {
        _configuration = configuration;
        _logger = logger;
    }
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        if (_configuration.GetValue<bool>("MiddlewareCountRequests"))
            _logger.LogInformation($"--------------------------------> Number of requests before {count}");
        await next(context);
        Interlocked.Increment(ref count);
        _logger.LogInformation($"--------------------------------> Number of requests after {count}");
    }
}
