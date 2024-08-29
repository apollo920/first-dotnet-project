using NetDevPack.Domain;

namespace CloudSuite.Modules.Domain;

public class WidgetZone : Entity, IAggregateRoot
{
    public WidgetZone(Guid id,string? name, string? description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public string? Name { get; set; }

    public string? Description { get; set; }

}
