namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class ModificarSiniestroUseCase
{
    private readonly IRepositorioSiniestro _repo;
    public ModificarSiniestroUseCase(IRepositorioSiniestro repo)
    {
        this._repo = repo;
    }
    public void Ejecutar(Siniestro s)
    {
        _repo.ModificarSiniestro(s);
    }
}