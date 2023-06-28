using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SQLAgregarException : Exception
    {
        public SQLAgregarException()
        {
        }

        public SQLAgregarException(string? message) : base(message)
        {
        }
    }
}
