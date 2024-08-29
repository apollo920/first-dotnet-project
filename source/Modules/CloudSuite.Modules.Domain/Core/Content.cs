using NetDevPack.Domain;

namespace CloudSuite.Modules.Domain;

public class Content : Entity, IAggregateRoot
{
    public abstract class Content
    {
        private bool isDelete;

        protected Content(long? createById,User createdBy,DateTimeOffset? createOn,
            DateTimeOffset? latestUpdatedOn,long? latestUpdatedById,
            User latestUpdateBy,string? name, string? slug)
        {
            CreatedById = createById;
            CreatedBy = createdBy;
            CreatedOn = DateTimeOffset.Now;
            LatestUpdatedOn = DateTimeOffset.Now;
            LatestUpdatedById = latestUpdatedById;
            LatestUpdatedById = latestUpdatedById;
            Name = name;
            Slug = slug;
        }

        public string? Name { get; private set; }

        public string? Slug { get; private set; }

        public string? MetaTitle { get; private set; }

        public bool? IsPublished { get; private set; }

        public DateTimeOffset? PublisheOn { get; private set; }

        public bool IsDeleted { get; private set; }
    }

}
