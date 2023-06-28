using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoPudoVenderException :Exception
    {
        public NoPudoVenderException()
        {
        }

        public NoPudoVenderException(string? message) : base(message)
        {
        }
    }
}
