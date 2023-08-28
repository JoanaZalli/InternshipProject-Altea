using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class InternalServerException : CustomException
    {
        public InternalServerException(string message, List<LocalizedString>? errors = default)
            : base( errors, HttpStatusCode.InternalServerError) { }
    }
}
