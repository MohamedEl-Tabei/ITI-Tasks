using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace ITI_API_BL;

public class ValidationException:Exception
{
    public List<ValidationFailure> Errors { get;  }
    public ValidationException(List<ValidationFailure> errors)
    {
        Errors=errors;
    }

}
