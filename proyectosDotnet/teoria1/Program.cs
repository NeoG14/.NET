/*
double r1 = 17 / 3;
double r2 = 17 / 3.0;

Console.WriteLine("r1 = "+r1);
Console.WriteLine("r2 = "+r2);
*/

/*
int x = 2;
int y = 5;
Console.WriteLine(x != 0 && y / x == 2);
Console.WriteLine(x != 0 & y / x == 2);
Console.WriteLine(x == 0 || y / x == 2);
Console.WriteLine(x == 0 | y / x == 2);
*/

/*
int x = 1;
 Console.WriteLine(x++); //post incremento
 Console.WriteLine(x);

x = 1;
 Console.WriteLine(++x); //pre incremento
 Console.WriteLine(x); 
 */

/*
 int x = 10;
 int y = x--; //post decremento
 Console.WriteLine(y);
 Console.WriteLine(x);
 y = --x; //pre decremento
 Console.WriteLine(y);
 Console.WriteLine(x); 
 */

/*
 int x = 10;
 Console.WriteLine(x++ == 10);
 Console.WriteLine(x-- == 10);
 Console.WriteLine(++x == 10);
 Console.WriteLine(--x == 10);
*/
/*
Console.WriteLine("Ingrese su nombre");
 string nombre = Console.ReadLine();
 Console.WriteLine("Hola " + nombre);
*/

Console.Write("Ingrese un numero: ");
int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 1; i<=n; i++){
    suma+=i;
}
Console.WriteLine("La sumatoria de 1 hasta "+n+" = "+suma);