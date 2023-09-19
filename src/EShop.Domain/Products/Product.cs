using EShop.Domain.Common.Models;
using EShop.Domain.Products.Events;
using EShop.Domain.Products.ValueObjects;

namespace EShop.Domain.Products;

public sealed class Product : AggregateRoot<ProductId, Guid>
{
    public const int MAX_NAME_LENGTH = 100;

    public string Name { get; private set; }
    public string Description { get; private set; }

    private Product(
        ProductId productId,
        string name,
        string description) : base(productId)
    {
        Name = name;
        Description = description;
    }

    public static Product Create(
        string name,
        string description)
    {
        var product = new Product(
            ProductId.Create(),
            name,
            description);

        product.AddDomainEvent(new ProductCreated(product));

        return product;
    }

#pragma warning disable CS8618
    private Product()
    {
    }
#pragma warning restore CS8618
}
