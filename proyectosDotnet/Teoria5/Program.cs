using Teoria5;
/*
Cuenta c1 = new Cuenta();
Cuenta c2 = new Cuenta();
c1.Monto = 20;
Cuenta.Total += c1.Monto;
c2.Monto = 30;
Cuenta.Total += c2.Monto;
Cuenta.ImprimirResumen(); 
Cuenta c1 = new Cuenta();
c1.Agregar(1);
*/

/*
Cuadrado c = new Cuadrado();
c.Lado = 3;
Console.WriteLine($"Lado: {c.Lado} área: {c.Area}");
*/

/*
Persona p = new Persona();
p.Nombre = "JUAN";
Console.WriteLine(p.Nombre);
p.Nombre = "MATIAS";
Console.WriteLine(p.Nombre);
*/

Familia f = new Familia();
f.Padre = new Persona("Juan", 50);
f[1] = new Persona("María", 40);
f[2] = new Persona("José", 15);

for (int i = 0; i < 3; i++)
{
    f[i]?.Imprimir();
}


Console.ReadLine();
