/*
Console.CursorVisible = false;
ConsoleKeyInfo k = Console.ReadKey(true);
while (k.Key != ConsoleKey.End) {
    Console.Clear();
    Console.Write($"{k.Modifiers}-{k.Key}-{k.KeyChar}");
    k = Console.ReadKey(true);
}
*/

//2 Imprimir todos los elementos de una matriz
/*
double[,] matriz = new double[,]
{ {1,2,3,4},
  {5,6,7,8},
  {9,10,11,12} };
//matriz.GetLength(0) la cantidad de filas
//matriz.GetLength(1) la cantidad de comulnas

void ImprimirMatriz(double[,] matriz){
    for (int i=0;i<matriz.GetLength(0);i++){
        for (int j=0;j<matriz.GetLength(1);j++)
            Console.Write(" "+matriz[i,j]);
        Console.WriteLine();
    }
}
/*

/* Preguntar En consulta
void ImprimirMatrizConFormato(double[,] matriz, string formatString){
    double formato = Convert.ToDouble(formatString);
    Console.WriteLine(formato);
    for (int i=0;i<matriz.GetLength(0);i++){
        for (int j=0;j<matriz.GetLength(1);j++)
            Console.Write($" {matriz[i,j]:formatString}");
        Console.WriteLine();
    }
}
*/
//ImprimirMatriz(matriz);
//ImprimirMatrizConFormato(matriz, "0.0");

// 4
/*
double[,] matriz = new double[,]
{ {1,2,3,4},
  {5,6,7,8},
  {9,10,11,12},
  {13,14,15,16} };

double[] GetDiagonalPrincipal(double[,] matriz){
    if(matriz.GetLength(0) == matriz.GetLength(1)){
        double[] vector = new double[matriz.GetLength(0)];
        for(int i=0;i<matriz.GetLength(0);i++)
            vector[i]=matriz[i,i];
        return vector;
    }else {
        throw new ArgumentException();
    }
}

double[] GetDiagonalSecundaria(double[,] matriz){
    if(matriz.GetLength(0) == matriz.GetLength(1)){
        double[] vector = new double[matriz.GetLength(0)];
        int aux=0;
        for(int i=(matriz.GetLength(0)-1) ;i>=0 ;i--)
            vector[aux++]=matriz[i,i];  
        return vector;
    }else {
        throw new ArgumentException();
    }
}
    
try
{
    double[] vector = GetDiagonalPrincipal(matriz);
    foreach(double d in vector)
        Console.Write(" "+d);
    Console.WriteLine();
    double[] vector2 = GetDiagonalSecundaria(matriz);
    foreach(double d in vector2)
        Console.Write(" "+d);
}
catch (ArgumentException e)
{
    
    Console.WriteLine(e.Message);
}
*/

//5
/*
double[,] matriz = new double[,]
{ {1,2,3,4},
  {5,6,7,8},
  {9,10,11,12} };

//Console.WriteLine(matriz.GetLength(0));
//Console.WriteLine(matriz.GetLength(1));

double[][] GetArregloDeArreglo(double [,] matriz){
    double[][] arregloDeArreglo = new double[matriz.GetLength(0)][];//Asigno la cantidad de filas de arreglos que va a tener mi arreglo de arreglos
    for (int i=0;i<matriz.GetLength(0);i++){
        arregloDeArreglo[i] = new double[matriz.GetLength(1)];//Una vez completada la fila creo otro arreglo de longitud=cantidad de columnas
        for (int j=0;j<matriz.GetLength(1);j++)
            arregloDeArreglo[i][j] = matriz[i,j];
    }
    return arregloDeArreglo;
}


//double[][] p = GetArregloDeArreglo(matriz);
Console.Write(GetArregloDeArreglo(matriz)[1][2]);
*/

