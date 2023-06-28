using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AgregarAlCarritoException : Exception
    {
        public AgregarAlCarritoException()
        {
        }

        public AgregarAlCarritoException(string? message) : base(message)
        {
        }
    }
}
