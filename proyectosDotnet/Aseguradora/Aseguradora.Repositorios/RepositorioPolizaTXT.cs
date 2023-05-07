namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion;

public class RepositorioPolizaTXT : IRepositorioPoliza
{
    readonly string _nombreArch = "polizas.txt";
    readonly string path = @".\polizas.txt";
    readonly string pathVehiculos = @".\vehiculos.txt";
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

    private bool ExisteVehiculo(int vehiculoId) //Verificar que el id de titular exista
    {
        bool puedo = false;
        string[] datos = File.ReadAllLines(pathVehiculos);//Leo todos los campos del txt
        for(int i=0; i<datos.Length;i++)
        {
            //Recorro el arreglo y verifico si existe el Id en el registro de titulares
            if(int.Parse(datos[i].Split(',')[0]) == vehiculoId){
                puedo = true;
                return puedo; //Si hay alguna coincidencia retorno true
            }   
        }
        return puedo;
    }

    // Me fijo que los campos no esten vacios, Que la fecha de fin sea mayor a la de inicio y que el ID de vehiculo exista en vehiculos.txt
    public void AgregarPoliza(Poliza poliza)
    {
        if(poliza.vehiculoAsegurado!=-1 && poliza.valor!=-0 && poliza.franquicia!="" && poliza.cobertura!="")
        {
            if(ExisteVehiculo(poliza.vehiculoAsegurado))
            {
                poliza.id = GenerarId();
                using var sw = new StreamWriter(_nombreArch,true);
                sw.WriteLine($"{poliza.id},{poliza.vehiculoAsegurado},{poliza.valor},{poliza.franquicia},{poliza.cobertura},{poliza.fechaInicio:d},{poliza.fechaFin:d}");
            }else
            {
                string message = "El id de vehiculo no se encuentra entre los vehiculos";
                throw new IdNotFoundException(message);
            }   
        }else
        {
            string message = "Todos los campos deben estar llenos y las fechas deben ser coherentes";
            throw new AllFieldNotFilledException(message);
        }  
    }

    public void EliminarPoliza(int id)
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
            File.WriteAllLines(path,datos);
        else
        {
            string message = "ID no encontrado";
            throw new IdNotFoundException(message);
        }
    }

    public List<int> IdPolizas(int idVehiculo)
    {
        List<int> ids_polizas = new List<int>();
        if(File.Exists(path)) {
            string[] datos = File.ReadAllLines(path);
            foreach(string dato in datos)
            {
                if(int.Parse(dato.Split(',')[1]) == idVehiculo)//Si el IdVehiculo = id
                {
                    ids_polizas.Add(int.Parse(dato.Split(',')[0]));//Agrego el id a la lista de ids
                }
            }
        }
         return ids_polizas;
    }

    public void EliminarPolizasVehiculo(int idVehiculo)
    {
        List <int> ids = IdPolizas(idVehiculo);
        if(ids.Count>0)
        {
            foreach(int id in ids)
            {
                EliminarPoliza(id);
            }
        }   
    }

    public void ModificarPoliza(Poliza p)
    {
        bool encontre = false;
        int pos = 0;
        string[] datos = File.ReadAllLines(path);
        while(!encontre && pos<datos.Length)
        {
            if(int.Parse(datos[pos].Split(',')[0]) == p.id)
            {
                encontre = true;
            }
            pos++;
        }
        if(encontre)
        {
            datos[pos-1] = $"{p.id},{p.vehiculoAsegurado},{p.valor},{p.franquicia},{p.cobertura},{p.fechaInicio:d},{p.fechaFin:d}";
            File.WriteAllLines(path,datos);
        }else
        {
            string message = "ID no encontrado";
            throw new IdNotFoundException(message);
        }
    }
    public List<Poliza> ListarPolizas()
    {
        var polizas = new List<Poliza>();
        using var sr = new StreamReader(_nombreArch);
        while(!sr.EndOfStream)
        {
            var poliza = new Poliza();
            string[] datos = (sr.ReadLine() ?? "").Split(',');
            poliza.id=int.Parse(datos[0]);
            poliza.vehiculoAsegurado=int.Parse(datos[1]);
            poliza.valor=decimal.Parse(datos[2]);
            poliza.franquicia=datos[3];
            poliza.cobertura=datos[4];
            poliza.fechaInicio=DateTime.Parse(datos[5]);
            poliza.fechaFin=DateTime.Parse(datos[6]);
            polizas.Add(poliza);
        }
        return polizas;
    }

}