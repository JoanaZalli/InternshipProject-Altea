using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOS
{
    public class MatrixTemplateDTO
    {
        public int LenderId { get; set; }
        public int ProductId { get; set; }
        public int Tenor { get; set; }
        public double Spread { get; set; }
    }
}
