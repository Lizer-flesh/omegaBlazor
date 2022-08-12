using Microsoft.EntityFrameworkCore;
namespace Landing.Server;

public class ApplicationContext : DbContext
{
    public ApplicationContext() { }

    public DbSet<User> User { get; set; }
    public DbSet<Cart> Cart { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // if (!optionsBuilder.IsConfigured)
        {
            //    optionsBuilder.EnableSensitiveDataLogging();
        }
    }

    

}
