using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class AuthenticationFailedException : BadHttpRequestException
    {
        public string CultureId { get; }

        public AuthenticationFailedException(string cultureId) : base(null)
        {
            CultureId = cultureId;
        }
    }
}
