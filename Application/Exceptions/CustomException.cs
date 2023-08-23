using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class CustomException : Exception
    {
        public List<LocalizedString>? ErrorMessages { get; }
        public HttpStatusCode StatusCode { get; }
        public CustomException( List<LocalizedString>? errors , HttpStatusCode statusCode = HttpStatusCode.InternalServerError)
            : base("Error occured.")
        {
            ErrorMessages = errors;
            StatusCode = statusCode;
        }
    }
}
