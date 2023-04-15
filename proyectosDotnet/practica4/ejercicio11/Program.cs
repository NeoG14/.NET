
//11) Qué salida produce en la consola el siguiente programa?

object o = 5;
Sobrecarga s = new Sobrecarga();
s.Procesar(o, o);
s.Procesar((dynamic)o, o);
s.Procesar((dynamic)o, (dynamic)o);
s.Procesar(o, (dynamic)o);
s.Procesar(5, 5);
Console.ReadLine();
class Sobrecarga
{
    public void Procesar(int i, object o)
    {
        Console.WriteLine($"entero: {i} objeto:{o}");
    }
    public void Procesar(dynamic d1, dynamic d2)
    {
        Console.WriteLine($"dynamic d1: {d1} dynamic d2:{d2}");
    }
}
/*
dynamic d1: 5 dynamic d2:5
entero: 5 objeto:5
entero: 5 objeto:5
dynamic d1: 5 dynamic d2:5
entero: 5 objeto:5
*/