using Aseguradora.Aplicacion;
using Aseguradora.Repositorios;
using System.Text.RegularExpressions;

//configuro las dependencias
IRepositorioPoliza repoPoliza = new RepositorioPolizaTXT();
IRepositorioVehiculo repoVehiculo = new RepositorioVehiculoTXT();
IRepositorioTitular repoTitular = new RepositorioTitularTXT();


//creo los casos de uso
//CU Titulares
var AgregarTitular = new AgregarTitularUseCase(repoTitular);
var ListarTitulares = new ListarTitularUseCase(repoTitular);
var EliminarTitular = new EliminarTitularUseCase(repoTitular,repoVehiculo,repoPoliza);
var ModificarTitular = new ModificarTitularUseCase(repoTitular);
var ListarTitularesYVehiculos = new ListarTitularesConSusVehiculosUseCase(repoTitular,repoVehiculo);
//CU Vehiculos
var AgregarVehiculo = new AgregarVehiculoUseCase(repoVehiculo);
var ListarVehiculos = new ListarVehiculosUseCase(repoVehiculo);
var EliminarVehiculo = new EliminarVehiculoUseCase(repoVehiculo,repoPoliza);
var ModificarVehiculo = new ModificarVehiculoUseCase(repoVehiculo);
//CU Polizas
var AgregarPoliza = new AgregarPolizaUseCase(repoPoliza);
var ListarPolizas = new ListarPolizasUseCase(repoPoliza);
var EliminarPoliza = new EliminarPolizaUseCase(repoPoliza);
var ModificarPoliza = new ModificarPolizaUseCase(repoPoliza);

// Menu de la aplicación
//Titular t = new Titular {nombre="PEPE", apellido="TORRES",dni="3434424",direccion="LA PLATA",correo="Corro@correo@gmail.com", telefono="221454464"};
//PersistirTitular(t);
menu();

// Metodos para presentar el menu
void cargarTitular()
{
     Titular t = new Titular();
     Console.Write("Nombre: ");
     t.nombre = Console.ReadLine()?? "";
     Console.Write("Apellido: ");
     t.apellido = Console.ReadLine()?? "";
     Console.Write("DNI: ");
     t.dni = Console.ReadLine()?? "";
     Console.Write("Telefono: ");
     t.telefono = Console.ReadLine()?? "";
     Console.Write("Dirección: ");
     t.direccion = Console.ReadLine()?? "";
     Console.Write("Correo: ");
     t.correo = Console.ReadLine()?? "";
     Console.WriteLine();
     PersistirTitular(t);
}

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


