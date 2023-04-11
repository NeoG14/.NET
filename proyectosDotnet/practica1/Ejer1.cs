//Ejercicio 1
/*
Console.WriteLine("Presione Enter para mostrar palabra a palabra");
Console.Write("Hola ");
while (Console.ReadKey().Key != ConsoleKey.Enter);
Console.Write("Mundo");
*/

//Ejercicio 2
/*
//Uso de las secuencias de escape \n, \t, \
Console.WriteLine("Hola\n mundo"); //Salto de linea
Console.WriteLine("Hola\t mundo"); //Tabulación
Console.WriteLine("Hola\\ mundo"); // Escape de caracter
*/

//Ejercicio 3
/*
string st = "c:\\windows\\system";
Console.WriteLine(st);
*/

//Ejercicio 4
/*
Console.Write("Ingrese su nombre: ");
string nombre = Console.ReadLine();
if(string.IsNullOrEmpty(nombre)){ //Verifica si un string esta vacio
    Console.WriteLine("Hola Mundo");
}else {
    Console.WriteLine("Hola "+nombre);
}
*/

//Ejercicio 5a
/*
int num = 1;
while(num==1){
Console.Write("Ingrese su nombre: ");
string nombre = Console.ReadLine();
if(nombre == "Juan"){
    Console.WriteLine("¡Hola amigo!");
}
else if (nombre == "Maria"){
    Console.WriteLine("Buen día señora");
}
else if(nombre == "Alberto"){
    Console.WriteLine("Hola Alberto");
}
else if(!string.IsNullOrEmpty(nombre)){
    Console.WriteLine("Buen dia");
}
else {
    Console.WriteLine("¡Buen día mundo!");
}
Console.WriteLine("Ingrese 1 para continuar, otro para salir");
num = int.Parse(Console.ReadLine());
}
*/

//Ejercicio 5b
/*
int num = 1;
while(num==1){
    Console.Write("Ingrese su nombre: ");
    string nombre = Console.ReadLine();
    switch(nombre)
    {
        case "Juan":
            Console.WriteLine("¡Hola amigo!");
            break;
        case "Maria":
            Console.WriteLine("Buen día señora");
            break;
        case "Alberto":
            Console.WriteLine("Hola Alberto");
            break;
        case "":
            Console.WriteLine("¡Buen día mundo!");
            break;
        default:
            Console.WriteLine("¡Buen día");
            break;
    }
    Console.WriteLine("Ingrese 1 para continuar, otro para salir");
    num = int.Parse(Console.ReadLine());
}
*/
//Ejercicio 6 
/*
string st;
Console.Write("Ingrese texto: ");
st = Console.ReadLine();
while(st != ""){
    Console.WriteLine("La longitud de la cadena es: "+st.Length);
    Console.Write("Ingrese texto: ");
    st = Console.ReadLine();
}
*/

//Ejercicio 7 
/*
Console.WriteLine("1000".Length); //Me devuelve la longitud de la cadena al leerla
*/

//Ejercicio 8
/*
String st;
Console.WriteLine(st=Console.ReadLine());//Esto es valido
*/

//Ejercicio 9
/*
string st1 = "abbccd";
string st2 = "dccaba";
bool valor = true;
if(st1.Length == st2.Length) {
    for(int i=0;i<=st1.Length-1;i++){
        if(st1[i] != st2[st2.Length-(i+1)]){
            valor = false;
        }
    }
}else{
    valor = false;
}
if(valor){
    Console.WriteLine("Las cadenas son iguales");
}else{
    Console.WriteLine("Las cadenas son distintas");
}
*/

//Ejercicio 10
/*
for (int i=1; i<=1000; i++){
    if(i%19==0 | i%29==0){
        Console.Write(" "+i);
    }
}
*/

