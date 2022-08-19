using Microsoft.EntityFrameworkCore;
using Landing.Shared.Entities;
namespace Landing.Server.DAL.Core;

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
