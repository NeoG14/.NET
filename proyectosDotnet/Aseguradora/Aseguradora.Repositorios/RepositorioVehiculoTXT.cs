namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion;

public class RepositorioVehiculoTXT : IRepositorioVehiculo
{
    readonly string _nombreArch = "vehiculos.txt";
    readonly string path = @".\vehiculos.txt";
    readonly string pathTitulares = @".\titulares.txt";

    private int GenerarId()
    {
        int id = 1;
        FileInfo archivo = new FileInfo(path);
        if(!archivo.Exists | archivo.Length==0) //Si el archivo no existe retorna ID 1 para agergar el primer producto
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
        if(File.Exists(path)){
            string[] datos = File.ReadAllLines(path);//Leo todos los campos del txt
            for(int i=0; i<datos.Length;i++)
            {
                //Recorro el arreglo y verifico si el dni es único
                if(datos[i].Split(',')[1] == dominio){
                    puedo = false;
                    return puedo; //Si hay alguna patente igual corto la ejecucion y retorno
                }   
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
                string message = "La patente no es única o El titular no existe";
                throw new UniqueFieldNotUniqueException(message);
            }
        }else
        {
            string message = "Todos los campos deben estar llenos";
            throw new AllFieldNotFilledException(message);
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
            File.WriteAllLines(path,datos);
        }
            
        else
        {
            string message = "ID no encontrado";
            throw new IdNotFoundException(message);
        }
    }

    public List<int> IdVehiculos(int idTitular)
    {
        List<int> ids_titular = new List<int>();
        if(File.Exists(path)){
            string[] datos = File.ReadAllLines(path);
            foreach(string dato in datos)
            {
                if(int.Parse(dato.Split(',')[4]) == idTitular)//Si el IdTitular = id
                {
                    ids_titular.Add(int.Parse(dato.Split(',')[0]));//Agrego el id a la lista de ids
                }
            }
        }
        return ids_titular;
    }

    public void EliminarVehiculosTitular(int idTitular)
    {
        List<int> ids = IdVehiculos(idTitular);
        if(ids.Count>0)
            foreach(int id in ids)
            {
                EliminarVehiculo(id);
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

    public void ModificarVehiculo(Vehiculo v)
    {
        bool encontre = false;
        int pos = 0;
        string[] datos = File.ReadAllLines(path);
        while(!encontre && pos<datos.Length)
        {
            if(int.Parse(datos[pos].Split(',')[0]) == v.id)
            {
                encontre = true;
            }
            pos++;
        }
        if(encontre)
        {
            datos[pos-1] = $"{v.id},{v.dominio},{v.marca},{v.fabricacion},{v.titular}";
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