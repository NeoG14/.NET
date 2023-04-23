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
    
    private bool PuedoAgregar(string dni) //Verificar que el dni es único
    {
        bool puedo = true;
        string[] datos = File.ReadAllLines(path);//Leo todos los campos del txt
        for(int i=0; i<datos.Length;i++)
        {
            //Recorro el arreglo y verifico si el dni es único
            if(datos[i].Split(',')[3] == dni){
                puedo = false;
                return puedo; //Si hay algun dni igual corto la ejecucion y retorno
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
            File.WriteAllLines(path,datos);
        else
        {
            string message = "ID no encontrado";
            throw new IdNotFoundException(message);
        }
    }

    private string modificar(string st)
    {
        string[] titular = st.Split(',');
        int opc = -1;
        string? mod = "";
        while(opc != 0)
        {
            Console.WriteLine("Seleccione campo a modificar");
            Console.WriteLine("1-Nombre");
            Console.WriteLine("2-Apellido");
            Console.WriteLine("3-DNI");
            Console.WriteLine("4-Telefono");
            Console.WriteLine("5-Direccion");
            Console.WriteLine("6-Correo");
            Console.WriteLine("0-Terminar");
            Console.WriteLine();
            Console.Write("Opcion: "); opc = int.Parse(Console.ReadLine()?? "7");

            switch (opc)
            {
                case 1:
                    Console.Write("Ingrese Nombre: ");
                    mod = Console.ReadLine()?? "";
                    if(mod != "") 
                        titular[1]=mod;
                    else
                        Console.WriteLine("No puede ir vacio");
                    break;
                case 2:
                    Console.Write("Ingrese Apellido: ");
                    mod = Console.ReadLine()?? "";
                    if(mod != "") 
                        titular[2]=mod;
                    else
                        Console.WriteLine("No puede ir vacio");
                    break;
                case 3:
                    Console.Write("Ingrese DNI: ");
                    mod = Console.ReadLine()?? "";
                    if(mod != "") 
                        titular[3]=mod;
                    else
                        Console.WriteLine("No puede ir vacio");
                    break;
                case 4:
                    Console.Write("Ingrese Telefono: ");
                    mod = Console.ReadLine()?? "";
                    if(mod != "") 
                        titular[4]=mod;
                    else
                        Console.WriteLine("No puede ir vacio");
                    break;
                case 5:
                    Console.Write("Ingrese Direccion: ");
                    mod = Console.ReadLine()?? "";
                    if(mod != "") 
                        titular[5]=mod;
                    else
                        Console.WriteLine("No puede ir vacio");
                    break;
                case 6:
                    Console.Write("Ingrese Correo: ");
                    mod = Console.ReadLine()?? "";
                    if(mod != "") 
                        titular[6]=mod;
                    else
                        Console.WriteLine("No puede ir vacio");
                    break;
                case 0: Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
        return $"{titular[0]},{titular[1]},{titular[2]},{titular[3]},{titular[4]},{titular[5]},{titular[6]}";
    }

    public void ModificarTitular(string dni)
    {
        bool encontre = false;
        int pos = 0;
        string[] datos = File.ReadAllLines(path);
        string st = "";
        while(!encontre && pos<datos.Length)
        {
            if(datos[pos].Split(',')[3] == dni)
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
}