void cargarVehiculo()
{
     Vehiculo v = new Vehiculo();
     bool patente = false;
     while(!patente)
     {
          Console.Write("Dominio: ");
          v.dominio = Console.ReadLine()?? "";
          if (Regex.IsMatch(v.dominio, "^[a-zA-Z0-9]*$")) 
               patente = true;
          else 
            Console.WriteLine("La patente debe ser Alfanumerica");
     }

     Console.Write("Marca: ");
     v.marca = Console.ReadLine()?? "";
     Console.Write("Fabricacion: ");
     v.fabricacion = Console.ReadLine()?? "";
     Console.Write("Titular: ");
     v.titular = int.Parse(Console.ReadLine()?? "");
     PersistirVehiculo(v);
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

void cargarPoliza()
{
     bool cobertura = false;
     bool fecha = false;
     Poliza p = new Poliza();
     Console.Write("Vehiculo Asegurado (id): ");
     p.vehiculoAsegurado = int.Parse(Console.ReadLine()?? "-1");
     Console.Write("Valor: ");
     p.valor = decimal.Parse(Console.ReadLine()?? "0");
     Console.Write("Franquicia: ");
     p.franquicia = Console.ReadLine()?? "";
     while(!cobertura)
     {
          Console.Write("Cobertura: ");
          p.cobertura = Console.ReadLine()?? "";
          if(p.cobertura.Equals("Responsabilidad Civil") || p.cobertura.Equals("Todo Riesgo"))
               cobertura=true;
          else
               Console.WriteLine("Solo se admite Responsabilidad Civil o Todo Riesgo");
     }
     while(!fecha)
     {
          Console.Write("Fecha Inicio: ");
          p.fechaInicio = DateTime.Parse(Console.ReadLine()?? "");
          Console.Write("Fecha Fin: ");
          p.fechaFin = DateTime.Parse(Console.ReadLine()?? "");
          if((p.fechaFin.CompareTo(p.fechaInicio)>0))
               fecha = true;
          else
               Console.WriteLine("La fecha de inicio no puede superar a la fecha de fin");
     }
     PersistirPoliza(p);
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
     List<Titular>? lista = ListarTitulares?.Ejecutar();
     if(lista != null)
          foreach (Titular t in lista)
               Console.WriteLine(t);
}

void ListarLosVehiculos()
{
     Console.WriteLine("Listando todos los Vehiculos");
     List<Vehiculo>? lista = ListarVehiculos?.Ejecutar();
     if(lista != null)
          foreach (Vehiculo v in lista)
               Console.WriteLine(v);
     
}

void ListarLasPolizas()
{
     Console.WriteLine("Listando todas las Polizas");
     List<Poliza>? lista = ListarPolizas?.Ejecutar();
     if(lista != null)
     foreach (Poliza p in lista)
          Console.WriteLine(p);
}

void ListarLosTitularesConSusVehiculos()
{
     Console.WriteLine("Listando todos los titulares con sus vehículos");
     List<Titular>? lista = ListarTitularesYVehiculos?.Ejecutar();
     if(lista != null)
     {
          foreach (Titular t in lista)
          {
               Console.WriteLine(t);
               if(t.vehiculos.Count>0)
                    Console.WriteLine("Vehiculos: ");   
               foreach(Vehiculo v in t.vehiculos)
               {
                    Console.WriteLine(v);
               }
               Console.WriteLine("------------------");
          }
     }   
}

void modificarTitular()
{
     try
     {
          Titular t = new Titular();
          Console.Write("ID: ");
          t.id = int.Parse(Console.ReadLine()?? "-1");
          Console.Write("Nombre: ");
          t.nombre = Console.ReadLine()?? "";
          Console.Write("Apellido: ");
          t.apellido = Console.ReadLine()?? "";
          Console.Write("DNI: ");
          t.dni = Console.ReadLine()?? "";
          Console.Write("Telefono: ");
          t.telefono = Console.ReadLine()?? "";
          Console.Write("Dirección: ");
          t.direccion = Console.ReadLine()?? "";
          Console.Write("Correo: ");
          t.correo = Console.ReadLine()?? "";
          ModificarTitular?.Ejecutar(t);

     }
     catch (Exception e)
     {
          
          Console.WriteLine(e.Message);
     }
     
}
void modificarVehiculo()
{
     try
     {
          Vehiculo v = new Vehiculo();
          Console.Write("ID: ");
          v.id = int.Parse(Console.ReadLine()?? "-1");
          Console.Write("Dominio: ");
          v.dominio = Console.ReadLine()?? "";
          Console.Write("Marca: ");
          v.marca = Console.ReadLine()?? "";
          Console.Write("Fabricacion: ");
          v.fabricacion = Console.ReadLine()?? "";
          Console.Write("Titular: ");
          v.titular = int.Parse(Console.ReadLine()?? "");
          ModificarVehiculo?.Ejecutar(v);
     }
     catch (Exception e)
     {
          Console.WriteLine(e.Message);
     }
}
void modificarPoliza()
{
     try
     {
          Poliza p = new Poliza();
          Console.Write("ID: ");
          p.id = int.Parse(Console.ReadLine()?? "-1");
          Console.Write("Vehiculo Asegurado (id): ");
          p.vehiculoAsegurado = int.Parse(Console.ReadLine()?? "-1");
          Console.Write("Valor: ");
          p.valor = decimal.Parse(Console.ReadLine()?? "0");
          Console.Write("Franquicia: ");
          p.franquicia = Console.ReadLine()?? "";
          Console.Write("Cobertura: ");
          p.cobertura = Console.ReadLine()?? "";
          Console.Write("Fecha Inicio: ");
          p.fechaInicio = DateTime.Parse(Console.ReadLine()?? "");
          Console.Write("Fecha Fin: ");
          p.fechaFin = DateTime.Parse(Console.ReadLine()?? "");
          ModificarPoliza?.Ejecutar(p);      
     }
     catch (Exception e)
     {
          
          Console.WriteLine(e.Message);
     }  
}

void agregar()
{
     Console.WriteLine("Seleccione una opcion");
     Console.WriteLine("1-Agregar Titular");
     Console.WriteLine("2-Agregar Vehiculo");
     Console.WriteLine("3-Agregar Poliza");
     Console.Write("Opcion: ");
     int opc = int.Parse(Console.ReadLine()?? "-1");
     switch (opc)
     {
          case 1:
               cargarTitular();
               break;
          case 2: 
               cargarVehiculo();
               break;
          case 3: 
               cargarPoliza();
               break;
          default:
               Console.WriteLine("Opcion Incorrecta");
               break;
     }
}

void eliminar()
{
     Console.WriteLine("Seleccione una opcion");
     Console.WriteLine("1-Eliminar Titular");
     Console.WriteLine("2-Eliminar Vehiculo");
     Console.WriteLine("3-Eliminar Poliza");
     Console.Write("Opcion: ");
     int id = 0;
     int opc = int.Parse(Console.ReadLine()?? "-1");

     switch (opc)
     {
          case 1: 
               Console.Write("Ingrese ID de Titular a eliminar: ");
               id = int.Parse(Console.ReadLine()??"-1");
               BajaTitular(id);
               break;
          case 2: 
               Console.Write("Ingrese ID de Vehiculo a eliminar: ");
               id = int.Parse(Console.ReadLine()??"-1");
               BajaVehiculo(id);
               break;
          case 3: 
               Console.Write("Ingrese ID de Poliza a eliminar: ");
               id = int.Parse(Console.ReadLine()??"-1");
               BajaPoliza(id);
               break;
          default:
               Console.WriteLine("Opcion Incorrecta");
               break;
     }
}

void modificar()
{
     Console.WriteLine("Seleccione una opcion");
     Console.WriteLine("1-Modificar Titular");
     Console.WriteLine("2-Modificar Vehiculo");
     Console.WriteLine("3-Modificar Poliza");
     Console.Write("Opcion: ");
     int opc = int.Parse(Console.ReadLine()??"-1");
     switch (opc)
     {
          case 1: 
               modificarTitular();
               break;
          case 2: 
               modificarVehiculo();
               break;
          case 3: 
               modificarPoliza();
               break;
          default:
               Console.WriteLine("Opcion Incorrecta");
               break;
     }
}

void listar()
{
     Console.WriteLine("Seleccione una opcion");
     Console.WriteLine("1-Listar Titulares");
     Console.WriteLine("2-Listar Vehiculos");
     Console.WriteLine("3-Listar Polizas");
     Console.WriteLine("4-Listar Titulares con sus Vehiculos");
     Console.Write("Opcion: ");
     int opc = int.Parse(Console.ReadLine()??"-1");
     switch (opc)
     {
          case 1: 
               ListarLosTitulares();
               break;
          case 2: 
               ListarLosVehiculos();
               break;
          case 3: 
               ListarLasPolizas();
               break;
          case 4: 
               ListarLosTitularesConSusVehiculos();
               break;
          default:
               Console.WriteLine("Opcion Incorrecta");
               break;
     }
}

void menu()
{
    int opc = -1;
    while(opc != 0)
    {
          Console.WriteLine("Ingrese Una Opcion");
          Console.WriteLine("1-Agregar");
          Console.WriteLine("2-Eliminar");
          Console.WriteLine("3-Modificar");
          Console.WriteLine("4-Listar");
          Console.WriteLine("0-Salir");
          Console.Write("Opcion: ");
          opc = int.Parse(Console.ReadLine()??"-1");
          switch (opc)
          {
               case 0:
                    Console.WriteLine("Saliendo...");
                    break;
               case 1:
                    Console.WriteLine();
                    agregar();
                    break;
               case 2:
                    Console.WriteLine();
                    eliminar();
                    break;
               case 3:
                    Console.WriteLine();
                    modificar();
                    break;
               case 4:
                    Console.WriteLine();
                    listar();
                    break;
               default:
                    Console.WriteLine("Opcion Incorrecta");
                    break;
          }
          Console.WriteLine("----------------");
    }
}

//Para que no se cierre la ventana
Console.ReadLine();
