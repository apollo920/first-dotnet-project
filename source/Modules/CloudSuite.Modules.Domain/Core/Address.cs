using NetDevPack.Domain;

namespace CloudSuite.Modules.Domain;

public class Address : Entity, IAggregateRoot
{
    private readonly List<District> _districts = new List<District>();

    private readonly List<City> _cities = new List<City>();
    
    public Address (Guid id)
    {
        Id= id;
        _districts = new List<District>();
        _cities = new List<City>();
    }
    public string? ContactName { get; private set; }

    public String? AddressLine1 { get; private set; }

    public City City { get; private set; }

    public District District { get; private set; }

    public Guid DistrictId { get; private set; }

    public IReadOnlyCollection<City> Cities => _cities.AsReadOnly();

    public IReadOnlyCollection<District> Disctrict => _districts.AsReadOnly();

}