//6
/*
double[,] matriz1 = new double[,]
{ {1,2,3},
  {4,5,6},
  {7,8,9} };

  double[,] matriz2 = new double[,]
{ {6,5},
  {4,3},
  {1,2} };

void imprimirMatriz(double[,] matriz) {
    for(int i = 0;i<matriz.GetLength(0);i++){
            for(int j=0;j<matriz.GetLength(1);j++)
                Console.Write(matriz[i,j]+",");
            Console.WriteLine();
        }
}

double[,] Suma(double[,] A, double[,] B) {
    if( (A.GetLength(0)!=B.GetLength(0)) | (A.GetLength(1)!=B.GetLength(1)))
        return null;
    else {
        double [,] matriz = new double[A.GetLength(0),A.GetLength(1)];
        for(int i = 0;i<A.GetLength(0);i++){
            for(int j=0;j<A.GetLength(1);j++)
                matriz[i,j] = (A[i,j]+B[i,j]);
        }
        return matriz;
    }
}

double[,] Resta(double[,] A, double[,] B) {
    if( (A.GetLength(0)!=B.GetLength(0)) | (A.GetLength(1)!=B.GetLength(1)))
        return null;
    else {
        double [,] matriz = new double[A.GetLength(0),A.GetLength(1)];
        for(int i = 0;i<A.GetLength(0);i++){
            for(int j=0;j<A.GetLength(1);j++)
                matriz[i,j] = (A[i,j]-B[i,j]);
        }
        return matriz;
    }
}

double[,] Multiplicacion(double[,] A, double[,] B) {
    if( (A.GetLength(1)!=B.GetLength(0)) )
        return null;
    else {
        double [,] matriz = new double[A.GetLength(0),B.GetLength(1)];//cantidad filas A y cantidad columnas B
        double suma=0;
                           //columnas B
        for (int a = 0; a<B.GetLength(1); a++){
                            //filas A
            for(int i = 0;i<A.GetLength(0);i++) {
                suma=0;
                                //columnas A
                for(int j = 0;j<A.GetLength(1);j++)
                    suma += (A[i,j]*B[j,a]);
                //Console.WriteLine(suma);
                matriz[i,a]=suma;
            }
        }
        return matriz;
    }
}

double[,] total = Multiplicacion(matriz1,matriz2);

if(total!=null)
    imprimirMatriz(total);
else
    Console.WriteLine("Las matrices deben ser de igual dimensión");
*/

//7
/*
int i = 10;
var x = i * 1.0; //double
var y = 1f;//float
var z = i * y;//float
Console.WriteLine(x.GetType());
Console.WriteLine(y.GetType());
Console.WriteLine(z.GetType());
*/

//8 ¿Qué líneas del siguiente método provocan error de compilación y por qué?
/*
var a = 3L;
dynamic b = 32;
object obj = 3;
//a = a * 2.0; // no se puede convertir porque ya existe una convesion explicita
b = b * 2.0;
b = "hola";
obj = b;
b = b + 11;
//obj = obj + 11;// operador + aplicado a operando de tipo object
var c = new { Nombre = "Juan" };
var d = new { Nombre = "María" };
var e = new { Nombre = "Maria", Edad = 20 };
var f = new { Edad = 20, Nombre = "Maria" };
//f.Edad = 22;
d = c;
//e = d;
//f = e;
Console.WriteLine(f.GetType());
*/

//9
/*
object obj = new int[10];
dynamic dyn = 13;
Console.WriteLine(obj.Length);//error en compilacion 
Console.WriteLine(dyn.Length);//error en tiempo de ejecucion
//no contiene una definición para "Length" ni un método de extensión accesible "Length"
*/

//10 Redondea
/*
double r = 2.417;
Console.WriteLine($"Valor = {r,2:0.0}");
*/

//11
/*
List<int> a = new List<int>() { 1, 2, 3, 4 };
a.Remove(5);
a.RemoveAt(4); //Index was out of range.
*/

//12
/*
string cifrarPalabra(int[] clave, string palabra) {
    Char[] valores = new char[] {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','Ñ','O','P','Q','R','S','T','U','V','W','X','Y','Z',' '};
    Queue<int> cola = new Queue<int>();
    foreach(int n in clave){
        cola.Enqueue(n);  //Encolar los valores de la clave
    }
    int[] valores_cifrados = new int[palabra.Length];

    for (int i = 0; i<palabra.Length;i++){
        char c = palabra.ElementAt(i);
        int v = Array.IndexOf(valores,c)+1;
        //Desencolo el valor del principio y lo vuelvo a a gregar al final
        int n_cola = cola.Dequeue();
        cola.Enqueue(n_cola);
        v+=n_cola;
        if(v>28)
            valores_cifrados[i]=v-28;
        else
            valores_cifrados[i]=v;
    }
    string p = "";
    foreach(int n in valores_cifrados)
        p+= valores[n-1];
    return p;
}

string descifrarPalabra(int[] clave, string palabra) {
    Char[] valores = new char[] {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','Ñ','O','P','Q','R','S','T','U','V','W','X','Y','Z',' '};
    Queue<int> cola = new Queue<int>();
    foreach(int n in clave){
        cola.Enqueue(n);  //Encolar los valores de la clave
    }
    int[] valores_cifrados = new int[palabra.Length];

    for (int i = 0; i<palabra.Length;i++){
        char c = palabra.ElementAt(i);
        int v = Array.IndexOf(valores,c)+1;
        //Desencolo el valor del principio y lo vuelvo a a gregar al final
        int n_cola = cola.Dequeue();
        cola.Enqueue(n_cola);
        v-=n_cola;
        if(v<1)
            valores_cifrados[i]=v+28;
            //Console.Write(v+28+" ");
        else
            //Console.Write(v+" ");
            valores_cifrados[i]=v;
    }
    string p = "";
    foreach(int n in valores_cifrados)
        p+= valores[n-1];
    return p;
}

int[] clave = new int[] {8,5,13,4};
string palabra = "HOLA MUNDO";

Console.WriteLine("Texto Original: "+palabra);
string palabra_cifrada = cifrarPalabra(clave,palabra);
Console.WriteLine("Texto Cifrada: "+palabra_cifrada);
string palabra_descifrada = descifrarPalabra(clave,palabra_cifrada);
Console.WriteLine("Texto Descifrado: "+palabra_descifrada);
*/

