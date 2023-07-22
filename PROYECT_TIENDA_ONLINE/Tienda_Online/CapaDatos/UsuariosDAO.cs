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
    public class UsuariosDAO : AccesoABaseDatos, IBaseDeDatos<Usuario>
    { 
        #region METODOS
        /// <summary>
        /// Me permite obtener la lista de usuarios de la base de datos.
        /// </summary>
        /// <returns></returns>  
        public List<Usuario> ObtenerLista()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            try
            {
                using (base._conexion = new SqlConnection())
                {
                    base._conexion.ConnectionString = AccesoABaseDatos.CadenaDeConexion;
                    string query = "SELECT * FROM Usuarios";//-->Traigo a todos de la base.
                    base._comando = new SqlCommand(query, base._conexion);//-->Le paso la query y la conexion
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
                    base._conexion.Close();//-->Cierro conexion.
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

        /// <summary>
        /// Metodo que me permitira registrar un usuario en
        /// la tabla Usuarios de la db_Carrito.
        /// Recibe un objeto del tipo Usuario y devuelve
        /// un int (id) y un mensaje.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="mss"></param>
        /// <returns></returns>
        public int RegistrarDato(Usuario usuario, out string mss)
        {
            int idAutoGenerado = 0;
            mss = string.Empty;

            try
            {
                using (base._conexion = new SqlConnection())
                {
                    base._conexion.ConnectionString = AccesoABaseDatos.CadenaDeConexion;
                    base._comando = new SqlCommand("sp_RegistrarUsuario",base._conexion);//-->Le paso el nombre del metodo/proceso y la conexion
                    base._comando.Parameters.AddWithValue("Nombres",usuario.Nombres);
                    base._comando.Parameters.AddWithValue("Apellidos", usuario.Apellidos);
                    base._comando.Parameters.AddWithValue("Correo", usuario.Correo);
                    base._comando.Parameters.AddWithValue("Clave", usuario.Clave);
                    base._comando.Parameters.AddWithValue("Activo", usuario.Activo);
                    base._comando.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;//-->Parametro de salida
                    base._comando.Parameters.Add("Mensaje",SqlDbType.VarChar,500).Direction = ParameterDirection.Output;//-->Parametro de salida
                    base._comando.CommandType = CommandType.StoredProcedure;//-->Del tipo de procedimiento de almacenado.

                    base._conexion.Open();//-->Abro la conexion

                    base._comando.ExecuteNonQuery();

                    idAutoGenerado = Convert.ToInt32(base._comando.Parameters["Resultado"].Value);//-->IdAutoGenerado sera el resultado
                    mss = base._comando.Parameters["Mensaje"].Value.ToString();//-->El mensaje lo recibo como string.
                }
            }
            catch (Exception ex)
            {
                idAutoGenerado = 0;
                mss = ex.Message;//-->Atrapo la excepcion.
            }
            finally
            {
                if (base._conexion.State == ConnectionState.Open)//-->Chequeo si la conexion esta abierta
                {
                    base._conexion.Close();//-->La cierro
                }
            }
            return idAutoGenerado;
        }

        /// <summary>
        /// Metodo que me permitira editar un usuario en
        /// la tabla Usuarios de la db_Carrito.
        /// Recibe un objeto del tipo Usuario y devuelve
        /// un int (id) y un mensaje.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="mss"></param>
        /// <returns></returns>
        public bool UpdateDato(Usuario usuario, out string mss)
        {
            bool pudoEditar = false;
            mss = string.Empty;

            try
            {
                using (base._conexion = new SqlConnection())
                {
                    base._conexion.ConnectionString = AccesoABaseDatos.CadenaDeConexion;
                    base._comando = new SqlCommand("sp_EditarUsuario", base._conexion);//-->Le paso el nombre del metodo/proceso y la conexion
                    base._comando.Parameters.AddWithValue("IDUsuario", usuario.IDUsuario);
                    base._comando.Parameters.AddWithValue("Nombres", usuario.Nombres);
                    base._comando.Parameters.AddWithValue("Apellidos", usuario.Apellidos);
                    base._comando.Parameters.AddWithValue("Correo", usuario.Correo); 
                    base._comando.Parameters.AddWithValue("Activo", usuario.Activo);
                    base._comando.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;//-->Parametro de salida
                    base._comando.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;//-->Parametro de salida
                    base._comando.CommandType = CommandType.StoredProcedure;//-->Del tipo de procedimiento de almacenado.

                    base._conexion.Open();//-->Abro la conexion

                    base._comando.ExecuteNonQuery();

                    pudoEditar = Convert.ToBoolean(base._comando.Parameters["Resultado"].Value);//-->Devuelve 1 o 0, lo conviert a booleano
                    mss = base._comando.Parameters["Mensaje"].Value.ToString();//-->El mensaje lo recibo como string.
                }
            }
            catch (Exception ex)
            {
                pudoEditar = false;
                mss = ex.Message;//-->Atrapo la excepcion.
            }
            finally
            {
                if (base._conexion.State == ConnectionState.Open)//-->Chequeo si la conexion esta abierta
                {
                    base._conexion.Close();//-->La cierro
                }
            }
            return pudoEditar;
        }

        /// <summary>
        /// Me permite eliminar un usuario 
        /// mediante el ID recibida.
        /// Devuelve un mensaje.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mss"></param>
        /// <returns>Retornará true si pudo, false sino.</returns>
        public bool DeleteDato(int id,out string mss)
        {
            bool pudoEliminar = false;
            mss = string.Empty;

            try
            {
                using (base._conexion = new SqlConnection())
                {
                    base._conexion.ConnectionString = AccesoABaseDatos.CadenaDeConexion;
                    base._comando = new SqlCommand("DELETE TOP (1) FROM USUARIOS WHERE IDUsuario = @ID", base._conexion);
                    base._comando.Parameters.AddWithValue("@ID", id);
                    base._comando.CommandType = CommandType.Text;

                    base._conexion.Open();//-->Abro la conexion.
                    pudoEliminar = base._comando.ExecuteNonQuery() > 0 ? true : false;//-->Verifico si pudo eliminar.
                }
            }
            catch (Exception ex)
            {
                pudoEliminar = false;
                mss = ex.Message;//-->Atrapo la excepcion.
            }
            finally
            {
                if (base._conexion.State == ConnectionState.Open)//-->Chequeo si la conexion esta abierta
                {
                    base._conexion.Close();//-->La cierro
                }
            }
            return pudoEliminar;
        }
        #endregion
    }
}
