using NetDevPack.Domain;

namespace CloudSuite.Modules.Domain;

public class Media : Entity, IAggregateRoot
{
    public Media(Guid id,string? caption, int? fileSize, string? fileName, MediaType mediaType)
    {
        Id = id;
        Caption = caption;
        FileSize = fileSize;
        FileName = fileName;
        MediaType = mediaType;
    }

    public string? Caption { get; set; }

    public int? FileSize { get; set; }

    public string? FileName { get; set; }

    public MediaType MediaType { get; set; }
}