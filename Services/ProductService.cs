using AutoBogus;

public class ProductService : IProductService
{
    public IQueryable<ProductDto> GetProducts()
    {
        return GetProductsFaker();
    }

    private IQueryable<ProductDto> GetProductsFaker()
    {
        var categories = new[] { "Office", "House", "TI", "Books" };

        var products = new AutoFaker<ProductDto>()
            .RuleFor(p => p.Id, f => f.IndexFaker)
            .RuleFor(p => p.Category, f => f.PickRandom(categories))
            .RuleFor(p => p.Price, f => f.Random.Decimal(1000, 99000))
            .Generate(30);

        return products.AsQueryable();

    }
}