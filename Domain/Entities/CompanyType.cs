using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CompanyType
    {
        public int Id { get; set; } 
        public string Company_Type { get; set; }
        public DateTime DateCreated { get; set; }
        public ICollection<Borrower> Borrowers { get; set; }

    }
}
