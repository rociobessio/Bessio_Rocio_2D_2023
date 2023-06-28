using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoPudoComprarException : Exception
    {
        public NoPudoComprarException()
        {
        }

        public NoPudoComprarException(string? message) : base(message)
        {
        }
    }
}
