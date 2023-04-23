namespace Almacen.Aplicacion;

public class ObtenerProductoUseCase
{
    private readonly IRepositorioProducto _repo;
    public ObtenerProductoUseCase(IRepositorioProducto repo)
    {
        this._repo = repo;
    }

    public Producto? Ejecutar(int id)
    {
        return _repo.GetProducto(id);
    }
}