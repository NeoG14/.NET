namespace AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public interface IRepositorioVehiculo
{
    void AgregarVehiculo(Vehiculo vehiculo);
    void EliminarVehiculo(int id);
    void EliminarVehiculosTitular(int idTitular);
    void ModificarVehiculo(Vehiculo v);
    List<Vehiculo> ListarVehiculos();
    //List<int> IdVehiculos(int idTitular);
    Vehiculo? GetVehiculo(int id);

}