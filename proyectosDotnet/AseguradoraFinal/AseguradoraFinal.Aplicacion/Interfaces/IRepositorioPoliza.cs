namespace AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public interface IRepositorioPoliza
{
    void AgregarPoliza(Poliza poliza);
    void EliminarPoliza(int id);
    void EliminarPolizasVehiculo(int idVehiculo);
    void ModificarPoliza(Poliza p);
    List<Poliza> ListarPolizas();
    List<int> IdPolizas(int idVehiculo);
    Poliza? GetPoliza(int id);
}