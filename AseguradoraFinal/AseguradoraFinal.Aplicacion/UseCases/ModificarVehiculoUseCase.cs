namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class ModificarVehiculoUseCase
{
    private readonly IRepositorioVehiculo _repo;
    public ModificarVehiculoUseCase(IRepositorioVehiculo repo)
    {
        this._repo = repo;
    }
    public void Ejecutar(Vehiculo v)
    {
        _repo.ModificarVehiculo(v);
    }
}