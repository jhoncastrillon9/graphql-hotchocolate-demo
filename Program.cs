var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services
    .AddGraphQLServer()
    .AddType<ProductType>()
    .AddQueryType<Query>()     
    .AddFiltering()
    .AddSorting();
var app = builder.Build();

app.MapGraphQL("/graphql");

app.UseHttpsRedirection();

app.Run();


