namespace Aseguradora.Aplicacion;

public class ModificarTitularUseCase
{
    private readonly IRepositorioTitular _repo;
    public ModificarTitularUseCase(IRepositorioTitular repo)
    {
        this._repo = repo;
    }
    public void Ejecutar(string dni)
    {
        _repo.ModificarTitular(dni);
    }
}