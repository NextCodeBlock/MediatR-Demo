namespace MediatRDemo.Services;

public class ProductService: IProductService
{
    private readonly List<Product> _products;

    public ProductService()
    {
        _products = new(){
            new Product
            {
                Id = Guid.Parse("9743ea71-b19a-4477-b6e9-30a50614115d"),
                ProductName = "Windows 11 Professional",
                Price = 200,
                Category = "OS"
            },
            new Product
            {
                Id = Guid.Parse("1a6053f9-5752-46b5-8989-4b851dd84d0b"),
                ProductName = "Visual Studio 2022 Enterprise",
                Price = 3000,
                Category = "IDE"
            },
            new Product
            {
                Id = Guid.Parse("e649777c-7433-4363-9cdf-88f92e006560"),
                ProductName = "VSCode",
                Price = 0,
                Category = "IDE"
            }
        };
    }

    public IEnumerable<Product> GetProducts() => _products.AsEnumerable();

    public Product GetById(Guid id) => _products.FirstOrDefault(p => p.Id == id);
}