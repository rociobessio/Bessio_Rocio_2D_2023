using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace CapaDatos
{
    public class PanelDAO : AccesoABaseDatos
    {
        #region METODOS
        /// <summary>
        /// Me permite obtener los 
        /// datos del panel de control.
        /// </summary>
        /// <returns></returns>  
        public PanelControl VerPanelControl()
        {
            PanelControl panelDeControl = new PanelControl();
            try
            {
                using (base._conexion = new SqlConnection())
                {
                    base._conexion.ConnectionString = AccesoABaseDatos.CadenaDeConexion; 
                    base._comando = new SqlCommand("sp_ReportePanel", base._conexion);//-->Le paso la query y la conexion
                    base._comando.CommandType = System.Data.CommandType.StoredProcedure;

                    base._conexion.Open();//-->Abro conexion.

                    using (base._lector = base._comando.ExecuteReader())
                    {
                        while (base._lector.Read())
                        {
                            panelDeControl = new PanelControl()
                            {
                                TotalClientes = Convert.ToInt32(base._lector["TotalClientes"]),
                                TotalProductos = Convert.ToInt32(base._lector["TotalProductos"]),
                                TotalVentas = Convert.ToInt32(base._lector["TotalVentas"])
                            };
                        }
                    }
                    base._conexion.Close();//-->Cierro conexion.
                }
            }
            catch
            {
                panelDeControl = new PanelControl();//-->Retorno lista vacia
            } 
            return panelDeControl;
        }
        #endregion
    }
}
