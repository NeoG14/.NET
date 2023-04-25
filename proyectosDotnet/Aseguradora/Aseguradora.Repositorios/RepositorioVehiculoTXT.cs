namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion;

public class RepositorioVehiculoTXT : IRepositorioVehiculo
{
    readonly string _nombreArch = "vehiculos.txt";
    readonly string path = @".\vehiculos.txt";
    readonly string pathTitulares = @".\titulares.txt";
    readonly string pathPolizas = @".\polizas.txt";
    private RepositorioPolizaTXT repoPoliza = new RepositorioPolizaTXT();

    private int GenerarId()
    {
        int id = 1;
        FileInfo archivo = new FileInfo(path);
        if(!archivo.Exists) //Si el archivo no existe retorna ID 1 para agergar el primer producto
            return id;
        else //Si el archivo existe
        {
            //Leo el ultimo campo del archivo y me guardo el id
            id = int.Parse(File.ReadLines(path).Last().Split(',')[0]);
            //Retorno el ultimo id+1
            return id+1;
        }
    }

    private bool PuedoAgregar(string dominio) //Verificar que la patente es única
    {
        bool puedo = true;
        string[] datos = File.ReadAllLines(path);//Leo todos los campos del txt
        for(int i=0; i<datos.Length;i++)
        {
            //Recorro el arreglo y verifico si el dni es único
            if(datos[i].Split(',')[1] == dominio){
                puedo = false;
                return puedo; //Si hay alguna patente igual corto la ejecucion y retorno
            }   
        }
        return puedo;
    }

    public void AgregarVehiculo(Vehiculo vehiculo)
    {
        //Compruebo que ningun campo sea vacio
        if(vehiculo.dominio!="" && vehiculo.marca!="" && vehiculo.fabricacion!="" && vehiculo.titular!=-1){
            vehiculo.id = GenerarId();
            if(PuedoAgregar(vehiculo.dominio) && ExisteTitular(vehiculo.titular)){ //Comprueno que no se repita la patente y que existe el titular
                using var sw = new StreamWriter(_nombreArch,true);
                sw.WriteLine($"{vehiculo.id},{vehiculo.dominio},{vehiculo.marca},{vehiculo.fabricacion},{vehiculo.titular}");
            }else
            {
                string message = "La patente no es única";
                throw new UniqueFieldNotUniqueException(message);
            }
        }else
        {
            string message = "Todos los campos deben estar llenos";
            throw new AllFieldNotFilledException(message);
        }   
    }

    private void EliminarPolizas(int idVehiculo)
    {
        List<int> ids_polizas = new List<int>();
        string[] datos = File.ReadAllLines(pathPolizas);
        foreach(string dato in datos)
        {
            if(int.Parse(dato.Split(',')[1]) == idVehiculo)//Si el IdVehiculo = id
            {
                ids_polizas.Add(int.Parse(dato.Split(',')[1]));//Agrego el id a la lista de ids
            }
        }
        foreach(int idP in ids_polizas)//Llamo a eliminar vehiculo del repositorios de vehiculos con los ID a eliminar
        {
            repoPoliza.EliminarPoliza(idP);
        }
    }

    public void EliminarVehiculo(int id)
    {
        bool encontre = false; string st;
        List<string> datos = new List<string>();
        using var sr = new StreamReader(_nombreArch,true);
        while(!sr.EndOfStream)
        {
            st = (sr.ReadLine() ?? "");
            if(int.Parse(st.Split(',')[0])==id)
            {
                encontre=true;
                continue; 
            }    
            datos.Add(st);
        }
        sr.Dispose();
        if(encontre)
        {
            EliminarPolizas(id);
            File.WriteAllLines(path,datos);
        }
            
        else
        {
            string message = "ID no encontrado";
            throw new IdNotFoundException(message);
        }
    }

    private bool ExisteTitular(int titularId) //Verificar que el id de titular exista
    {
        bool puedo = false;
        string[] datos = File.ReadAllLines(pathTitulares);//Leo todos los campos del txt
        for(int i=0; i<datos.Length;i++)
        {
            //Recorro el arreglo y verifico si existe el Id en el registro de titulares
            if(int.Parse(datos[i].Split(',')[0]) == titularId){
                puedo = true;
                return puedo; //Si hay alguna coincidencia retorno true
            }   
        }
        return puedo;
    }

    private string modificar(string st)
    {
        string[] vehiculo = st.Split(',');
        int opc = -1;
        string mod = "";
        while(opc != 0)
        {
            Console.WriteLine("Seleccione campo a modificar");
            Console.WriteLine("1-Dominio");
            Console.WriteLine("2-Marca");
            Console.WriteLine("3-Año de fabricación");
            Console.WriteLine("4-Titular");
            Console.WriteLine("0-Terminar");
            Console.WriteLine();
            Console.Write("Opcion: "); opc = int.Parse(Console.ReadLine()?? "7");

            switch (opc)
            {
                case 1:
                    Console.Write("Ingrese Dominio: ");
                    mod = Console.ReadLine()?? "";
                    if(mod != "") 
                        vehiculo[1]=mod;
                    else
                        Console.WriteLine("No puede ir vacio");
                    break;
                case 2:
                    Console.Write("Ingrese Marca: ");
                    mod = Console.ReadLine()?? "";
                    if(mod != "") 
                        vehiculo[2]=mod;
                    else
                        Console.WriteLine("No puede ir vacio");
                    break;
                case 3:
                    Console.Write("Ingrese Año de fabricación: ");
                    mod = Console.ReadLine()?? "";
                    if(mod != "") 
                        vehiculo[3]=mod;
                    else
                        Console.WriteLine("No puede ir vacio");
                    break;
                case 4:
                    Console.Write("Ingrese Id de Titular: ");
                    mod = Console.ReadLine()?? "";
                    if( ExisteTitular(int.Parse(mod))  && mod!="") 
                        vehiculo[4]=mod;
                    else
                        Console.WriteLine("El Id ingresado no figura entre los titulares o El campo es vacio");
                    break;
                case 0: Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
        return $"{vehiculo[0]},{vehiculo[1]},{vehiculo[2]},{vehiculo[3]},{vehiculo[4]}";
    }
    public void ModificarVehiculo(int id)
    {
        bool encontre = false;
        int pos = 0;
        string[] datos = File.ReadAllLines(path);
        string st = "";
        while(!encontre && pos<datos.Length)
        {
            if(int.Parse(datos[pos].Split(',')[0]) == id)
            {
                encontre = true;
                st = datos[pos];
            }
            pos++;
        }
        if(encontre)
        {
            datos[pos-1] = modificar(st);
            File.WriteAllLines(path,datos);
        }else
        {
            string message = "ID no encontrado";
            throw new IdNotFoundException(message);
        }
    }
    public List<Vehiculo> ListarVehiculos()
    {
        var vehiculos = new List<Vehiculo>();
        using var sr = new StreamReader(_nombreArch);
        while(!sr.EndOfStream)
        {
            var vehiculo = new Vehiculo();
            string[] datos = (sr.ReadLine() ?? "").Split(',');
            vehiculo.id=int.Parse(datos[0]);
            vehiculo.dominio=datos[1];
            vehiculo.marca=datos[2];
            vehiculo.fabricacion=datos[3];
            vehiculo.titular=int.Parse(datos[4]);
            vehiculos.Add(vehiculo);
        }
        return vehiculos;
    }
}