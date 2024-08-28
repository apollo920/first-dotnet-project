using NetDevPack.Domain;

namespace CloudSuite.Modules.Domain;

public class AppSettings : Entity, IAggregateRoot
{
    public AppSettings(Guid id)
    {
        Id = id;
    }
    public string? Value { get; private set; }
    public string? Module { get; private set; }

    public bool? IsVisibleIncommonSettingsPage { get; private set; }
}
