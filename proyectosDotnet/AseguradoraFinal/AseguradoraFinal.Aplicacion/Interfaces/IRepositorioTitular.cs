namespace AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public interface IRepositorioTitular
{
    void AgregarTitular(Titular titular);
    void EliminarTitular(int dni);
    void ModificarTitular(Titular t);
    List<Titular> ListarTitulares();
    List<Vehiculo> ListarTitularesConSusVehiculos (int id);
    Titular? GetTitular(int id);
 
    
}