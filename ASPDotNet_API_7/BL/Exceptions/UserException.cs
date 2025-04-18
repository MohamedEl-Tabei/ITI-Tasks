using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace SocialMediaApi.BL;

public class UserException : Exception
{
    public List<ValidationFailure> Error { get; }
    public UserException(List<ValidationFailure> errors)
    {
        Error = errors;

    }

}
