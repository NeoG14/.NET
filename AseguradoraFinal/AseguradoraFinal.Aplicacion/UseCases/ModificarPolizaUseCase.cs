namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class ModificarPolizaUseCase
{
    private readonly IRepositorioPoliza _repo;
    public ModificarPolizaUseCase(IRepositorioPoliza repo)
    {
        this._repo = repo;
    }
    public void Ejecutar(Poliza p)
    {
        _repo.ModificarPoliza(p);
    }
}