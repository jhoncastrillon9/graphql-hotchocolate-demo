### Retornar todos los productos filtrados por category
```graphql
query {
  products(where: { category: { eq: "Office" } }) {
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