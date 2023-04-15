namespace ejercicio12;

class Cuenta
{
    private double _monto;
    private int _titularDNI;
    private string? _titularNobre;

    public Cuenta()
    {
        _titularDNI = 0;
        _titularNobre = "No espeficado";
        _monto = 0;
    }
    public Cuenta(string nombre) : this()
    {
        _titularNobre = nombre;
    }

    public Cuenta(int dni) : this()
    {
        _titularDNI = dni;
    }

    public Cuenta(string nombre,int dni)
    {
        _titularDNI = dni;
        _titularNobre = nombre;
        _monto = 0;
    }


    public void Imprimir()
    {
        Console.WriteLine($"Nombre: {_titularNobre}, DNI: {( _titularDNI==0 ? "No especificado" : _titularDNI)}, Monto: {_monto}");
    }

    public void Depositar(double monto)
    {
        if(monto>0)
            _monto += monto;
        else
            Console.WriteLine("Monto no valido");
    }

    public void Extraer(double monto)
    {
        if(monto>0 && monto<=_monto)
            _monto -= monto;
        else
            Console.WriteLine("Operación cancelada, monto Insuficiente");
    }

}