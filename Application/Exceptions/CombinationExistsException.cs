using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class CombinationExistsException : BadRequestException
    {
        public string CultureId { get; }

        public CombinationExistsException(string cultureId) : base(null)
        {

            CultureId = cultureId;
        }
    }
}