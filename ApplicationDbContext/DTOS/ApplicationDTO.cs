using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOS
{
    public class ApplicationDTO
    {
        public string ApplicationName { get; set; }  
        public decimal RequestedAmount { get; set; }
        public decimal RequestedTenor { get; set; }
        public int ProductId { get; set; }  
        public bool IsApproved { get; set; }
        public int ApplicationStatusId { get; set; }
        public string FinancingPurposeDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

    }
}
