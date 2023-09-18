using EShop.Domain.Products;
using FluentValidation;

namespace EShop.Application.Products.Commands.CreateProduct;

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(Product.MAX_NAME_LENGTH);
        RuleFor(x => x.Description).NotEmpty();
    }
}
