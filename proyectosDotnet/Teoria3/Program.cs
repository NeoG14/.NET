/*
string marca = "Ford";
int modelo = 2000;
string st = string.Format("Es un {0} año {1}", marca, modelo);
Console.WriteLine(st);
*/
/*
string marca = "Ford";
int modelo = 2000;
string st = string.Format($"Es un {marca} año {modelo}");
Console.WriteLine(st);
*/
//Cadenas interpoladas
/*
string marca = "Ford";
int modelo = 2000;
Console.WriteLine($"Es un {marca,7} año {modelo}");
Console.WriteLine($"Es un {"Nissan",7} año {2020}");
*/

/*
string marca = "Ford";
 int modelo = 2000;
 Console.WriteLine($"Es un {marca,-7} año {modelo}");
 Console.WriteLine($"Es un {"Nissan",-7} año {2020}");
*/
/*
double r = 2.417;
Console.WriteLine($"Valor = {r:0.0}");
Console.WriteLine($"Valor = {r:0.00}");
Console.WriteLine($"Valor = {r:0.000}");
*/

//Colecciones y listas
/*
List<int> lista = new List<int>() { 10, 20, 30, 40 };
for (int i = 0; i < lista.Count; i++)
{
 Console.WriteLine(lista[i]);
}
*/

/*
List<int> lista = new List<int>() { 10, 20, 30, 40 };
lista.Add(55);
for (int i = 0; i < lista.Count; i++)
{
 Console.WriteLine(lista[i]);
}
*/

/*
List<int> lista = new List<int>() { 10, 20, 30, 40 };
int[] vector = new int[] { 31, 32, 33 };
lista.InsertRange(3,vector);
for (int i = 0; i < lista.Count; i++)
{
 Console.WriteLine(lista[i]);
}
*/

//Excepciones
/*
double[]? vector = new double[10];
void Procesar(double[]? v, int i, int c)
{
    c = c + 10;
    if(c!=0 && v!=null && i<v.Length & i>=0){
        v[i] = 1000 / c;
        Console.WriteLine(v[i]);
    }
    else{
        Console.WriteLine("No procesado");
    }
}

Procesar(null, 1, 1);
Procesar(vector, 10, 1);
Procesar(vector, -1, 1);
Procesar(vector, 1, -10);
Procesar(vector, 1, 1);
*/

/*
double[]? vector = new double[10];
void Procesar(double[]? v, int i, int c)
{
    try{
        c = c + 10;
        v[i] = 1000 / c;
        Console.WriteLine(v[i]);
    }
    catch(Exception e){
        Console.WriteLine(e.Message);
    }
}

Procesar(null, 1, 1);
Procesar(vector, 10, 1);
Procesar(vector, -1, 1);
Procesar(vector, 1, -10);
Procesar(vector, 1, 1);
*/
//Overflow
/*
byte b = 255;
b++;
Console.WriteLine(b);
*/

try {
    Metodo1();
} 
catch {
    Console.WriteLine("catch en Main");
}
void Metodo1() {
    try {
    throw new Exception();
    }    
    catch {
        Console.WriteLine("catch en Metodo1");
        //throw;
    }
}





