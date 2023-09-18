using EShop.Application.Common.Interfaces.Persistence;
using EShop.Domain.Products;

namespace EShop.Infrastructure.Persistence.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly EShopDbContext _dbContext;

    public ProductRepository(EShopDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Add(Product product)
    {
        _dbContext.Products.Add(product);
        await _dbContext.SaveChangesAsync();
    }
}
