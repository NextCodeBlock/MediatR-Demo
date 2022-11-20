namespace MediatRDemo.Services;

public interface IProductService
{
    IEnumerable<Product> GetProducts();
    Product GetById(Guid id);
}