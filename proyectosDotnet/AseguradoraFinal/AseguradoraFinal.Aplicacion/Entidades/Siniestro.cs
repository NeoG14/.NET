namespace AseguradoraFinal.Aplicacion.Entidades;

public class Siniestro
{
    public int id {get;set;}
    public int polizaId {get;set;} = -1;
    public DateTime ocurrencia {get;set;} = DateTime.Now;
    public DateTime ingreso {get;set;} = DateTime.Now;
    public string direccion {get;set;} = "";
    public string descripcion {get;set;} = "";
    public List<Tercero>? terceros {get; set;}
    
    public override string ToString()
    {
        return $"Id: {id} Poliza Id: {polizaId} Creación: {ingreso} Ocurrencia: {ocurrencia} Direccion: {direccion} Descripcion: {descripcion}";
    }
}