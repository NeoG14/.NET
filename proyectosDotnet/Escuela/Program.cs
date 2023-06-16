using Microsoft.EntityFrameworkCore;
using Escuela;

using (var db = new EscuelaContext())
{
   foreach (Alumno a in db.Alumnos.Include(a => a.Examenes))
   {
       Console.WriteLine(a.Nombre);
       a.Examenes?.ToList()
           .ForEach(ex => Console.WriteLine($" - {ex.Materia} {ex.Nota}"));
   }
}

Console.ReadLine();