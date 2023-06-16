namespace AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public interface IRepositorioTercero
{
    void AgregarTercero(Tercero tercero);
    void EliminarTercero(int id);
    void ModificarTercero(Tercero t);
    List<Tercero> ListarTerceros();
    Tercero? GetTercero(int id);
}