using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class EmailAlreadyConfirmedExcepion : BadRequestException
    {
        public string CultureId { get; }

        public EmailAlreadyConfirmedExcepion(string cultureId) : base(null) { 
        
            CultureId = cultureId;
        }
    }
}
