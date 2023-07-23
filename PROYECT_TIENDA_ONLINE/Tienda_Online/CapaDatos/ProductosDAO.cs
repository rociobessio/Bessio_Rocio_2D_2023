using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace CapaDatos
{
    public class ProductosDAO : AccesoABaseDatos, IBaseDeDatos<Producto>
    {
        #region METODOS
        /// <summary>
        /// Me permite obtener la lista de productos de la base de datos.
        /// </summary>
        /// <returns></returns>  
        public List<Producto> ObtenerLista()
        {
            List<Producto> listaProductos = new List<Producto>();
            try
            {
                using (base._conexion = new SqlConnection())
                {
                    base._conexion.ConnectionString = AccesoABaseDatos.CadenaDeConexion;
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("SELECT p.IDProducto, p.Nombre, p.Descripcion, ");
                    sb.AppendLine("m.IDMarca, m.Descripcion AS DesMarca,");
                    sb.AppendLine("c.IDCategoria, c.Descripcion AS DesCategoria,");
                    sb.AppendLine("p.Precio, p.Stock, p.RutaImagen, p.NombreImagen, p.Activo");
                    sb.AppendLine("FROM PRODUCTOS p ");
                    sb.AppendLine("INNER JOIN MARCAS m ON m.IDMarca = p.IDMarca");
                    sb.AppendLine("INNER JOIN CATEGORIAS c ON c.IDCategoria = p.IDCategoria");

                    base._comando = new SqlCommand(sb.ToString(), base._conexion);//-->Le paso la query y la conexion
                    base._comando.CommandType = System.Data.CommandType.Text;

                    base._conexion.Open();//-->Abro conexion.

                    using (base._lector = base._comando.ExecuteReader())
                    {
                        while (base._lector.Read())
                        {
                            listaProductos.Add(
                                new Producto()
                                {
                                    IDProducto = Convert.ToInt32(base._lector["IDProducto"]),
                                    Nombre = Convert.ToString(base._lector["Nombre"]),
                                    Descripcion = Convert.ToString(base._lector["Descripcion"]),
                                    oMarca = new Marca() { 
                                        IDMarca = Convert.ToInt32(base._lector["IDMarca"]),
                                        Descripcion = base._lector["DesMarca"].ToString()},
                                    oCategoria = new Categoria() { 
                                        IDCategoria = Convert.ToInt32(base._lector["IDCategoria"]),
                                        Descripcion = base._lector["DesCategoria"].ToString()
                                    },
                                    Precio = Convert.ToDouble(base._lector["Precio"]),
                                    Stock = Convert.ToInt32(base._lector["Stock"]),
                                    RutaImagen = Convert.ToString(base._lector["RutaImagen"]),
                                    NombreImagen = Convert.ToString(base._lector["NombreImagen"]),
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
                listaProductos = new List<Producto>();//-->Retorno lista vacia
            }
            return listaProductos;
        }

        /// <summary>
        /// Metodo que me permitira registrar un nuevo
        /// producto en la tabla MARCAS de la db_Carrito.
        /// Recibe un objeto del tipo Producto y devuelve
        /// un int (id) y un mensaje.
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="mss"></param>
        /// <returns></returns>
        public int RegistrarDato(Producto producto, out string mss)
        {
            int idAutoGenerado = 0;
            mss = string.Empty;

            try
            {
                using (base._conexion = new SqlConnection())
                {
                    base._conexion.ConnectionString = AccesoABaseDatos.CadenaDeConexion;
                    base._comando = new SqlCommand("sp_RegistrarProducto", base._conexion);//-->Le paso el nombre del metodo/proceso y la conexion
                    base._comando.Parameters.AddWithValue("Nombre", producto.Nombre);
                    base._comando.Parameters.AddWithValue("Descripcion", producto.Descripcion); 
                    base._comando.Parameters.AddWithValue("IDMarca", producto.oMarca.IDMarca);
                    base._comando.Parameters.AddWithValue("IDCategoria", producto.oCategoria.IDCategoria);
                    base._comando.Parameters.AddWithValue("Precio", producto.Precio);
                    base._comando.Parameters.AddWithValue("Stock", producto.Stock);
                    base._comando.Parameters.AddWithValue("Activo", producto.Activo);
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
        /// Metodo que me permitira editar una Producto en
        /// la tabla ProductoS de la db_Carrito.
        /// Recibe un objeto del tipo Producto y devuelve
        /// un int (id) y un mensaje.
        /// </summary>
        /// <param name="Producto"></param>
        /// <param name="mss"></param>
        /// <returns></returns>
        public bool UpdateDato(Producto producto, out string mss)
        {
            bool pudoEditar = false;
            mss = string.Empty;

            try
            {
                using (base._conexion = new SqlConnection())
                {
                    base._conexion.ConnectionString = AccesoABaseDatos.CadenaDeConexion;
                    base._comando = new SqlCommand("sp_EditarProducto", base._conexion);//-->Le paso el nombre del metodo/proceso y la conexion
                    base._comando.Parameters.AddWithValue("IDProducto", producto.IDProducto);
                    base._comando.Parameters.AddWithValue("Nombre", producto.Nombre);
                    base._comando.Parameters.AddWithValue("Descripcion", producto.Descripcion);
                    base._comando.Parameters.AddWithValue("IDMarca", producto.oMarca.IDMarca);
                    base._comando.Parameters.AddWithValue("IDCategoria", producto.oCategoria.IDCategoria);
                    base._comando.Parameters.AddWithValue("Precio", producto.Precio);
                    base._comando.Parameters.AddWithValue("Stock", producto.Stock);
                    base._comando.Parameters.AddWithValue("Activo", producto.Activo);
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
        /// Me permite eliminar una Producto 
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
                    base._comando = new SqlCommand("sp_EliminarProducto", base._conexion);
                    base._comando.Parameters.AddWithValue("IDProducto", id);
                    base._comando.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;//-->Parametro de salida
                    base._comando.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;//-->Parametro de salida
                    base._comando.CommandType = CommandType.StoredProcedure;//-->Del tipo de procedimiento de almacenado.

                    base._conexion.Open();//-->Abro la conexion.
                    base._comando.ExecuteNonQuery();

                    pudoEliminar = Convert.ToBoolean(base._comando.Parameters["Resultado"].Value);//-->Devuelve 1 o 0, lo conviert a booleano
                    mss = base._comando.Parameters["Mensaje"].Value.ToString();//-->El mensaje lo recibo como string.
                }
            }
            catch (Exception ex)
            {
                pudoEliminar = false;
                mss = ex.Message;//-->Atrapo la excepcion.
            }
            return pudoEliminar;
        }

        /// <summary>
        /// Metodo que me permitira
        /// acutalizar los valores de las imagenes
        /// de los productos al momento de registrarlos.
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="mss"></param>
        /// <returns></returns>
        public bool GuardarDatosImagen(Producto producto, out string mss)
        {
            bool pudoGuardar = false;
            mss = string.Empty;

            try
            {
                using (base._conexion = new SqlConnection())
                {
                    base._conexion.ConnectionString = AccesoABaseDatos.CadenaDeConexion;
                    string query = "UPDATE PRODUCTOS SET RutaImagen = @RutaImagen, NombreImagen = @NombreImagen WHERE IDProducto = @IDProducto";
                    base._comando = new SqlCommand(query, base._conexion);//-->Le paso el nombre del metodo/proceso y la conexion
                    base._comando.Parameters.AddWithValue("@IDProducto", producto.IDProducto);
                    base._comando.Parameters.AddWithValue("@RutaImagen", producto.RutaImagen);
                    base._comando.Parameters.AddWithValue("@NombreImagen", producto.NombreImagen); 
                    base._comando.CommandType = CommandType.Text;//-->Del tipo de procedimiento de almacenado.

                    base._conexion.Open();//-->Abro la conexion

                    if (base._comando.ExecuteNonQuery() > 0)
                        pudoGuardar = true;
                    else
                        mss = "No se ha podido actualizar la imagen, reintente.";  
                }
            }
            catch (Exception ex)
            {
                pudoGuardar = false;
                mss = ex.Message;//-->Atrapo la excepcion.
            } 
            return pudoGuardar;
        }
        #endregion
    }
}
