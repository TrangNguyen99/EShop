using ErrorOr;
using EShop.Application.Common.Interfaces.Persistance;
using EShop.Domain.Products;
using MediatR;

namespace EShop.Application.Products.Commands.CreateProduct;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ErrorOr<Product>>
{
    private readonly IProductRepository _productRepository;

    public CreateProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<ErrorOr<Product>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = Product.Create(request.Name, request.Description);
        await _productRepository.Add(product);
        return product;
    }
}
