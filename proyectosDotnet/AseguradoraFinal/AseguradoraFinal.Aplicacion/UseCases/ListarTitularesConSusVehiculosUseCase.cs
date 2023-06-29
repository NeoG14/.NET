namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class ListarTitularesConSusVehiculosUseCase
{
    private readonly IRepositorioTitular _repo;
    //private readonly IRepositorioVehiculo _repoVehiculo;
    public ListarTitularesConSusVehiculosUseCase(IRepositorioTitular repo)
    {
        _repo = repo;
    }
    public List<Vehiculo> Ejecutar(int id)
    {
       return _repo.ListarTitularesConSusVehiculos(id);
    }
}