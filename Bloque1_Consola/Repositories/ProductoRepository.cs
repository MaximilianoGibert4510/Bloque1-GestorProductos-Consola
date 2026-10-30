using Bloque1_Consola.Models;

namespace Bloque1_Consola.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly List<Producto> _productos;

        public ProductoRepository()
        {
            // Datos de prueba (seed data)
            _productos = new List<Producto>
            {
                new Producto { Id = 1, Nombre = "Notebook", Precio = 850000m, Categoria = "Tecnología", Activo = true },
                new Producto { Id = 2, Nombre = "Mouse inalámbrico", Precio = 15000m, Categoria = "Tecnología", Activo = true },
                new Producto { Id = 3, Nombre = "Silla de oficina", Precio = 120000m, Categoria = "Muebles", Activo = true },
                new Producto { Id = 4, Nombre = "Lámpara de escritorio", Precio = 25000m, Categoria = "Hogar", Activo = false }
            };
        }

        public void Agregar(Producto producto)
        {
            _productos.Add(producto);
        }

        public List<Producto> ObtenerTodos()
        {
            return _productos.ToList();
        }

        public Producto? ObtenerPorId(int id)
        {
            return _productos.FirstOrDefault(p => p.Id == id);
        }

        public List<Producto> BuscarPorCategoria(string categoria)
        {
            return _productos
                .Where(p => p.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
