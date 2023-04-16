namespace Figuras;
public class Circulo
{
    private double _radio;

    public Circulo(double radio)
    {
        _radio = radio;
    }

    public double GetArea() => Math.PI*Math.Pow(_radio,2);
}
