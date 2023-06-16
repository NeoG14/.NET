namespace Escuela;

public class EscuelaInit
{
   public static void Inicializar(EscuelaContext context)
   {
       if (context.Alumnos.Count() > 0) // ya fue inicializada
       {
           return;
       }

       context.Add(new Alumno() { Nombre = "Juan",Email="juan@gmail.com" });
       context.Add(new Alumno() { Nombre = "Ana" });
       context.Add(new Alumno() { Nombre = "Laura" });

       context.Add(new Examen() { AlumnoId = 2, Materia = "Inglés", Nota = 9, Fecha = DateTime.Parse("4/4/2022") });
       context.Add(new Examen() { AlumnoId = 1, Materia = "Inglés", Nota = 5, Fecha = DateTime.Parse("1/3/2019") });
       context.Add(new Examen() { AlumnoId = 1, Materia = "Álgebra", Nota = 10, Fecha = DateTime.Parse("24/5/2021") });

       context.SaveChanges();
   }
}