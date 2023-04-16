namespace Figuras;
public class Rectangulo
{
    private double _base;
    private double _altura;

    public Rectangulo(double b, double h)
    {
        _base = b;
        _altura = h;
    }

    public double GetArea() => _base*_altura;
}