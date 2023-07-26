using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class TokenExpiredException : BadRequestException
    {
        public string CultureId { get; }

        public TokenExpiredException(string cultureId) : base(null)
        {
            CultureId = cultureId;
        }
    }
}
