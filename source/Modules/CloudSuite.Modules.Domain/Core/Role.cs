namespace CloudSuite.Modules.Domain;

public class Role
{
    public IList<UserRole> Users { get; set; } = new List<UserRole>();

    public Guid UserRoleId { get; private set; }

    public UserRole UserRole { get; private set; }
}
