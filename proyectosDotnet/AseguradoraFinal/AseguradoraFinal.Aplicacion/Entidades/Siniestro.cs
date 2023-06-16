namespace AseguradoraFinal.Aplicacion.Entidades;

public class Siniestro
{
    public int id {get;set;}
    public int polizaId {get;set;} = -1;
    public DateTime ingreso {get;set;} = DateTime.Now;
    public DateTime ocurrencia {get;set;} = new DateTime();
    public string direccion {get;set;} = "";
    public string descripcion {get;set;} = "";

    public override string ToString()
    {
        return $"Id: {id} Poliza Id: {polizaId} Creación: {ingreso} Ocurrencia: {ocurrencia} Direccion: {direccion} Descripcion: {descripcion}";
    }
}