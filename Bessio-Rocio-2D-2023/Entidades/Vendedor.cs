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
        private List<Carne> _listaCarne;  
        #endregion

        #region PROPIEDADES
        public int ID { get { return this._id; } }
        public List<Cliente> ListaClientes { get { return this._listaClientes; } set { this._listaClientes = value; } }
        public List<Carne> ListaProductos { get { return this._listaCarne; } set { this._listaCarne = value; } } 
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
                       int id,DateTime fechaIngreso,List<Cliente> clientes,List<Carne> productos,string telefono,Usuario user)
            : base(nombre, apellido, sexo, nacionalidad, fechaNacimiento, dni, domicilio,telefono,user)
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
        public Vendedor(Usuario user)
            :base(user)
        {
            this._listaCarne = new List<Carne>();
            this._listaClientes = new List<Cliente>();  
        } 
        #endregion

        /// <summary>
        /// Este metodo estatico me permite hardcodear las listas de los vendedores.
        /// </summary>
        /// <param name="vendedor"></param>
        /// <returns></returns>
        public static Vendedor CargarDatosVendedor(Vendedor vendedor)
        {
            #region INSTANCIO CARNES
            //velistaCarnesDisponibles = new List<Carne>();
            vendedor._listaCarne.Add(new Carne(Corte.Lomo, 1900, CategoriaBovina.Ternero, new DateTime(2023, 12, 10), 900, "Mingo CO", Tipo.Carne_Vacuna, 1000));
            vendedor._listaCarne.Add(new Carne(Corte.Pechuga, 700, CategoriaBovina.No_Es_Bovino, new DateTime(2023, 11, 22), 100, "La Granjita", Tipo.Pollo, 120));
            vendedor._listaCarne.Add(new Carne(Corte.Costilla, 1900, CategoriaBovina.Novillo, new DateTime(2023, 09, 08), 230, "El Muelle Mardel", Tipo.Cerdo, 300));
            vendedor._listaCarne.Add(new Carne(Corte.Asado, 1000, CategoriaBovina.Ternero, new DateTime(2023, 05, 10), 190, "La mirona", Tipo.Carne_Vacuna, 1300));
            vendedor._listaCarne.Add(new Carne(Corte.Pollo_Entero, 900, CategoriaBovina.No_Es_Bovino, new DateTime(2023, 12, 07), 230, "La Granjita", Tipo.Pollo, 500));
            vendedor._listaCarne.Add(new Carne(Corte.Matambre, 500, CategoriaBovina.No_Es_Bovino, new DateTime(2023, 09, 08), 1000, "Chascomus LA", Tipo.Cerdo, 1300));
            vendedor._listaCarne.Add(new Carne(Corte.Pechuga, 100, CategoriaBovina.No_Es_Bovino, new DateTime(2023, 06, 18), 500, "La Granjita", Tipo.Pollo, 1000));
            vendedor._listaCarne.Add(new Carne(Corte.Pechito, 900, CategoriaBovina.No_Es_Bovino, new DateTime(2023, 10, 05), 2000, "La mirona", Tipo.Cerdo, 2500));
            vendedor._listaCarne.Add(new Carne(Corte.Bife_Angosto, 100, CategoriaBovina.Novillito, new DateTime(2023, 09, 08),2000, "Siga la vaca", Tipo.Carne_Vacuna, 2300));
            #endregion

            #region INSTANCIO CLIENTES 
            vendedor._listaClientes.Add(new Cliente("Pablo", "Fernandez", Sexo.Masculino, Nacionalidad.Chile, new DateTime(1979, 08, 12),
                        "18920129", "Alcorta 90", "10923891", new Usuario("paFer@yahoo.com.ar", "123"), new Carrito(),
                        new Tarjeta(new DateTime(2025, 04, 29), "Pablo Fernandez", "0900", "09691273892180328", "Banco Provincia", 55000, false), true));//-->Utiliza Tarjeta Débito
            vendedor._listaClientes.Add(new Cliente("Mariana", "Silveira", Sexo.Femenino, Nacionalidad.Argentina, new DateTime(1990, 10, 19),
                                    "22312335", "Formosa 2716", "77090989", new Usuario("mar@hotmail.com", "123"), new Carrito(),
                                    new Tarjeta(new DateTime(2025, 04, 29), "Mariana Silveira", "0033", "1892312901234124", "Banco Nacion", 10000, true), true));//-->Utiliza Tarjeta Credito
            vendedor._listaClientes.Add(new Cliente("Gaston", "Casares", Sexo.Masculino, Nacionalidad.Uruguay, new DateTime(1978, 12, 09),
                                    "20193123", "Rucci 2680", "11234124", new Usuario("gCasares@yahoo.com.ar", "123"), new Carrito(), 12000, false));//-->Utiliza Debito
            #endregion

            return vendedor;
        }

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
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{base.ToString()}-{this._id} - ID: {this._id} - Fecha Ingreso: {this._fechaIngreso.ToShortDateString()}");
            return stringBuilder.ToString();
        }
        #endregion
    }
}
