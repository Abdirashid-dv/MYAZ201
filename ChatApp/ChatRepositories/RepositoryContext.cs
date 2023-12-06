using ChatEntities;
using Microsoft.EntityFrameworkCore;

namespace ChatRepositories;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions<RepositoryContext> options)
    : base(options)
    {

    }

    public DbSet<Chats> Chats { get; set; }


}
