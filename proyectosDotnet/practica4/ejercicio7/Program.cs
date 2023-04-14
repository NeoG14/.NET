using ejercicio7;


ABB ab = new ABB();
ab.insertar(7,ab.raiz);
ab.insertar(4,ab.raiz);
ab.insertar(2,ab.raiz);

foreach (int i in ab.getInOrden())
{
Console.Write(i + " ");
}

Console.ReadLine();