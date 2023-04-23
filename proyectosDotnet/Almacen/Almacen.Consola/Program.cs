using Almacen.Aplicacion;
using Almacen.Repositorios;
/*
//configuro las dependencias
IRepositorioProducto repo = new RepositorioProductoTXT();

//creo los casos de uso
var agregarProducto = new AgregarProductoUseCase(repo);
var listarProducto = new ListarProductosUseCase(repo);
var obtenerProducto = new ObtenerProductoUseCase(repo);

//ejecuto los casos de uso
//agregarProducto.Ejecutar(new Producto() {Nombre="Yerba"});
//agregarProducto.Ejecutar(new Producto() {Nombre="Azúcar"});
//agregarProducto.Ejecutar(new Producto() {Nombre="Arroz"});
//agregarProducto.Ejecutar(new Producto() {Nombre="Fideos"});
var lista = listarProducto.Ejecutar();

foreach(Producto p in lista)
{
    Console.WriteLine(p);
}


Console.WriteLine();
Producto? p1 = obtenerProducto.Ejecutar(7);
if(p1!=null) 
    Console.WriteLine(p1); 
else 
    Console.WriteLine("No se encontro el producto");
*/

//Obtener la ultima linea de un archivo y un campo especifico
/*
int id = 1;
string path = @".\productos.txt";
FileInfo archivo = new FileInfo(path);
if(!archivo.Exists) //Si el archivo no existe retorna ID 1 para agergar el primer producto
    Console.WriteLine(id);
else
{
    id = int.Parse(File.ReadLines(path).Last().Split(',')[0]);
    Console.WriteLine(id+1);
}
*/

string path = @".\productos.txt";
string _nombreArch = "productos.txt";
//using var sr = new StreamReader(_nombreArch);

string[] prods = File.ReadAllLines(path);

string[] nombres = new string[prods.Length];
for(int i=0; i<prods.Length;i++)
{
    nombres[i] = prods[i].Split(',')[1];
}

if(nombres.Contains("Lawea"))
    Console.WriteLine("YA EXISTE");
else    
    Console.WriteLine("Valido");

Console.ReadLine();

    
