namespace Teoria5;

class Persona
{
    public int Edad { get; }
    public string Nombre { get; }
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
    public void Imprimir() => Console.WriteLine($"{Nombre} ({Edad})");


}