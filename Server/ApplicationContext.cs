using Microsoft.EntityFrameworkCore;
namespace Landing;

public class ApplicationContext : DbContext
{
    public DbSet<Users> Users { get; set; }

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
