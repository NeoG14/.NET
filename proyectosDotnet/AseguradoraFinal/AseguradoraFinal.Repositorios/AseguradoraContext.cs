namespace AseguradoraFinal.Repositorios;
using Microsoft.EntityFrameworkCore;
using AseguradoraFinal.Aplicacion.Entidades;

public class AseguradoraContext : DbContext
{
    #nullable disable
    public DbSet<Titular> titulares {get; set;}
    public DbSet<Poliza> polizas {get; set;}
    public DbSet<Vehiculo> vehiculos {get; set;}
    public DbSet<Tercero> terceros {get; set;}
    public DbSet<Siniestro> siniestros {get; set;}
    #nullable restore

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=Aseguradora.sqlite");
    }

    public DbContext GetDatabase()
    {
        return this;
    }
}
