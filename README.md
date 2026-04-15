# ToDo API - ASP.NET Core

API REST desarrollada con ASP.NET Core para la gestión de tareas.

## Funcionalidades

- CRUD completo de tareas.
- Conexión a base de datos SQL Server.
- Uso de Entity Framework Core.
- Documentación con Swagger.
- Exportación de tareas a PDF.

## Tecnologías utilizadas

- C#
- ASP.NET Core
- Entity Framework
- SQL Server

## Cómo ejecutar

1. Clonar repositorio
2. Configurar cadena de conexión en appsettings.json
3. Ejecutar migraciones:
   dotnet ef database update
4. Ejecutar:
   dotnet run

## Endpoints principales

- GET /api/ToDoItems
- POST /api/ToDoItems
- PUT /api/ToDoItems/{id}
- DELETE /api/ToDoItems/{id}
- GET /api/ToDoItems/export/pdf
