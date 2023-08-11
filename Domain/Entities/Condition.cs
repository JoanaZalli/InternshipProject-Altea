using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Condition
    {
        public int Id { get; set; }
        public int? CompanyTypeId { get; set; }
       public CompanyType? CompanyType { get; set; }
        public decimal TenorMin { get; set; }
        public decimal? TenorMax { get; set; }
        public decimal? MinRequestedAmount { get; set; }
        public int LenderId { get; set; }
        public Lender Lender { get; set;}
    }
}
