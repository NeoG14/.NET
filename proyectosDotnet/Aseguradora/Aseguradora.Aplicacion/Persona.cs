namespace Aseguradora.Aplicacion;

public abstract class Persona
{
    public int id {get; set;} = -1;
    public string dni {get; set;} = "";
    public string apellido {get; set;} = "";
    public string nombre {get; set;} = "";
    public string telefono {get; set;} = "";

    public abstract override string ToString();

}