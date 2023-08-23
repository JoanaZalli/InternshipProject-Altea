using Application.Moduls.ApplicationModul.Commands;
using Application.Moduls.PermissionModul.Command;
using Application.Resources;
using FluentValidation;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validations
{
    public class CreateApplicationValidation : AbstractValidator<CreateApplicationCommand>
    {
        public CreateApplicationValidation(IStringLocalizer<CreateApplicationCommand> localizationService, string cultureId)
        {
            RuleFor(a => a.RequestedAmount).NotEmpty().WithMessage(a => localizationService[ValidationResource.Requested_Amount, cultureId]);
            RuleFor(a => a.RequestedTenor).NotEmpty().WithMessage(a => localizationService[ValidationResource.Requested_Tenor, cultureId]);
            RuleFor(a => a.FinancingPurposeDescription).NotEmpty().WithMessage(a => localizationService[ValidationResource.Financing_Purpose_Description, cultureId])
                .MaximumLength(100).WithMessage(a => localizationService[ValidationResource.Financing_Puropse_length,cultureId]);




        }
    }
}
