namespace Aseguradora.Aplicacion;
//Esta Excepción se lanza cuando un campo que deberia ser único se repite
public class UniqueFieldNotUniqueException : Exception
{
    public UniqueFieldNotUniqueException() {}
    public UniqueFieldNotUniqueException(string message) : base(message) {}
    public UniqueFieldNotUniqueException(string message, Exception inner): base(message, inner) {}

}