using AseguradoraFinal.Aplicacion.Entidades;
using AseguradoraFinal.Aplicacion.Interfaces;
namespace AseguradoraFinal.Repositorios;

public class RepositorioSiniestro : IRepositorioSiniestro
{
    public void AgregarSiniestro(Siniestro siniestro)
    {
        using (var db = new AseguradoraContext())
        {
            //Compruebo que el exista una poliza con el id = polizaId
            //y que la fecha de Ocurrencia sea menor a la fecha de ingreso
            var polizaId = db.polizas.Where(a => a.id == siniestro.polizaId).SingleOrDefault();
            if(polizaId != null && siniestro.ocurrencia.CompareTo(siniestro.ingreso)<0)
                db.Add(siniestro);
            db.SaveChanges();
        } 
    }

    public void EliminarSiniestro(int id)
    {
        using (var db = new AseguradoraContext())
        {
            var siniestroaBorrar = db.siniestros.Where(a => a.id == id).SingleOrDefault();
            if(siniestroaBorrar != null)
                db.Remove(siniestroaBorrar);
            db.SaveChanges();
        } 
        RepositorioTercero repoTerceros = new RepositorioTercero();
        repoTerceros.EliminarTercerosSiniestro(id);
    }

    public void EliminarSiniestrosPoliza(int idPoliza)
    {
        using (var db = new AseguradoraContext())
        {
            var siniestros = db.siniestros.Where(b => b.polizaId == idPoliza);
            foreach (var siniestro in siniestros)
            {
                EliminarSiniestro(siniestro.id);
            }
            db.SaveChanges();
        }
    }

    public List<int> IdSiniestros(int idPoliza)
    {
        using (var db = new AseguradoraContext())
        {
            var ids = db.siniestros.Where(a => a.polizaId == idPoliza).Select(v => v.id).ToList();
            return ids;
        }   
    }

    public void ModificarSiniestro(Siniestro s)
    {
        using (var db = new AseguradoraContext())
        {
            var siniestroModificar = db.siniestros.Where(a => a.id == s.id).SingleOrDefault();
            if(siniestroModificar != null)
            {
                siniestroModificar.polizaId = s.polizaId;
                siniestroModificar.ingreso = s.ingreso;
                siniestroModificar.ocurrencia = s.ocurrencia;
                siniestroModificar.direccion = s.direccion;
                siniestroModificar.descripcion = s.descripcion;
            }
            db.SaveChanges();
        }
    }

    public List<Siniestro> ListarSiniestros()
    {
        using (var db = new AseguradoraContext())
        {
            var query = db.siniestros.ToList();
            return query ;
        }
    }

    public Siniestro? GetSiniestro(int id)
    {
        return ListarSiniestros().SingleOrDefault(c => c.id == id);
    }
}