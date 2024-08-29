using NetDevPack.Domain;

namespace CloudSuite.Modules.Domain;

public class State : Entity, IAggregateRoot
{
    private readonly List<Country> _countries;
    public State(Guid id,string? uF, string statename)
    {
        Id = id;
        _countries = new List<Country>();
        UF = uF;
        StateName = statename;
    }
    public State() { }

   public string? StateName { get; private set; }

   public string? UF { get; private set; }

   public Country Country { get; set; }

   public Guid CountryId { get; private set; }

   public IReadOnlyCollection<Country> Countries => _countries.AsReadOnly();
}
