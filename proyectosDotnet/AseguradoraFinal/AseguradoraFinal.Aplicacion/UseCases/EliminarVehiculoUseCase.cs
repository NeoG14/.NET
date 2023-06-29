namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class EliminarVehiculoUseCase
{
    private readonly IRepositorioVehiculo _repo;
    //private readonly IRepositorioPoliza _repoPoliza;

    public EliminarVehiculoUseCase(IRepositorioVehiculo repo)
    {
        _repo = repo;
        //_repoPoliza = repoPoliza;
    }

    public void Ejecutar(int id)
    {
        _repo.EliminarVehiculo(id);
        
    }
}