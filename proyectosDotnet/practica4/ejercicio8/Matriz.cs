namespace ejercicio8;

class Matriz
{
    private int filas;
    private int columnas;
    double[,] matriz;

    public int getFilas()
    {
        return this.filas;
    }

    public int getColumnas()
    {
        return this.columnas;
    }

    public double[,] getMatriz()
    {
        return this.matriz;
    }

    public Matriz(int filas, int columnas)
    {
        this.filas = filas;
        this.columnas = columnas;
        matriz = new double[filas,columnas];
    }

    public Matriz(double[,] matriz)
    {
        filas = matriz.GetLength(0);
        columnas = matriz.GetLength(1);
        this.matriz = matriz;
    }

    public void setElemento(int fila, int columna, double elem)
    {
        if(fila<matriz.GetLength(0) && columna<matriz.GetLength(1))
            matriz[fila,columna] = elem;
        else
            Console.WriteLine("Posición invalida");
    }

    public double? getElemento(int fila, int columna)
    {
        if(fila<matriz.GetLength(0) && columna<matriz.GetLength(1))
            return matriz[fila,columna];
        else
            return null;
    }

    public void imprimir()
    {
        for(int i=0; i<this.filas; i++)
        {   
            for(int j=0; j<this.columnas; j++)
                Console.Write(matriz[i,j]+" ");
            Console.WriteLine();
        }
    }

    public void imprimir(string formatString)
    {
        for(int i=0; i<this.filas; i++)
        {   Console.Write($"fila {i+1}:");
            for(int j=0; i<this.columnas; i++)
                Console.Write(matriz[i,j].ToString(formatString));
            Console.WriteLine();
        }
    }

    public double[] getFila(int fila)
    {
        if(fila<this.filas+1)
        {
            double[] row = new double[this.columnas];
            for(int i=0; i<this.columnas; i++)
                row[i] = matriz[fila-1,i];
            return row;
        }
        Console.WriteLine("Posición invalida");
        return null;
    }

    public double[] getColumna(int columna)
    {
        if(columna<this.columnas+1)
        {
            double[] column = new double[this.filas];
            for(int i=0; i<this.filas; i++)
                column[i] = matriz[i,columna-1];
            return column;
        }
        Console.WriteLine("Posición invalida");
        return null;
    }

    public double[] getDiagonalPrincipal()
    {
        if(this.filas==this.columnas)
        {
            double[] diagonal = new double[this.filas];
            for(int i=0; i<this.filas; i++)
                diagonal[i] = matriz[i,i];
            return diagonal;
        }
        Console.WriteLine("No es una matriz cuadradada");
        return null;
    }

    public double[] getDiagonalSecundaria()
    {
        if(this.filas==this.columnas)
        {
            double[] diagonal = new double[this.filas];
            int j = this.columnas;
            for(int i=0; i<this.filas; i++)
            {
                j--;
                diagonal[i] = matriz[j,i];
            }
            return diagonal;
        }
        Console.WriteLine("No es una matriz cuadradada");
        return null;
    }

    public double[][] getArregloDeArreglo()
    {
        double[][] arreglo = new double[this.filas][];
        for(int i = 0; i<this.filas; i++)
            arreglo[i] = this.getFila(i+1);

        return arreglo;
    }

    public void sumarle(Matriz m)
    {
        double[,] mat = m.getMatriz();
        if( (m.getFilas() == this.filas) && (m.getColumnas() == this.columnas) )
        {
            for(int i = 0; i<this.filas; i++)
            {
                for(int j=0; j<this.columnas; j++)
                    this.matriz[i,j] += mat[i,j];
            }
        }
        else
            Console.WriteLine("Las matrices no coinciden");
    }

    public void restarle(Matriz m)
    {
        double[,] mat = m.getMatriz();
        if( (m.getFilas() == this.filas) && (m.getColumnas() == this.columnas) )
        {
            for(int i = 0; i<this.filas; i++)
            {
                for(int j=0; j<this.columnas; j++)
                    this.matriz[i,j] -= mat[i,j];
            }
        }
        else
            Console.WriteLine("Las matrices no coinciden");
    }

    public double[,] multiplicarle(Matriz m)
    {
        double[,] mat = m.getMatriz();
        if(this.filas == m.getColumnas()) 
        {
            double[,] multiplicacion = new double[this.filas,m.getColumnas()];
            for(int fila=0; fila<this.filas; fila++)
            {
                for(int i=0; i<this.columnas;i++)
                {
                    for(int j=0; j<m.getFilas();j++)
                    {
                        multiplicacion[fila,i] += this.matriz[fila,j] * mat[j,i];
                    }
                }
            }
            return multiplicacion;
        }
        else
            Console.WriteLine("Las matrices no coinciden");
            return null;
    }
}