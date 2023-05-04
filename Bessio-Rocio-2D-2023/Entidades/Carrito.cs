using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrito
    {
        #region ATRIBUTOS
        private DateTime _fechaCompra;
        private double _precioTotal; 
        private bool _conTarjeta;
        private List<Carne> _listaDeProductos;  
        #endregion

        #region PROPIEDADES
        public DateTime FechaCompra { get { return this._fechaCompra; } }
        public double PrecioTotal { get { return this._precioTotal; } set { this._precioTotal = value; } }
        public bool ConTarjeta { get { return this._conTarjeta; } }
        public List<Carne> Productos { get { return this._listaDeProductos; } }
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
            this._listaDeProductos = new List<Carne>();
        }

        /// <summary>
        /// Constructor de la clase Carrito que me permite crear una instacia del objeto
        /// parametrizado.
        /// parametrizado. 
        /// </summary>
        /// <param name="compra"></param>
        /// <param name="precioTotal"></param>
        /// <param name="descuento"></param>
        /// <param name="productos"></param>
        public Carrito(DateTime compra, double precioTotal, double descuento, List<Carne> productos,bool tarjeta)
        {
            this._conTarjeta = tarjeta;
            this._fechaCompra = compra; 
            this._precioTotal = precioTotal;
            this._listaDeProductos = productos;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Me permite añadir un producto al carrito si este no se encuentra
        /// ya contenido en el.
        /// Utilizo la sobrecarga del == de Carne.
        /// </summary>
        /// <param name="carrito"></param>
        /// <param name="carne"></param>
        /// <returns></returns>
        public static bool operator +(Carrito carrito, Carne carne)
        {
            bool puede = true;
            Carne carneAux = new Carne();
            carneAux = carne;
            if (!(carrito is null) && !(carne is null))
            {
                if (!carrito._listaDeProductos.Contains(carne))
                {
                    carrito._listaDeProductos.Add(carneAux);
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
        public bool AgregarAlCarrito(Carne carne, double cantPesoCliente,Cliente cliente)
        {
            bool pudoAgregar = false;
            Carne auxCarne = new Carne();//-->Aux para no sobreescribir el producto

            double precioCarne = Carne.CalcularPrecioTotal(cliente, carne, cantPesoCliente);

            //-->Peso de la carne > 0 y mayor a lo que pide el cliente
            if (carne.Peso > 0 && carne.Peso >= cantPesoCliente)
            {
                auxCarne.Proveedor = carne.Proveedor;
                auxCarne.Peso = cantPesoCliente;
                auxCarne.Tipo = carne.Tipo;
                auxCarne.Corte = carne.Corte;
                auxCarne.Categoria = carne.Categoria;
                auxCarne.Vencimiento = carne.Vencimiento; 
                auxCarne.PrecioCompraCliente = precioCarne;//-->Setteo su precio ya calculado
                //cliente.CarritoCompra.PrecioTotal += precioCarne;
                //cliente.CarritoCompra.Productos.Add(auxCarne);
                //pudoAgregar = true;
                if (cliente.CarritoCompra + auxCarne)//-->Devuelve true si puede
                {
                    cliente.CarritoCompra.PrecioTotal += precioCarne;//-->Acumulo el precio d productos al total del carrito
                    pudoAgregar = true;//-->Si puede retorno true
                }
            }
            return pudoAgregar;
        }
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// Sobrecarga del .ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); 
            sb.AppendLine($"FECHA DE COMPRA:{this._fechaCompra.ToShortDateString()}");
            
            foreach (Carne producto in this._listaDeProductos)
            {
                sb.AppendLine("---------PRODUCTO-------------");
                if (this._listaDeProductos.Count > 0)
                {
                    sb.AppendLine($"Tipo: {producto.Tipo.ToString().Replace("_", " ")}");
                    sb.AppendLine($"Corte: {producto.Corte.ToString().Replace("_", " ")}");
                    sb.AppendLine($"Categoría: {producto.Categoria.ToString().Replace("_", " ")}");
                    sb.AppendLine($"Peso: {producto.Peso}kgs.");
                    sb.AppendLine($"Precio: ${producto.PrecioCompraCliente:f}"); 
                }
                else
                {
                    sb.AppendLine("No hay productos seleccionados.");
                }
            }
            sb.AppendLine("-----------------------------");
            sb.AppendLine($"Total: ${this._precioTotal:f}");

            return sb.ToString();
        }
        #endregion
    }
}
