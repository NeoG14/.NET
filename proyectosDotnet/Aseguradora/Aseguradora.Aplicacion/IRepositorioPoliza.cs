namespace Aseguradora.Aplicacion;

public interface IRepositorioPoliza
{
    void AgregarPoliza(Poliza poliza);
    void EliminarPoliza(int id);
    void ModificarPoliza(int id);
    List<Poliza> ListarPolizas();
}