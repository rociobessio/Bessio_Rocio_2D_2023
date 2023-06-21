using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Entidades
{
    public class ProductoDAO : IBaseDeDatos<Producto>
    {
        #region ATRIBUTOS
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        #endregion

        #region Constructor
        /// <summary>
        /// Me permite obtener la conexion a la base de datos de la interfaz.
        /// </summary>
        public ProductoDAO()
        {
            try
            {
                this.conexion = new SqlConnection(IBaseDeDatos<Producto>.CadenaConexionBase());
            }
            catch(Exception)
            {
                throw new SQLConexionException("Error en la conexion con la base de datos.");
            }
       }
        #endregion

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
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM Productos";
                this.comando.Connection = this.conexion;

                this.conexion.Open();//-->Abro la conexion

                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())//-->Mientras haya para leer.
                {
                    Producto producto = new Producto();

                    producto.Codigo = (int)this.lector[0];
                    producto.Tipo = (string)this.lector[1];
                    producto.Corte = (string)this.lector[2];
                    producto.Categoria = (string)this.lector[3];
                    producto.Peso = (double)this.lector[4];
                    producto.PrecioCompraCliente = (double)this.lector[5];
                    producto.Proveedor = (string)this.lector[6];
                    producto.PrecioVentaProveedor = (double)this.lector[7];
                    producto.Vencimiento = DateTime.Parse(this.lector[8].ToString());

                    listaProductos.Add(producto);
                }
                this.lector.Close();
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
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = $"SELECT * FROM Productos WHERE IdProducto {id}";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();

                this.lector.Read();

                //-->Cargo ese producto.
                producto.Codigo = (int)this.lector[0];
                producto.Tipo = (string)this.lector[1];
                producto.Corte = (string)this.lector[2];
                producto.Categoria = (string)this.lector[3];
                producto.Peso = (double)this.lector[4];
                producto.PrecioCompraCliente = (double)this.lector[5];
                producto.Proveedor = (string)this.lector[6];
                producto.PrecioVentaProveedor = (double)this.lector[7];
                producto.Vencimiento = (DateTime)this.lector[8];

                this.lector.Close();//-->Lo cargue lo cierro.
            }
            catch (Exception e)
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
            return producto;//-->Retorno el producto.
        }

        /// <summary>
        /// Me permite eliminar un Producto mediante su id
        /// recibida de la tabla Productos.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteProducto(int id)
        {
            bool pudo = true;

            try
            {
                this.comando = new SqlCommand();

                //-->Atajo de parametros.
                this.comando.Parameters.AddWithValue("@IdProducto", id);

                string query = "DELETE FROM Productos WHERE IdProducto = @IdProducto";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = query;//-->Le paso la query.
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasActualizadas = this.comando.ExecuteNonQuery();//-->Me devolvera la cantidad de filas actualizadas

                if (filasActualizadas == 0)//-->Quiere decir que no actualizo ninguna
                {
                    pudo = false;
                }
            }
            catch (Exception e)
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
            return pudo;
        }


        /// <summary>
        /// Me permite recibir un producto y modificarlo
        /// dentro de la base de datos
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool UpdateProducto(Producto producto)
        {
            bool puedeModificar = true;

            try
            {
                this.comando = new SqlCommand();

                //-->Atajo de parametros.
                this.comando.Parameters.AddWithValue("@IdProducto", producto.Codigo);
                this.comando.Parameters.AddWithValue("@Tipo", producto.Tipo);
                this.comando.Parameters.AddWithValue("@Corte", producto.Corte);
                this.comando.Parameters.AddWithValue("@Categoria", producto.Categoria);
                this.comando.Parameters.AddWithValue("@Peso", producto.Peso);
                this.comando.Parameters.AddWithValue("@PrecioCompraCliente", producto.PrecioCompraCliente);
                this.comando.Parameters.AddWithValue("@Proveedor", producto.Proveedor);
                this.comando.Parameters.AddWithValue("@PrecioVentaProveedor", producto.PrecioVentaProveedor);
                this.comando.Parameters.AddWithValue("@Vencimiento", producto.Vencimiento.ToShortDateString());

                //-->Le doy formato a la query.
                string sqlQuery = "UPDATE Productos ";
                sqlQuery += "SET Tipo = @Tipo, Corte = @Corte, Categoria = @Categoria, Peso = @Peso, PrecioCompraCliente = @PrecioCompraCliente, Proveedor = @Proveedor, PrecioVentaProveedor = @PrecioVentaProveedor, Vencimiento = @Vencimiento ";
                sqlQuery += "WHERE IdProducto = @IdProducto";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sqlQuery;//-->Le paso la query.
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasActualizadas = this.comando.ExecuteNonQuery();//-->Me devolvera la cantidad de filas actualizadas

                if (filasActualizadas == 0)//-->Quiere decir que no actualizo ninguna
                {
                    puedeModificar = false;
                }
                this.conexion.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                this.conexion.Close();
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)//-->Chequeo si la conexion esta abierta
                {
                    this.conexion.Close();//-->La cierro
                }
            }
            return puedeModificar;
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
                query += $"VALUES ('{producto.Tipo}', '{producto.Corte}', '{producto.Categoria}', {producto.Peso}, ";
                query += $"{producto.PrecioCompraCliente}, '{producto.Proveedor}', {producto.PrecioVentaProveedor}, " +
                    $"'{producto.Vencimiento.ToShortDateString()}');";

                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = query;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

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
                if (this.conexion.State == ConnectionState.Open)//-->Chequeo si la conexion esta abierta
                {
                    this.conexion.Close();//-->La cierro
                }
            }
            return pudo;
        }
        #endregion
    }
}
