namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class ListarSiniestrosUseCase
{
    private readonly IRepositorioSiniestro _repo;
    public ListarSiniestrosUseCase(IRepositorioSiniestro repo)
    {
        _repo = repo;
    }
    public List<Siniestro> Ejecutar()
    {
       return _repo.ListarSiniestros();
    }
}