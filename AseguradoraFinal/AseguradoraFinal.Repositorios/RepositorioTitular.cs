using AseguradoraFinal.Aplicacion.Entidades;
using AseguradoraFinal.Aplicacion.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace AseguradoraFinal.Repositorios;

public class RepositorioTitular : IRepositorioTitular
{
    public void AgregarTitular(Titular titular)
    {
        using (var db = new AseguradoraContext())
        {
            //Compruebo que el dni sea unico
            var dni = db.titulares.Where(a => a.dni == titular.dni).SingleOrDefault();
            if(dni == null)
                db.Add(titular);
            db.SaveChanges();
        } 
    }

    public void EliminarTitular(int id)
    {
        using (var db = new AseguradoraContext())
        {
            var titularBorrar = db.titulares.Where(a => a.id == id).SingleOrDefault();
            if(titularBorrar != null)
                db.Remove(titularBorrar);
            db.SaveChanges();
        } 
        RepositorioVehiculo repoVehiculos = new RepositorioVehiculo();
        repoVehiculos.EliminarVehiculosTitular(id);
    }

    public void ModificarTitular(Titular t)
    {
        using (var db = new AseguradoraContext())
        {
            var titularModificar = db.titulares.Where(a => a.dni == t.dni).SingleOrDefault();
            if(titularModificar != null)
            {
                titularModificar.direccion = t.direccion;
                titularModificar.correo = t.correo;
                titularModificar.nombre = t.nombre;
                titularModificar.apellido = t.apellido;
                titularModificar.telefono = t.telefono;
            }
            db.SaveChanges();
        } 
    }

    public List<Titular> ListarTitulares()
    {
        using (var db = new AseguradoraContext())
        {
            var query = db.titulares.ToList();
            return query ;
        }   
    }

    public List<Titular> ListarTitularesConSusVehiculos () 
    {
        using (var db = new AseguradoraContext())
        {
            foreach (Titular a in db.titulares.Include(a => a.vehiculos))
            {
                Console.WriteLine(a.nombre);
                //a.vehiculos?.ToList().ForEach(ex => Console.WriteLine($" - {ex.Materia} {ex.Nota}"));
                //return a.vehiculos?.ToList();
                a.vehiculos?.ToList().ForEach(ex => Console.WriteLine($" - Patente: {ex.dominio} Año: {ex.fabricacion}"));
            }
        }

        List<Titular> titulares = new List<Titular>();
        return titulares ;
    }

    public Titular? GetTitular(int id)
    {
        return ListarTitulares().SingleOrDefault(c => c.id == id);
    }
}