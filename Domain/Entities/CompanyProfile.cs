using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities
{
        public class CompanyProfile
        {

            [JsonIgnore]
            public int Id { get; set; }
            public string ticker { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string phone { get; set; }
            public string state { get; set; }
            public string weburl { get; set; }
            public string address { get; set; }  
            public string naicsSector { get; set; }
            public string naicsSubsector { get; set; }
            public string naicsNationalIndustry { get; set; }
            public string currency { get; set; }
        }
    
}

