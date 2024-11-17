### Retornar todos los productos filtrados por category y ordenados por description
```graphql
query {
  products(where: { category: { eq: "Office" } }, order: { description: DESC }) {
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