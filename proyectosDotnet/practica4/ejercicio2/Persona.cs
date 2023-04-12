namespace ejercicio2;

class Persona 
{
    private string _nombre;
    private string _edad;
    private string _dni;

    public Persona(string nombre, string edad, string dni)
    {
        _nombre = nombre;
        _edad = edad;
        _dni = dni;
    }

    public Persona()
    {
    }

    public void Imprimir(List<Persona> p) {
        for(int i = 0; i<p.Count; i++)
        {
            Console.WriteLine($"{i+1}) {p.ElementAt(i)._nombre} {p.ElementAt(i)._edad} {p.ElementAt(i)._dni}");
        }
    }

}