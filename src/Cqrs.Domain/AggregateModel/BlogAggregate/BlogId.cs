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

    /// <summary>
    /// Implicitly convert <see cref="BlogId"/> to <see cref="Guid"/> when either performing an assignment or passing a <see cref="BlogId"/> as an argument
    /// whose parameter type is <see cref="BlogId"/>.
    /// </summary>
    /// <param name="blogId">The value to convert.</param>
    public static implicit operator Guid(BlogId blogId) => blogId._id;

    /// <summary>
    /// Implicitly convert <see cref="Guid"/> to <see cref="BlogId"/> when either performing an assignment or passing a <see cref="Guid"/> as an argument
    /// whose parameter type is <see cref="Guid"/>.
    /// </summary>
    /// <param name="guid"></param>
    public static implicit operator BlogId(Guid guid) => new BlogId(guid);
}
