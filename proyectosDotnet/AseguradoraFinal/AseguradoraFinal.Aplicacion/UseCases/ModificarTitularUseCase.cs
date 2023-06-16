namespace AseguradoraFinal.Aplicacion.UseCases;
using AseguradoraFinal.Aplicacion.Interfaces;
using AseguradoraFinal.Aplicacion.Entidades;

public class ModificarTitularUseCase
{
    private readonly IRepositorioTitular _repo;
    public ModificarTitularUseCase(IRepositorioTitular repo)
    {
        this._repo = repo;
    }
    public void Ejecutar(Titular t)
    {
        _repo.ModificarTitular(t);
    }
}