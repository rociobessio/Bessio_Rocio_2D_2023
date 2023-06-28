using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Lanzo una excepcion si el usuario no
    /// es valido.
    /// </summary>
    public class IngresoUsuarioException : Exception
    {
        public IngresoUsuarioException(string? message) : base(message)
        {
        }
    }
}
