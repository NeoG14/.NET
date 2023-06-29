namespace AseguradoraFinal.Aplicacion.Entidades;

public class Poliza
{
    public int id{get;set;}
    public int vehiculoId{get;set;}
    public decimal valor{get;set;} = 0;
    public string franquicia {get;set;} = "";
    public string cobertura {get;set;} = "";
    //Pongo Now para que en el formulario de ingreso aparezca la fecha actual y sea mas comodo seleccionar la fecha de lo contrario inicia en el 01/01/0001
    public DateTime fechaInicio {get;set;} = DateTime.Now; 
    public DateTime fechaFin {get;set;} = DateTime.Now;
    public List<Siniestro>? siniestros {get; set;}

    public override string ToString()
    {
        return $"Id: {id} Id Vehiculo: {vehiculoId} Valor: {valor:0:2} Franquicia: {franquicia} Cobertura: {cobertura} Inicio: {fechaInicio:d} Final: {fechaFin:d}";
    }
}