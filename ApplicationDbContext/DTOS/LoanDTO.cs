using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOS
{
    public class LoanDTO
    {
        public int Id { get; set; }
        public decimal RequestedAmount { get; set; }
        public double InterestRate { get; set; }
        public int Tenor { get; set; }
        public string ProductName { get; set; }
        public string LenderName { get; set; }
        public string ApplicationStatusName { get; set; }
        public string LoanStatusName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
