using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Validador
    {
        /// <summary>
        /// Me fijo que la cadena no sea null o que este vacia
        /// </summary>
        /// <param name="dato"></param>
        /// <returns>Si es falso retorna true</returns>
        public static bool ValidarTexto(string dato)
        {
            return !string.IsNullOrEmpty(dato);
        }
    }
}
