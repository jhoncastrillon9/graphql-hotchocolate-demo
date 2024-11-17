public class ProductType : ObjectType<ProductDto>{
    protected override void Configure(IObjectTypeDescriptor<ProductDto> descriptor)
    {
        descriptor.Name("Product");
        descriptor.Field(p => p.Id).Description("Id del producto");
        descriptor.Field(p => p.Name).Description("Nombre del producto");
        descriptor.Field(p => p.Price).Description("Precio en USD");    
        descriptor.Field(p => p.Description).Description("Descripción del producto");
        descriptor.Field(p => p.Category).Description("Categoría del producto");
        descriptor.Field(p => p.ImageUrl).Description("URL de la imagen del producto");
        descriptor.Field(p => p.Stock).Description("Stock disponible del producto");        
    }
}