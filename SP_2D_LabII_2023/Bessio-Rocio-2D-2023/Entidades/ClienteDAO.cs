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
    /// IDataBase<Cliente>
    /// </summary>
    public class ClienteDAO : AccesoADataBase, IDataBase<Cliente>
    {  
        #region METODOS  

        /// <summary>
        /// Me permite obtener una lista de Clientes de la 
        /// base de datos.
        /// </summary>
        /// <returns></returns>
        public List<Cliente> ObtenerLista()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            try
            {
                base._comando = new SqlCommand();

                base._comando.CommandType = CommandType.Text;
                base._comando.CommandText = "SELECT p.Nombre, p.Apellido, u.Email, p.DNI, p.Telefono, p.Domicilio, c.ConTarjeta, c.EfectivoDisponible, " +
                                             "c.TarjetaVencimiento, c.TarjetaEntidadEmisora, c.TarjetaTitular, c.TarjetaNumTarjeta, c.TarjetaCVV, " +
                                             "c.TarjetaDineroDisponible, c.TarjetaEsDebito, c.IDCliente, p.IDPersona " +
                                             "FROM Usuarios u " +
                                             "JOIN Personas p ON u.IDPersona = p.IDPersona " +
                                             "JOIN Clientes c ON u.IDCliente = c.IDCliente";
                base._comando.Connection = base._conexion;

                base._conexion.Open();//-->Abro la conexion

                base._lector = base._comando.ExecuteReader();

                while (base._lector.Read())//-->Mientras pueda leer, obtengo los clientes de la base
                {
                    Cliente cliente = new Cliente(new Usuario("", ""));

                    cliente.Nombre = (string)base._lector[0];
                    cliente.Apellido = (string)base._lector[1];
                    cliente.Usuario.Email = (string)base._lector[2];
                    cliente.DNI = (string)base._lector[3];
                    cliente.Telefono = (string)base._lector[4];
                    cliente.Domicilio = (string)base._lector[5];
                    cliente.ConTarjeta = (bool)base._lector[6];
                    cliente.DineroEfectivoDisponible = (double)base._lector[7];

                    if (cliente.ConTarjeta)//-->Si es con tarjeta la cargo
                    {
                        Tarjeta tarjeta = new Tarjeta((DateTime)base._lector[8], (string)base._lector[10], (string)base._lector[12],
                            (string)base._lector[11], (string)base._lector[9], (double)base._lector[13], (bool)base._lector[14]);

                        cliente.Tarjeta = tarjeta;//-->Se la paso, sino se instancia rompe.
                    }
                    cliente.IDCliente = (int)base._lector[15];
                    cliente.IDPersona = (int)base._lector[16];

                    listaClientes.Add(cliente);//-->Añado a la lista
                }
                base._lector.Close();//-->Cierro el lector
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
            return listaClientes;//-->Retorno la lista de clientes.
        }

        /// <summary>
        /// Me permite obtener un cliente de la base de datos
        /// filtrando por su mail, el cual sera mi "key".
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public Cliente ObtenerEspecifico(int id)
        {
            Cliente cliente = new Cliente(new Usuario("", ""));

            try
            {
                base._comando = new SqlCommand();

                base._comando.CommandType = CommandType.Text;
                base._comando.CommandText = "SELECT p.Nombre, p.Apellido, u.Email, p.DNI, p.Telefono, p.Domicilio, c.ConTarjeta, c.EfectivoDisponible, " +
                                             "c.TarjetaVencimiento, c.TarjetaEntidadEmisora, c.TarjetaTitular, c.TarjetaNumTarjeta, c.TarjetaCVV, " +
                                             "c.TarjetaDineroDisponible, c.TarjetaEsDebito, c.IDCliente, p.IDPersona " +
                                             "FROM Usuarios u " +
                                             "JOIN Personas p ON u.IDPersona = p.IDPersona " +
                                             "JOIN Clientes c ON u.IDCliente = c.IDCliente " +
                                             $"WHERE c.IDCliente = {id}";
                base._comando.Connection = base._conexion;

                base._conexion.Open();

                base._lector = base._comando.ExecuteReader();

                base._lector.Read();

                //-->Cargo ese cliente. 
                string nombre = (string)base._lector[0];
                string apellido = (string)base._lector[1];
                string email = (string)base._lector[2];
                string dni = (string)base._lector[3];
                string telefono = (string)base._lector[4];
                string domicilio = (string)base._lector[5];
                bool conTarjeta = (bool)base._lector[6];
                double dineroEfectivoDisponible = (double)base._lector[7];

                if (conTarjeta)
                {
                    DateTime vencimientoTarjeta = (DateTime)base._lector[8];
                    string entidadEmisora = (string)base._lector[9];
                    string titularTarjeta = (string)base._lector[10];
                    string numeroTarjeta = (string)base._lector[11];
                    string cvv = (string)base._lector[12];
                    double dineroDisponible = (double)base._lector[13];
                    bool esDebito = (bool)base._lector[14];

                    cliente = new Cliente(nombre, apellido, Sexo.No_Binario, Nacionalidad.Argentina, new DateTime(), dni,
                              domicilio, telefono, new Usuario(email, string.Empty), new Carrito(),
                              new Tarjeta(vencimientoTarjeta, titularTarjeta, cvv, numeroTarjeta, entidadEmisora, dineroDisponible, esDebito),
                              conTarjeta);
                }
                else
                {
                    cliente = new Cliente(nombre, apellido, Sexo.No_Binario, Nacionalidad.Argentina, new DateTime(), dni,
                              domicilio, telefono, new Usuario(email, string.Empty), new Carrito(), dineroEfectivoDisponible, conTarjeta);
                }
                cliente.IDCliente = (int)base._lector[15];
                cliente.IDPersona = (int)base._lector[16];

                base._lector.Close();//-->Cierro el lector.
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
            return cliente;//-->Retorno al cliente.
        }

        /// <summary>
        /// En este caso me permitira obtener una 
        /// instancia de cliente por su Email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public Cliente ObtenerPorEmail(string email)
        {
            Cliente cliente = new Cliente(new Usuario("", ""));

            try
            {
                base._comando = new SqlCommand();

                base._comando.CommandType = CommandType.Text;
                base._comando.CommandText = "SELECT p.Nombre, p.Apellido, u.Email, p.DNI, p.Telefono, p.Domicilio, c.ConTarjeta, c.EfectivoDisponible, " +
                                             "c.TarjetaVencimiento, c.TarjetaEntidadEmisora, c.TarjetaTitular, c.TarjetaNumTarjeta, c.TarjetaCVV, " +
                                             "c.TarjetaDineroDisponible, c.TarjetaEsDebito, c.IDCliente, p.IDPersona  " +
                                             "FROM Usuarios u " +
                                             "JOIN Personas p ON u.IDPersona = p.IDPersona " +
                                             "JOIN Clientes c ON u.IDCliente = c.IDCliente " +
                                             "WHERE u.Email = @email";

                base._comando.Connection = base._conexion;
                base._comando.Parameters.AddWithValue("@email", email);

                base._conexion.Open();

               base._lector = base._comando.ExecuteReader();

               base._lector.Read();

               //-->Cargo ese cliente.
               string nombre  = (string)base._lector[0];
               string apellido = (string)base._lector[1]; 
               string dni = (string)base._lector[3];
               string telefono = (string)base._lector[4];
               string domicilio = (string)base._lector[5];
               bool  conTarjeta = (bool)base._lector[6];
               double dineroEfectivoDisponible = (double)base._lector[7];
               int idCliente = (int)base._lector[15];
               int idPersona = (int)base._lector[16];

               if (conTarjeta)
               {
                   DateTime vencimientoTarjeta = (DateTime)base._lector[8];                    
                   string entidadEmisora = (string)base._lector[9];
                   string titularTarjeta = (string)base._lector[10];
                   string numeroTarjeta = (string)base._lector[11];
                   string cvv = (string)base._lector[12];
                   double dineroDisponible = (double)base._lector[13];
                   bool esDebito = (bool)base._lector[14];

                   cliente = new Cliente(nombre, apellido, Sexo.No_Binario, Nacionalidad.Argentina, new DateTime(), dni,
                             domicilio, telefono, new Usuario(email, string.Empty), new Carrito(), 
                              new Tarjeta(vencimientoTarjeta,titularTarjeta, cvv, numeroTarjeta,entidadEmisora,dineroDisponible,esDebito),
                              conTarjeta);
               }
               else
               {
                   cliente = new Cliente(nombre,apellido,Sexo.No_Binario,Nacionalidad.Argentina,new DateTime(),dni,
                             domicilio,telefono,new Usuario(email,string.Empty),new Carrito(),dineroEfectivoDisponible,conTarjeta);
               }
               cliente.IDCliente = idCliente;
               cliente.IDPersona = idPersona;

               base._lector.Close();//-->Cierro el lector.
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
            return cliente;//-->Retorno al cliente.
        }

        /// <summary>
        /// Me permite modificar un cliente de la
        /// base de datos.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool UpdateDato(Cliente cliente)
        {
            bool pudo = true;

            try
            {
                base._comando = new SqlCommand();
                //-->Parametros: 
                base._comando.Parameters.AddWithValue("@IDCliente", cliente.IDCliente);
                base._comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                base._comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                base._comando.Parameters.AddWithValue("@DNI", cliente.DNI);
                base._comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                base._comando.Parameters.AddWithValue("@Domicilio", cliente.Domicilio);
                base._comando.Parameters.AddWithValue("@ConTarjeta", cliente.ConTarjeta);
                base._comando.Parameters.AddWithValue("@EfectivoDisponible", cliente.DineroEfectivoDisponible);

                string sqlQuery = "UPDATE Personas SET " +
                                  "Nombre = @Nombre, " +
                                  "Apellido = @Apellido, " +
                                  "DNI = @DNI, " +
                                  "Telefono = @Telefono, " +
                                  "Domicilio = @Domicilio " +
                                  "WHERE IDPersona = (SELECT IDPersona FROM Usuarios WHERE IDCliente = @IDCliente);" +
                                  "UPDATE Clientes SET " +
                                  "ConTarjeta = @ConTarjeta, " +
                                  "EfectivoDisponible = @EfectivoDisponible"; 

                if (cliente.ConTarjeta)//-->Me fijo con que paga.
                {
                    base._comando.Parameters.AddWithValue("@TarjetaTitular", cliente.Tarjeta.Titular);
                    base._comando.Parameters.AddWithValue("@TarjetaNumTarjeta", cliente.Tarjeta.NumeroTarjeta);
                    base._comando.Parameters.AddWithValue("@TarjetaEntidadEmisora", cliente.Tarjeta.EntidadEmisora);
                    base._comando.Parameters.AddWithValue("@TarjetaCVV", cliente.Tarjeta.CVV);
                    base._comando.Parameters.AddWithValue("@TarjetaEsDebito", cliente.Tarjeta.EsDebito);
                    base._comando.Parameters.AddWithValue("@TarjetaDineroDisponible", cliente.Tarjeta.DineroDisponible);
                    base._comando.Parameters.AddWithValue("@VencimientoTarjeta", cliente.Tarjeta.FechaVencimiento);

                    sqlQuery += ", TarjetaVencimiento = @VencimientoTarjeta, " +
                                  "TarjetaEntidadEmisora = @TarjetaEntidadEmisora, " +
                                  "TarjetaTitular = @TarjetaTitular, " +
                                  "TarjetaNumTarjeta = @TarjetaNumTarjeta, " +
                                  "TarjetaCVV = @TarjetaCVV, " +
                                  "TarjetaDineroDisponible = @TarjetaDineroDisponible, " +
                                  "TarjetaEsDebito = @TarjetaEsDebito ";
                }  

                sqlQuery += " WHERE IDCliente = @IDCliente;"; 

                base._comando.CommandType = CommandType.Text;
                base._comando.CommandText = sqlQuery;//-->Le paso la query.
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
        /// Implemento el metodo DeleteDato de la 
        /// interfaz, el cual me permitira eliminar 
        /// a un usuario mediante su ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteDato(int id)
        {
            bool pudoEliminar = false;

            using (SqlConnection conexion = new SqlConnection(CadenaDeConexion))
            {
                string query = "DELETE FROM Clientes WHERE IDCliente = @IDCliente";//-->Elimino de la tabla Clientes.

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@IDCliente", id);

                    try
                    {
                        conexion.Open();
                        int filasAfectadas = comando.ExecuteNonQuery();
                        pudoEliminar = filasAfectadas > 0;//-->Si elimino hubo una fila afectada, retornando true 
                    }
                    catch (Exception ex)
                    { 
                        Console.WriteLine("Error al eliminar el cliente: " + ex.Message);
                    }
                }
            }//-->Con el using se cierra la conexion al terminar.

            return pudoEliminar;
        }
        #endregion
    }
}
