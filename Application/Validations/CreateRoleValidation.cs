using Application.Moduls.RoleModul.Command;
using Application.Moduls.UserModul.Commands;
using Application.Resources;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validations
{
    public class CreateRoleValidation : AbstractValidator<CreateRoleCommand>
    {
        public CreateRoleValidation(IStringLocalizer<CreateRoleCommand> localizationService, string cultureId) {
            RuleFor(r => r.RoleName).NotEmpty().WithMessage(u => localizationService[ValidationResource.RoleNameRequired, cultureId]);
        }
    }
}
