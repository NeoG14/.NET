namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class AgregarPolizaUseCase
{
    private readonly IRepositorioPoliza _repo;
    public AgregarPolizaUseCase(IRepositorioPoliza repo)
    {
        _repo = repo;
    }
    public void Ejecutar(Poliza poliza)
    {
        _repo.AgregarPoliza(poliza);
    }
}