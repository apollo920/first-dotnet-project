namespace CloudSuite.Modules.Domain;

public class ThemeManifest
{
    public ThemeManifest(string? name, string? fullName, string? displayName, string? version)
    {
        Name = name;
        FullName = fullName;
        DisplayName = displayName;
        Version = version;
    }

    public string? Name { get; private set; }

    public string? FullName { get; private set; }

    public string? DisplayName { get; private set; }

    public string? Version { get; private set; }
}
