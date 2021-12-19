namespace Cqrs.Domain.Events;

public class BlogCreatedDomainEvent : INotification
{
    public Blog Blog { get; }

    public BlogCreatedDomainEvent(Blog blog)
    {
        Blog = blog;
    }
}