//13
/*
string balanceado = "(()(())())";
string no_balanceado = "((())(())";

bool verificarCadena(string cadena) {
    Stack<char> pila = new Stack<char>();
    for(int i=0;i<cadena.Length;i++) {
        char c = cadena.ElementAt(i);
        if(c == '(')
            pila.Push(c);
        else if(c==')') {
            if(pila.Count == 0)
                return false;
            pila.Pop();    
        }
    }
    if(pila.Count == 0)
        return true;
    else
        return false;
}
Console.WriteLine(verificarCadena(balanceado));


//14
/*
string aBinario(int n){
    Stack<int> pila = new Stack<int>();
    while(n>0) {
        pila.Push(n%2);
        n/=2;
    }
    string bin = "";
    while(pila.Count>0)
        bin += pila.Pop();
    return bin;
}
Console.WriteLine(aBinario(100));
*/

//15 
//Floating point division is govered by IEEE754, which specifies that divide by zero should be infinity. There is no such standard for integer division, so they simply went with the standard rules of math.
/*
int x = 0;
try
{
Console.WriteLine(1.0 / x);
//Console.WriteLine(1 / x);
Console.WriteLine("todo OK");
}
catch (Exception e)
{
Console.WriteLine(e.Message);
}
*/

//16
/*
void sumar() {
    Console.Write("Ingrese un entero: ");
    string n = Console.ReadLine();
    int sum=0;
    while(n!=""){
        try {
            int num = Convert.ToInt32(n);
            sum+=num;
            Console.WriteLine("La suma es: "+sum);
        }
        catch (System.Exception) {
            
            Console.WriteLine("No ingreso un numero valido: ");
        }
        Console.Write("Ingrese un entero: ");
        n = Console.ReadLine();
    }
}
sumar();
*/
//17
/*
char[] delimitadores = {'+','-','/','*'};
string operacion = "44.5/456";
char op='c';
string[] nums_txt = {"a"};

if(operacion.Contains('+')){
    nums_txt = operacion.Split('+');
    op='+';
}
else
    if(operacion.Contains('-')){
        nums_txt = operacion.Split('-');
        op='-';
    }
    else
        if(operacion.Contains('/'))
        {
            nums_txt = operacion.Split('/');
            op='/';
        }
            
        else
            if(operacion.Contains('*')){
                nums_txt = operacion.Split('*');
                op='*';
            }
                

double resultado=0;
try
{
    double[] nums = {0,0};
    for(int i=0;i<nums_txt.Length;i++){
        nums[i]=Convert.ToDouble(nums_txt[i]);
    }
    double n1,n2;
    n1=nums[0];
    n2=nums[1];
    switch (op)
    {
        case '+':resultado=n1+n2;
            break;
        case '-':resultado=n1-n2;
            break;
        case '/':resultado=n1/n2;
            break;
        case '*':resultado=n1*n2;
            break;
    }
}
catch (System.Exception)
{
    Console.WriteLine("Los numeros no son correctos");
}

Console.WriteLine($"resultado: {resultado}");
*/

try {
    Metodo1();
}
catch {
    Console.WriteLine("Método 1 propagó una excepción no tratada");
}
try {
    Metodo2();
}
catch {
    Console.WriteLine("Método 2 propagó una excepción no tratada");
}
try {
    Metodo3();
}
catch {
    Console.WriteLine("Método 3 propagó una excepción");
}

void Metodo1() {
    object obj = "hola";
    try {
        int i = (int)obj;
    }
    finally {
        Console.WriteLine("Bloque finally en Metodo1");
    }
}

void Metodo2() {
    object obj = "hola";
    try {
        int i = (int)obj;
    }
    catch (OverflowException) {
        Console.WriteLine("Overflow");
    }
}

void Metodo3() {
    object obj = "hola";
    try {
        int i = (int)obj;
    }
    catch (InvalidCastException) {
        Console.WriteLine("Excepción InvalidCast en Metodo3");
        throw;
    }
}





















