namespace CalculoSimple;
public class Logger: Ilogger
{
   public void Log(string mensaje)
   {
       Console.WriteLine(mensaje);
   }
}