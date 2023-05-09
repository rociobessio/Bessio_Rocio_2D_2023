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
        private DateTime _horaIngresoApp;
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Esta propiedad de lectura me permitira imprimir en los textboxes
        /// la contrasenia.
        /// </summary>
        public string Contrasenia { get { return this._contrasenia; } }
        /// <summary>
        /// Esta propiedad de lectura me permitira imprimir en los textboxes
        /// el email.
        /// </summary>
        public string Email { get { return this._email; } }
        public DateTime HoraIngreso { get { return this._horaIngresoApp; } }  
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado de la clase Usuario.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="contrasenia"></param>
        public Usuario(string email, string contrasenia)
        {
            this._horaIngresoApp = DateTime.Now;
            this._email = email;
            this._contrasenia = contrasenia; 
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

        #region METODOS
        /// <summary>
        /// Metodo estatico de la clase Usuario.
        /// Recibe un usuario, y las listas de Vendedores y Clientes.
        /// Instacio un usuario con el usuario recibido y recorro cada lista (ya que cuento
        /// con dos perfiles en la app) buscando si coincide el usuario instanciado con alguno de la lista,
        /// si hay coincidencia lo retorno, pero como debo retornar uno o el otro retorno una Persona, ya que
        /// ambos (Cliente y Vendedor) heredan de esta.
        /// 
        /// Utilizo la sobrecarga del == de mi clase Usuario.
        /// </summary>
        /// <param name="usuario"></param> 
        /// <returns>Retorna a una persona (la cual puede ser del tipo Vendedor o Cliente), null sino es ninguna</returns>
        public static Persona esValidoElUsuario(Usuario usuario,List<Vendedor> vendedores,List<Cliente> clientes)
        {
            foreach (Vendedor vendedorAux in vendedores)
            {
                if (vendedorAux.Usuario == usuario)
                {
                    return vendedorAux;
                }
            }

            foreach (Cliente clienteAux in clientes)
            {
                if (clienteAux.Usuario == usuario)
                {
                    return clienteAux;
                }
            }
            return null;
        }
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// Sobrecarga del .ToString().
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $" email: {this._email} - contraseña: {this._contrasenia}";
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
        /// Codigo Hash del objeto, es unico.
        /// </summary>
        /// <returns>Codigo Hash del objeto</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        } 
        #endregion
    }
}
