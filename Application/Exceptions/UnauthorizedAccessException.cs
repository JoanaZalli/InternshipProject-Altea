using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class UnauthorizedAccessException: CustomException
    {
        public UnauthorizedAccessException(string message) : base(null, HttpStatusCode.Unauthorized)
        {
        }
    }
}
