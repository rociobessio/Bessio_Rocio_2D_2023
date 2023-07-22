using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;//-->Using para poder encriptar

namespace Negocio
{
    public class CN_Recursos
    {
        /// <summary>
        /// Método que me permitirá encriptar las claves
        /// de los usuarios del sistema.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string EncriptarClavesSha256(string text)
        {
            StringBuilder sb = new StringBuilder();
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(text));

                foreach (byte b in result)
                    sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
