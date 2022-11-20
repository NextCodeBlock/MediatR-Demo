using MediatR;
using MediatRDemo.Services;

namespace MediatRDemo.Queries.GetById;

public class GetProductByIdQuery : IRequest<Product>
{
    public Guid Id { get; set; }

    public GetProductByIdQuery(Guid id)
    {
        Id = id;
    }
}

internal class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
{
    private readonly IProductService _productService;

    public GetProductByIdQueryHandler(IProductService productService) => _productService = productService;
    
    public Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken) 
        => Task.FromResult(_productService.GetById(request.Id));
}