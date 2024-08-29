using NetDevPack.Domain;

namespace CloudSuite.Modules.Domain;

public class Widget : Entity, IAggregateRoot
{
    public Widget(string? name, string? viewComponentName, string? createUrl, string? editUrl, DateTimeOffset? createOn, bool? isPublished)
    {
        Name = name;
        ViewComponentName = viewComponentName;
        CreateUrl = createUrl;
        EditUrl = editUrl;
        CreateOn = createOn;
        IsPublished = isPublished;
    }

    public string? Name { get; private set; }
    public string? ViewComponentName { get; private set; }

    public string? CreateUrl { get; private set; }

    public string? EditUrl { get; private set; }

    public DateTimeOffset? CreateOn { get; private set; }

    public bool? IsPublished { get; set; }

}
