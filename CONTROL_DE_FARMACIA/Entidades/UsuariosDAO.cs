using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public class UsuariosDAO
    {
        #region ATRIBUTOS
        private static string cadena_conexion;//Cadena para poder conectarse a la URL de la base de datos
        private static SqlCommand comando;//Para los comandos de tipo Insert, delete, update, select, etc
        private static SqlConnection conexion;//Para conectarse a la base de datos SQLServer, si no esta no puedo hacer ningun tipo de consulta.
        private static SqlDataReader lector;//Permite recuperar las filas de un posible select y despues lo puedo mostrar
        #endregion

        #region CONSTRUCTOR
        static UsuariosDAO()
        {
            UsuariosDAO.cadena_conexion = @"Integrated Security=SSPI;Persist Security Info=False;User ID="";Initial Catalog=GIMNASIO_DB;Data Source=DESKTOP-S8KBDM2";
            UsuariosDAO.comando = new SqlCommand();//Instancio el comando
            UsuariosDAO.conexion = new SqlConnection(UsuariosDAO.cadena_conexion);//Instancio la conexion pasandole la URL de la base de datos
            UsuariosDAO.comando.Connection = UsuariosDAO.conexion;//Al comando d conexion le paso la conexion
            UsuariosDAO.comando.CommandType = CommandType.Text;//El comando lo pongo en tipo texto
        }
        #endregion

        #region METODOS

        #region PROBAR CONEXION
        /// <summary>
        /// Metodo para probar la conexion con el servidor
        /// </summary>
        /// <returns></returns>
        public static bool ProbarConexion()
        {
            bool huboConexion = true;

            try
            {
                //Intento abrir la conexion, si no hubo excepcion todo bien.
                conexion.Open();
            }
            catch (Exception)
            {
                huboConexion = false;//Si hubo excepcion devuelvo false.
            }
            finally
            {
                //No puedo abrir algo que esta abierto, o cerrar algo que esta cerrado...
                if (conexion.State == ConnectionState.Open)//Chequeo el ESTADO de la la conexion, si esta abierta y la cierro...
                {
                    conexion.Close();
                }
            }
            return huboConexion;
        }
        #endregion

        #region LEERID
        public static List<Usuarios> LeerUsuarios()
        {
            List<Usuarios> listaUsuariosBase = new List<Usuarios>();

            try
            {
                //Instancio el comando de tipo SqlCommand para usarlo
                UsuariosDAO.comando = new SqlCommand();
                UsuariosDAO.comando.CommandType = CommandType.Text;//Como sera interpretado el comando, en este caso, como texto
                UsuariosDAO.comando.CommandText = "SELECT * FROM Usuarios1";//Hago un select de TODA (*) la base para luego mostrarla.
                UsuariosDAO.comando.Connection = UsuariosDAO.conexion;//Settea la conexion

                UsuariosDAO.conexion.Open(); //Abro la conexion con la base de datos...

                UsuariosDAO.lector = UsuariosDAO.comando.ExecuteReader();//Envia el comando a la conexion y crean el SqlReader

                //Utilizo una estructura iterativa, para acceder a los campos
                while (UsuariosDAO.lector.Read())//Mientras tenga para leer el lector en la base....
                {
                    Usuarios usuario = new Usuarios(0, "", "");
                    // ACCEDO POR NOMBRE, POR INDICE O POR GETTER (SEGUN TIPO DE DATO)
                    usuario.ID = (int)lector["id"];
                    usuario.Usuario = lector[1].ToString();
                    usuario.Contraseña = lector[2].ToString();

                    listaUsuariosBase.Add(usuario);//Añado a la lista, podria haber validaciones antes de guardarlo..
                }

                lector.Close();//Cierro el lector...

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());//Si ocurrio alguna excepcion la imprimo por consola..
            }
            finally
            {
                if (UsuariosDAO.conexion.State == ConnectionState.Open)//Si la conexion con el servidor esta abierta...
                {
                    UsuariosDAO.conexion.Close();//Cierro la conexion
                }
            }
            return listaUsuariosBase;
        }

        #endregion

        #endregion


    }
}
