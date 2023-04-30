namespace Aseguradora.Aplicacion;

public class EliminarTitularUseCase
{
    private readonly IRepositorioTitular _repo;
    private readonly IRepositorioVehiculo _repoVehiculo;
    private readonly IRepositorioPoliza _repoPoliza;
    public EliminarTitularUseCase(IRepositorioTitular repo, IRepositorioVehiculo repoVehiculo,IRepositorioPoliza repoPoliza)
    {
        _repo = repo;
        _repoVehiculo = repoVehiculo;
        _repoPoliza = repoPoliza;
    }
    public void Ejecutar(int id)
    {
        _repo.EliminarTitular(id);
        
        List<int>? vehiculos = _repoVehiculo.IdVehiculos(id);
        if(vehiculos!=null){
            foreach(int idV in vehiculos)
            {
                _repoPoliza.EliminarPolizasVehiculo(idV);
            }
        }
        _repoVehiculo.EliminarVehiculosTitular(id);
            
    }
}