using EShop.Domain.Common.Models;

namespace EShop.Domain.Products.Events;

public record ProductCreated(Product Product) : IDomainEvent;
