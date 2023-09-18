using EShop.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace EShop.Infrastructure.Persistence;

public class EShopDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EShopDbContext).Assembly);
    }
}
