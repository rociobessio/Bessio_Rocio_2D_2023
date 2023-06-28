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
    public class ClienteDAO : IDataBase<Cliente>
    {
        #region ATRIBUTOS
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        #endregion

        #region CONSTRUCTOR
        public ClienteDAO()
        {
            try
            {
                this.conexion = new SqlConnection(CadenaConexionBase());
            }
            catch(Exception)
            {
                throw new SQLConexionException("Error en la conexion con la base de datos.");
            }
        }
        #endregion

        #region METODOS 
        /// <summary>
        /// Me permite retornar la cadena de conexion
        /// de la base de datos.
        /// </summary>
        /// <returns></returns>
        public string CadenaConexionBase()
        {
            return @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CARNICERIA_DB;Data Source=DESKTOP-S8KBDM2;Trusted_Connection=True;";
        }

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
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT p.Nombre, p.Apellido, u.Email, p.DNI, p.Telefono, p.Domicilio, c.ConTarjeta, c.EfectivoDisponible, " +
                                             "c.TarjetaVencimiento, c.TarjetaEntidadEmisora, c.TarjetaTitular, c.TarjetaNumTarjeta, c.TarjetaCVV, " +
                                             "c.TarjetaDineroDisponible, c.TarjetaEsDebito, c.IDCliente, p.IDPersona " +
                                             "FROM Usuarios u " +
                                             "JOIN Personas p ON u.IDPersona = p.IDPersona " +
                                             "JOIN Clientes c ON u.IDCliente = c.IDCliente";
                this.comando.Connection = this.conexion;

                this.conexion.Open();//-->Abro la conexion

                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())//-->Mientras pueda leer, obtengo los clientes de la base
                {
                    Cliente cliente = new Cliente(new Usuario("", ""));

                    cliente.Nombre = (string)this.lector[0];
                    cliente.Apellido = (string)this.lector[1];
                    cliente.Usuario.Email = (string)lector[2];
                    cliente.DNI = (string)this.lector[3];
                    cliente.Telefono = (string)this.lector[4];
                    cliente.Domicilio = (string)this.lector[5];
                    cliente.ConTarjeta = (bool)this.lector[6];
                    cliente.DineroEfectivoDisponible = (double)this.lector[7];

                    if (cliente.ConTarjeta)//-->Si es con tarjeta la cargo
                    {
                        Tarjeta tarjeta = new Tarjeta((DateTime)this.lector[8], (string)this.lector[10], (string)this.lector[12],
                            (string)this.lector[11], (string)this.lector[9], (double)this.lector[13], (bool)this.lector[14]);

                        cliente.Tarjeta = tarjeta;//-->Se la paso, sino se instancia rompe.
                    }
                    cliente.IDCliente = (int)this.lector[15];
                    cliente.IDPersona = (int)this.lector[16];

                    listaClientes.Add(cliente);//-->Añado a la lista
                }
                this.lector.Close();//-->Cierro el lector
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
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT p.Nombre, p.Apellido, u.Email, p.DNI, p.Telefono, p.Domicilio, c.ConTarjeta, c.EfectivoDisponible, " +
                                             "c.TarjetaVencimiento, c.TarjetaEntidadEmisora, c.TarjetaTitular, c.TarjetaNumTarjeta, c.TarjetaCVV, " +
                                             "c.TarjetaDineroDisponible, c.TarjetaEsDebito, c.IDCliente, p.IDPersona " +
                                             "FROM Usuarios u " +
                                             "JOIN Personas p ON u.IDPersona = p.IDPersona " +
                                             "JOIN Clientes c ON u.IDCliente = c.IDCliente " +
                                             $"WHERE c.IDCliente = {id}";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();

                this.lector.Read();

                //-->Cargo ese cliente. 
                string nombre = (string)this.lector[0];
                string apellido = (string)this.lector[1];
                string email = (string)this.lector[2];
                string dni = (string)this.lector[3];
                string telefono = (string)this.lector[4];
                string domicilio = (string)this.lector[5];
                bool conTarjeta = (bool)this.lector[6];
                double dineroEfectivoDisponible = (double)this.lector[7];

                if (conTarjeta)
                {
                    DateTime vencimientoTarjeta = (DateTime)this.lector[8];
                    string entidadEmisora = (string)this.lector[9];
                    string titularTarjeta = (string)this.lector[10];
                    string numeroTarjeta = (string)this.lector[11];
                    string cvv = (string)this.lector[12];
                    double dineroDisponible = (double)this.lector[13];
                    bool esDebito = (bool)this.lector[14];

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
                cliente.IDCliente = (int)this.lector[15];
                cliente.IDPersona = (int)this.lector[16];

                this.lector.Close();//-->Cierro el lector.
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
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT p.Nombre, p.Apellido, u.Email, p.DNI, p.Telefono, p.Domicilio, c.ConTarjeta, c.EfectivoDisponible, " +
                                             "c.TarjetaVencimiento, c.TarjetaEntidadEmisora, c.TarjetaTitular, c.TarjetaNumTarjeta, c.TarjetaCVV, " +
                                             "c.TarjetaDineroDisponible, c.TarjetaEsDebito, c.IDCliente, p.IDPersona  " +
                                             "FROM Usuarios u " +
                                             "JOIN Personas p ON u.IDPersona = p.IDPersona " +
                                             "JOIN Clientes c ON u.IDCliente = c.IDCliente " +
                                             "WHERE u.Email = @email";

               this.comando.Connection = this.conexion;
               this.comando.Parameters.AddWithValue("@email", email);

               this.conexion.Open();

               this.lector = this.comando.ExecuteReader();

               this.lector.Read();

               //-->Cargo ese cliente.
               string nombre  = (string)this.lector[0];
               string apellido = (string)this.lector[1]; 
               string dni = (string)this.lector[3];
               string telefono = (string)this.lector[4];
               string domicilio = (string)this.lector[5];
               bool  conTarjeta = (bool)this.lector[6];
               double dineroEfectivoDisponible = (double)this.lector[7];
               int idCliente = (int)this.lector[15];
               int idPersona = (int)this.lector[16];

               if (conTarjeta)
               {
                   DateTime vencimientoTarjeta = (DateTime)this.lector[8];                    
                   string entidadEmisora = (string)this.lector[9];
                   string titularTarjeta = (string)this.lector[10];
                   string numeroTarjeta = (string)this.lector[11];
                   string cvv = (string)this.lector[12];
                   double dineroDisponible = (double)this.lector[13];
                   bool esDebito = (bool)this.lector[14];

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

               this.lector.Close();//-->Cierro el lector.
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
            return cliente;//-->Retorno al cliente.
        }

        /// <summary>
        /// Me permite modificar un cliente de la
        /// base de datos.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool ModificarCliente(Cliente cliente)
        {
            bool pudo = true;

            try
            {
                this.comando = new SqlCommand();
                //-->Parametros: 
                this.comando.Parameters.AddWithValue("@IDCliente", cliente.IDCliente);
                this.comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                this.comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                this.comando.Parameters.AddWithValue("@DNI", cliente.DNI);
                this.comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                this.comando.Parameters.AddWithValue("@Domicilio", cliente.Domicilio);
                this.comando.Parameters.AddWithValue("@ConTarjeta", cliente.ConTarjeta);
                this.comando.Parameters.AddWithValue("@EfectivoDisponible", cliente.DineroEfectivoDisponible);

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
                    this.comando.Parameters.AddWithValue("@TarjetaTitular", cliente.Tarjeta.Titular);
                    this.comando.Parameters.AddWithValue("@TarjetaNumTarjeta", cliente.Tarjeta.NumeroTarjeta);
                    this.comando.Parameters.AddWithValue("@TarjetaEntidadEmisora", cliente.Tarjeta.EntidadEmisora);
                    this.comando.Parameters.AddWithValue("@TarjetaCVV", cliente.Tarjeta.CVV);
                    this.comando.Parameters.AddWithValue("@TarjetaEsDebito", cliente.Tarjeta.EsDebito);
                    this.comando.Parameters.AddWithValue("@TarjetaDineroDisponible", cliente.Tarjeta.DineroDisponible);
                    this.comando.Parameters.AddWithValue("@VencimientoTarjeta", cliente.Tarjeta.FechaVencimiento);

                    sqlQuery += ", TarjetaVencimiento = @VencimientoTarjeta, " +
                                  "TarjetaEntidadEmisora = @TarjetaEntidadEmisora, " +
                                  "TarjetaTitular = @TarjetaTitular, " +
                                  "TarjetaNumTarjeta = @TarjetaNumTarjeta, " +
                                  "TarjetaCVV = @TarjetaCVV, " +
                                  "TarjetaDineroDisponible = @TarjetaDineroDisponible, " +
                                  "TarjetaEsDebito = @TarjetaEsDebito ";
                }  

                sqlQuery += " WHERE IDCliente = @IDCliente;"; 

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sqlQuery;//-->Le paso la query.
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
