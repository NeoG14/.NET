using AseguradoraFinal.Aplicacion.Entidades;
using AseguradoraFinal.Aplicacion.Interfaces;
namespace AseguradoraFinal.Repositorios;

public class RepositorioVehiculo : IRepositorioVehiculo
{
    public void AgregarVehiculo(Vehiculo vehiculo)
    {
        using (var db = new AseguradoraContext())
        {
            //Compruebo que la pantente sea unica
            var patente = db.vehiculos.Where(a => a.dominio == vehiculo.dominio).SingleOrDefault();
            //Compruebo que el exista un titular con el id = titularId
            var titularId = db.titulares.Where(a => a.id == vehiculo.titularId).SingleOrDefault();
            if(patente == null && titularId != null)
                db.Add(vehiculo);
            else
                Console.WriteLine("Patente repetida o ID de titular No Valido");
            db.SaveChanges();
        } 
    }

    public void EliminarVehiculo(int id)
    {
        using (var db = new AseguradoraContext())
        {
            var vehiculoBorrar = db.vehiculos.Where(a => a.id == id).SingleOrDefault();
            if(vehiculoBorrar != null)
                db.Remove(vehiculoBorrar);
            db.SaveChanges();
        }
    }

    public void ModificarVehiculo(Vehiculo v)
    {
        using (var db = new AseguradoraContext())
        {
            var vehiculoModificar = db.vehiculos.Where(a => a.id == v.id).SingleOrDefault();
            if(vehiculoModificar != null)
            {
                vehiculoModificar.dominio = v.dominio;
                vehiculoModificar.marca = v.marca;
                vehiculoModificar.fabricacion = v.fabricacion;
                vehiculoModificar.titularId = v.titularId;
            }
            db.SaveChanges();
        } 
    }

    public List<Vehiculo> ListarVehiculos()
    {
        using (var db = new AseguradoraContext())
        {
            var query = db.vehiculos.ToList();
            return query ;
        }  
    }

    public Vehiculo? GetVehiculo(int id)
    {
        return ListarVehiculos().SingleOrDefault(c => c.id == id);
    }
}