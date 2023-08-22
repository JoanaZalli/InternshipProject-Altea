using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class EmailInUseException : BadRequestException
    {
        public string Email {  get; }
        public string CultureId { get; }
        public EmailInUseException(string email, string cultureId) : base(null) { 
        Email = email;
         CultureId = cultureId;
        }
    }
}
