using Microsoft.EntityFrameworkCore;
namespace Landing.Server.Models;

public class ApplicationContext : DbContext
{
    public ApplicationContext() { }

    public DbSet<User> User { get; set; }
    public DbSet<Cart> Cart { get; set; } 

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }
}
