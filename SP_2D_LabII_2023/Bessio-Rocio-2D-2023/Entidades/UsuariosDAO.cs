using Excepciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase UsuariosDAO hereda de 
    /// AccesoADataBase e implementa la interfaz
    /// IDataBase<Usuario>
    /// </summary>
    public class UsuariosDAO : AccesoADataBase, IDataBase<Usuario>
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
                base._comando = new SqlCommand();

                base._comando.CommandType = System.Data.CommandType.Text;
                base._comando.CommandText = "SELECT * FROM Usuarios";//-->Traigo a todos de la base.
                base._comando.Connection = _conexion;

                base._conexion.Open();//-->Abro conexion.

                base._lector = base._comando.ExecuteReader();

                while (base._lector.Read())//-->Seguira mientras haya para leer
                {
                    Usuario usuario = new Usuario(string.Empty,string.Empty);
                    usuario.Email = (string)base._lector[1];
                    usuario.Contrasenia = (string)base._lector[2];
                    //usuario.EsCliente = (bool)this.lector[3];

                    listaUsuarios.Add(usuario);//-->Añado a la lista.
                }
                base._lector.Close();//-->Cierro el lector
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
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
        /// Me permite obtener de la tabla un usuario
        /// especifico mediante su ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Usuario ObtenerEspecifico(int id)
        {
            Usuario usuario = new Usuario(string.Empty, string.Empty);

            try
            {
                base._comando = new SqlCommand();

                base._comando.CommandType = CommandType.Text;
                base._comando.CommandText = $"SELECT * FROM Usuarios WHERE ID {id}";
                base._comando.Connection = base._conexion;

                base._conexion.Open();

                base._lector = base._comando.ExecuteReader();

                base._lector.Read();

                //-->Cargo el usuario.
                usuario.Email = (string)base._lector[1];
                usuario.Contrasenia = (string)base._lector[2];
                usuario.EsCliente = (bool)base._lector[3];

                base._conexion.Close();//-->Lo cargue lo cierro.
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (base._conexion.State == ConnectionState.Open)//-->Chequeo si la conexion esta abierta
                {
                    base._conexion.Close();//-->La cierro
                }
            }
            return usuario;//-->Retorno el usuario.
        }

        /// <summary>
        /// Me permite verificar si el email y contrasenia
        /// se encuentran en la tabla Usuarios.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="contrasenia"></param>
        /// <param name="esCliente"></param>
        /// <returns>Devuelve true si es esCliente, false sino</returns>
        public bool VerificarUser(string email,string contrasenia,out bool esCliente)
        { 
            esCliente = false;
           
            try
            {
                base._comando = new SqlCommand();

                base._comando.Parameters.AddWithValue("@Email", email);
                base._comando.Parameters.AddWithValue("@Contrasenia", contrasenia);

                base._comando.CommandType = CommandType.Text;
                base._comando.CommandText = $"SELECT P.IDRol FROM Usuarios U " +
                    $"INNER JOIN Personas P ON U.IdPersona = P.IDPersona " +
                    $"WHERE U.Email = @Email AND U.Contrasenia = @Contrasenia"; 

                base._comando.Connection = base._conexion;

                base._conexion.Open();

                using (base._lector = base._comando.ExecuteReader())
                {
                    if (base._lector.Read())
                    { 
                        int idPuesto = base._lector.GetInt32(0);
                        
                        if (idPuesto == 2)
                        {
                            esCliente = true; 
                        }
                        return true;
                    } 
                }
            }
            catch (Exception)
            {
                esCliente = false;
                throw;
            }
            finally
            {
                if (base._conexion.State == ConnectionState.Open)//-->Chequeo si la conexion esta abierta
                {
                    base._conexion.Close();//-->La cierro
                }
            }
            return false;
        }

        /// <summary>
        /// Recibo al objeto usuario con el 
        /// nuevo mail
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool UpdateDato(Usuario usuario)
        {
            string sqlQuery = "UPDATE Usuarios SET Email = @NuevoEmail WHERE IDUsuario = @IDUsuario";

            using (SqlConnection conexion = new SqlConnection(AccesoADataBase._cadenaDeConexion))
            {
                using (SqlCommand comando = new SqlCommand(sqlQuery, conexion))
                {
                    comando.Parameters.AddWithValue("@NuevoEmail", usuario.Email);
                    comando.Parameters.AddWithValue("@IDUsuario", usuario.IDUsuario);

                    try
                    {
                        conexion.Open();
                        int filasAfectadas = comando.ExecuteNonQuery();
                        return filasAfectadas > 0;//-->Retorna si pudo
                    }
                    catch (Exception ex)
                    { 
                        throw new Exception("Error al actualizar el email del usuario.", ex);
                    }
                }
            }
        }

        /// <summary>
        /// Implemento el metodo de la interfaz
        /// DeleteDato().
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteDato(int id)
        {
            bool pudoEliminar = false;

            using (SqlConnection conexion = new SqlConnection(CadenaDeConexion))
            {
                string query = "DELETE FROM Usuarios WHERE IDUsuario = @IDUsuario";//-->Elimino de la tabla Usuarios.

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@IDUsuario", id);

                    try
                    {
                        conexion.Open();
                        int filasAfectadas = comando.ExecuteNonQuery();
                        pudoEliminar = filasAfectadas > 0;//-->Si elimino hubo una fila afectada, retornando true 
                    }
                    catch (Exception ex)
                    { 
                        Console.WriteLine("Error al eliminar el usuario: " + ex.Message);
                    }
                }
            }//-->Con el using se cierra la conexion al terminar.
            return pudoEliminar;
        }
        #endregion
    }
}
