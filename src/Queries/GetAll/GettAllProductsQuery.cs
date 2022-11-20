using MediatR;
using MediatRDemo.Services;

namespace MediatRDemo.Queries.GetAll;

public class GetAllProductsQuery : IRequest<IEnumerable<Product>> { }

internal class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
{
    private readonly IProductService _productService;

    public GetAllProductsQueryHandler(IProductService productService) => _productService = productService;

    public Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken) 
        => Task.FromResult(_productService.GetProducts());
}