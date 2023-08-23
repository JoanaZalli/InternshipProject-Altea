using Application.DTOS;
using Application.Moduls.BorrowerModul.Command;
using Application.Moduls.UserModul.Commands;
using Application.Resources;
using Domain.Entities;
using FluentValidation;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validations
{
    public class CreateBorrowerValidation : AbstractValidator<CreateBorrowerCommand>
    {
        private readonly IEnumerable<CompanyType> _companyTypes;


        public CreateBorrowerValidation(IStringLocalizer<CreateBorrowerCommand> localizationService, string cultureId, IEnumerable<CompanyType> companyTypes)
        {

            _companyTypes = companyTypes;

            RuleFor(b => b.CompanyName).NotEmpty().WithMessage(u => localizationService[ValidationResource.CompanyNameRequired, cultureId]);

            RuleFor(b => b.CompanyTypeId).NotEmpty().WithMessage(u => localizationService[ValidationResource.CompanyTypeRequired, cultureId]);

            RuleFor(b => b.VatNumber)
                .MinimumLength(11).WithMessage(u => localizationService[ValidationResource.VatNumberLength, cultureId])
                .MaximumLength(11).WithMessage(u => localizationService[ValidationResource.VatNumberLength, cultureId])
                .NotEmpty().WithMessage(u => localizationService[ValidationResource.VatNumberRequired, cultureId]);

            RuleFor(b => b.FiscalCode).Custom((value, context) =>
            {

                var companyType = _companyTypes.FirstOrDefault(ct => ct.Id == context.InstanceToValidate.CompanyTypeId);

                if (companyType == null)
                {
                    return;
                }

                if (companyType.Company_Type == "Sole proprietorship (S.I.)" && (value == null || value.Length != 16))
                {
                    context.AddFailure(nameof(BorrowerDTO.FiscalCode), localizationService[ValidationResource.FiscalCodeLengthSP, cultureId]);
                }
                else
                if ((value == null || value.Length != 11))
                {
                    context.AddFailure(nameof(BorrowerDTO.FiscalCode), localizationService[ValidationResource.FiscalCodeLendthOther, cultureId]);
                }

            }).NotEmpty().WithMessage(u => localizationService[ValidationResource.FiscalCodeRequired, cultureId]);

            //    RuleFor(b => b.FiscalCode)
            //               .Must((command, fiscalCode) => IsFiscalCodeUnique(command.UserId.ToString(), fiscalCode))
            //               .WithMessage(u => localizationService[ValidationResource.FiscalCodeUnique, cultureId]);
            //}

            //private bool IsFiscalCodeUnique(string userId, string fiscalCode)
            //{
            //    var b = _borrowers.Any(b=>b.UserId==userId &&  b.FiscalCode == fiscalCode);
            //    if (b)
            //    {
            //        return false;
            //    }
            //    return true;
            //}
        }
    }
}
