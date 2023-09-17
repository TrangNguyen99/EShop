using EShop.Domain.Products;

namespace EShop.Application.Common.Interfaces.Persistance;

public interface IProductRepository
{
    Task Add(Product product);
}
