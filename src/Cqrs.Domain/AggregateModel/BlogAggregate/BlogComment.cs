namespace Cqrs.Domain.AggregateModel.BlogAggregate;

public class BlogComment : Entity<Guid>
{
    public string CommentorUsername { get; }

    public BlogComment(string commentorUsername)
    {
        CommentorUsername = commentorUsername;
    }
}
