using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Me permitira arrojar una exception del tipo
    /// TarjetaNoValida si al ingresar los datos
    /// de la tarjeta alguno de estos no es valida.
    /// </summary>
    public class TarjetaNoValidaException : Exception
    {
        public TarjetaNoValidaException(string? message) : base(message)
        {
        }
    }
}
