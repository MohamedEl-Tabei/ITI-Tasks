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
    public string? Email { get; set; }
    public string? Password { get; set; }


}

public class UserCreateValidator : AbstractValidator<UserCreate>
{
    private readonly IStringLocalizer<SharedResources> _localizer;

    public UserCreateValidator(IConfiguration configuration, IStringLocalizer<SharedResources> localizer)
    {
        _localizer = localizer;
        RuleFor(u => u.Name).NotEmpty().WithMessage(_localizer[AppConstants.ErrorMessages.NameNotEmpty]).WithErrorCode(AppConstants.ErrorCodes.NameNotEmpty);

    }
}