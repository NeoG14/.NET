namespace AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public interface IRepositorioVehiculo
{
    void AgregarVehiculo(Vehiculo vehiculo);
    void EliminarVehiculo(int id);
    void ModificarVehiculo(Vehiculo v);
    List<Vehiculo> ListarVehiculos();
    Vehiculo? GetVehiculo(int id);

}