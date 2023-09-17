using ErrorOr;
using EShop.Domain.Products;
using MediatR;

namespace EShop.Application.Products.Commands.CreateProduct;

public record CreateProductCommand(
    string Name,
    string Description) : IRequest<ErrorOr<Product>>;
