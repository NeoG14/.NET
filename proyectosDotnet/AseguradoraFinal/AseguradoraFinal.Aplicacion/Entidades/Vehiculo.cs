namespace AseguradoraFinal.Aplicacion.Entidades;

public class Vehiculo
{
    public int id {get;set;}
    public string dominio{get;set;} = "";
    public string marca{get;set;} = "";
    public string fabricacion{get;set;} = "";
    public int titularId{get;set;} 
    public List<Poliza>? polizas {get; set;}

    public override string ToString()
    {
        return $"Id: {id} Dominio: {dominio} Marca: {marca} Año de fabricación: {fabricacion} Id titular: {titularId}";
    }
}