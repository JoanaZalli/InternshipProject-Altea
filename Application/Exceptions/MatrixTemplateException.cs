using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class MatrixTemplateException : BadRequestException
    {
        public string CultureId { get; }
        public MatrixTemplateException(string cultureId) : base(null)
        {
            CultureId = cultureId;
        }
    }
}
