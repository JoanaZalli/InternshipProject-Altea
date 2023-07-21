using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public List<LocalizedString> Message { get; set; } = new();

        public override string ToString() => JsonSerializer.Serialize(this);

    }
}
