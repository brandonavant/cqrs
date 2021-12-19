namespace Cqrs.Domain.AggregateModel.BlogAggregate;

public record BlogId
{
    private readonly Guid _id;

    public BlogId(Guid blogId)
    {
        if (blogId == Guid.Empty)
        {
            throw new BlogDomainException("The blog id must be a non-empty Guid value.");
        }

        _id = blogId;
    }

    public static implicit operator Guid(BlogId blogId) => blogId._id;
}
