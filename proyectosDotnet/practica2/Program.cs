// 1 Qué líneas del siguiente código provocan conversiones boxing y unboxing
/*
char c1 = 'A';
string st1 = "A";
object o1 = c1; //Boxing
object o2 = st1;//nada ya que st es de tipo referencia
char c2 = (char)o1;//Unboxing
string st2 = (string)o2;//Unboxing
*/

//2 Ni idea Preguntar
/*
object o1 = "A";
object o2 = o1;
o2 = "Z";
Console.WriteLine(o1 == o2);
Console.WriteLine(o1 + " " + o2);
*/

// 3. Analizar la siguiente porción de código para calcular la sumatoria de 1 a 10. ¿Cuál es el error?
//¿Qué hace realmente? 
// Se queda en un bucle infinito por culpa del ; al final de la condición del while
/**
int sum = 0;
int i = 1;
while (i <= 10);
{
sum += i++;
}
*/

//4. ¿Cuál es la salida por consola si no se pasan argumentos por la línea de comandos?
/*
Console.WriteLine(args == null); //False
Console.WriteLine(args.Length); // 0
*/

//5. ¿Qué hace la instrucción?
/*
int[]? vector = new int[0]; // Crea un vector de longitud 0
Console.WriteLine(vector == null);
*/
//¿asigna a la variable vector el valor null? No, no le asigna ningun valor

// 6  Determinar qué hace el siguiente programa y explicar qué sucede si no se pasan parámetros
//cuando se invoca desde la línea de comandos.
//Console.WriteLine("¡Hola {0}!", args[0]);
//El codigo recibe un parametro por consola y lo concatena a Hola utilizando el format
//Si no se recibe ningun parametro lanza una excepción

//7. Analizar el siguiente código. ¿Qué líneas producen error de compilación y por qué?
/*
char c;
char? c2;
string? st;
c = ""; // Se intenta asignar un string a un char
c = ''; // Caracter vacio a un char
c = null;// Intentar asignar null a un tipo de valor
c2 = null;
c2 = (65 as char?);
st = "";
st = ''; // Literal de caracter vacio
st = null;
st = (char)65; //No se puede convertir implicitamente el tipo 'char' en 'string'
st = (string)65;// No se puede convertir el tipo int en string
st = 47.89.ToString();
*/

//8.  Escribir un programa que reciba una lista de nombres como parámetro e imprima por consola un
//saludo personalizado para cada uno de ellos.
//a) utilizando la sentencia for
//b) utilizando la sentencia foreach

/*
for(int i=0;i<args.Length;i++){
    Console.WriteLine("Hola "+args[i]+"!!"); 
}
*/
/*
foreach (string st in args){
    Console.WriteLine("Hola "+st+"!!"); 
}
*/

//9. El StringBuilder permite modificar cada caracter del string individualmente
//La clase String crea una nueva cadena cada vez que se modifica, esto puede tener
//un impacto significativo en el rendimiento si el proceso modifica repetidamente el string
//Considere la posibilidad de usar la StringBuilder clase en estas condiciones:
/*
Cuando se espera que el código realice un número desconocido de cambios en una cadena en 
tiempo de diseño (por ejemplo, cuando se usa un bucle para concatenar un número aleatorio 
de cadenas que contienen la entrada del usuario).

Cuando espera que el código realice un número significativo de cambios en una cadena.
*/

//10 DateTime
/*
DateTime inicio = DateTime.Now;
int suma=0;
for (int i=0;i<=10;i++){
    suma+=i;
}
Console.WriteLine(suma);
double tiempo = DateTime.Now.Subtract(inicio).Microseconds;
Console.WriteLine(tiempo);
Console.ReadKey();
*/

//11. ¿Para qué sirve el método Split de la clase string? Usarlo para escribir en la consola todas
//las palabras (una por línea) de una frase ingresada por consola por el usuario.

/*
Console.WriteLine("Ingrese una cadena: ");
String st = Console.ReadLine();
string[] palabras = st.Split(' ');

foreach (string palabra in palabras)
{
    Console.WriteLine(palabra);
}
*/

//13.
/*
for (Meses m = Meses.Diciembre; m >= Meses.Enero; m--)
{
    Console.WriteLine((Meses)m);
}

Console.Write("Ingrese nombre de un mes: ");
string nombre_mes = Console.ReadLine();
for (Meses m = Meses.Enero; m <= Meses.Diciembre; m++)
{
    if (nombre_mes == m.ToString())
    {
        Console.WriteLine("El mes es igual");
    }
}
enum Meses
{
    Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre
}
*/

//14.
/*
int n = int.Parse(args[0]);
bool EsPrimo(int n)
{
    int raiz = Convert.ToInt32(Math.Sqrt(n));
    bool valor =true;
    for (int i = 2; i <= raiz; i++)
    {
        if (n % i == 0)
            valor= false;
    }
    return valor;
}
for (int i = 2; i <= n; i++)
{
    if (EsPrimo(i))
        Console.Write(i + ",");
}
*/


//15
/*
Console.Write("Ingrese un numero: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
int Fib(int n){
    if(n<=2)
        return 1;
    else{
       return Fib(n-1) + Fib(n-2);
    }
}
for(int i=1;i<n;i++)
    sum+=Fib(n);
Console.WriteLine(Fib(n));
*/

//16
/*
int Fac(int n){
    int fac = 1;
    for (int i=1;i<=n;i++)
        fac = fac * i;
    return fac;
}
*/

/*
int Fac(int n){
    if(n==0)
        return 1;
    return n * Fac(n-1);
}
*/
/*
int Fac(int n) => n == 0 ? 1 : n * Fac(n-1);
Console.WriteLine(Fac(5));
*/

//17
/*
void Fac(int n, out int f){
    f = 1;
    for (int i=1;i<=n;i++)
        f = f * i;
}
int f
Fac(5,out f);
Console.WriteLine(f);
*/
//Ni puta idea
/*
void Fac(int n, out int f){
    f=0;
    if(n>=0)
        f += n*(n-1) ;
    Fac(n-1,out f);
}
int f;
Fac(5,out f);
Console.WriteLine(f);
*/

//18
/*
void Swap(int n1, int n2){
    Console.WriteLine("n1="+n1+" n2="+n2);
    int aux=n1;
    n1=n2;
    n2=aux;
    Console.WriteLine("n1="+n1+" n2="+n2);
}
int n1=3;
int n2=9;
Swap(n1,n2);
Console.WriteLine("n1="+n1+" n2="+n2);
*/

//19
/*
void Imprimir(params object[] parametros){
    foreach(object s in parametros){
        Console.Write(Convert.ToString(s)+" ");
    }
    Console.WriteLine();
}

Imprimir(1, "casa", 'A', 3.4, DayOfWeek.Saturday);
Imprimir(1, 2, "tres");
Imprimir();
Imprimir("-------------");
*/






