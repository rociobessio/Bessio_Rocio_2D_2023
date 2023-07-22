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

        #region METODOS
        /// <summary>
        /// Retorno la lista de Usuarios 
        /// de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Usuario> Listar()
        {
            usuariosDAO = new UsuariosDAO();
            return usuariosDAO.ObtenerLista();
        }

        /// <summary>
        /// Me sirve de intermediario, recibe el
        /// usuario y devuelve un int y 
        /// un mensaje.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="mss"></param>
        /// <returns></returns>
        public int RegistrarDato(Usuario usuario, out string mss)
        {
            mss = string.Empty;
            usuariosDAO = new UsuariosDAO();

            if (string.IsNullOrEmpty(usuario.Nombres) || string.IsNullOrEmpty(usuario.Apellidos)
                || string.IsNullOrEmpty(usuario.Correo))
                mss = "No pueden existir campos vacios.";

            if (string.IsNullOrEmpty(mss))
            {
                string clave = CN_Recursos.GenerarClaveAutomatica();//-->Devuelve una clave 

                string asunto = "Registro de cuenta";
                //-->Formato HTML del mensaje
                string mensajeCorreo = $"<h3>Su cuenta fue creada correctamente</h3></br>Su contraseña para acceder es: {clave}</p>";

                bool pudoEnviarCorreo = CN_Recursos.EnviarCorreo(usuario.Correo,asunto,mensajeCorreo);

                if (pudoEnviarCorreo)
                {
                    usuario.Clave = CN_Recursos.EncriptarClavesSha256(clave);//-->Recibe la clave y la devuelve encriptada
                    return usuariosDAO.RegistrarDato(usuario, out mss); 
                }
                else
                {
                    mss = "No se ha podido enviar el correo.";
                    return 0;
                }

            }
            else
                return 0; 
        }

        /// <summary>
        /// Intermediario entre la capa de negocios,
        /// los metodos de la base y el objeto.
        /// Edito un usuario existente.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="mss"></param>
        /// <returns>Retornará true si pudo, false sino.</returns>
        public bool EditarDato(Usuario usuario, out string mss)
        {
            mss = string.Empty;
            usuariosDAO = new UsuariosDAO();

            if (string.IsNullOrEmpty(usuario.Nombres) || string.IsNullOrEmpty(usuario.Apellidos)
                || string.IsNullOrEmpty(usuario.Correo))
                mss = "No pueden existir campos vacios.";

            if (string.IsNullOrEmpty(mss))
                return usuariosDAO.UpdateDato(usuario, out mss);
            else
                return false;
        }

        /// <summary>
        /// Intermediario entre la capa de negocios,
        /// los metodos de la base y el objeto.
        /// Elimino un usuario existente.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mss"></param>
        /// <returns></returns>
        public bool DeleteDato(int id, out string mss)
        {
            usuariosDAO = new UsuariosDAO();
            return usuariosDAO.DeleteDato(id, out mss);
        }
        #endregion
    }
}
