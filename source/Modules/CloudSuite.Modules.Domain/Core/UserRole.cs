using NetDevPack.Domain;

namespace CloudSuite.Modules.Domain;

public class UserRole : Entity, IAggregateRoot
{
    public virtual User User {get; set;}

    public Guid UserId {get; private set;}
    
    public virtual Role Role {get; set;}

    public Guid RoleId {get; private set;}
}

