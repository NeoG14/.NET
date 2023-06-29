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
        //_repoVehiculo.EliminarVehiculosTitular(id);
    /*
        var EliminarVehiculo = new EliminarVehiculoUseCase(_repoVehiculo,_repoPoliza);
        List<int>? idVehiculos = _repoVehiculo.IdVehiculos(id);
        if(idVehiculos!=null){
            foreach(int idV in idVehiculos)
            {
                EliminarVehiculo.Ejecutar(idV);
            }
        }
    */
        
        
        
        /*
        List<int>? idVehiculos = _repoVehiculo.IdVehiculos(id);
        List<int>? idPolizas = _repoVehiculo.IdVehiculos(id);
        List<int>? idSiniestros = _repoVehiculo.IdVehiculos(id);
        List<int>? idTerceros = _repoVehiculo.IdVehiculos(id);
        if(vehiculos!=null){
            foreach(int idV in vehiculos)
            {
                _repoPoliza.EliminarPolizasVehiculo(idV);
            }
        }
        _repoVehiculo.EliminarVehiculosTitular(id);
            */
    }
}