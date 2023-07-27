using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOS
{
    public class ForgotPasswordDto
    {
        public string Email { get; set; }
        public string CultureId { get; set; }

    }
}
