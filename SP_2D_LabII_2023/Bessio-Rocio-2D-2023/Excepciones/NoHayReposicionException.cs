using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoHayReposicionException : Exception
    {
        public NoHayReposicionException()
        {
        }

        public NoHayReposicionException(string? message) : base(message)
        {
        }
    }
}
