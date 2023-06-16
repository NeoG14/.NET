namespace Escuela;
public class Examen
{
    public int Id { get; set; }
    public int AlumnoId { get; set; }
    public string Materia { get; set; } = "";
    public double Nota { get; set; }
    public DateTime Fecha { get; set; }
}
