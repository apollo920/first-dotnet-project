using NetDevPack.Domain;

namespace CloudSuite.Modules.Domain;

public class Country : Entity, IAggregateRoot
{
    private readonly List<State> _states;

    public Country(Guid Id,string? countryName, string? code3, bool? isBillingEnable, bool? isShippingEnable, bool? isCityEnable, bool? isZipCodeEnabled, bool? isDistrictEnable)
    {
        Id = Id;
        CountryName = countryName;
        Code3 = code3;
        IsBillingEnable = isBillingEnable;
        IsShippingEnable = isShippingEnable;
        IsCityEnable = isCityEnable;
        IsZipCodeEnabled = isZipCodeEnabled;
        IsDistrictEnable = isDistrictEnable;
        _states = new List<State>();
    }

    public string? CountryName { get; private set; }

    public string? Code3 { get; private set; }

    public bool? IsBillingEnable { get; private set; }

    public bool? IsShippingEnable { get; private set;  }

    public bool? IsCityEnable { get; private set; }

    public bool? IsZipCodeEnabled { get; private set; }

    public bool? IsDistrictEnable { get; private set; }

    public IReadOnlyCollection<State> State => _states.AsReadOnly();

    public Guid StateId { get; private set; }
}
