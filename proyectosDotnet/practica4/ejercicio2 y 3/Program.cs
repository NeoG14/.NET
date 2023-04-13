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

Persona masJoven(List<Persona> personas)
{
    Persona pMax = new Persona("Maximo","-1","0");
    for(int i=0; i < personas.Count();i++)
    {
        if(personas.ElementAt(i).EsMayorQue(pMax))
            pMax = personas.ElementAt(i);
    }
    return pMax;
}

Persona p1 = new Persona("Juan","40","34356435");
Persona p2 = new Persona("Ana","26","4556435");
Persona p3 = new Persona("Maria","21","1236435");
Persona p4 = new Persona("Tomas","34","21546435");
Persona p5 = new Persona("Rocio","9","3346435");

List<Persona> personas = new List<Persona>();
personas.Add(p1);
personas.Add(p2);
personas.Add(p3);
personas.Add(p4);
personas.Add(p5);

Console.WriteLine(masJoven(personas).getNombre()); 

Console.ReadLine();






