using Bloque1_Consola.Models;

namespace Bloque1_Consola.Repositories
{
    public interface IProductoRepository
    {
        void Agregar(Producto producto);
        List<Producto> ObtenerTodos();
        Producto? ObtenerPorId(int id);
        List<Producto> BuscarPorCategoria(string categoria);
    }
}
