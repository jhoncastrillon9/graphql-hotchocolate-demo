### Retornar todos los productos con todos los campos
```graphql
query {
  products {
    category
    description
    id
    name
    imageUrl
    stock
    price
  }
}
```