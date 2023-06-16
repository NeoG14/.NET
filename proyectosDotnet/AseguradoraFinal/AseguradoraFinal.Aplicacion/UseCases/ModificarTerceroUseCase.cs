namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class ModificarTerceroUseCase
{
    private readonly IRepositorioTercero _repo;
    public ModificarTerceroUseCase(IRepositorioTercero repo)
    {
        this._repo = repo;
    }
    public void Ejecutar(Tercero t)
    {
        _repo.ModificarTercero(t);
    }
}