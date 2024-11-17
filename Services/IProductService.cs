public interface IProductService{
    IQueryable<ProductDto> GetProducts();
}