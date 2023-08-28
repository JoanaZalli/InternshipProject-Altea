using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public  class RoleExistsException : BadRequestException
    {
        public string CultureId { get; }

        public RoleExistsException(string cultureId) : base(null)
        {
            CultureId = cultureId;
        }
    }
}
