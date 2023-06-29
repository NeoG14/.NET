namespace AseguradoraFinal.Aplicacion.Entidades;
public class Titular : Persona
{
    public string direccion {get; set;} = "";
    public string correo {get; set;} = "";
    public List<Vehiculo>? vehiculos {get; set;}

    public override string ToString()
    {
        return $"Id: {id} Nombre: {nombre} Apellido: {apellido} DNI: {dni} Teléfono: {telefono} Direccion: {direccion} Correo: {correo}";
    }
}