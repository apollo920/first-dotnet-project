using NetDevPack.Domain;

namespace CloudSuite.Modules.Domain;

public class City : Entity, IAggregateRoot
{
    private readonly List<State> _states;
    public City(Guid id) 
    {
        Id = Id;
        _states = new List<State>();
    }

    public City() { }
    public string? CityName { get; private set; }

    public IReadOnlyCollection<State> State => _states.AsReadOnly();

    public State State {  get; private set; }

    public Guid StateId { get; private set; }
}
