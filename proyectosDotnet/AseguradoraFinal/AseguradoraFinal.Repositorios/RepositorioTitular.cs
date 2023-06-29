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
    }

    //No se puede modificar el dni de un titular proque la busqueda se realiza por dni 
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

    public List<Vehiculo> ListarTitularesConSusVehiculos (int id) 
    {
        List<Vehiculo> vehi = new List<Vehiculo>();
        using (var db = new AseguradoraContext())
        {
            //foreach (Vehiculo a in db.vehiculos.Include(a => a.vehiculos))
            foreach (Vehiculo v in db.vehiculos)
            {
                if (v.titularId == id)
                    vehi.Add(v);
            }
        }
        return vehi ;
    }

    public Titular? GetTitular(int id)
    {
        return ListarTitulares().SingleOrDefault(c => c.id == id);
    }
}