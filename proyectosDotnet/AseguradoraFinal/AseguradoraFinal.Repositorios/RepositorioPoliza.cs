using AseguradoraFinal.Aplicacion.Entidades;
using AseguradoraFinal.Aplicacion.Interfaces;
namespace AseguradoraFinal.Repositorios;

public class RepositorioPoliza : IRepositorioPoliza
{
     public void AgregarPoliza(Poliza poliza)
    {
        using (var db = new AseguradoraContext())
        {
            //Compruebo que el exista un vehiculo con el id = vehiculoAseguradoId y que fechaFin sea mayor a fechaInicio
            var vehiculoId = db.vehiculos.Where(a => a.id == poliza.vehiculoAseguradoId).SingleOrDefault();
            if(vehiculoId != null && poliza.fechaInicio.CompareTo(poliza.fechaFin)<0)
                db.Add(poliza);
            db.SaveChanges();
        } 
    }

    public void EliminarPoliza(int id)
    {
        using (var db = new AseguradoraContext())
        {
            var polizaBorrar = db.polizas.Where(a => a.id == id).SingleOrDefault();
            if(polizaBorrar != null)
                db.Remove(polizaBorrar);
            db.SaveChanges();
        } 
        RepositorioSiniestro repoSiniestros = new RepositorioSiniestro();
        repoSiniestros.EliminarSiniestrosPoliza(id);
    }

    public void EliminarPolizasVehiculo(int idVehiculo)
    {
        using (var db = new AseguradoraContext())
        {
            var polizas = db.polizas.Where(b => b.vehiculoAseguradoId == idVehiculo);
            foreach (var poliza in polizas)
            {
                EliminarPoliza(poliza.id);
            }
            db.SaveChanges();
        }
    }

    public List<int> IdPolizas(int idVehiculo)
    {
        using (var db = new AseguradoraContext())
        {
            var ids = db.polizas.Where(a => a.vehiculoAseguradoId == idVehiculo).Select(v => v.id).ToList();
            return ids;
        }   
    }

    public void ModificarPoliza(Poliza p)
    {
        using (var db = new AseguradoraContext())
        {
            var polizaModificar = db.polizas.Where(a => a.id == p.id).SingleOrDefault();
            if(polizaModificar != null)
            {
                polizaModificar.vehiculoAseguradoId = p.vehiculoAseguradoId;
                polizaModificar.valor = p.valor;
                polizaModificar.franquicia = p.franquicia;
                polizaModificar.cobertura = p.cobertura;
            }
            db.SaveChanges();
        } 
    }
    public List<Poliza> ListarPolizas()
    {
        using (var db = new AseguradoraContext())
        {
            var query = db.polizas.ToList();
            return query ;
        }   
    }

    public Poliza? GetPoliza(int id)
    {
        return ListarPolizas().SingleOrDefault(c => c.id == id);
    }
}