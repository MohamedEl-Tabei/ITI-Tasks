using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_API_BL.DTO;

public class GeneralResult<T>: GeneralResult
{
    public T? Data { get; set; }

}
public class GeneralResult
{
    public bool Success { get; set; }
    public ResultError[]? Errors { get; set; }

}
public class ResultError
{
    public string? Message { get; set; }
    public string? Code { get; set; }
}