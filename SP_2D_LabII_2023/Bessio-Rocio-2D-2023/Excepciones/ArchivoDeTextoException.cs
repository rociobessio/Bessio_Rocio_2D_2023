using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivoDeTextoException : Exception
    {
        public ArchivoDeTextoException()
        {
        }

        public ArchivoDeTextoException(string? message) : base(message)
        {
        }
    }
}
