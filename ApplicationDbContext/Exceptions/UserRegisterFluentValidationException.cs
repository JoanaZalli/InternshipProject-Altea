using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class UserRegisterFluentValidationException : CustomException
    {
        public UserRegisterFluentValidationException(List<LocalizedString> errorMessage/*, string localizerKey*/) : base(errorMessage)
        {
        }

    }
}
