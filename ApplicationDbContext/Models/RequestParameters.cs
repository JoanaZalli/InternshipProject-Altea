using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public abstract class RequestParameters
    {
        public string? OrderBy { get; set; }
    }
}
