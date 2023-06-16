namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class AgregarSiniestroUseCase
{
    private readonly IRepositorioSiniestro _repo;
    public AgregarSiniestroUseCase(IRepositorioSiniestro repo)
    {
        _repo = repo;
    }
    public void Ejecutar(Siniestro siniestro)
    {
        _repo.AgregarSiniestro(siniestro);
    }
}