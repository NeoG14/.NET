namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class ObtenerTerceroUseCase
{
    private readonly IRepositorioTercero _repo;
    public ObtenerTerceroUseCase(IRepositorioTercero repo)
    {
        this._repo = repo;
    }
    public Tercero? Ejecutar(int id)
    {
        return _repo.GetTercero(id);
    }
}