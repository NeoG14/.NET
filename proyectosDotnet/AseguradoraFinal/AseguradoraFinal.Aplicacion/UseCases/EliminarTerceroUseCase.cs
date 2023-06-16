namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class EliminarTerceroUseCase
{
    private readonly IRepositorioTercero _repo;
    public EliminarTerceroUseCase(IRepositorioTercero repo)
    {
        _repo = repo;
    }

    public void Ejecutar(int id)
    {
        _repo.EliminarTercero(id);
    }
}