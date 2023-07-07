using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace App_Forms_Farmacia
{
    class Database
    {
        /// <summary>
        /// Obtengo la conexion con la base de datos.
        /// </summary>
        /// <returns></returns>
        protected SqlConnection obtenerConexion()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Initial Catalog=farmacia;Data Source=DESKTOP-S8KBDM2;TrustServerCertificate=True;Integrated security=True";
            return con;
        }

        /// <summary>
        /// Me permite extraer datos de la base.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataSet obtenerData(String query)
        {
            SqlConnection con = obtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        /// <summary>
        /// Me permite guardar data dentro de la database.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="mensaje"></param>
        public void setData(String query,String mensaje)
        {
            SqlConnection con = obtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(mensaje,"INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
