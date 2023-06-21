using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodosDeExtension
    {
        /// <summary>
        /// Metodo de extension de la clase string
        /// que me permite darle formato XX-XXXX-XXXX 
        /// a un numero de telefono que recibo
        /// utilizo el metodo Substring 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="cadenaTelefono"></param>
        /// <returns></returns>
        public static string ExtensionFormatoTelefono(this string str)
        {
            if (str.Length >= 10 && str.Length <= 15)
            {
                string codigoArea = str.Substring(0, 2);//-->Primeros dos numeros, codigo de area
                string primerParte = str.Substring(2,4);
                string segundaParte = str.Substring(6, 4);
                return $"{codigoArea}-{primerParte}-{segundaParte}";
            }
            return string.Empty;
        }

        /// <summary>
        /// Este metodo de extension estatico me permite
        /// darle formato de dni a una cadena que recibo
        /// XX.XXX.XXX
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ExtensionFormatoDNI(this string str)
        {
            if (str.Length >= 8 && str.Length <= 12)
            {
                string primeraParte = str.Substring(0, 2);//-->Primeros dos numeros,
                string segunda = str.Substring(2, 3);//-->2+3=5-->Donde termina el proximo .
                string tercera = str.Substring(5, 3);//-->5+3=8 total d la cadena
                return $"{primeraParte}.{segunda}.{tercera}";
            }
            return string.Empty;
        }
    }
}