//Ejercicio 11
/*
Console.WriteLine("10/3 = " + 10 / 3);
Console.WriteLine("10.0/3 = " + 10.0 / 3);
Console.WriteLine("10/3.0 = " + 10 / 3.0);
int a = 10, b = 3;
Console.WriteLine("Si a y b son variables enteras, si a=10 y b=3");
Console.WriteLine("entonces a/b = " + a / b);
double c = 3;
Console.WriteLine("Si c es una variable double, c=3");
Console.WriteLine("entonces a/c = " + a / c);
//La operacion division "/" es decimal si uno de los operandos es un decimal, por defecto entera
//El operador "+" entre un string y und ato numerico lo concatena como un string
*/

//Ejercicio 12
/*
Console.Write("Ingrese un numero: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Los Divisores de "+num+" son: ");
for (int i=1;i<=num;i++){
    if(num%i==0){
        Console.Write(" "+i);
    }
}
*/

//Ejercicio13
/*
Console.Write("Ingrese numero 1: ");
double n1 = double.Parse(Console.ReadLine());
Console.Write("Ingrese numero 2: ");
double n2 = double.Parse(Console.ReadLine());
//string st = String.Format("La suma de "+n1+"+"+n2+" = "+(n1+n2));
Console.WriteLine(String.Format("La suma de {0} + {1} = {2}",n1,n2,n1+n2));
*/

//Ejercicio 14
/*
Console.Write("ingrese un entero: ");
int num = int.Parse(Console.ReadLine());
num *= 365;
while (num != 0){
    Console.Write(num%10);
    num/=10;
}
*/

//Ejercicio 15
/*
Console.Write("Ingrese un año: ");
int anio = int.Parse(Console.ReadLine());
if(anio%4==0 & anio%100!=0){
    Console.WriteLine(anio+" Es bisiesto");
}else if(anio%100==0 & anio%400==0){
    Console.WriteLine(anio+" Es bisiesto");
}else{
    Console.WriteLine(anio+" No es bisiesto");
}
*/
/*
Console.Write("Ingrese un año: ");
int anio = int.Parse(Console.ReadLine());
if((anio%4==0 & anio%100!=0) | (anio%100==0 & anio%400==0)){
    Console.WriteLine(anio+" Es bisiesto");
}else{
    Console.WriteLine(anio+" No es bisiesto");
}
*/

//Ejercicio 16
/*
int a=7;
int b=0;
if ((b != 0) && (a/b > 5)) Console.WriteLine(a/b);
*/

//Ejercicio 17 
/*
int n1 = 9;
int n2 = 1;
int n = (n1<n2) ? n = n1 : n = n2;
Console.WriteLine(n);
*/

//Ejercicio 18
/*
for (int i = 0; i <= 4; i++)
{
string st = i < 3 ? i == 2 ? "dos" : i == 1 ? "uno" : "< 1" : i < 4 ? "tres" : "> 3";
Console.WriteLine(st);
} 
< 1 
uno
dos
tres
> 3
*/

//Ejercicio 19
//int a, b, c; Permitida
//int a; int b; int c, d; Permitida
//int a = 1; int b = 2; int c = 3; Permitida
//int b; int c; int a = b = c = 1; Permitida 1 1 1
//int c; int a, b = c = 1; Permitida pero a no se le asigna ningun valor
//int c; int a = 2, b = c = 1; Permitida 2 1 1
//int a = 2, b, c, d = 2 * a; Permitida pero b y c no se le asigna ningun valor
//int a = 2, int b = 3, int c = 4; No permitida deberian estar separadas por ;
//int a = 2; b = 3; c = 4; No permitida, no se declara el tipo de variable para b y c
//int a; int c = a; No permitida a no tiene un valor asignado
//char c = 'A', string st = "Hola"; No permitida deberias estar separada por ;
//char c = 'A'; string st = "Hola"; Permitida c=A, st="Hola"
//char c = 'A', st = "Hola"; No permitida st deberias ser char encerrada entre '' y no ""

//Ejercicio 20
//int i = 0;
/*
for (int i = 1; i <= 10;)
{
Console.WriteLine(i++);
}
*/

//Ejercicio 21
/*
int i = 1;
if (--i == 0)
{
Console.WriteLine("cero");
}
if (i++ == 0)
{
Console.WriteLine("cero");
}
Console.WriteLine(i);
*/
// cero cero 1




