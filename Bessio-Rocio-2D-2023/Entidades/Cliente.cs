using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        #region ATRIBUTOS
        private double _dineroDebitoDisponible;
        private List<Producto> _listaProductos;
        private Tarjeta _tarjetaCredito;
        private Ticket _ticketCompra;
        private Usuario usuario;
        #endregion

        #region PROPIEDADES
        public double DineroDebitoDisponible { get { return this._dineroDebitoDisponible; } }
        public List<Producto> Productos { get { return this._listaProductos; } }
        public Tarjeta TarjetaCredito { get { return this._tarjetaCredito; } }
        public Ticket TicketCompra { get { return this._ticketCompra; } }
        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        //public string Mail { get { return this.mail; } }    
        //public string Contraseña { get { return this.contraseña; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor que inicializar con valores validos el objeto que va a ser creado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="dni"></param>
        /// <param name="domicilio"></param>
        /// <param name="contraseña"></param>
        /// <param name="usuario"></param>
        /// <param name="dineroDebitoDisponible"></param>
        /// <param name="productos"></param>
        /// <param name="tarjeta"></param>
        /// <param name="ticket"></param>
        public Cliente(string nombre, string apellido, Sexo sexo, Nacionalidad nacionalidad, DateTime fechaNacimiento,
                       string dni, string domicilio,
                       double dineroDebitoDisponible,List<Producto> productos, Tarjeta tarjeta, Ticket ticket,Usuario usuario1)
            : base(nombre, apellido,sexo,nacionalidad,fechaNacimiento,dni,domicilio)
        {
            this._dineroDebitoDisponible = dineroDebitoDisponible;
            this._listaProductos = productos;
            this._tarjetaCredito = tarjeta; 
            this._ticketCompra = ticket;
            this.usuario = usuario1;
        }
        #endregion 

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Dos Clientes seran iguales, si comparten el mismo DNI.
        /// 
        /// PIENSA BART PIENSA-------------
        /// Esta pensando para que luego en la clase Cliente y Vendedor
        /// lo unico que haga es comparar si ellos son iguales por el
        /// mail y la contraseña.
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
    }
}
