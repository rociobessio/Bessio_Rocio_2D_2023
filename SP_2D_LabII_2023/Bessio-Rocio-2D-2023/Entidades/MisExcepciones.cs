using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SQLConexionException : Exception
    {  
        public SQLConexionException(string? message) : base(message)
        { 
        } 
    }

    public class JSONException : Exception
    {
        public JSONException(string? message) : base(message)
        {
        }
    }
}
