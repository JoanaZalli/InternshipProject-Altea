using Application.Moduls.PermissionModul.Command;
using Application.Moduls.RoleModul.Command;
using Application.Resources;
using FluentValidation;
using FluentValidation.Validators;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validations
{
    public class CreatePermissionValidation : AbstractValidator<CreatePermissionCommand>
    {
        public CreatePermissionValidation(IStringLocalizer<CreatePermissionCommand> localizationService, string cultureId) { 
        
            RuleFor(p=>p.Name).NotEmpty().WithMessage(p=> localizationService[ValidationResource.PermissionNameRequired, cultureId]);
            RuleFor(p => p.Description).NotEmpty().WithMessage(p => localizationService[ValidationResource.PermissionDescriptionRequired, cultureId]);
        }
    }
}
