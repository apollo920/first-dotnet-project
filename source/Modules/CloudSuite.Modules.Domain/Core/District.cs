using NetDevPack.Domain;

namespace CloudSuite.Modules.Domain;

public class District : Entity, IAggregateRoot
{
    private readonly List<State> _states;

    public District(Guid id,string? name, string? type, string? location)
    {
        Id = id;
        _states = new List<State>();
        Name = name;
        Type = type;
        Location = location;
    }

    public State State { get; set; }

    public Guid StateId { get; private set; }

    public string? Name { get; private set; }

    public string? Type { get; private set; }

    public string? Location { get; private set; }

}