namespace Aseguradora.Aplicacion;

public class EliminarVehiculoUseCase
{
    private readonly IRepositorioVehiculo _repo;
    private readonly IRepositorioPoliza _repoPoliza;

    public EliminarVehiculoUseCase(IRepositorioVehiculo repo, IRepositorioPoliza repoPoliza)
    {
        _repo = repo;
        _repoPoliza = repoPoliza;
    }

    public void Ejecutar(int id)
    {
        _repo.EliminarVehiculo(id);
        _repoPoliza.EliminarPolizasVehiculo(id);
    }
}