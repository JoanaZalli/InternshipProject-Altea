using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class UserNameInUseException : BadRequestException
    {
        public string UserName { get; }
        public string CultureId { get; }
        public UserNameInUseException(string username, string cultureId) : base(null)
        {
            UserName = username;
            CultureId = cultureId;
        }
    }
}
