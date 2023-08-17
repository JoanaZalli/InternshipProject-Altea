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
            public string? country { get; set; }
            public string? currency { get; set; }
            public string? exchange { get; set; }
            public string? ipo { get; set; }
            public double? marketCapitalization { get; set; }
            public string? name { get; set; }
            public string? phone { get; set; }  
            public double? shareOutstanding { get; set; }
            public string? ticker { get; set; }
            public string? weburl { get; set; }
            public string? logo { get; set; }
            public string? finnhubIndustry { get; set; }

    }

}

