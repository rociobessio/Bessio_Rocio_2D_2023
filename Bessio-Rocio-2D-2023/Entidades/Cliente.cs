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
        //private List<Producto> _listaProductos;--> La lista de productos en realidad estaria en ticket o compra ya que de ahi luego impprimiria los detalles de estos
        private Tarjeta _tarjetaCredito;
        private Carrito _CarritoCompra;
        //private Usuario usuario;
        private bool _esConTarjeta;
        #endregion

        #region PROPIEDADES
        public double DineroDebitoDisponible { get { return this._dineroDebitoDisponible; } }
        //public List<Producto> Productos { get { return this._listaProductos; } }
        public Tarjeta TarjetaCredito { get { return this._tarjetaCredito; } }
        public Carrito CarritoCompra { get { return this._CarritoCompra; } }
        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        //public string Mail { get { return this.mail; } }    
        //public string Contraseña { get { return this.contraseña; } }
        public bool ConTarjeta { get { return this._esConTarjeta; } }
        /// <summary>
        /// Hago override de la propiedad EsCliente retornando true.
        /// </summary>
        public override bool EsCliente { get { return true; } }
        #endregion

        #region CONSTRUCTORES
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
        /// <param name="dineroDebitoDisponible"></param>
        /// <param name="productos"></param>
        /// <param name="tarjeta"></param>
        /// <param name="carrito"></param>
        public Cliente(string nombre, string apellido, Sexo sexo, Nacionalidad nacionalidad, DateTime fechaNacimiento,
                       string dni, string domicilio,
                       double dineroDebitoDisponible, Carrito carrito)
            : base(nombre, apellido,sexo,nacionalidad,fechaNacimiento,dni,domicilio)
        {
            this._dineroDebitoDisponible = dineroDebitoDisponible;
            //this._listaProductos = productos;
            this._CarritoCompra = carrito;
            //this.usuario = usuario1;
        }

        /// <summary>
        /// Sobrecarga de constructor, este a diferencia del anterior añade el parametro
        /// tarjeta, por si el cliente decide abonar con esta.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="dni"></param>
        /// <param name="domicilio"></param>
        /// <param name="dineroDebitoDisponible"></param>
        /// <param name="productos"></param>
        /// <param name="tarjeta"></param>
        /// <param name="carrito"></param>
        /// <param name="usuario1"></param>
        public Cliente(string nombre, string apellido, Sexo sexo, Nacionalidad nacionalidad, DateTime fechaNacimiento,
                       string dni, string domicilio,
                       double dineroDebitoDisponible, Tarjeta tarjeta, Carrito carrito )
             : this(nombre,apellido,sexo,nacionalidad,fechaNacimiento,dni,domicilio,dineroDebitoDisponible,carrito)
        {
            this._tarjetaCredito = tarjeta;
        }

        public Cliente(string email, string contrasenia)
              : base(email, contrasenia)
        { 

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

        #region POLIMORFISMO
        /// <summary>
        /// Sobrecarga del metodo .ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()}-${this._dineroDebitoDisponible:f}-{this._tarjetaCredito.ToString()}" +
                $"-{this._CarritoCompra.ToString()}";
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
        /// Valor Hash del objeto
        /// </summary>
        /// <returns>Valor Hash del objeto</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

    }
}
