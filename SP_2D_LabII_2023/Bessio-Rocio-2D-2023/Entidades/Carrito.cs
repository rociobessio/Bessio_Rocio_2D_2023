using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Carrito
    {
        #region ATRIBUTOS 
        private DateTime _fechaCompra;
        private double _precioTotal; 
        private bool _conTarjeta;
        private List<Producto> _listaDeProductos;
        private string _usuarioCompra;
        private static int ultimoCodigo;
        #endregion

        #region PROPIEDADES
        public string UsuarioCompra { get { return this._usuarioCompra; } set { this._usuarioCompra = value; } } 
        /// <summary>
        /// Propiedad de lectura que me permite obtener la fecha de compra.
        /// </summary>
        public DateTime FechaCompra { get { return this._fechaCompra; } set { this._fechaCompra = value; } }
        /// <summary>
        /// Propiedad de lectura y escritura.
        /// </summary>
        public double PrecioTotal { get { return this._precioTotal; } set { this._precioTotal = value; } }
        /// <summary>
        /// Propiedad de escritura y lectura, me permite saber si la compra/venta se realizo con
        /// Tarjeta.
        /// </summary>
        public bool ConTarjeta { get { return this._conTarjeta; } set { this._conTarjeta = value; } }
        /// <summary>
        /// Propiedad de escritura y lectura de la Lista de Productos.
        /// </summary>
        public List<Producto> Productos { get { return this._listaDeProductos; } set { this._listaDeProductos = value; } }
        #endregion

        #region CONSTRUCTOR 

        /// <summary>
        /// Este constructor inicializa todos los parametros
        /// </summary>
        public Carrito() 
        {
            this._conTarjeta = false;
            this._fechaCompra = DateTime.Today;
            this._precioTotal = 00;
            this._listaDeProductos = new List<Producto>(); 
        }

        /// <summary>
        /// Constructor de la clase Carrito que me permite crear una instacia del objeto
        /// parametrizado.
        /// parametrizado. 
        /// </summary>
        /// <param name="compra"></param>
        /// <param name="precioTotal"></param>
        /// <param name="tarjeta"></param>
        /// <param name="productos"></param>
        public Carrito(DateTime compra, double precioTotal, List<Producto> productos,bool tarjeta)
            :this()
        {
            this._conTarjeta = tarjeta;
            this._fechaCompra = compra; 
            this._precioTotal = precioTotal;
            this._listaDeProductos = productos; 
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// La sobrecarga del operador + me permite añadir un producto al carrito si este no se encuentra
        /// ya contenido en el.
        /// Utilizo la sobrecarga del == de Carne.
        /// </summary>
        /// <param name="carrito"></param>
        /// <param name="carne"></param>
        /// <returns>Devuelve true si pudo añadirlo, false sino.</returns>
        public static bool operator +(Carrito carrito, Producto carne)
        {
            bool puede = true; 
            if (!(carrito is null) && !(carne is null))
            {
                if (!carrito._listaDeProductos.Contains(carne))
                {
                    carrito._listaDeProductos.Add(carne);
                    puede = true;
                }
            }
            return puede;
        } 
        #endregion

        #region METODO
        /// <summary>
        /// Este método me permite validar si el ingreso del peso requerido es valido
        /// y si puede agregar al carrito mediante la sobrecarga del + en Carrito.
        /// A su vez llamo al metodo de CalcularPrecioTotal para que lo acumule al total de la compra.
        /// </summary>
        /// <param name="carne"></param>
        /// <param name="cantPesoCliente"></param>
        /// <param name="cliente"></param>
        /// <returns>Retorna true si pudo, false sino</returns>
        public static bool AgregarAlCarrito(Producto carne, double cantPesoCliente,Cliente cliente)
        {
            bool pudoAgregar = false;
            Producto auxCarne = new Producto();//-->Aux para no sobreescribir el producto original

            double precioCarne = Producto.CalcularPrecioTotalProducto(cliente, carne, cantPesoCliente);//-->Calculo el precio
            cliente.CarritoCompra._conTarjeta = cliente.ConTarjeta;//-->Paso si es con tarjeta la compra

            //-->Peso de la carne > 0 y mayor a lo que pide el cliente
            if (carne.Stock > 0 && carne.Stock >= cantPesoCliente)
            {
                //--->Por alguna razón me pisaba la carne anterior, asi que instancio una nueva y le paso sus atributos
                auxCarne.Codigo = carne.Codigo;
                auxCarne.Proveedor = carne.Proveedor;
                auxCarne.Stock = cantPesoCliente;
                auxCarne.Tipo = carne.Tipo;
                auxCarne.Corte = carne.Corte;
                auxCarne.Categoria = carne.Categoria;
                auxCarne.Vencimiento = carne.Vencimiento; 
                auxCarne.PrecioCompraCliente = precioCarne;//-->Setteo su precio ya calculado
                cliente.CarritoCompra.FechaCompra = DateTime.Now;//-->Guardo esa fecha de compra.

                foreach (Producto item in cliente.CarritoCompra.Productos)//-->Recorro si son coincidentes
                {
                    if(item == auxCarne)//-->Mediante el codigo comparo
                    {
                        item.Stock += auxCarne.Stock;//-->Si son iguales sumo la cantidad
                        item.PrecioCompraCliente += auxCarne.PrecioCompraCliente;//-->Sumo el precio
                        break;
                    }
                }

                if (cliente.CarritoCompra + auxCarne)//-->Devuelve true si puede añadirlo al carrito
                {
                    cliente.CarritoCompra.PrecioTotal += precioCarne;//-->Acumulo el precio d productos al total del carrito

                    pudoAgregar = true;//-->Si puede retorno true
                }
            }
            else
            {
                throw new NoHayStockException("No hay stock del producto.");
            }
            return pudoAgregar;
        }

        /// <summary>
        /// Metodo que me permite limpiar el carrito de productos y
        /// el precio total.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static Carrito LimpiarCarrito(Cliente cliente)
        { 
            cliente.CarritoCompra.Productos.Clear();
            cliente.CarritoCompra.PrecioTotal = 0;//-->Quito tambien el dinero acumulado

            return cliente.CarritoCompra;
        } 
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// Sobrecarga del .ToString(). 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); 
            sb.AppendLine($"FECHA DE COMPRA: {this._fechaCompra.ToShortDateString()}");
            if (ConTarjeta)
            {
                sb.AppendLine("Con tarjeta: SI.");
            }
            else
            {
                sb.AppendLine("Con tarjeta: NO.");
            }
            
            foreach (Producto producto in this._listaDeProductos)
            {
                sb.AppendLine("-------------PRODUCTO-------------");
                if (this._listaDeProductos.Count > 0)
                {
                    sb.AppendLine($"Tipo: {producto.Tipo.ToString().Replace("_", " ")}");
                    sb.AppendLine($"Corte: {producto.Corte.ToString().Replace("_", " ")}");
                    sb.AppendLine($"Categoría: {producto.Categoria.ToString().Replace("_", " ")}");
                    sb.AppendLine($"Peso: {producto.Stock}kgs.");
                    sb.AppendLine($"Precio: ${producto.PrecioCompraCliente:f}"); 
                }
                else
                {
                    sb.AppendLine("No hay productos seleccionados.");
                }
            }
            sb.AppendLine("----------------------------------------");
            sb.AppendLine($"Total: ${this._precioTotal:f}");

            return sb.ToString();
        } 

        /// <summary>
        /// Valor Hash del objeto, es unico
        /// </summary>
        /// <returns>Valor Hash del objeto</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
