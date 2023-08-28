﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOS
{
    public class BorrowerDTO
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string VatNumber { get; set; }
        public string FiscalCode { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
     
    }
}
