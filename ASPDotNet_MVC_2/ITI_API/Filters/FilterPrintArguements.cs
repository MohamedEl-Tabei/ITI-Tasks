using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ITI_API;

public class FilterPrintArguements : Attribute, IAsyncActionFilter
{
    private readonly ILogger<FilterPrintArguements> _logger;

    public FilterPrintArguements( ILogger<FilterPrintArguements> logger) {
        _logger= logger;
    }
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        
        await next();
        var arguments = context.ActionArguments;
        foreach (var arg in arguments)
        {
            _logger.LogInformation($"--------------------------------> {arg}");
        }
    }
}
