using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.ValidationLocalization
{
    public interface IUserValidationLocalizationService
    {
        string CultureId { get; set; }
        string GetValidationMessage(string key);
    }
}
