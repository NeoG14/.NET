namespace Aseguradora.Aplicacion;

public interface IRepositorioTitular
{
    void AgregarTitular(Titular titular);
    void EliminarTitular(int dni);
    void ModificarTitular(Titular t);
    List<Titular> ListarTitulares();
    List<Titular> ListarTitularesConSusVehiculos (List<Titular> listT,List<Vehiculo> listV);
 
    
}