using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuariosDAO : IBaseDeDatos<Usuario>
    {

        #region ATRIBUTOS
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        #endregion

        #region CONSTRUCTOR
        public UsuariosDAO()
        {
            this.conexion = new SqlConnection(IBaseDeDatos<Usuario>.CadenaConexionBase());
        }
        #endregion

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
                this.comando = new SqlCommand();

                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "SELECT * FROM Usuarios";//-->Traigo a todos de la base.
                this.comando.Connection = this.conexion;

                this.conexion.Open();//-->Abro conexion.

                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())//-->Seguira mientras haya para leer
                {
                    Usuario usuario = new Usuario(string.Empty,string.Empty);
                    usuario.Email = (string)this.lector[1];
                    usuario.Contrasenia = (string)this.lector[2];
                    usuario.EsCliente = (bool)this.lector[3];

                    listaUsuarios.Add(usuario);//-->Añado a la lista.
                }
                this.lector.Close();//-->Cierro el lector
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)//-->Chequeo si la conexion esta abierta
                {
                    this.conexion.Close();//-->La cierro
                }
            }
            return listaUsuarios;
        }

        public Usuario ObtenerEspecifico(int id)
        {
            Usuario usuario = new Usuario(string.Empty, string.Empty);

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = $"SELECT * FROM Usuarios WHERE ID {id}";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();

                this.lector.Read();

                //-->Cargo el usuario.
                usuario.Email = (string)this.lector[1];
                usuario.Contrasenia = (string)this.lector[2];
                usuario.EsCliente = (bool)this.lector[3];

                this.lector.Close();//-->Lo cargue lo cierro.
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)//-->Chequeo si la conexion esta abierta
                {
                    this.conexion.Close();//-->La cierro
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
                this.comando = new SqlCommand(); 

                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@Contrasenia", contrasenia);

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = $"SELECT P.IDRol FROM Usuarios U " +
                    $"INNER JOIN Personas P ON U.IdPersona = P.IDPersona " +
                    $"WHERE U.Email = @Email AND U.Contrasenia = @Contrasenia"; 

                this.comando.Connection = this.conexion;

                this.conexion.Open();

                using (lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    { 
                        int idPuesto = lector.GetInt32(0);
                        
                        if (idPuesto == 2)
                        {
                            esCliente = true; 
                        }
                        return true;
                    } 
                }
            }
            catch(Exception e)
            { 
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)//-->Chequeo si la conexion esta abierta
                {
                    this.conexion.Close();//-->La cierro
                }
            }
            return false;
        }
        #endregion
    }
}
