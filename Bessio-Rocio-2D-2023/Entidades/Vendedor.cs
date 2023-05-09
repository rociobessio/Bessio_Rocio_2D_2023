using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
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
        /// Este metodo estatico me permite hardcodear las listas de los vendedores.
        /// </summary>
        /// <param name="vendedor"></param>
        /// <returns></returns>
        public static Vendedor CargarDatosVendedor(Vendedor vendedor)
        {
            #region INSTANCIO CARNES 
            vendedor._listaProductos.Add(1, new Producto(Corte.Lomo, 19, CategoriaBovina.Ternero, new DateTime(2023, 12, 10), 900, "Mingo CO", Tipo.Carne_Vacuna, 1000));
            vendedor._listaProductos.Add(2, new Producto(Corte.Pechuga, 17, CategoriaBovina.No_Es_Bovino, new DateTime(2023, 11, 22), 100, "La Granjita", Tipo.Pollo, 120));
            vendedor._listaProductos.Add(3, new Producto(Corte.Costilla, 190, CategoriaBovina.No_Es_Bovino, new DateTime(2023, 09, 08), 230, "El Muelle Mardel", Tipo.Cerdo, 300));
            vendedor._listaProductos.Add(4, new Producto(Corte.Asado, 10, CategoriaBovina.Ternero, new DateTime(2023, 05, 10), 190, "La mirona", Tipo.Carne_Vacuna, 1300));
            vendedor._listaProductos.Add(5, new Producto(Corte.Pollo_Entero, 90, CategoriaBovina.No_Es_Bovino, new DateTime(2023, 12, 07), 230, "La Granjita", Tipo.Pollo, 500));
            vendedor._listaProductos.Add(6, new Producto(Corte.Matambre, 50, CategoriaBovina.No_Es_Bovino, new DateTime(2023, 09, 08), 1000, "Chascomus LA", Tipo.Cerdo, 1300));
            vendedor._listaProductos.Add(7, new Producto(Corte.Pechuga, 100, CategoriaBovina.No_Es_Bovino, new DateTime(2023, 06, 18), 500, "La Granjita", Tipo.Pollo, 1000));
            vendedor._listaProductos.Add(8, new Producto(Corte.Pechito, 190, CategoriaBovina.No_Es_Bovino, new DateTime(2023, 10, 05), 2000, "La mirona", Tipo.Cerdo, 2500));
            vendedor._listaProductos.Add(9, new Producto(Corte.Bife_Angosto, 100, CategoriaBovina.Novillito, new DateTime(2023, 09, 08), 2000, "Siga la vaca", Tipo.Carne_Vacuna, 2300));
            #endregion 

            #region INSTANCIO CLIENTES 
            vendedor._listaClientes.Add(new Cliente("Pablo", "Fernandez", Sexo.Masculino, Nacionalidad.Chile, new DateTime(1979, 08, 12),
                        "18920129", "Alcorta 90", "10923891", new Usuario("paFer@yahoo.com.ar", "123"), new Carrito(),
                        new Tarjeta(new DateTime(2025, 04, 29), "Pablo Fernandez", "0900", "09691273892180328", "Banco Provincia", 5500, false), true));//-->Utiliza Tarjeta Débito
            vendedor._listaClientes.Add(new Cliente("Mariana", "Silveira", Sexo.Femenino, Nacionalidad.Argentina, new DateTime(1990, 10, 19),
                                    "22312335", "Formosa 2716", "77090989", new Usuario("mar@hotmail.com", "123"), new Carrito(),
                                    new Tarjeta(new DateTime(2025, 04, 29), "Mariana Silveira", "0033", "1892312901234124", "Banco Nacion", 10000, true), true));//-->Utiliza Tarjeta Credito
            vendedor._listaClientes.Add(new Cliente("Gaston", "Casares", Sexo.Masculino, Nacionalidad.Uruguay, new DateTime(1978, 12, 09),
                                    "20193123", "Rucci 2680", "11234124", new Usuario("gCasares@yahoo.com.ar", "123"), new Carrito(), 12000, false));//-->Utiliza Debito
            #endregion

            return vendedor;
        }

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
        public static bool Vender(double totalCompra, Cliente cliente, double peso,Producto carneSeleccionada)
        {
            bool pudoComprar = false;
            if (cliente.ConTarjeta)//-->Chequeo que sea con tarjeta
            {
                if (cliente.Tarjeta.DineroDisponible > 0 &&
                     cliente.Tarjeta.DineroDisponible > totalCompra)
                {
                    if (Carrito.AgregarAlCarrito(carneSeleccionada,peso,cliente))
                    {
                        cliente.Tarjeta.DineroDisponible -= totalCompra;//-->Descuento la plata
                        carneSeleccionada.Peso -= peso;//-->Descuento el peso
                        pudoComprar = true;
                    } 
                }
            }
            else//Es con efectivo
            {
                if (cliente.DineroEfectivoDisponible > 0 && cliente.DineroEfectivoDisponible > totalCompra)
                {
                    if (Carrito.AgregarAlCarrito(carneSeleccionada, peso, cliente))
                    {
                        cliente.DineroEfectivoDisponible -= totalCompra;
                        carneSeleccionada.Peso -= peso;//-->Descuento el peso 
                        pudoComprar = true;
                    } 
                }
            } 

            return pudoComprar;
        }

        /// <summary>
        /// Método estatico que me permite ver el historial de ventas,
        /// recibo un cliente y creo una instancia carrito 
        /// para pasarselo a mi lista.
        /// </summary>
        /// <param name="cliente"></param>
        public static void ObtenerHistorialVentas(Cliente cliente)
        {
            Carrito carrito = new Carrito();
            carrito.Productos = cliente.CarritoCompra.Productos;
            carrito.PrecioTotal = cliente.CarritoCompra.PrecioTotal;
            carrito.ConTarjeta = cliente.CarritoCompra.ConTarjeta;
            if (!_historialVentas.Contains(carrito))
            {
                _historialVentas.Add(carrito);//-->Añado al historial del cliente pasandole el carrito
            }
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
            stringBuilder.AppendLine($"{base.ToString()}-{this._id} - ID: {this._id}");
            return stringBuilder.ToString();
        }
        #endregion
    }
}
