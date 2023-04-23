namespace Aseguradora.Aplicacion;

public interface IRepositorioTitular
{
    void AgregarTitular(Titular titular);
    void EliminarTitular(int dni);
    void ModificarTitular(string dni);
    List<Titular> ListarTitulares();
}