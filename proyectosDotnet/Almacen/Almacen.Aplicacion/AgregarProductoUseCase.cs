namespace Almacen.Aplicacion;  

public class AgregarProductoUseCase   
{
    private readonly IRepositorioProducto _repo;
    public AgregarProductoUseCase(IRepositorioProducto repo)
    {
        this._repo = repo;
    }
    public void Ejecutar(Producto producto)
    {
        _repo.AgregarProducto(producto);
    }
}