using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class RoleWasNotFoundException : BadRequestException
    {
        public string CultureId { get; }
        public RoleWasNotFoundException(string cultureId) : base(null)
        {
            CultureId = cultureId;
        }
    }
}
