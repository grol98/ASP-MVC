using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ASP_MVC.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Order> Orders { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }    
}
