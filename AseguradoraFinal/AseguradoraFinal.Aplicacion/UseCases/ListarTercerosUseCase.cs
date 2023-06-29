namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class ListarTercerosUseCase
{
    private readonly IRepositorioTercero _repo;
    public ListarTercerosUseCase(IRepositorioTercero repo)
    {
        _repo = repo;
    }
    public List<Tercero> Ejecutar()
    {
       return _repo.ListarTerceros();
    }
}