using Teoria7;
/*
object[] vector = new object[] {
       new Moto("Zanella"),
       new Empleado("Juan"),
       new Moto("Gilera"),
   };
*/
/*
foreach (IImprimible imp in vector)
{
   imp.Imprimir();
}
*/
//Mejor Solucion este vector solo acepta elementos de tipo IImprimible
IImprimible[] vector = new IImprimible[]{
    new Moto("Zanella"),
    new Empleado("Juan"),
    new Moto("Gilera"),
};


for (int i = 0; i < vector.Length; i++)
{
    /*
    if(vector[i] is IImprimible imp)
        imp.Imprimir();
    */
    vector[i].Imprimir();
}
Console.ReadLine();