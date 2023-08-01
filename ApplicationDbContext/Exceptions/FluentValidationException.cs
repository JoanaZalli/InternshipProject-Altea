using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class FluentValidationException : CustomException
    {
        public List<LocalizedString> ErrorMessages { get; }
        public FluentValidationException(List<LocalizedString> errorMessage) : base(errorMessage)
        {
            ErrorMessages = errorMessage;
        }

    }
}
