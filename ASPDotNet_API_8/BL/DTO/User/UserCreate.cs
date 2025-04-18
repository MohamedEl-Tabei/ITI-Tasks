using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;

namespace SocialMediaApi.BL;

public class UserCreate
{
    public string? Name { get; set; }
    public string? Role { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }


}

