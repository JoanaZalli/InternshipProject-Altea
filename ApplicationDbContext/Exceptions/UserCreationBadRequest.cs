using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class UserCreationBadRequest : BadRequestException
    {
        public UserCreationBadRequest(List <string> errorMessages) :base("User Faild Creation!"){

            ErrorMessages = errorMessages;
        }
        public List<string> ErrorMessages { get; }

    }
}
