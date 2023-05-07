namespace Aseguradora.Aplicacion;

public class ListarTitularesConSusVehiculosUseCase
{
    private readonly IRepositorioTitular _repo;
    private readonly IRepositorioVehiculo _repoVehiculo;
    public ListarTitularesConSusVehiculosUseCase(IRepositorioTitular repo, IRepositorioVehiculo repoVehiculo)
    {
        _repo = repo;
        _repoVehiculo = repoVehiculo;
    }
    
    public List<Titular> Ejecutar()
    {
        return _repo.ListarTitularesConSusVehiculos(_repo.ListarTitulares(),_repoVehiculo.ListarVehiculos());
    }
    
}