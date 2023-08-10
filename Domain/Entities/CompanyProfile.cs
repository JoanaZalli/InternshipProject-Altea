using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CompanyProfile
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public string Url { get; set; }
        public string Adress { get; set; }
        public string Sector { get;set; }
        public string SubSector { get; set; }
        public string NationalIndustry { get;set; }
        public string Currency { get; set; }
    }
}
