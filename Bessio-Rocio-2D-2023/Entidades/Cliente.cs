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
        private double _dineroEfectivoDisponible;
        //private List<Producto> _listaProductos;--> La lista de productos en realidad estaria en ticket o compra ya que de ahi luego impprimiria los detalles de estos
        private Tarjeta _tarjeta;
        private Carrito _CarritoCompra; 
        private bool _esConTarjeta;
        #endregion

        #region PROPIEDADES
        public double DineroEfectivoDisponible { get { return this._dineroEfectivoDisponible; } set { this._dineroEfectivoDisponible = value; } }
        public Tarjeta Tarjeta { get { return this._tarjeta; } set { this._tarjeta = value; } }
        public Carrito CarritoCompra { get { return this._CarritoCompra; } set { this.CarritoCompra = value; } } 
        public bool ConTarjeta { get { return this._esConTarjeta; } set { this._esConTarjeta = value; } }
        /// <summary>
        /// Hago override de la propiedad EsCliente retornando true.
        /// </summary>
        public override bool EsCliente { get { return true; } }
        #endregion
 
        #region CONSTRUCTORES VERSION 2
        /// <summary>
        /// Constructor del base y me permite instanciar tambien el carrito.
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
            this._CarritoCompra = carrito;
        }

        /// <summary>
        /// Me permite crear una instancia de Cliente con tarjeta de credito
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
        /// Me permitira crear una instancia de Cliente si este decide usar unicamente debito,
        /// uso sobrecarga del this.
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
        /// <param name="debito"></param>
        /// <param name="usaTarjeta"></param>
        public Cliente(string nombre, string apellido, Sexo sexo, Nacionalidad nacionalidad, DateTime fechaNacimiento,
                       string dni, string domicilio, string telefono, Usuario user, Carrito carrito,double debito,bool usaTarjeta)
            : this(nombre, apellido, sexo, nacionalidad, fechaNacimiento, dni, domicilio, telefono, user, carrito)
        {
            this._dineroEfectivoDisponible = debito;
            this._esConTarjeta = usaTarjeta;
        }

        public Cliente(Usuario user)
                    : base(user)
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
            return $"{base.ToString()}-${this._dineroEfectivoDisponible:f}-{this._tarjeta.ToString()}";
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

        #region METODOS
        //private bool Comprar()
        //{

        //}
        #endregion
    }
}
