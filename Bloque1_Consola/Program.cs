using Bloque1_Consola.Models;
using Bloque1_Consola.Repositories;

IProductoRepository repo = new ProductoRepository();

// 1. Listado completo
Console.WriteLine("=== Lista completa de productos ===");
foreach (var producto in repo.ObtenerTodos())
{
    MostrarProducto(producto);
}

// 2. Búsqueda por ID
Console.WriteLine();
Console.WriteLine("=== Búsqueda por ID ===");
int idBuscado = 2;
var productoEncontrado = repo.ObtenerPorId(idBuscado);
if (productoEncontrado != null)
{
    Console.WriteLine($"Producto con ID {idBuscado}:");
    MostrarProducto(productoEncontrado);
}
else
{
    Console.WriteLine($"No se encontró un producto con ID {idBuscado}.");
}

int idInexistente = 99;
var productoInexistente = repo.ObtenerPorId(idInexistente);
if (productoInexistente == null)
{
    Console.WriteLine($"No se encontró un producto con ID {idInexistente}.");
}

// 3. Filtrado por categoría
Console.WriteLine();
Console.WriteLine("=== Productos de la categoría Tecnología ===");
foreach (var producto in repo.BuscarPorCategoria("Tecnología"))
{
    MostrarProducto(producto);
}

// 4. Incorporación de un producto nuevo
Console.WriteLine();
Console.WriteLine("=== Agregar un producto nuevo ===");
var productoNuevo = new Producto
{
    Id = 5,
    Nombre = "Teclado mecánico",
    Precio = 60000m,
    Categoria = "Tecnología",
    Activo = true
};
repo.Agregar(productoNuevo);
Console.WriteLine("Producto agregado. Lista actualizada:");
foreach (var producto in repo.ObtenerTodos())
{
    MostrarProducto(producto);
}

static void MostrarProducto(Producto producto)
{
    string estado = producto.Activo ? "Activo" : "Inactivo";
    Console.WriteLine($"[{producto.Id}] {producto.Nombre} - ${producto.Precio:F2} - {producto.Categoria} - {estado}");
}
