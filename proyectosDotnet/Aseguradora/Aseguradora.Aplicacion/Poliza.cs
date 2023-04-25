namespace Aseguradora.Aplicacion;

public class Poliza
{
    public int id{get;set;} = -1;
    public int vehiculoAsegurado{get;set;} = -1;
    public decimal valor{get;set;} = 0;
    public string franquicia{get;set;} = "";
    public string cobertura{get;set;} = "";
    public DateTime fechaInicio = new DateTime(); 
    public DateTime fechaFin = new DateTime();

    public override string ToString()
    {
        return $"Id: {id} Id Vehiculo: {vehiculoAsegurado} Valor: {valor:0:2} Franquicia: {franquicia} Cobertura: {cobertura} Inicio: {fechaInicio:d} Final: {fechaFin:d}";
    }
}