using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Prefix
    {
        
            public int Id { get; set; }

            [JsonPropertyName("code")]
            public string Country_Code { get; set; }

            [JsonPropertyName("prefix")]
            public string Country_Prefix { get; set; }

            [JsonPropertyName("name")]
            public string Country_Name { get; set; }
        
    }
}
