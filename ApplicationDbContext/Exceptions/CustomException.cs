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
        public List<string>? ErrorMessages { get; }
        public HttpStatusCode StatusCode { get; }
        public CustomException( List<string>? errors , HttpStatusCode statusCode = HttpStatusCode.InternalServerError)
            : base("Error occured.")
        {
            ErrorMessages = errors;
            StatusCode = statusCode;
        }
    }
}
