using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Exceptions;
using Application.Moduls.UserModul.Commands;
using Application.Resources;
//using Application.Resources;
using Domain.Entities;
using FluentValidation;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Validations
{
    public class CreateUserValidations : AbstractValidator<CreateUserCommand>
    {

        public CreateUserValidations(IStringLocalizer<CreateUserCommand> localizationService , string cultureId  )
        {
           
            RuleFor(u => u.FirstName)
                .NotEmpty().WithMessage(u => localizationService[ValidationResource.FirstName_Required, cultureId])
                    .MaximumLength(30).WithMessage(u => localizationService[ValidationResource.FirstName_MaxLength, cultureId]);

            RuleFor(u => u.LastName)
                .NotEmpty().WithMessage(u => localizationService[ValidationResource.LastName_Required, cultureId])
                .MaximumLength(30).WithMessage(u => localizationService[ValidationResource.LastName_MaxLength, cultureId]);


            RuleFor(u => u.Email).EmailAddress().WithMessage(u => localizationService[ValidationResource.Email_InvalidFormat, cultureId])
                .NotEmpty().WithMessage(u => localizationService[ValidationResource.Email_Required, cultureId]);
               

            RuleFor(u => u.PrefixId)
                .NotEmpty().WithMessage(u => localizationService[ValidationResource.PrefixId_Required, cultureId]);

            RuleFor(u => u.PhoneNumber)
                .MinimumLength(8).WithMessage(u => localizationService[ValidationResource.PhoneNumber_MinLength, cultureId])
                .NotEmpty().WithMessage(u => localizationService[ValidationResource.PhoneNumber_Required,cultureId]);

            RuleFor(u => u.UserName)
                .NotEmpty().WithMessage(u => localizationService[ValidationResource.UserName_Required, cultureId])
            .MinimumLength(8).WithMessage(u => localizationService[ValidationResource.UserName_MinLength, cultureId])
            .Must(HasNumber).WithMessage(u => localizationService[ValidationResource.UserName_RequiresNumber, cultureId]);

            RuleFor(u => u.Password).NotEmpty().WithMessage(u => localizationService[ValidationResource.Password_Required, cultureId])
                .MaximumLength(14).WithMessage(u => localizationService[ValidationResource.Password_MaxLength, cultureId]).
                MinimumLength(8).WithMessage(u => localizationService[ValidationResource.Password_MinLength, cultureId])
                .Must(HasAlphanumericCharacter).WithMessage(u => localizationService[ValidationResource.Password_RequiresAlphanumeric, cultureId]);
        }

            public bool HasNumber(string? username)
            {
                return username.Any(char.IsDigit);
            }
            private bool HasAlphanumericCharacter(string password)
            {
                return password.Any(c => !char.IsLetterOrDigit(c));
            }
       





    }
    }

