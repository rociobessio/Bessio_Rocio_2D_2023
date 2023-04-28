using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor : Persona
    {
        #region ATRIBUTOS
        private int _id;
        private DateTime _fechaIngreso;
        private List<Cliente> _listaClientes;
        private List<Carne2> _listaCarne;  
        #endregion

        #region PROPIEDADES
        public int ID { get { return this._id; } }
        public List<Cliente> ListaClientes { get { return this._listaClientes; } }
        public List<Carne2> ListaProductos { get { return this._listaCarne; }  set { this.ListaProductos = value; } } 
        public DateTime FechaIngreso { get { return this._fechaIngreso; } }

        /// <summary>
        /// Hago override de la propiedad abtracta retornando false.
        /// </summary>
        public override bool EsCliente { get { return false; } } 
        #endregion

        #region CONSTRUCTOR 
        /// <summary>
        /// Constructor parametrizado de la clase Vendedor.
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
                       int id,DateTime fechaIngreso,List<Cliente> clientes,List<Carne2> productos,string telefono)
            : base(nombre, apellido, sexo, nacionalidad, fechaNacimiento, dni, domicilio,telefono)
        {
            this._id = id;
            this._fechaIngreso = fechaIngreso;
            this._listaClientes = clientes;
            this._listaCarne = productos; 
        } 

        /// <summary>
        /// Este constructor me permite tomar el mail y contraseña,
        /// se lo paso al base, para que no tire warnings instancio
        /// las listas.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="contrasenia"></param>
        public Vendedor(string email,string contrasenia)
            :base(email,contrasenia)
        {
            this._listaCarne = new List<Carne2>();
            this._listaClientes = new List<Cliente>();  
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
                sonIguales =  (vendedor1._id == vendedor2._id);  
            }
            return sonIguales;
        }

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
            return $"{base.ToString()}-{this._id}-{this._fechaIngreso.ToShortDateString()}";
        }
        #endregion
    }
}
