using EShop.Application.Products.Commands.CreateProduct;
using EShop.Contracts.Products;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Api.Controllers;

[Route("[controller]")]
public class ProductsController : ApiController
{
    private readonly IMapper _mapper;
    private readonly ISender _sender;

    public ProductsController(IMapper mapper, ISender sender)
    {
        _mapper = mapper;
        _sender = sender;
    }

    [HttpPost]
    public async Task<IActionResult> CreateProductAsync(CreateProductRequest request)
    {
        var command = _mapper.Map<CreateProductCommand>(request);
        var result = await _sender.Send(command);
        return result.Match(product => Ok(_mapper.Map<ProductResponse>(product)), Problem);
    }
}
