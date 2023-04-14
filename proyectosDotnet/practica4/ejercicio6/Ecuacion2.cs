namespace ejercicio6;

class Ecuacion2
{
    private double a;
    private double b;
    private double c;

    public Ecuacion2(double a,double b, double c)
    {
        this.a=a;
        this.b=b;
        this.c=c;
    }

    public double GetDiscriminante()
    {
        return Math.Pow(b,2)-(4*a*c);
    }

    public int GetCantidadDeRaices()
    {
        switch (GetDiscriminante())
        {
            case >0: return 2;
            case <0: return 0;
            default: return 1;
        }
    }

    public void imprimirRaices()
    {

        if(GetCantidadDeRaices()==1)
            Console.WriteLine( "x1= "+ (-b+(Math.Sqrt(Math.Pow(b,2)-4*a*c))) / (2*a) ) ;
        else 
        if(GetCantidadDeRaices()==2)
        {
            Console.WriteLine( "x1= "+(-b+(Math.Sqrt(Math.Pow(b,2)-4*a*c))) / (2*a) );
            Console.WriteLine( "x2= "+(-b-(Math.Sqrt(Math.Pow(b,2)-4*a*c))) / (2*a) );
        }else
            Console.WriteLine("No tiene raices reales");
    }   
}