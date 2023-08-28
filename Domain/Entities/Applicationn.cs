using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Applicationn
    {
        public int Id { get; set; }
        public string ApplicationName { get; set; }
        public int BorrowerId { get; set; }
        public Borrower Borrower { get; set;}
        public decimal RequestedAmount { get; set; }
        public int RequestedTenor { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }    
        public bool IsApproved { get; set; }
        public int ApplicationStatusId { get; set; }
        public ApplicationStatus ApplicationStatus { get; set; }
        public string FinancingPurposeDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public byte[]? ExcelFileData { get; set; }

    }
}
