namespace AseguradoraFinal.Aplicacion.Entidades;

public class Tercero : Persona
{
    public string aseguradora {get; set;} = "";
    public int siniestroId {get; set;}

    public override string ToString()
    {
        return $"Id: {id} Nombre: {nombre} Apellido: {apellido} DNI: {dni} Teléfono: {telefono} Aseguradora: {aseguradora} Id Siniestro: {siniestroId}";
    }

}