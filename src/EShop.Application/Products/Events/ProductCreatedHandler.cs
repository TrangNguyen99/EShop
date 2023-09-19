using EShop.Domain.Products.Events;
using MediatR;

namespace EShop.Application.Products.Events;

public class ProductCreatedHandler : INotificationHandler<ProductCreated>
{
    public Task Handle(ProductCreated notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Product {notification.Product.Name} created");

        return Task.CompletedTask;
    }
}
