using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Borrower
    {
        public int Id { get; set; }
        public string CompanyName { get;set; }
        public int CompanyTypeId { get; set; }
        public CompanyType CompanyType { get; set; }
        public string VatNumber { get; set; }
        public string FiscalCode { get; set; }  
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public ICollection<Applicationn> Applications { get; set; }
        public int? CompanyProfileId { get; set; }
        public CompanyProfile? CompanyProfile { get; set; }



    }
}
