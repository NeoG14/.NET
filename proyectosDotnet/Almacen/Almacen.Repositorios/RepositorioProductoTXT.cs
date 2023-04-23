namespace Almacen.Repositorios;
using Almacen.Aplicacion;
public class RepositorioProductoTXT : IRepositorioProducto  
{
    readonly string _nombreArch = "productos.txt";

    private int GenerarId()
    {
        int id = 1;
        string path = @".\productos.txt";
        FileInfo archivo = new FileInfo(path);
        if(!archivo.Exists) //Si el archivo no existe retorna ID 1 para agergar el primer producto
            return id;
        else //Si el archivo existe
        {
            //Abro el archivo
            using var sr = new StreamReader(_nombreArch);
            while (!sr.EndOfStream)
            {
                //Leo el id y me salto el campo nombre (me gustaria ir al ultimo campo-1 por ejemplo directamente)
                id = int.Parse(sr.ReadLine() ?? "");
                sr.ReadLine();
            }
            //Al final retorno el ultimo id+1
            return id+1;
        }
        
    }
    public void AgregarProducto(Producto producto)
    {
        producto.Id = GenerarId();
        using var sw = new StreamWriter(_nombreArch, true);
        sw.WriteLine(producto.Id);
        sw.WriteLine(producto.Nombre);
    }
    public List<Producto> ListarProductos()
    {
        var resultado = new List<Producto>();
        using var sr = new StreamReader(_nombreArch);
        while (!sr.EndOfStream)
        {
            var producto = new Producto();
            producto.Id = int.Parse(sr.ReadLine() ?? "");
            producto.Nombre = sr.ReadLine() ?? "";
            resultado.Add(producto);
        }
        return resultado;
    }

    //Retorna null si no encontró el producto
    public Producto? GetProducto(int id)
    {
        bool encontre = false;
        var producto = new Producto();
        using var sr = new StreamReader(_nombreArch);
        while (!encontre && !sr.EndOfStream)
        {
            producto.Id = int.Parse(sr.ReadLine() ?? "");
            producto.Nombre = sr.ReadLine() ?? "";
            if(producto.Id==id)
                encontre=true;
        }
        return (encontre) ? producto : null;
    }
}