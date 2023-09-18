using EShop.Domain.Products;

namespace EShop.Application.Common.Interfaces.Persistence;

public interface IProductRepository
{
    Task Add(Product product);
}
