namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class ObtenerPolizaUseCase
{
    private readonly IRepositorioPoliza _repo;
    public ObtenerPolizaUseCase(IRepositorioPoliza repo)
    {
        this._repo = repo;
    }
    public Poliza? Ejecutar(int id)
    {
        return _repo.GetPoliza(id);
    }
}