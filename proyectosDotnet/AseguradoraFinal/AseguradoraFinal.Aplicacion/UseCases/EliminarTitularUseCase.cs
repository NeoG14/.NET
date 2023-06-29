namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class EliminarTitularUseCase
{
    private readonly IRepositorioTitular _repo;
    /*
    private readonly IRepositorioVehiculo _repoVehiculo;
    private readonly IRepositorioPoliza _repoPoliza;
    public EliminarTitularUseCase(IRepositorioTitular repo, IRepositorioVehiculo repoVehiculo,IRepositorioPoliza repoPoliza)
    {
        _repo = repo;
        _repoVehiculo = repoVehiculo;
        _repoPoliza = repoPoliza;
    }
    */
    public EliminarTitularUseCase(IRepositorioTitular repo)
    {
        _repo = repo;
        //_repoVehiculo = repoVehiculo;
    }
    public void Ejecutar(int id)
    {
        _repo.EliminarTitular(id);
    }
}