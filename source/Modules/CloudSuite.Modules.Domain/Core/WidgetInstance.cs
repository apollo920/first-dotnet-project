using NetDevPack.Domain;

namespace CloudSuite.Modules.Domain;

public class WidgetInstance : Entity, IAggregateRoot
{
    public WidgetInstance(string name)
    {
        CreatedOn = DateTimeOffset.Now;
        LatestUpdateOn = DateTimeOffset.Now;
        _widgetZones = new List<WidgetZone>();
        Name = name;
    }

    private readonly List<WidgetZone> _widgetZones;

    public IReadOnlyCollection<WidgetZone> WidgetZones => _widgetZones.AsReadOnly();
    public string? Name { get; private set; }

    public DateTimeOffset? CreatedOn { get; private set; }

    public DateTimeOffset? LatestUpdateOn { get; private set; }

    public DateTimeOffset? PublishStart {  get; private set; }
    
    public DateTimeOffset? PublishEnd { get; private set; }

    public string? WidgetId { get; private set; }

    public Widget Widget { get; private set; }  

    public WidgetZone WidgetZone { get; private set; }

    public Guid WidgetZoneId { get; private set; }

    public int? DisplayOrder {  get; set; }

    public string? Data { get; set; }

    public string? HtmlData { get; set; }

    public bool? IsPublished
    {
        get
        {
            return PublishStart.HasValue && PublishedStart.Value < DataTimeOffset.Now && (!Published.HasValue || PublishEnd.Value > DateTimeOffset.Now) 
        }
    }
}
    

