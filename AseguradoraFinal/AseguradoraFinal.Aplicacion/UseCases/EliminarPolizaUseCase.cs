namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class EliminarPolizaUseCase
{
    private readonly IRepositorioPoliza _repo;
    public EliminarPolizaUseCase(IRepositorioPoliza repo)
    {
        this._repo = repo;
    }
    public void Ejecutar(int id)
    {
        _repo.EliminarPoliza(id);
    }
}