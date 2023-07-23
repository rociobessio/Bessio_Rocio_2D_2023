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
    public class MarcasDAO : AccesoABaseDatos//, IBaseDeDatos<Usuario>
    {
        #region METODOS
        /// <summary>
        /// Me permite obtener la lista de marcas de la base de datos.
        /// </summary>
        /// <returns></returns>  
        public List<Marca> ObtenerLista()
        {
            List<Marca> listaMarcas = new List<Marca>();
            try
            {
                using (base._conexion = new SqlConnection())
                {
                    base._conexion.ConnectionString = AccesoABaseDatos.CadenaDeConexion;
                    string query = "SELECT * FROM MARCAS";//-->Traigo a todas de la base.
                    base._comando = new SqlCommand(query, base._conexion);//-->Le paso la query y la conexion
                    base._comando.CommandType = System.Data.CommandType.Text;

                    base._conexion.Open();//-->Abro conexion.

                    using (base._lector = base._comando.ExecuteReader())
                    {
                        while (base._lector.Read())
                        {
                            listaMarcas.Add(
                                new Marca()
                                {
                                    IDMarca = Convert.ToInt32(base._lector["IDMarca"]),
                                    Descripcion = Convert.ToString(base._lector["Descripcion"]),
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
                listaMarcas = new List<Marca>();//-->Retorno lista vacia
            } 
            return listaMarcas;
        }

        /// <summary>
        /// Metodo que me permitira registrar una nueva
        /// marca en la tabla MARCAS de la db_Carrito.
        /// Recibe un objeto del tipo Marca y devuelve
        /// un int (id) y un mensaje.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="mss"></param>
        /// <returns></returns>
        public int RegistrarDato(Marca marca, out string mss)
        {
            int idAutoGenerado = 0;
            mss = string.Empty;

            try
            {
                using (base._conexion = new SqlConnection())
                {
                    base._conexion.ConnectionString = AccesoABaseDatos.CadenaDeConexion;
                    base._comando = new SqlCommand("sp_RegistrarMarcas", base._conexion);//-->Le paso el nombre del metodo/proceso y la conexion
                    base._comando.Parameters.AddWithValue("Descripcion", marca.Descripcion);
                    base._comando.Parameters.AddWithValue("Activo", marca.Activo);
                    base._comando.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;//-->Parametro de salida
                    base._comando.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;//-->Parametro de salida
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
            return idAutoGenerado;
        }

        /// <summary>
        /// Metodo que me permitira editar una Marca en
        /// la tabla MARCAS de la db_Carrito.
        /// Recibe un objeto del tipo Marca y devuelve
        /// un int (id) y un mensaje.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="mss"></param>
        /// <returns></returns>
        public bool UpdateDato(Marca marca, out string mss)
        {
            bool pudoEditar = false;
            mss = string.Empty;

            try
            {
                using (base._conexion = new SqlConnection())
                {
                    base._conexion.ConnectionString = AccesoABaseDatos.CadenaDeConexion;
                    base._comando = new SqlCommand("sp_EditarMarca", base._conexion);//-->Le paso el nombre del metodo/proceso y la conexion
                    base._comando.Parameters.AddWithValue("IDMarca", marca.IDMarca);
                    base._comando.Parameters.AddWithValue("Descripcion", marca.Descripcion);
                    base._comando.Parameters.AddWithValue("Activo", marca.Activo);
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
            return pudoEditar;
        }

        /// <summary>
        /// Me permite eliminar una Marca 
        /// mediante el ID recibida.
        /// Devuelve un mensaje.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mss"></param>
        /// <returns>Retornará true si pudo, false sino.</returns>
        public bool DeleteDato(int id, out string mss)
        {
            bool pudoEliminar = false;
            mss = string.Empty;

            try
            {
                using (base._conexion = new SqlConnection())
                {
                    base._conexion.ConnectionString = AccesoABaseDatos.CadenaDeConexion;
                    base._comando = new SqlCommand("DELETE TOP (1) FROM MARCAS WHERE IDMarca = @ID", base._conexion);
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
            return pudoEliminar;
        }
        #endregion
    }
}
