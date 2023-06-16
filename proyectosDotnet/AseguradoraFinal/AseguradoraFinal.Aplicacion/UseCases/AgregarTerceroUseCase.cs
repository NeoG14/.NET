namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class AgregarTerceroUseCase
{
    private readonly IRepositorioTercero _repo;
    public AgregarTerceroUseCase(IRepositorioTercero repo)
    {
        _repo = repo;
    }
    public void Ejecutar(Tercero tercero)
    {
        _repo.AgregarTercero(tercero);
    }
}