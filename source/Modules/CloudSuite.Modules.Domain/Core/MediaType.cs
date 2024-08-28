using NetDevPack.Domain;

namespace CloudSuite.Modules.Domain;

public class MediaType : Entity, IAggregateRoot
{
        Image = 1,

        File = 5,

        Video = 10, 
}
