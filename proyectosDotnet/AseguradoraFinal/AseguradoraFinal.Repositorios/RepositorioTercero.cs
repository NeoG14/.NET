using AseguradoraFinal.Aplicacion.Entidades;
using AseguradoraFinal.Aplicacion.Interfaces;
namespace AseguradoraFinal.Repositorios;

public class RepositorioTercero : IRepositorioTercero
{
    public void AgregarTercero(Tercero tercero)
    {
        using (var db = new AseguradoraContext())
        {
            //Compruebo que el exista un siniestro con el id = siniestroId
            var siniestroId = db.siniestros.Where(a => a.id == tercero.siniestroId).SingleOrDefault();
            if(siniestroId != null)
                db.Add(tercero);
            db.SaveChanges();
        } 
    }

    public void EliminarTercero(int id)
    {
        using (var db = new AseguradoraContext())
        {
            var terceroBorrar = db.terceros.Where(a => a.id == id).SingleOrDefault();
            if(terceroBorrar != null)
                db.Remove(terceroBorrar);
            db.SaveChanges();
        } 
    }

    public void ModificarTercero(Tercero t)
    {
        using (var db = new AseguradoraContext())
        {
            var tercerosModificar = db.terceros.Where(a => a.id == t.id).SingleOrDefault();
            if(tercerosModificar != null)
            {
                tercerosModificar.aseguradora = t.aseguradora;
                tercerosModificar.siniestroId = t.siniestroId;
                tercerosModificar.dni = t.dni;
                tercerosModificar.apellido = t.apellido;
                tercerosModificar.nombre = t.nombre;
                tercerosModificar.telefono = t.telefono;
            }
            db.SaveChanges();
        } 
    }

    public List<Tercero> ListarTerceros()
    {
        using (var db = new AseguradoraContext())
        {
            var query = db.terceros.ToList();
            return query ;
        }   
    }

    public Tercero? GetTercero(int id)
    {
        return ListarTerceros().SingleOrDefault(c => c.id == id);
    }
}