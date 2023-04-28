using Aseguradora.Aplicacion;
using Aseguradora.Repositorios;

//configuro las dependencias
IRepositorioPoliza repoPoliza = new RepositorioPolizaTXT();
IRepositorioVehiculo repoVehiculo = new RepositorioVehiculoTXT(repoPoliza);
IRepositorioTitular repoTitular = new RepositorioTitularTXT(repoVehiculo);


//creo los casos de uso
//CU Titulares
var AgregarTitular = new AgregarTitularUseCase(repoTitular);
var ListarTitulares = new ListarTitularUseCase(repoTitular);
var EliminarTitular = new EliminarTitularUseCase(repoTitular);
var ModificarTitular = new ModificarTitularUseCase(repoTitular);
var ListarTitularesYVehiculos = new ListarTitularesConSusVehiculosUseCase(repoTitular);
//CU Vehiculos
var AgregarVehiculo = new AgregarVehiculoUseCase(repoVehiculo);
var ListarVehiculos = new ListarVehiculosUseCase(repoVehiculo);
var EliminarVehiculo = new EliminarVehiculoUseCase(repoVehiculo);
var ModificarVehiculo = new ModificarVehiculoUseCase(repoVehiculo);
//CU Polizas
var AgregarPoliza = new AgregarPolizaUseCase(repoPoliza);
var ListarPolizas = new ListarPolizasUseCase(repoPoliza);
var EliminarPoliza = new EliminarPolizaUseCase(repoPoliza);
var ModificarPoliza = new ModificarPolizaUseCase(repoPoliza);


//ejecuto los casos de uso
//AgregarTitular.Ejecutar(new Titular() {dni="41899909", apellido="Alvarez", nombre="Nicolas", telefono="221 5595439", direccion="Calle 2 n°432", correo="nicolaplatajob@gmail.com"});
//AgregarTitular.Ejecutar(new Titular() {dni="44768309", apellido="Jorge", nombre="Gimenez", telefono="221 3242523", direccion="Calle 89 n°456", correo="correo@gmail.com"});
//AgregarTitular.Ejecutar(new Titular() {dni="44721351", apellido="Rocio", nombre="Lunge", telefono="3755 3232798", direccion="Calle Siempre viva 742", correo="correito@gmail.com"});
//AgregarTitular.Ejecutar(new Titular() {dni="4356369", apellido="Son", nombre="Goku", telefono="221 32434353", direccion="Calle 33 n° 721", correo="goku@correo.com"});
//Titular t = new Titular() {dni="4315342", apellido="David", nombre="Folkz", telefono="422 3223252", direccion="Av italia 428", correo="david@correo2.com"};
//PersistirTitular(t);

// Vehiculo v1 = new Vehiculo() {dominio="ASD934", marca="BMW", fabricacion="2008", titular=3};
// Vehiculo v2 = new Vehiculo() {dominio="CQC001", marca="Renault", fabricacion="2008", titular=1};
// Vehiculo v3 = new Vehiculo() {dominio="POX231", marca="Ford", fabricacion="2011", titular=5};
// Vehiculo v4 = new Vehiculo() {dominio="FVC934", marca="Nissan", fabricacion="2020", titular=4};
// Vehiculo v5 = new Vehiculo() {dominio="BFP346", marca="Peugeot", fabricacion="2005", titular=4};
// PersistirVehiculo(v2);
// PersistirVehiculo(v3);
// PersistirVehiculo(v4);
// PersistirVehiculo(v5);

// Poliza p1 = new Poliza() {vehiculoAsegurado=2, valor = 350000, franquicia="Coches S.A", cobertura="Todo Riesgo", fechaInicio=new DateTime(2008, 3, 1), fechaFin= new DateTime(2009,3,1)};
// Poliza p2 = new Poliza() {vehiculoAsegurado=3, valor = 350000, franquicia="Coches S.A", cobertura="Todo Riesgo", fechaInicio=new DateTime(2020, 3, 1), fechaFin= new DateTime(2021,4,4)};
// Poliza p3 = new Poliza() {vehiculoAsegurado=4, valor = 350000, franquicia="Coches S.A", cobertura="Civil", fechaInicio=new DateTime(2013, 8, 9), fechaFin= new DateTime(2014,2,6)};
// Poliza p4 = new Poliza() {vehiculoAsegurado=5, valor = 350000, franquicia="Coches S.A", cobertura="Responsabilidad Civil", fechaInicio=new DateTime(2020, 3, 7), fechaFin= new DateTime(2022,3,7)};
// Poliza p5 = new Poliza() {vehiculoAsegurado=1, valor = 350000, franquicia="Coches S.A", cobertura="Todo Riesgo", fechaInicio=new DateTime(2008, 3, 1), fechaFin= new DateTime(2009,4,1)};
// Poliza p6 = new Poliza() {vehiculoAsegurado=3, valor = 335000, franquicia="AUTOS S.A", cobertura="Todo Riesgo", fechaInicio=new DateTime(2020, 3, 1), fechaFin= new DateTime(2021,4,4)};
//BajaVehiculo();

//BajaTitular(3);

ListarLosTitulares();
ListarLosVehiculos();
ListarLasPolizas();
Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
ListarLosTitularesConSusVehiculos();


void PersistirTitular(Titular t)
{
     try
     {
          AgregarTitular?.Ejecutar(t);
     }
     catch (Exception e)
     {
          Console.WriteLine(e.Message);
     }
}

void PersistirVehiculo(Vehiculo v)
{
     try
     {
          AgregarVehiculo?.Ejecutar(v);
     }
     catch (Exception e)
     {
          Console.WriteLine(e.Message);
     }
}

void PersistirPoliza(Poliza p)
{
     try
     {
          AgregarPoliza?.Ejecutar(p);
     }
     catch (Exception e)
     {
          Console.WriteLine(e.Message);
     }
}

void BajaTitular(int id)
{
     try
     {
          EliminarTitular?.Ejecutar(id);
     }
     catch (Exception e)
     {
          Console.WriteLine(e.Message);
     }
}
void BajaVehiculo(int id)
{
     try
     {
          EliminarVehiculo?.Ejecutar(id);
     }
     catch (Exception e)
     {
          Console.WriteLine(e.Message);
     }
}
void BajaPoliza(int id)
{
     try
     {
          EliminarPoliza?.Ejecutar(id);
     }
     catch (Exception e)
     {
          Console.WriteLine(e.Message);
     }
}


void ListarLosTitulares()
{
     Console.WriteLine("Listando todos los titulares de vehículos");
     List<Titular> lista = ListarTitulares.Ejecutar();
     foreach (Titular t in lista)
     {
          Console.WriteLine(t);
     }
}

void ListarLosVehiculos()
{
     Console.WriteLine("Listando todos los Vehiculos");
     List<Vehiculo> lista = ListarVehiculos.Ejecutar();
     foreach (Vehiculo v in lista)
     {
          Console.WriteLine(v);
     }
}

void ListarLasPolizas()
{
     Console.WriteLine("Listando todas las Polizas");
     List<Poliza> lista = ListarPolizas.Ejecutar();
     foreach (Poliza p in lista)
     {
          Console.WriteLine(p);
     }
}

void ListarLosTitularesConSusVehiculos()
{
     Console.WriteLine("Listando todos los titulares con sus vehículos");
     List<Titular> lista = ListarTitularesYVehiculos.Ejecutar();
     foreach (Titular t in lista)
     {
          Console.WriteLine(t);
          foreach(Vehiculo v in t.vehiculos)
          {
               Console.WriteLine(v);
          }
     }
}

Console.ReadLine();
