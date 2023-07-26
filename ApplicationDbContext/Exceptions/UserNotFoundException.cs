using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class UserNotFoundException : NotFoundException
    {
        public string UserName { get; }
        public string CultureId { get; }
        public UserNotFoundException(string user, string cultureId) : base(null) {
        UserName = user;
        CultureId = cultureId;
        }
    }
}
