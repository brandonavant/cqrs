namespace Cqrs.Domain.AggregateModel.BlogAggregate;

public class BlogAuthor : Entity<Guid>
{
    public string Username { get; set; }

    public BlogAuthor(string username)
    {
        if (string.IsNullOrEmpty(username) || username.Length < 2 || username.Length > 16)
        {
            throw new BlogDomainException("Invalid username. User name must be between 2 and 16 characters.");
        }

        Username = username;
    }
}
