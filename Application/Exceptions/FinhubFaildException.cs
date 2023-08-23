using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class FinhubFaildException : BadRequestException
    {

        public FinhubFaildException( ) : base("Warning: Failed to fetch company profile from Finhub.")
        {           
        }
    }
}
