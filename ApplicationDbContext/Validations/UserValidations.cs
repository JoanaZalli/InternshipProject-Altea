using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validations
{
    public class UserValidations : AbstractValidator<User>
    {
        public UserValidations() {

            RuleFor(u => u.FirstName).NotEmpty().WithMessage("Field required!")
                .MaximumLength(30).WithMessage("Maximum length is 30 characters");

            RuleFor(u => u.LastName).NotEmpty().WithMessage("Field required!")
                .MaximumLength(30).WithMessage("Maximum length is 30 characters");

            RuleFor(u => u.Prefix).NotEmpty().WithMessage("Field is required!");

            RuleFor(u => u.PhoneNumber).MinimumLength(8).WithMessage("Phone number should be at least 8 characters long!");

            RuleFor(u => u.UserName).Must(HasNumber).WithMessage("UserName should have at least one numeric digit!")
                .NotEmpty().WithMessage("Field Requierd");

        }
        
        private bool HasNumber(string username)
        {
            return username.Any(char.IsDigit);
        }
    }
}
