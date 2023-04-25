namespace Aseguradora.Aplicacion;

public interface IRepositorioVehiculo
{
    void AgregarVehiculo(Vehiculo vehiculo);
    void EliminarVehiculo(int id);
    void ModificarVehiculo(int id);
    List<Vehiculo> ListarVehiculos();
}