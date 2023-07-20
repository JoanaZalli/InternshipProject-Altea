using Application.Contracts.ValidationLocalization;
using Application.DTOS;
using Application.Exceptions;
using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validations
{
    public class UserValidations : AbstractValidator<UserRegistrationDTO>
    {
        private readonly IUserValidationLocalizationService _localizationService;
        private readonly string _cultureId;

        public UserValidations(IUserValidationLocalizationService localizationService, string cultureId)
        {
            _localizationService = localizationService;
            _cultureId = cultureId;
        }
        public UserValidations()
        {
            RuleFor(u => u.FirstName)
                .NotEmpty().WithMessage(u=>_localizationService.GetValidationMessage("FirstName_Required"))
                .MaximumLength(30).WithMessage(u => _localizationService.GetValidationMessage("FirstName_MaxLength"));

            RuleFor(u => u.LastName)        
                .NotEmpty().WithMessage(u => _localizationService.GetValidationMessage("LastName_Required"))
                .MaximumLength(30).WithMessage(u => _localizationService.GetValidationMessage("LastName_MaxLength"));


            RuleFor(u => u.Email).EmailAddress().WithMessage(u => _localizationService.GetValidationMessage("Email_InvalidFormat"))
                .WithMessage(u => _localizationService.GetValidationMessage("Email_Required"));

            RuleFor(u => u.PrefixId)
                .NotEmpty().WithMessage(u => _localizationService.GetValidationMessage("PrefixId_Required"));

            RuleFor(u => u.PhoneNumber)
                .MinimumLength(8).WithMessage(u => _localizationService.GetValidationMessage("PhoneNumber_MinLength"))
                .NotEmpty().WithMessage(u => _localizationService.GetValidationMessage("PhoneNumber_Required"));
            
            RuleFor(u => u.UserName)
                .NotEmpty().WithMessage(u => _localizationService.GetValidationMessage("UserName_Required"))
            .MinimumLength(8).WithMessage(u => _localizationService.GetValidationMessage("UserName_MinLength"))
            .Must(HasNumber).WithMessage(u => _localizationService.GetValidationMessage("UserName_RequiresNumber"));

            RuleFor(u => u.Password).NotEmpty().WithMessage(u => _localizationService.GetValidationMessage("Password_Required"))
                .MaximumLength(14).WithMessage(u => _localizationService.GetValidationMessage("Password_MinLength")).
                MinimumLength(8).WithMessage(u => _localizationService.GetValidationMessage("Password_MaxLength"))
                .Must(HasAlphanumericCharacter).WithMessage(u => _localizationService.GetValidationMessage("Password_RequiresAlphanumeric"));
        }

        private bool HasNumber(string username)
        {
            return username.Any(char.IsDigit);
        }
        private bool HasAlphanumericCharacter(string password)
        {
            return password.Any(c => !char.IsLetterOrDigit(c));
        }
       
    }
}

