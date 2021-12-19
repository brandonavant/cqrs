namespace Cqrs.Domain.AggregateModel.BlogAggregate;

public class Blog : Entity<BlogId>, IAggregateRoot
{
    private readonly List<BlogComment> _comments;
    public string Title { get; private set;}
    public string Content { get; private set; }
    public BlogAuthor Author { get; private set; }
    public IReadOnlyCollection<BlogComment> Comments => _comments;

    private Blog (
        string title, 
        string content, 
        string authorUsername
    )
    {
        _comments = new();

        Title = title;
        Content = content;
        Author = new(authorUsername);         

        AddBlogCreatedDomainEvent();
    }

    private void AddBlogCreatedDomainEvent()
    {
        this.AddDomainEvent(new BlogCreatedDomainEvent(this));
    }
}
