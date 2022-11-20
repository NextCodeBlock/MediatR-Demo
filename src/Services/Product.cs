namespace MediatRDemo.Services;

public class Product
{
    public Guid Id { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.Now;
}