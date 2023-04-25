using Aseguradora.Aplicacion;
using Aseguradora.Repositorios;

//configuro las dependencias
IRepositorioTitular repo = new RepositorioTitularTXT();

//creo los casos de uso
var AgregarTitular = new AgregarTitularUseCase(repo);
var ListarTitulares = new ListarTitularUseCase(repo);
var EliminarTitular = new EliminarTitularUseCase(repo);
var ModificarTitular = new ModificarTitularUseCase(repo);


//ejecuto los casos de uso
//AgregarTitular.Ejecutar(new Titular() {dni="41899909", apellido="Alvarez", nombre="Nicolas", telefono="221 5595439", direccion="Calle 2 n°432", correo="nicolaplatajob@gmail.com"});
//AgregarTitular.Ejecutar(new Titular() {dni="44768309", apellido="Jorge", nombre="Gimenez", telefono="221 3242523", direccion="Calle 89 n°456", correo="correo@gmail.com"});
//AgregarTitular.Ejecutar(new Titular() {dni="44721351", apellido="Rocio", nombre="Lunge", telefono="3755 3232798", direccion="Calle Siempre viva 742", correo="correito@gmail.com"});
//AgregarTitular.Ejecutar(new Titular() {dni="4356369", apellido="Son", nombre="Goku", telefono="221 32434353", direccion="Calle 33 n° 721", correo="goku@correo.com"});
//EliminarTitular.Ejecutar(2);
//ModificarTitular.Ejecutar("41899909");

var lista = ListarTitulares.Ejecutar();

foreach(Titular t in lista)
{
     Console.WriteLine(t);
}

Console.ReadLine();