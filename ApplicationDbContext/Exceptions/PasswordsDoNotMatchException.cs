using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class PasswordsDoNotMatchException : BadRequestException
    {
        public string CultureId { get; }

        public PasswordsDoNotMatchException(string cultureId) : base(null)
        {
            CultureId = cultureId;
        }
    }
}
