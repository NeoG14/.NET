namespace AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public interface IRepositorioSiniestro
{
    void AgregarSiniestro(Siniestro siniestro);
    void EliminarSiniestro(int id);
    void ModificarSiniestro(Siniestro s);
    List<Siniestro> ListarSiniestros();
    Siniestro? GetSiniestro(int id);
}