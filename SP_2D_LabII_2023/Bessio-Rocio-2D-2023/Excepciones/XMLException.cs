using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class XMLException : Exception
    {
        public XMLException()
        {
        }   

        public XMLException(string? message) : base(message)
        {
        }
    }
}
