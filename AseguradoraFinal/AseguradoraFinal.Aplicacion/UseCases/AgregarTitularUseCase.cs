namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class AgregarTitularUseCase
{
    private readonly IRepositorioTitular _repo;
    public AgregarTitularUseCase(IRepositorioTitular repo)
    {
        this._repo = repo;
    }
    public void Ejecutar(Titular titular)
    {
        _repo.AgregarTitular(titular);
    }
}