namespace Aseguradora.Aplicacion;

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