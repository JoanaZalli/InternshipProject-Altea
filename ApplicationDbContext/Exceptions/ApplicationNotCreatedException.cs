using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class ApplicationNotCreatedException : BadRequestException
    {
        public string CultureId { get; }
        public ApplicationNotCreatedException(string cultureId) : base(null)
        {
            CultureId = cultureId;
        }
    }
}
