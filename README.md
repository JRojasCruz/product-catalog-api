# Product Catalog API (.NET 8)

API REST desarrollada en ASP.NET Core 8 con Entity Framework Core InMemory.

## Funcionalidad

- Listar productos: `GET /api/products`
- Ver detalle de producto: `GET /api/products/{id}`
- Crear producto: `POST /api/products`

## Validaciones

- `Name` y `Category` son requeridos
- `Price` debe ser mayor a 0

## Tecnologías

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core (InMemory)
- Swagger (OpenAPI)
- CORS habilitado para frontend

## Ejecutar el proyecto
dotnet run
swagger: http://localhost:5249/swagger

<img width="1854" height="552" alt="image" src="https://github.com/user-attachments/assets/91d7b6d3-514f-4578-9d41-6ab8d8545530" />
