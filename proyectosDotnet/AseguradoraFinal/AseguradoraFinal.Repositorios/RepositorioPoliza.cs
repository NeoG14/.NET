using AseguradoraFinal.Aplicacion.Entidades;
using AseguradoraFinal.Aplicacion.Interfaces;
namespace AseguradoraFinal.Repositorios;

public class RepositorioPoliza : IRepositorioPoliza
{
     public void AgregarPoliza(Poliza poliza)
    {
        using (var db = new AseguradoraContext())
        {
            //Compruebo que el exista un vehiculo con el id = vehiculoId y que fechaFin sea mayor a fechaInicio
            var vehiculoId = db.vehiculos.Where(a => a.id == poliza.vehiculoId).SingleOrDefault();
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
    }

    public void ModificarPoliza(Poliza p)
    {
        using (var db = new AseguradoraContext())
        {
            var polizaModificar = db.polizas.Where(a => a.id == p.id).SingleOrDefault();
            if(polizaModificar != null)
            {
                polizaModificar.vehiculoId = p.vehiculoId;
                polizaModificar.valor = p.valor;
                polizaModificar.franquicia = p.franquicia;
                polizaModificar.fechaInicio = p.fechaInicio;
                polizaModificar.fechaFin = p.fechaFin;
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