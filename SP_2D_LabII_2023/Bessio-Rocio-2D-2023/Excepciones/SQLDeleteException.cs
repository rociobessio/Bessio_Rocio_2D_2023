using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SQLDeleteException : Exception
    {
        public SQLDeleteException()
        {
        }

        public SQLDeleteException(string? message) : base(message)
        {
        }
    }
}
