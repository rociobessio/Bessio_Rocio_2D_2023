using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    /// <summary>
    /// Esta clase hereda de Persona.
    /// </summary>
    public class Cliente : Persona
    {
        #region ATRIBUTOS
        private int _idCliente;
        private double _dineroEfectivoDisponible;
        private Tarjeta _tarjeta;
        private Carrito _carritoCompra; 
        private bool _esConTarjeta; 
        #endregion

        #region PROPIEDADES
        public int IDCliente { get { return this._idCliente; } set { this._idCliente = value; } }
        /// <summary>
        /// Propiedad de lectura y escritura, me permite devolver
        /// y settear el dinero en efectivo del cliente.
        /// </summary>
        public double DineroEfectivoDisponible { get { return this._dineroEfectivoDisponible; } set { this._dineroEfectivoDisponible = value; } }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo _tarjeta.
        /// </summary>
        public Tarjeta Tarjeta { get { return this._tarjeta; } set { this._tarjeta = value; } }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo _carritoCompra
        /// </summary>
        public Carrito CarritoCompra { get { return this._carritoCompra; } set { this.CarritoCompra = value; } } 
        /// <summary>
        /// Retornara un booleano si usa tarjeta o no.
        /// </summary>
        public bool ConTarjeta { get { return this._esConTarjeta; } set { this._esConTarjeta = value; } }
        /// <summary>
        /// Hago override de la propiedad EsCliente retornando true, servirá para
        /// el Login.
        /// </summary>
        public override bool EsCliente { get { return true; } } 
        #endregion
 
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor que me permite crear una instancia de Cliente, le paso los 
        /// parametros correspondientes al base y el valor Carrito que recibo se lo doy
        /// a mi atributo carrito.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="dni"></param>
        /// <param name="domicilio"></param>
        /// <param name="telefono"></param>
        /// <param name="user"></param>
        /// <param name="carrito"></param>
        public Cliente(string nombre, string apellido, Sexo sexo, Nacionalidad nacionalidad, DateTime fechaNacimiento,
                       string dni, string domicilio, string telefono, Usuario user,Carrito carrito) 
            : base(nombre, apellido, sexo, nacionalidad, fechaNacimiento, dni, domicilio, telefono, user)
        {
            this._carritoCompra = carrito;
        }

        /// <summary>
        /// Constructor que me permite crear una instancia de cliente con Tarjeta y
        /// realizo una sobrecarga de constructor con el : this()
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="dni"></param>
        /// <param name="domicilio"></param>
        /// <param name="telefono"></param>
        /// <param name="user"></param>
        /// <param name="carrito"></param>
        /// <param name="tarjeta"></param>
        /// <param name="usaTarjeta"></param>
        public Cliente(string nombre, string apellido, Sexo sexo, Nacionalidad nacionalidad, DateTime fechaNacimiento,
                       string dni, string domicilio, string telefono, Usuario user,Carrito carrito,Tarjeta tarjeta,bool usaTarjeta)
            : this(nombre, apellido, sexo, nacionalidad, fechaNacimiento, dni, domicilio, telefono, user,carrito)
        {
            this._tarjeta = tarjeta;
            this._esConTarjeta = usaTarjeta;
        }

        /// <summary>
        /// Me permitira crear una instancia de Cliente si este decide usar unicamente efectivo,
        /// uso sobrecarga del : this().
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="dni"></param>
        /// <param name="domicilio"></param>
        /// <param name="telefono"></param>
        /// <param name="user"></param>
        /// <param name="carrito"></param>
        /// <param name="efectivo"></param>
        /// <param name="usaTarjeta"></param>
        public Cliente(string nombre, string apellido, Sexo sexo, Nacionalidad nacionalidad, DateTime fechaNacimiento,
                       string dni, string domicilio, string telefono, Usuario user, Carrito carrito,double efectivo,bool usaTarjeta)
            : this(nombre, apellido, sexo, nacionalidad, fechaNacimiento, dni, domicilio, telefono, user, carrito)
        {
            this._dineroEfectivoDisponible = efectivo;
            this._esConTarjeta = usaTarjeta;
        }

        /// <summary>
        /// Constructor que me permite recibir un usuario, y
        /// pasarselo al base.
        /// </summary>
        /// <param name="user"></param>
        public Cliente(Usuario user)
                    : base(user)
        { 
            this._carritoCompra = new Carrito();
        }
        #endregion 

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Dos Clientes seran iguales, si comparten el mismo DNI.
        /// </summary>
        /// <param name="cliente1"></param>
        /// <param name="cliente2"></param>
        /// <returns>Retorna true si son iguales, false sino.</returns>
        public static bool operator ==(Cliente cliente1, Cliente cliente2)
        {
            bool sonIguales = false;
            if (!(cliente1 is null) && !(cliente2 is null))
            {
                sonIguales = (cliente1.dni == cliente2.dni);
            }
            return sonIguales;
        }

        public static bool operator !=(Cliente cliente, Cliente cliente2)
        {
            return !(cliente == cliente2);
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Me permite que un cliente compre si cumple con las validaciones necesarias, tiene dinero disponible.
        /// </summary>
        /// <param name="clienteIngresado"></param>
        /// <param name="listaCarnesDisponibles"></param> 
        /// <returns></returns>
        public static bool Comprar(Cliente clienteIngresado, List<Producto> listaCarnesDisponibles, out bool updateBaseProducto)
        {
            bool puedeComprar = false;
            updateBaseProducto = false;

            if (!VerificarDisponibilidadPago(clienteIngresado))
            {
                return false;
            }

            foreach (Producto carneDisponible in listaCarnesDisponibles)
            {
                foreach (Producto carneCarrito in clienteIngresado.CarritoCompra.Productos)
                {
                    if (DescontarStock(carneDisponible, carneCarrito))
                    {
                        if (ActualizarStockProducto(carneDisponible))
                        {
                            updateBaseProducto = true;
                            puedeComprar = true;
                        }
                    }
                }
            }

            if (puedeComprar)
            {
                ActualizarDineroCliente(clienteIngresado);
                ClienteDAO clienteDAO = new ClienteDAO();
                clienteIngresado.CarritoCompra.FechaCompra = DateTime.Now;//-->Lo guardo con la fecha actual.

                if (clienteDAO.UpdateDato(clienteIngresado))
                {
                    clienteIngresado.CarritoCompra.UsuarioCompra = clienteIngresado.Usuario.Email;
                    if (!XML.SerializacionXML(clienteIngresado.CarritoCompra))
                        throw new XMLException("Ocurrio un problema al intentar serializar en formato XML.");
                }
                else
                {
                    return false;
                }
            } 
            return puedeComprar;
        }

        /// <summary>
        /// Me permite verificar con que paga
        /// y si puede,
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        private static bool VerificarDisponibilidadPago(Cliente cliente)
        {
            if (cliente.ConTarjeta)
            {
                return cliente.Tarjeta.DineroDisponible >= cliente.CarritoCompra.PrecioTotal && cliente.Tarjeta.DineroDisponible >= 0;
            }
            else
            {
                return cliente.DineroEfectivoDisponible >= 0 && cliente.DineroEfectivoDisponible >= cliente.CarritoCompra.PrecioTotal;
            }
        }

        /// <summary>
        /// Me permite descontar el stock
        /// </summary>
        /// <param name="carneDisponible"></param>
        /// <param name="carneCarrito"></param>
        /// <returns></returns>
        private static bool DescontarStock(Producto carneDisponible, Producto carneCarrito)
        {
            if (carneDisponible == carneCarrito && carneDisponible.Stock >= carneCarrito.Stock)
            {
                carneDisponible.Stock -= carneCarrito.Stock;
                return true;
            } 

            return false;
        }

        /// <summary>
        /// Me permite actualizar stock 
        /// del producto.
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        private static bool ActualizarStockProducto(Producto producto)
        {
            ProductoDAO productoDAO = new ProductoDAO();
            return productoDAO.UpdateDato(producto);
        }

        /// <summary>
        /// Me permite actualizar el saldo del cliente.
        /// </summary>
        /// <param name="cliente"></param>
        private static void ActualizarDineroCliente(Cliente cliente)
        {
            if (cliente.ConTarjeta)
            {
                cliente.Tarjeta.DineroDisponible -= cliente.CarritoCompra.PrecioTotal;
            }
            else
            {
                cliente.DineroEfectivoDisponible -= cliente.CarritoCompra.PrecioTotal;
            }
        }
        #endregion 

        #region POLIMORFISMO
        /// <summary>
        /// Sobrecarga del metodo .ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            if (this._esConTarjeta)
            {
                sb.AppendLine("DATOS DE LA TARJETA:");
                sb.AppendLine(this._tarjeta.ToString());
            }
            else
            {
                sb.AppendLine($"Efectivo: ${this._dineroEfectivoDisponible:f}"); 
            }
            sb.AppendLine("CARRITO:");
            sb.AppendLine(this._carritoCompra.ToString());    

            return sb.ToString();
        }

        /// <summary>
        /// Compara si el objeto this actual es igual al pasaddo por parametro
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Cliente)
            {
                retorno = this == ((Cliente)obj);
            }
            return retorno;
        }

        /// <summary>
        /// Valor Hash del objeto, es unico.
        /// </summary>
        /// <returns>Valor Hash del objeto</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
