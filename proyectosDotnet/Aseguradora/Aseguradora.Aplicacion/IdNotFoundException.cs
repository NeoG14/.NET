namespace Aseguradora.Aplicacion;
//Esta excepción se lanza cuando no encuentra un identificador
public class IdNotFoundException : Exception
{
    public IdNotFoundException() {}
    public IdNotFoundException(string message) : base(message) {}
    public IdNotFoundException(string message, Exception inner): base(message, inner) { }
}