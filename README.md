# 🚀 GraphQL + Hot Chocolate + .NET 8 Demo

Proyecto demo que muestra cómo implementar GraphQL en .NET de manera simple y efectiva. ¡Perfecto para comenzar con GraphQL!

## ✨ Características

- 📦 Configuración básica de Hot Chocolate
- 🎯 Queries y Types
- 🔍 Auto-documentación
- 🛠️ Inyección de dependencias
- 📝 Ejemplos de uso común

## 🚀 Quick Start

### Prerrequisitos
- .NET 8 SDK
- Tu IDE favorito (Visual Studio, VS Code, Rider)

### Instalación
```bash
# Clonar el repo
git clone https://github.com/jhoncastrillon9/graphql-hotchocolate-demo
cd graphql-hotchocolate-demo

# Restaurar dependencias
dotnet restore

# Ejecutar el proyecto
dotnet run
```

Visita `https://localhost:5001/graphql` para acceder a Banana Cake Pop (UI de GraphQL)

## 📋 Ejemplos incluidos

### 1. Query básica
```graphql
query {
  products {
    name
    price
  }
}
```


### 2. Definición de Types
```csharp
public class ProductType : ObjectType<ProductDto>
{
    protected override void Configure(IObjectTypeDescriptor<ProductDto> descriptor)
    {
        descriptor.Field(p => p.Id).Description("ID único del producto");
        descriptor.Field(p => p.Name).Description("Nombre del producto");
        descriptor.Field(p => p.Price).Description("Precio en USD");
    }
}
```

## 🗂️ Estructura del Proyecto

```
├── src/
    ├── GraphQL/
    │   ├── Types/          # Definiciones de GraphQL Types
    │   ├── Queries/        # Queries de GraphQL
    │   └── Extensions/     # Extensiones y configuraciones
    ├── Services/           # Servicios de la aplicación
    └── Models/             # DTOs y modelos

```

## 📚 Recursos Útiles

- [Documentación de Hot Chocolate](https://chillicream.com/docs/hotchocolate)
- [GraphQL](https://graphql.org/)
- [Ejemplos de Queries](./examples.md)

## 🤝 Contribuir

¡Las contribuciones son bienvenidas!

1. Fork el proyecto
2. Crea tu Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Push al Branch (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

## 📝 Licencia

Este proyecto está bajo la licencia MIT. Ver el archivo [LICENSE](LICENSE) para más detalles.

## ✨ Agradecimientos

- [Hot Chocolate](https://chillicream.com/) por su increíble framework
- La comunidad de .NET por su continuo apoyo

---

¿Te resultó útil? ¡Dale una ⭐️ al repo!

## 📫 Contacto

Jhon Castrillón - [@tulinkedin](https://www.linkedin.com/in/jhon-castrillon-a20540101/)

Link del Proyecto: [https://github.com/jhoncastrillon9/graphql-hotchocolate-demo](https://github.com/jhoncastrillon9/graphql-hotchocolate-demo)
