namespace ejercicio4;

class Hora
{
    private string _hora;
    private string _minutos;
    private string _segundos;

    public Hora(double hora, double minutos, double segundos)
    {
        this._hora = hora.ToString();
        this._minutos = minutos.ToString();
        this._segundos = segundos.ToString();
    }

    public Hora(double n)
    {
        string hora = n.ToString("0");
        string minutos = ((decimal.Parse(n.ToString()) - decimal.Parse(hora)) * 60).ToString().Substring(0,2);
        string segundos =  (((decimal.Parse(n.ToString()) - decimal.Parse(n.ToString("0")) ) * 60) ).ToString().Substring(2);
        double seg = double.Parse(segundos)*60;
        this._hora = hora;
        this._minutos = minutos;
        this._segundos = seg.ToString("0.000");

    }


    public void Imprimir() => Console.WriteLine($"{_hora} horas, {_minutos} minutos y {_segundos} segundos");
    
}