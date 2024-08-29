using NetDevPack.Domain;

namespace CloudSuite.Modules.Domain;

public class Company : Entity, IAggregateRoot
{
    public Company(Guid Id,Cnpj cnpj, Guid cnpjId, string? fantasyName, string? registerName, Address address, Guid addressId)
    {
        Id = Id;
        Cnpj = cnpj;
        CnpjId = cnpjId;
        FantasyName = fantasyName;
        RegisterName = registerName;
        Address = address;
        AddressId = addressId;
    }

    public Cnpj Cnpj { get; private set; }

    public Guid CnpjId { get; private set; }

    public String? FantasyName { get; private set; }

    public string? RegisterName { get; private set; }

    public  Address Address { get; private set; }

    public Guid AddressId { get; private set; }
}
