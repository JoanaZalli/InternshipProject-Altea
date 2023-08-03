using Application.Moduls.PermissionModul.Command;
using Application.Resources;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Application.Validations
{
    public class CreatePermissionValidation : AbstractValidator<CreatePermissionCommand>
    {
        public CreatePermissionValidation(IStringLocalizer<CreatePermissionCommand> localizationService, string cultureId)
        {

            RuleFor(p => p.Name).NotEmpty().WithMessage(p => localizationService[ValidationResource.PermissionNameRequired, cultureId]);
            RuleFor(p => p.Description).NotEmpty().WithMessage(p => localizationService[ValidationResource.PermissionDescriptionRequired, cultureId]);
        }
    }
}
