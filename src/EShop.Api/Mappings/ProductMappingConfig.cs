using EShop.Application.Products.Commands.CreateProduct;
using EShop.Contracts.Products;
using EShop.Domain.Products;
using Mapster;

namespace EShop.Api.Mappings;

public class ProductMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<CreateProductRequest, CreateProductCommand>();

        config.NewConfig<Product, ProductResponse>()
            .Map(dest => dest.Id, src => src.Id.Value.ToString());
    }
}
