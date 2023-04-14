using ejercicio8;

double[,] matriz1 = new double[,]
{   
    {1,2,3},
    {5,6,7},
    {9,10,11}
};

double[,] matriz2 = new double[,]
{   
    {1,2,3},
    {5,6,7},
    {9,10,11}
};

Matriz m = new Matriz(matriz1);
Matriz m2 = new Matriz(matriz2);

void imprimirArreglo(double[] a){
    if(a!=null){
        foreach(double n in a)
            Console.Write(n+" ");
    }
}

void imprimirArregloDeArreglo(double[][] a){
    for(int i=0;i<a.GetLength(0);i++){
        foreach(double n in a[i])
            Console.Write(n+" ");
        Console.WriteLine();
    }       
    
}

//m.imprimir();
//imprimirArreglo(m.getFila(4));
//imprimirArreglo(m.getDiagonalPrincipal());
//imprimirArreglo(m.getDiagonalSecundaria());
//imprimirArregloDeArreglo(m.getArregloDeArreglo());
//m.getArregloDeArreglo();
//m.sumarle(m2);
//m.restarle(m2);
//Matriz m3 = new Matriz(m.multiplicarle(m2));
//m3.imprimir();

Console.ReadLine();