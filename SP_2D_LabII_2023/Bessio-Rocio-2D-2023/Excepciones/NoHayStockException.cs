using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoHayStockException : Exception
    {
        public NoHayStockException()
        {
        }

        public NoHayStockException(string? message) : base(message)
        {
        }
    }
}
