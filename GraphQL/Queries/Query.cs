
public class Query(){
    
        public string HelloWorld() => "¡Hola Mundo!";

        [UseFiltering]
        [UseSorting]
        public IQueryable<ProductDto> GetProducts([Service] IProductService service){
        return service.GetProducts();
    }

}