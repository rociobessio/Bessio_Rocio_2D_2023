using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos
{
    public class UsuariosDAO : AccesoABaseDatos//, IBaseDeDatos<Usuario>
    {
        /// <summary>
        /// Me permite obtener la lista de usuarios de la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<Usuario> ObtenerLista()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            try
            {
                using (base._conexion = new SqlConnection(AccesoABaseDatos.CadenaDeConexion))
                { 
                    string query = "SELECT * FROM Usuarios";//-->Traigo a todos de la base.
                    base._comando = new SqlCommand(query,base._conexion);//-->Le paso la query y la conexion
                    base._comando.CommandType = System.Data.CommandType.Text;
                    
                    base._conexion.Open();//-->Abro conexion.

                    using (base._lector = base._comando.ExecuteReader())
                    {
                        while (base._lector.Read())
                        {
                            listaUsuarios.Add(
                                new Usuario()
                                {
                                    IDUsuario = Convert.ToInt32(base._lector["IDUsuario"]),
                                    Nombres = Convert.ToString(base._lector["Nombres"]),
                                    Apellidos = Convert.ToString(base._lector["Apellidos"]),
                                    Correo = Convert.ToString(base._lector["Correo"]),
                                    Clave = Convert.ToString(base._lector["Clave"]),
                                    Reestablecer = Convert.ToBoolean(base._lector["Reestablecer"]),
                                    Activo = Convert.ToBoolean(base._lector["Activo"])
                                }
                            );
                        }
                    }
                }  
            }
            catch
            {
                listaUsuarios = new List<Usuario>();//-->Retorno lista vacia
            }
            finally
            {
                if (base._conexion.State == ConnectionState.Open)//-->Chequeo si la conexion esta abierta
                {
                    base._conexion.Close();//-->La cierro
                }
            }
            return listaUsuarios;
        }
    }
}
