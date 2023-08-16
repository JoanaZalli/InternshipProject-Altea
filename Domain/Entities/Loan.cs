using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Loan
    {
        public int Id { get; set; } 
        public decimal RequestedAmount { get;set; }
        public double InterestRate { get; set; }
        public int Tenor { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int LenderId { get; set; }
        public Lender Lender { get; set; }
        public int ApplicationId { get; set; }
        public Applicationn Application { get; set; }
        public int LoanStatusId { get; set; }
        public LoanStatus LoanStatus { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
