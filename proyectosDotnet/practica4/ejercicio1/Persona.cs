namespace ejercicio1;

class Persona 
{
    public string? nombre;
    public string? edad;
    public string? dni;

    public void leerDatos()
    {
        List<Persona> personas = new List<Persona>();
        Console.Write("Ingrese datos: Nombre,Documento,Edad");
        string st = Console.ReadLine();
        while (st != "fin")
        {
            string[] datos = st.Split(',');
            Persona p = new Persona();
            p.nombre = datos[0];
            p.edad = datos[1];
            p.dni = datos[2];
            personas.Add(p);
            Console.Write("Ingrese datos: Nombre,Documento,Edad");
            st = Console.ReadLine();
        }
        for(int i = 0; i<personas.Count; i++)
        {
            Console.WriteLine($"{i+1}) {personas.ElementAt(i).nombre} {personas.ElementAt(i).edad} {personas.ElementAt(i).dni}");
        }
    }
}