using ejercicio2;

List<Persona> leerDatos()
{
    List<Persona> personas = new List<Persona>();
    Console.Write("Ingrese datos: Nombre,Documento,Edad ");
    string st = Console.ReadLine();
    while (st != "fin")
    {
        string[] datos = st.Split(',');
        Persona p = new Persona(datos[0],datos[1],datos[2]);
        personas.Add(p);
        Console.Write("Ingrese datos: Nombre,Documento,Edad ");
        st = Console.ReadLine();
    }
    return personas;
}

Persona p = new Persona();

p.Imprimir(leerDatos());