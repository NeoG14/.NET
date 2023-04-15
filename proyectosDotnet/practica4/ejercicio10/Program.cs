//10) ¿Qué se puede decir en relación a la sobrecarga de métodos en este ejemplo?


A a = new A();
//Consersion implicita de short a int
a.Metodo(5);
Console.ReadLine();

class A
{
    public void Metodo(short n)
    {
    Console.Write("short {0} - ", n);
    }
    public void Metodo(int n)
    {
    Console.Write("int {0} - ", n);
    }
    //sobrecarga invalida
    // public int Metodo(int n)
    // {
    //     return n + 10;
    // }
}