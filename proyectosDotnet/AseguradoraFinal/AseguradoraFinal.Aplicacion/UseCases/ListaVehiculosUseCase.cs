namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class ListarVehiculosUseCase
{
    private readonly IRepositorioVehiculo _repo;
    public ListarVehiculosUseCase(IRepositorioVehiculo repo)
    {
        _repo = repo;
    }
    public List<Vehiculo> Ejecutar()
    {
       return _repo.ListarVehiculos();
    }
}