using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Excepciones;

namespace Entidades
{
    /// <summary>
    /// La clase UsuariosDAO hereda de 
    /// AccesoADataBase e implementa la interfaz
    /// IDataBase<Producto>
    /// </summary>
    public class ProductoDAO : AccesoADataBase, IDataBase<Producto>
    {  
        #region METODOS   
        /// <summary>
        /// Me permite obtener TODOS los productos que se
        /// encuentran en la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<Producto> ObtenerLista()
        {
            List<Producto> listaProductos = new List<Producto>();

            try
            {
                base._comando = new SqlCommand();

                base._comando.CommandType = CommandType.Text;
                base._comando.CommandText = "SELECT * FROM Productos";
                base._comando.Connection = base._conexion;

                base._conexion.Open();//-->Abro la conexion

                base._lector = base._comando.ExecuteReader();

                while (base._lector.Read())//-->Mientras haya para leer.
                {
                    Producto producto = new Producto();

                    producto.Codigo = (int)base._lector[0];
                    producto.Tipo = (string)base._lector[1];
                    producto.Corte = (string)base._lector[2];
                    producto.Categoria = (string)base._lector[3];
                    producto.Stock = (double)base._lector[4];
                    producto.PrecioCompraCliente = (double)base._lector[5];
                    producto.Proveedor = (string)base._lector[6];
                    producto.PrecioVentaProveedor = (double)base._lector[7];
                    producto.Vencimiento = DateTime.Parse(base._lector[8].ToString());

                    listaProductos.Add(producto);
                }
                base._lector.Close();
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
            return listaProductos;//-->Retorno la lista de productos.
        }

        /// <summary>
        /// Me permite obtener un Producto de la base
        /// mediante su ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Producto ObtenerEspecifico(int id)
        {
            Producto producto = new Producto();

            try
            {
                base._comando = new SqlCommand();

                base._comando.CommandType = CommandType.Text;
                base._comando.CommandText = $"SELECT * FROM Productos WHERE IdProducto {id}";
                base._comando.Connection = base._conexion;

                base._conexion.Open();

                base._lector = base._comando.ExecuteReader();

                base._lector.Read();

                //-->Cargo ese producto.
                producto.Codigo = (int)base._lector[0];
                producto.Tipo = (string)base._lector[1];
                producto.Corte = (string)base._lector[2];
                producto.Categoria = (string)base._lector[3];
                producto.Stock = (double)base._lector[4];
                producto.PrecioCompraCliente = (double)base._lector[5];
                producto.Proveedor = (string)base._lector[6];
                producto.PrecioVentaProveedor = (double)base._lector[7];
                producto.Vencimiento = (DateTime)base._lector[8];

                base._lector.Close();//-->Lo cargue lo cierro.
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (base._conexion.State == ConnectionState.Open)//-->Chequeo si la conexion esta abierta
                {
                    base._conexion.Close();//-->La cierro
                }
            }
            return producto;//-->Retorno el producto.
        }

        /// <summary>
        /// Me permite eliminar un Producto mediante su id
        /// recibida de la tabla Productos.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteDato(int id)
        {
            bool pudo = true;

            try
            {
                base._comando = new SqlCommand();

                //-->Atajo de parametros.
                base._comando.Parameters.AddWithValue("@IdProducto", id);

                string query = "DELETE FROM Productos WHERE IdProducto = @IdProducto";

                base._comando.CommandType = CommandType.Text;
                base._comando.CommandText = query;//-->Le paso la query.
                base._comando.Connection = base._conexion;

                base._conexion.Open();

                int filasActualizadas = base._comando.ExecuteNonQuery();//-->Me devolvera la cantidad de filas actualizadas

                if (filasActualizadas == 0)//-->Quiere decir que no actualizo ninguna
                {
                    pudo = false;
                }
            }
            catch (Exception e)
            {
                pudo = false;
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (base._conexion.State == ConnectionState.Open)//-->Chequeo si la conexion esta abierta
                {
                    base._conexion.Close();//-->La cierro
                }
            }
            return pudo;
        }

        /// <summary>
        /// Me permite recibir un producto y modificarlo
        /// dentro de la base de datos
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        /// 
        public bool UpdateDato(Producto producto)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(AccesoADataBase.CadenaDeConexion))
                {
                    string sqlQuery = "UPDATE Productos " +
                                      "SET Tipo = @Tipo, Corte = @Corte, Categoria = @Categoria, Peso = @Peso, " +
                                      "PrecioCompraCliente = @PrecioCompraCliente, Proveedor = @Proveedor, " +
                                      "PrecioVentaProveedor = @PrecioVentaProveedor, Vencimiento = @Vencimiento " +
                                      "WHERE IdProducto = @IdProducto";

                    using (SqlCommand comando = new SqlCommand(sqlQuery, conexion))
                    {
                        comando.Parameters.AddWithValue("@Tipo", producto.Tipo);
                        comando.Parameters.AddWithValue("@Corte", producto.Corte);
                        comando.Parameters.AddWithValue("@Categoria", producto.Categoria);
                        comando.Parameters.AddWithValue("@Peso", producto.Stock);
                        comando.Parameters.AddWithValue("@PrecioCompraCliente", producto.PrecioCompraCliente);
                        comando.Parameters.AddWithValue("@Proveedor", producto.Proveedor);
                        comando.Parameters.AddWithValue("@PrecioVentaProveedor", producto.PrecioVentaProveedor);
                        comando.Parameters.AddWithValue("@Vencimiento", producto.Vencimiento);
                        comando.Parameters.AddWithValue("@IdProducto", producto.Codigo);

                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        } 

        /// <summary>
        /// Me permite realizar un insert en la base de datos.
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool AgregarProducto(Producto producto)
        {
            bool pudo = true;

            try
            {
                string query = "INSERT INTO Productos (Tipo, Corte, Categoria, Peso, PrecioCompraCliente, Proveedor, PrecioVentaProveedor, Vencimiento) ";
                query += $"VALUES ('{producto.Tipo}', '{producto.Corte}', '{producto.Categoria}', {producto.Stock}, ";
                query += $"{producto.PrecioCompraCliente}, '{producto.Proveedor}', {producto.PrecioVentaProveedor}, " +
                    $"'{producto.Vencimiento.ToShortDateString()}');";

                base._comando = new SqlCommand();

                base._comando.CommandType = CommandType.Text;
                base._comando.CommandText = query;
                base._comando.Connection = base._conexion;

                base._conexion.Open();

                int filasAfectadas = base._comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    pudo = false;
                }
            }
            catch (Exception e)
            {
                pudo = false;
            }
            finally 
            {
                if (base._conexion.State == ConnectionState.Open)//-->Chequeo si la conexion esta abierta
                {
                    base._conexion.Close();//-->La cierro
                }
            }
            return pudo;
        }
        #endregion
    }
}
