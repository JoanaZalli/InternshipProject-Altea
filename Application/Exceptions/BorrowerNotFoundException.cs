using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class BorrowerNotFoundException : NotFoundException
    {
        public string CultureId { get; }
        public BorrowerNotFoundException(string cultureId) : base(null)
        {
            CultureId = cultureId;
        }
    }
}
