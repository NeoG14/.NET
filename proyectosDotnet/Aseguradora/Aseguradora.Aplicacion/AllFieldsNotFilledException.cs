namespace Aseguradora.Aplicacion;
//Esta excepción se lanza cuando algun campo requerido es vacio
public class AllFieldNotFilledException : Exception
{
    public AllFieldNotFilledException() {}
    public AllFieldNotFilledException(string message) : base(message) {}
    public AllFieldNotFilledException(string message, Exception inner): base(message, inner) { }
}