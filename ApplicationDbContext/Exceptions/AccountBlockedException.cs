using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class AccountBlockedException : BadRequestException
    {
        public string CultureId { get; }

        public AccountBlockedException(string cultureId) : base(null)
        {
            CultureId = cultureId;
        }
    }
}
