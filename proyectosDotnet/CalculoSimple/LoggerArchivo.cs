namespace CalculoSimple;
class LoggerArchivo : Ilogger
{
    public void Log(string mensaje)
    {
        using var sw = new StreamWriter("registro.log", true);
        sw.WriteLine($"{DateTime.Now} {mensaje}");
    }
}
