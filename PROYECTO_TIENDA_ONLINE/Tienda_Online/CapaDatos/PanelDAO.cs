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

        /// <summary>
        /// Me permite obtener la lista de reportes de la base de datos.
        /// </summary>
        /// <returns></returns>  
        public List<Reporte> ObtenerVentas(string fechaInicio,string fechaFin,string IDTransaccion)
        {
            List<Reporte> listaReportes = new List<Reporte>();
            try
            {
                using (base._conexion = new SqlConnection())
                {
                    base._conexion.ConnectionString = AccesoABaseDatos.CadenaDeConexion; 
                    base._comando = new SqlCommand("sp_ReporteVentas", base._conexion);//-->Le paso la query y la conexion
                    base._comando.Parameters.AddWithValue("fechaInicio", fechaInicio);
                    base._comando.Parameters.AddWithValue("fechaFin", fechaFin);
                    base._comando.Parameters.AddWithValue("IDTransaccion", IDTransaccion);
                    base._comando.CommandType = System.Data.CommandType.StoredProcedure;

                    base._conexion.Open();//-->Abro conexion.

                    using (base._lector = base._comando.ExecuteReader())
                    {
                        while (base._lector.Read())
                        {
                            listaReportes.Add(
                                new Reporte()
                                {
                                    FechaVenta = Convert.ToString(base._lector["FechaVenta"]),
                                    Cliente = Convert.ToString(base._lector["Cliente"]),
                                    Producto = Convert.ToString(base._lector["Producto"]),
                                    Precio = Convert.ToDouble(base._lector["Precio"]),
                                    Cantidad = Convert.ToInt32(base._lector["Cantidad"]),
                                    Total = Convert.ToDouble(base._lector["Total"]),
                                    IDTransaccion = Convert.ToString(base._lector["IDTransaccion"])
                                }
                            );
                        }
                    }
                    base._conexion.Close();//-->Cierro conexion.
                }
            }
            catch
            {
                listaReportes = new List<Reporte>();//-->Retorno lista vacia
            }
            return listaReportes;
        }
        #endregion
    }
}
