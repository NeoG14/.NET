namespace Aseguradora.Aplicacion;

public interface IRepositorioPoliza
{
    void AgregarPoliza(Poliza poliza);
    void EliminarPoliza(int id);
    void EliminarPolizasVehiculo(int idVehiculo);
    void ModificarPoliza(int id);
    List<Poliza> ListarPolizas();
}