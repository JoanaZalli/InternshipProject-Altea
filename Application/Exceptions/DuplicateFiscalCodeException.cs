using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class DuplicateFiscalCodeException : BadRequestException
    {
        public string CultureId { get; }

        public DuplicateFiscalCodeException(string cultureId) : base(null)
        {
            CultureId = cultureId;
        }
    }
}
