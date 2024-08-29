using NetDevPack.Domain;

namespace CloudSuite.Modules.Domain;

public class Vendor : Entity, IAggregateRoot
{
    public Vendor() { }

    public Vendor(Guid id,string name,string? slug, string? description, Cnpj cnpj, Guid cnpjId, Email email, Guid emailId, DateTimeOffset? createdOn, DateTimeOffset? latestupdateon, bool? isActive, bool? isDeleted)
    {
        Id = id;
        Name = name;
        Slug = slug;
        Description = description;
        Cnpj = cnpj;
        Email = email;
        CreatedOn = createdOn;
        LatestUpdateOn = latestupdateon;
        IsActive = isActive;
        IsDeleted = isDeleted;
    }

    public string Name { get; private set; }

    public string? Slug { get; private set; }
    
    public string Description { get; private set; }

    public Cnpj Cnpj { get; private set; }

    public Guid CnpjId { get; private set; }

    public Email Email { get; private set; }

    public Guid EmailId { get; private set; }

    public DateTimeOffset? CreatedOn { get; private set; }

    public DateTimeOffset? LatestUpdateOn { get; private set; }

    public bool? IsActive { get; private set; }

    public bool? IsDeleted { get; private set; }

    public IList<User> Users { get; set; } = new List<User>();

    public User user { get; private set; }

    public Guid UserId { get; private set; }


}

