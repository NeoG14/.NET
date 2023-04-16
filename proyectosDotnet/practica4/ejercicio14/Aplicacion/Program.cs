using Figuras;
using Automotores;
//El constructor de Circulo espera recibir el radio
var listaCirculos = new List<Circulo>() {
    new Circulo(1.1),
    new Circulo(3),
    new Circulo(3.2)
};
//El constructor de Rectángulo espera recibir la base y la altura
var listaRectangulos = new List<Rectangulo>() {
    new Rectangulo(3, 4),
    new Rectangulo(4.3, 4.4)
};

//La clase Auto está codificada como la vista en la teoría
var listaAutos = new List<Auto>(){
    new Auto("Nissan", 2017),
    new Auto("Ford", 2015),
    new Auto("Renault")
};
foreach(Circulo c in listaCirculos)
{
    Console.WriteLine($"Área del círculo {c.GetArea()}");
}
foreach(Rectangulo r in listaRectangulos)
{
    Console.WriteLine($"Área del rectángulo {r.GetArea()}");
}
foreach(Auto a in listaAutos)
{
    Console.WriteLine(a.GetDescripcion());
}
