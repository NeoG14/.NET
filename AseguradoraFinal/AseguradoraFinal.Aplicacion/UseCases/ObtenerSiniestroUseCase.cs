namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class ObtenerSiniestroUseCase
{
    private readonly IRepositorioSiniestro _repo;
    public ObtenerSiniestroUseCase(IRepositorioSiniestro repo)
    {
        this._repo = repo;
    }
    public Siniestro? Ejecutar(int id)
    {
        return _repo.GetSiniestro(id);
    }
}