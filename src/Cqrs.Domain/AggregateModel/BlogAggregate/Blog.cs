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

        Id = Guid.NewGuid();
        Title = title;
        Content = content;
        Author = new(authorUsername);         

        AddBlogCreatedDomainEvent();
    }

    public static Blog CreateBlog(string title, string content, string authorUsername)
    {
        if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(content) || string.IsNullOrEmpty(authorUsername))
        {
            throw new ArgumentException("You must provide a valid title, content, and author's user name.");
        }

        return new Blog(title, content, authorUsername);
    }

    private void AddBlogCreatedDomainEvent()
    {
        this.AddDomainEvent(new BlogCreatedDomainEvent(this));
    }
}
