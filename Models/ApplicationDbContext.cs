using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext 
{
    public DbSet<Customer> Customers { get; set; }

    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()
            .Property(b => b.id)
            .IsRequired();
        
        modelBuilder.Entity<Customer>().HasData(
            new Customer {
                id = 1,
                name = "John Galt",
                email = "j.galt@gmail.com",
                phone = "800-444-5555"
            },
            new Customer {
                id = 2,
                name = "Dagny Taggart",
                email = "dagny.taggart@taggartrail.com",
                phone = "888-555-4444"
            }
        );
    }
}