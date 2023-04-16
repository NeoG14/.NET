namespace Teoria5;
class Cuenta
{
    public int Monto;
    public static int Total;
 //public static void ImprimirResumen() => Console.WriteLine($"Monto = {Monto}");


private readonly List<object> lista = new List<object>();
public void Agregar(object obj)
{
    lista.Add(obj);
}

}
