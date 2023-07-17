using Application.DTOS;
using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validations
{
    public class UserValidations : AbstractValidator<UserRegistrationDTO>
    {
        public UserValidations()
        {
            RuleFor(u => u.FirstName)
                .NotEmpty()
                .MaximumLength(30);

            RuleFor(u => u.LastName)        
                .NotEmpty()
                .MaximumLength(30);
            RuleFor(u => u.Email).EmailAddress();
            RuleFor(u => u.PrefixId)
                .NotEmpty();

            RuleFor(u => u.PhoneNumber)
                .MinimumLength(8);

            RuleFor(u => u.UserName)
                .NotEmpty()
            .MinimumLength(8)
            .Must(HasNumber).WithMessage("Username should contain at least one number!");

            RuleFor(u => u.Password).NotEmpty().MaximumLength(14).MinimumLength(8).Must(HasAlphanumericCharacter).WithMessage("Password should has at least 1 alhpa-numeric character");
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
