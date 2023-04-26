using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        #region ATRIBUTOS
        private string _email;
        private string _contrasenia;
        private DateTime _fechaActual;
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado de la clase Usuario.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="contrasenia"></param>
        public Usuario(string email, string contrasenia)
        {
            this._email = email;
            this._contrasenia = contrasenia;
            this._fechaActual = DateTime.Now;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Dos usuarios seran iguales si comparten email y contraseña
        /// </summary>
        /// <param name="usuario1"></param>
        /// <param name="usuario2"></param>
        /// <returns>True si lo son, false sino</returns>
        public static bool operator ==(Usuario usuario1, Usuario usuario2)
        {
            return ((usuario1._email == usuario2._email) && (usuario1._contrasenia == usuario2._contrasenia));
        }

        public static bool operator !=(Usuario usuario1, Usuario usuario2)
        {
            return !(usuario1 == usuario2);
        }
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// Sobrecarga del .ToString().
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this._email}-{this._contrasenia}-{this._fechaActual.ToShortTimeString()}";
        }

        /// <summary>
        /// Compara si el objeto this actual es igual obj del parametro comparando por la sobrecarga del ==
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Usuario)
            {
                retorno = this == ((Usuario)obj);
            }
            return retorno;
        }

        /// <summary>
        /// Codigo Hash del objeto
        /// </summary>
        /// <returns>Codigo Hash del objeto</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        } 
        #endregion
    }
}
