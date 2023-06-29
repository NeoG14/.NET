namespace AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public interface IRepositorioPoliza
{
    void AgregarPoliza(Poliza poliza);
    void EliminarPoliza(int id);
    void ModificarPoliza(Poliza p);
    List<Poliza> ListarPolizas();
    Poliza? GetPoliza(int id);
}