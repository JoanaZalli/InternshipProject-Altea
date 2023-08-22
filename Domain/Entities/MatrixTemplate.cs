using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MatrixTemplate
    {
        public int Id { get; set; }
        public Lender Lender { get; set; }
        public Product Product { get; set; }
        public int Tenor { get; set; }
        public double? Spread { get; set; }
    }
}
