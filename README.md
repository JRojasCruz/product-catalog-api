# Product Catalog API (.NET 8)

API REST desarrollada en ASP.NET Core 8 con Entity Framework Core InMemory.

Está hecho con .NET 8 usando una base de datos en memoria (InMemory), lo cual hace que sea muy fácil de ejecutar sin necesidad de instalar nada adicional.
Usé la nueva forma de trabajar con APIs mínimas (MapGet, MapPost, etc.) para mantener todo en un solo archivo (Program.cs), ideal para proyectos pequeños.
Toda la lógica se mantiene clara y concentrada:

    Models/ tiene el modelo Product

    Data/ contiene la configuración del contexto de EF Core

Se incluyen validaciones básicas (como campos obligatorios y precios mayores a cero).
Swagger está activado para que se pueda probar fácilmente la API desde el navegador. 

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
