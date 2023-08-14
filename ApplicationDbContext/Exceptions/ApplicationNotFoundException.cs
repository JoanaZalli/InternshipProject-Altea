using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class ApplicationNotFoundException : NotFoundException
    {
        public string CultureId { get; }
        public ApplicationNotFoundException(string cultureId) : base(null)
        {
            CultureId = cultureId;
        }
    }
}
