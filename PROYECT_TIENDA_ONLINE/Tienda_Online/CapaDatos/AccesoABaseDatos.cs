using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    public abstract class AccesoABaseDatos
    {
        #region ATRIBUTOS
        protected SqlConnection _conexion;
        protected SqlCommand _comando;
        protected SqlDataReader _lector;
        protected static string _cadenaDeConexion;
        #endregion

        #region PROPIEDAD
        public static string CadenaDeConexion { get { return AccesoABaseDatos._cadenaDeConexion; } set { AccesoABaseDatos._cadenaDeConexion = value; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Se ejecutara una sola vez el
        /// constructor estatico, obteniendo 
        /// la cadena de conexion a la DB.
        /// </summary>
        static AccesoABaseDatos()
        {
            AccesoABaseDatos._cadenaDeConexion = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=db_Carrito;Data Source=DESKTOP-S8KBDM2;Trusted_Connection=True;";
        }

        /// <summary>
        /// Constructor sin parametros que le
        /// pasa al SQLConnection la cadena de 
        /// conexion.
        /// </summary>
        public AccesoABaseDatos()
        {
            _conexion = new SqlConnection(_cadenaDeConexion);
        } 

        /// <summary>
        /// Constructor parametrizado que me servirá para 
        /// comprobar el unit testing de la clase.
        /// </summary>
        /// <param name="cadena"></param>
        public AccesoABaseDatos(string cadena)
        {
            this._conexion = new SqlConnection(cadena);
        }
        #endregion

        #region METODO
        /// <summary>
        /// Metodo de prueba para la conexion a 
        /// base de datos.
        /// </summary>
        /// <returns></returns>
        public bool ProbarConexion()
        {
            bool pudoConectar = true;

            try
            {
                this._conexion.Open();
            }
            catch (Exception)
            {
                pudoConectar = false;
            }
            finally
            {
                if (this._conexion.State == System.Data.ConnectionState.Open)
                {
                    this._conexion.Close();
                }
            }
            return pudoConectar;
        }
        #endregion
    }
}
