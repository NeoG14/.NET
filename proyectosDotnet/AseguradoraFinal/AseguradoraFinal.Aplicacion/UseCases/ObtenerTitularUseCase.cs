namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class ObtenerTitularUseCase
{
    private readonly IRepositorioTitular _repo;
    public ObtenerTitularUseCase(IRepositorioTitular repo)
    {
        this._repo = repo;
    }
    public Titular? Ejecutar(int id)
    {
        return _repo.GetTitular(id);
    }
}