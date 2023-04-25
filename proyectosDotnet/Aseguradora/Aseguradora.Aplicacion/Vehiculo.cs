namespace Aseguradora.Aplicacion;

public class Vehiculo
{
    public int id {get;set;} = -1;
    public string dominio{get;set;} = "";
    public string marca{get;set;} = "";
    public string fabricacion{get;set;} = "";
    public int titular{get;set;} = -1;

    public override string ToString()
    {
        return $"Id: {id} Dominio: {dominio} Marca: {marca} Año de fabricación: {fabricacion} Id titular: {titular}";
    }
}