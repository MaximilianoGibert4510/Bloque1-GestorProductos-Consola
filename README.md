# Práctico Bloque 1 — Gestor de Productos en Consola

Aplicación de consola en C# (.NET 10) que gestiona productos en memoria usando POO, interfaces, `List<T>` y LINQ.

## Requisitos

- [.NET SDK 10](https://dotnet.microsoft.com/download)

## Estructura

```
Productos.slnx
Bloque1_Consola/
├── Models/Producto.cs                      Entidad Producto
├── Repositories/IProductoRepository.cs     Contrato del repositorio
├── Repositories/ProductoRepository.cs      Implementación en memoria (List<Producto> + LINQ)
└── Program.cs                              Demostración de las operaciones
```

## Cómo ejecutarlo

```bash
git clone <URL-del-repositorio>
cd <carpeta-del-repositorio>
dotnet run --project Bloque1_Consola
```

## Qué muestra el programa

1. Listado completo de productos.
2. Búsqueda de un producto por ID (uno existente y uno inexistente).
3. Filtrado de productos por categoría.
4. Incorporación de un producto nuevo con `Agregar(...)` y listado actualizado.
