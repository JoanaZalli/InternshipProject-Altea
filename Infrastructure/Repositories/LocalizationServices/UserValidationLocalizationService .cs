using Application.Contracts.ValidationLocalization;
using Microsoft.Extensions.Localization;
using System.Globalization;

public class UserValidationLocalizationService : IUserValidationLocalizationService
{
    private readonly IStringLocalizerFactory _localizerFactory;

    public UserValidationLocalizationService(IStringLocalizerFactory localizerFactory)
    {
        _localizerFactory = localizerFactory;
    }

    public string CultureId { get; set; }

    public string GetValidationMessage(string key)
    {
        var culture = new CultureInfo(CultureId);
        var localizer = _localizerFactory.Create(nameof(UserValidationLocalizationService), culture.Name);
        return localizer[key];
    }
}
