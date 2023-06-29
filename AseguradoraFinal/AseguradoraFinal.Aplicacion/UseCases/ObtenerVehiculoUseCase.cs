namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class ObtenerVehiculoUseCase
{
    private readonly IRepositorioVehiculo _repo;
    public ObtenerVehiculoUseCase(IRepositorioVehiculo repo)
    {
        this._repo = repo;
    }
    public Vehiculo? Ejecutar(int id)
    {
        return _repo.GetVehiculo(id);
    }
}