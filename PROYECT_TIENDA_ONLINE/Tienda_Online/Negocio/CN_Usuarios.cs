using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace Negocio
{
    /// <summary>
    /// Intermediario,
    /// aplicare las reglas de negocio.
    /// </summary>
    public class CN_Usuarios
    {
        #region ATRIBUTOS
        private static UsuariosDAO usuariosDAO;
        public List<Usuario> listaUsuarios;
        #endregion

        #region CONSTRUCTOR
        static CN_Usuarios()
        {
            usuariosDAO = new UsuariosDAO();
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Retorno la lista de Usuarios 
        /// de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Usuario> Listar()
        {
            return usuariosDAO.ObtenerLista();
        }
        #endregion
    }
}
