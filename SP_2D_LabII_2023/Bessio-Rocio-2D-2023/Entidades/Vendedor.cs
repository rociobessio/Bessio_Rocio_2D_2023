using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que hereda de Persona.
    /// </summary>
    public class Vendedor : Persona
    {
        #region ATRIBUTOS
        private int _id; 
        private List<Cliente> _listaClientes; 
        private Dictionary<int, Producto> _listaProductos;
        private static List<Carrito> _historialVentas;
        private static int ultimoID;
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Me permite obtener el ID del Vendedor.
        /// </summary>
        public int ID { get { return this._id; } }
        /// <summary>
        /// Propiedad de lectura y escritura de la lista de Clientes.
        /// </summary>
        public List<Cliente> ListaClientes { get { return this._listaClientes; } set { this._listaClientes = value; } }
        /// <summary>
        /// Propiedad de escritura y lectura de la Lista de Productos/Carne.
        /// </summary>
        public Dictionary<int,Producto> ListaProductos { get { return this._listaProductos; } set { this._listaProductos = value; } }
       // public List<Producto> ListaProductos { get { return this._listaCarne; } set { this._listaCarne = value; } } 
        /// <summary>
        /// Hago override de la propiedad abtracta retornando false, ya que NO es cliente.
        /// </summary>
        public override bool EsCliente { get { return false; } } 
        /// <summary>
        /// Me permite obtener el historial de ventas realizadas por el vendedor.
        /// </summary>
        public static List<Carrito> HistorialVentas { get { return _historialVentas; } }
        #endregion

        #region CONSTRUCTOR 
        /// <summary>
        /// Constructor estatico que le asigna una ID a cada vendedor.
        /// </summary>
        static Vendedor()
        {
            ultimoID = 2001;
            _historialVentas = new List<Carrito>();
        }

        /// <summary>
        /// Constructor parametrizado de la clase Vendedor.
        /// Le paso sus parametros al base y recibe y asigna los atributos
        /// propios.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="dni"></param>
        /// <param name="domicilio"></param>
        /// <param name="id"></param>
        /// <param name="fechaIngreso"></param>
        /// <param name="clientes"></param>
        /// <param name="productos"></param>
        /// <param name="user"></param>
        public Vendedor(string nombre, string apellido, Sexo sexo, Nacionalidad nacionalidad, DateTime fechaNacimiento,
                       string dni, string domicilio,
                        List<Cliente> clientes,Dictionary<int,Producto> productos,string telefono,Usuario user,List<Carrito> listaVentas)
            : base(nombre, apellido, sexo, nacionalidad, fechaNacimiento, dni, domicilio,telefono,user)
        {  
            this._listaClientes = clientes;
            _historialVentas = listaVentas;
            this._listaProductos = productos;
            this._id = ultimoID;
            ultimoID++;
        } 

        /// <summary>
        /// Este constructor me permite tomar el mail y contraseña,
        /// se lo paso al base, para que no tire warnings instancio
        /// las listas.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="contrasenia"></param>
        public Vendedor(Usuario user)
            :base(user)
        {
            this._listaProductos = new Dictionary<int, Producto>();
            this._listaClientes = new List<Cliente>();  
            this._id = ultimoID;
            ultimoID++;
        }
        #endregion

        #region METODOS  
        /// <summary>
        /// Me permite verificar si el cliente cumple con los requisitios para comprar:
        /// 1.Si es con tarjeta que esta tenga saldo y que sea mayor al total de la compra.
        /// 2.Lo mismo con debito, que tenga saldo y que sea mayor al total.
        /// 3.Me fijo si pudo agregarlo al carrito. (Reutilizo codigo)
        /// 4.Si pudo, le descuento el total de su billetera 
        /// 5.Resto del stock la cantidad. 
        /// </summary>
        /// <param name="totalCompra"></param>
        /// <param name="cliente"></param> 
        /// <param name="peso"></param>
        /// <param name="carneSeleccionada"></param>
        /// <returns>True si cumple con los requisitos, false sino.</returns>
        public static bool Vender(double totalCompra, Cliente cliente, double peso,Producto carneSeleccionada,out bool updateBase)
        {
            bool pudoComprar = false;
            updateBase = false; 

            if (cliente.ConTarjeta)
            {
                pudoComprar = VenderConTarjeta(totalCompra, cliente, peso, carneSeleccionada);
            }
            else
            {
                pudoComprar = VenderConEfectivo(totalCompra, cliente, peso, carneSeleccionada);
            } 

            if (pudoComprar == true)//-->Si pudo comprar
            {
                ProductoDAO productoDAO = new ProductoDAO();
                ClienteDAO clienteDAO = new ClienteDAO();

                //-->Modifico las tablas correspondientes
                if (productoDAO.UpdateDato(carneSeleccionada) && clienteDAO.UpdateDato(cliente))
                    updateBase = true;

                //-->Serializo en formato JSON el carrito, que seria como el ticket de compra
                if (JSON.SerializacionJSON(cliente.CarritoCompra) && pudoComprar == true)
                {
                    pudoComprar = true;
                }
                else
                    throw new JSONException("Error al intentar serializar el producto en JSON.");
            } 
            return pudoComprar;
        }

        /// <summary>
        /// Metodo privado estatico que realiza la venta si el
        /// cliente cuenta con tarjeta.
        /// </summary>
        /// <param name="totalCompra"></param>
        /// <param name="cliente"></param>
        /// <param name="peso"></param>
        /// <param name="carneSeleccionada"></param>
        /// <returns></returns>
        private static bool VenderConTarjeta(double totalCompra, Cliente cliente, double peso, Producto carneSeleccionada)
        {
            if (cliente.Tarjeta.DineroDisponible >= 0 && cliente.Tarjeta.DineroDisponible >= totalCompra)
            {
                if (Carrito.AgregarAlCarrito(carneSeleccionada, peso, cliente))
                {
                    cliente.CarritoCompra.UsuarioCompra = cliente.Usuario.Email;
                    cliente.Tarjeta.DineroDisponible -= totalCompra;
                    carneSeleccionada.Stock -= peso;
                    return true;
                }
            } 
            return false;
        }

        /// <summary>
        /// Metod privado estatico que realiza la venta si el
        /// cliente cuenta con tarjeta.
        /// </summary>
        /// <param name="totalCompra"></param>
        /// <param name="cliente"></param>
        /// <param name="peso"></param>
        /// <param name="carneSeleccionada"></param>
        /// <returns></returns>
        private static bool VenderConEfectivo(double totalCompra, Cliente cliente, double peso, Producto carneSeleccionada)
        {
            if (cliente.DineroEfectivoDisponible >= 0 && cliente.DineroEfectivoDisponible >= totalCompra)
            {
                if (Carrito.AgregarAlCarrito(carneSeleccionada, peso, cliente))
                {
                    cliente.CarritoCompra.UsuarioCompra = cliente.Usuario.Email;
                    cliente.DineroEfectivoDisponible -= totalCompra;
                    carneSeleccionada.Stock -= peso;
                    return true;
                }
            } 
            return false;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Dos vendedores seran iguales si tienen el mismo ID.
        /// </summary>
        /// <param name="vendedor1"></param>
        /// <param name="vendedor2"></param>
        /// <returns>True si son iguales, false sino.</returns>
        public static bool operator ==(Vendedor vendedor1 , Vendedor vendedor2)
        {
            bool sonIguales = false;
            if (!(vendedor1 is null) && !(vendedor2 is null))
            {
                sonIguales =  (vendedor1._id == vendedor2._id) && 
                              (vendedor1.usuario == vendedor2.usuario);  
            }
            return sonIguales;
        }

        /// <summary>
        /// Dos vendedores seran distintos si no comparte el mismo ID
        /// y usuario.
        /// </summary>
        /// <param name="vendedor1"></param>
        /// <param name="vendedor2"></param>
        /// <returns></returns>
        public static bool operator !=(Vendedor vendedor1, Vendedor vendedor2)
        {
            return !(vendedor1 == vendedor2);
        }
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// Compara si el objeto this actual es igual al pasaddo por parametro
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Vendedor)
            {
                retorno = this == ((Vendedor)obj);
            }
            return retorno;
        }

        /// <summary>
        /// Valor Hash del objeto
        /// </summary>
        /// <returns>Valor Hash del objeto</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Retorna un string con el estado del objeto
        /// </summary>
        /// <returns>string con el estado del objeto</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{base.ToString()} - ID: {this._id}");
            return stringBuilder.ToString();
        }
        #endregion
    }
}
