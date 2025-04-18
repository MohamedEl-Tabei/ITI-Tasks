using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApi.BL;

public class GeneralResult<T>
{
    public bool Success { get; set; }
    public T? Data { get; set; }
    public GeneralError[]? generalErrors { get; set; }
}

public class GeneralError
{
    public string? Message { get; set; }
    public string? Code { get; set; }
}
