namespace Almacen.Aplicacion;

public class ListarProductosUseCase 
{
    private readonly IRepositorioProducto _repo;

    public ListarProductosUseCase(IRepositorioProducto repo)
    {
        _repo = repo;
    }

    public List<Producto> Ejecutar()
    {
        return _repo.ListarProductos();
    }
}