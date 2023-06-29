namespace AseguradoraFinal.Aplicacion.Entidades;

public class Poliza
{
    public int id{get;set;}
    public int vehiculoAseguradoId{get;set;} = -1;
    public decimal valor{get;set;} = 0;
    public string franquicia {get;set;} = "";
    public string cobertura {get;set;} = "";
    public DateTime fechaInicio {get;set;} = new DateTime(); 
    public DateTime fechaFin {get;set;} = new DateTime();

    public override string ToString()
    {
        return $"Id: {id} Id Vehiculo: {vehiculoAseguradoId} Valor: {valor:0:2} Franquicia: {franquicia} Cobertura: {cobertura} Inicio: {fechaInicio:d} Final: {fechaFin:d}";
    }
}