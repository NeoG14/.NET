namespace Teoria4;

class Auto {
    private string _marca;
    private int _modelo;

    public Auto(string marca, int modelo) 
    {
        this._marca = marca;
        this._modelo = modelo;
    }
    public Auto() 
    {
        _marca = "Fiat";
        _modelo = DateTime.Now.Year;
    }

    public Auto(string marca) : this() 
    {
        _marca = marca;
    }

    public string ObtenerDescripcion() => $"Auto {_marca} {_modelo}";
}