using EShop.Application.Common.Interfaces.Persistance;
using EShop.Domain.Products;

namespace EShop.Infrastructure.Persistence.Repositories;

public class ProductRepository : IProductRepository
{
    public async Task Add(Product product)
    {
        await Task.CompletedTask;
    }
}
