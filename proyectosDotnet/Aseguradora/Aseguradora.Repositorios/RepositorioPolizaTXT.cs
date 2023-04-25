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
        if(poliza.vehiculoAsegurado!=-1 && poliza.valor!=-0 && poliza.franquicia!="" && poliza.cobertura!="" && (poliza.fechaFin.CompareTo(poliza.fechaInicio)>0))
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

    private string modificar(string st)
    {
        string[] poliza = st.Split(',');
        int opc = -1;
        string mod = "";
        while(opc != 0)
        {
            Console.WriteLine("Seleccione campo a modificar");
            Console.WriteLine("1-Valor");
            Console.WriteLine("2-Franquicia");
            Console.WriteLine("3-Cobertura");
            Console.WriteLine("4-Fecha de Inicio");
            Console.WriteLine("5-Fecha de Fin");
            Console.WriteLine("0-Terminar");
            Console.WriteLine();
            Console.Write("Opcion: "); opc = int.Parse(Console.ReadLine()?? "7");

            switch (opc)
            {
                case 1:
                    Console.Write("Ingrese Valor: ");
                    mod = Console.ReadLine()?? "";
                    if(mod != "") 
                        poliza[2]=mod;
                    else
                        Console.WriteLine("No puede ir vacio");
                    break;
                case 2:
                    Console.Write("Ingrese Franquicia: ");
                    mod = Console.ReadLine()?? "";
                    if(mod != "") 
                        poliza[3]=mod;
                    else
                        Console.WriteLine("No puede ir vacio");
                    break;
                case 3:
                    Console.Write("Ingrese Cobertura: ");
                    mod = Console.ReadLine()?? "";
                    if(mod != "" && (mod=="Responsabilidad Civil" | mod=="Todo Riesgo")) 
                        poliza[4]=mod;
                    else
                        Console.WriteLine("No puede ir vacio");
                    break;
                case 4:
                    Console.Write("Ingrese Fecha Inicio dd/mm/aa: ");
                    mod = Console.ReadLine()?? "";
                    if(mod != "" && DateTime.Parse(mod).CompareTo(DateTime.Parse(poliza[6]))<0) //Si la nueva fecha inicio no es mayor a la final
                        poliza[5]=mod;
                    else
                        Console.WriteLine("No puede ir vacio");
                    break;
                case 5:
                    Console.Write("Ingrese Fecha Fin: ");
                    mod = Console.ReadLine()?? "";
                    if(mod != "" && DateTime.Parse(mod).CompareTo(DateTime.Parse(poliza[6]))>0) //Si la nueva fecha fin no es menor a la de inicio
                        poliza[6]=mod;
                    else
                        Console.WriteLine("No puede ir vacio");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
        return $"{poliza[0]},{poliza[1]},{poliza[2]},{poliza[3]},{poliza[4]},{poliza[5]},{poliza[6]}";
    }
    public void ModificarPoliza(int id)
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