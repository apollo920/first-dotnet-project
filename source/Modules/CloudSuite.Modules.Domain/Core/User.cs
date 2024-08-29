using NetDevPack.Domain;

namespace CloudSuite.Modules.Domain;

public class User : Entity, IAggregateRoot
{
    private readonly List<Vendor> _vendors;


    public User(string? fullName, Email email, Cpf cpf, Telephone telephone, Vendor vendor, bool? isDeleted, DateTimeOffset? createdOn, DateTimeOffset? lastestUpdatedOn, string? culture, string? extensionData)
    {
        FullName = fullName;
        Email = email;
        Cpf = cpf;
        Telephone = telephone;
        Vendor = vendor;
        IsDeleted = isDeleted;
        CreatedOn = createdOn;
        LastestUpdatedOn = lastestUpdatedOn;
        Culture = culture;
        ExtensionData = extensionData;
        CreatedOn = DateTimeOffset.Now;
        LastestUpdatedOn = DateTimeOffset.Now;
        _vendors = new List<Vendor>();
    }

    public User() { }

    public const string SettingsDataKey = "Settings";

    public Guid UserGuid { get; set; }  

    public string? FullName { get; private set; }

    public Email Email { get; private set; }

    public Cpf Cpf { get; private set; }

    public Telephone Telephone { get; private set; }

    public Vendor Vendor { get; private set; }

    public bool? IsDeleted { get; private set; }

    public DateTimeOffset? CreatedOn { get; private set; }

    public DateTimeOffset? LastestUpdatedOn { get; private set; }

    public string? Culture { get; private set; }

    public string? ExtensionData { get; private set; }

    public IReadOnlyCollection<Vendor> Vendors => _vendors.AsReadOnly();

    public Guid VendorId { get; private set; }

    public IList<UserRole> Roles { get; set; } = new List<UserRole>();
}
