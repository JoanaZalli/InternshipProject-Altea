using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class PermissionToRoleAssignedException : BadRequestException
    {
        public string CultureId { get; }

        public PermissionToRoleAssignedException(string cultureId) : base(null)
        {
            CultureId = cultureId;
        }
    }
}
