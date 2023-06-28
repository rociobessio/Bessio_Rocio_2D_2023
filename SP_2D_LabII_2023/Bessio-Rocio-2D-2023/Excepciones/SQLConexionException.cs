
namespace Excepciones
{
    public class SQLConexionException : Exception
    {
        public SQLConexionException(string? message) : base(message)
        {
        }
    }
}