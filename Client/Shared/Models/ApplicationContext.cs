using Landing.Client.Shared.Models;
using Microsoft.EntityFrameworkCore;
namespace Landing.Server.Models;

public class ApplicationContext : DbContext
{
    public ApplicationContext() { }

    public DbSet<Users> Users { get; set; } = null!;

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
