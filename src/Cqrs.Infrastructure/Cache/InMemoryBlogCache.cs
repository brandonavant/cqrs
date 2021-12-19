namespace Cqrs.Infrastructure.Cache;

public class InMemoryBlogCache : ConcurrentDictionary<BlogId, Blog> { }