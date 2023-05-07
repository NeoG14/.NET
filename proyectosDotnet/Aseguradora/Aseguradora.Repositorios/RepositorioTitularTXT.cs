namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion;

public class RepositorioTitularTXT : IRepositorioTitular
{
    readonly string _nombreArch = "titulares.txt";
    readonly string path = @".\titulares.txt";
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
    
    private bool PuedoAgregar(string dni) //Verificar que el dni es único
    {
        bool puedo = true;
        if(File.Exists(path))
        {
            string[] datos = File.ReadAllLines(path);//Leo todos los campos del txt
            for(int i=0; i<datos.Length;i++)
            {
                //Recorro el arreglo y verifico si el dni es único
                if(datos[i].Split(',')[3] == dni){
                    puedo = false;
                    return puedo; //Si hay algun dni igual corto la ejecucion y retorno
                }   
            }
        }
        return puedo;
    }

    public void AgregarTitular(Titular titular)
    {
        //Compruebo que ningun campo sea vacio
        if(titular.apellido!="" && titular.nombre!="" && titular.dni!="" && titular.direccion!="" && titular.correo!="" && titular.telefono!=""){
            titular.id = GenerarId();
            if(PuedoAgregar(titular.dni)){
                using var sw = new StreamWriter(_nombreArch,true);
                sw.WriteLine($"{titular.id},{titular.nombre},{titular.apellido},{titular.dni},{titular.telefono},{titular.direccion},{titular.correo}");
            }else
            {
                string message = "El DNI no es único";
                throw new UniqueFieldNotUniqueException(message);
            }
        }else
        {
            string message = "Todos los campos deben estar llenos";
            throw new AllFieldNotFilledException(message);
        }    
    }

    public void EliminarTitular(int id)
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

    public void ModificarTitular(Titular t)
    {
        bool encontre = false;
        int pos = 0;
        string[] datos = File.ReadAllLines(path);
        while(!encontre && pos<datos.Length)
        {
            if(datos[pos].Split(',')[3].Equals(t.dni))
            {
                encontre = true;
            }
            pos++;
        }
        if(encontre)
        {
            string id = datos[pos-1].Split(',')[0];
            datos[pos-1] = $"{id},{t.nombre},{t.apellido},{t.dni},{t.telefono},{t.direccion},{t.correo}";;
            File.WriteAllLines(path,datos);
        }else
        {
            string message = "DNI no encontrado";
            throw new IdNotFoundException(message);
        }        
    }

    public List<Titular> ListarTitulares()
    {
        var titulares = new List<Titular>();
        using var sr = new StreamReader(_nombreArch);
        while(!sr.EndOfStream)
        {
            var titular = new Titular();
            string[] datos = (sr.ReadLine() ?? "").Split(',');
            titular.id=int.Parse(datos[0]);
            titular.nombre=datos[1];
            titular.apellido=datos[2];
            titular.dni=datos[3];
            titular.telefono=datos[4];
            titular.direccion=datos[5];
            titular.correo=datos[6];
            titulares.Add(titular);
        }
        return titulares;
    }

    public List<Titular> ListarTitularesConSusVehiculos (List<Titular> listaTitulares, List<Vehiculo> listaVehiculos) {
        foreach(Vehiculo v in listaVehiculos){
            listaTitulares.Find(x => x.id==v.titular)?.vehiculos.Add(v);
        }
        return listaTitulares;
    }
}