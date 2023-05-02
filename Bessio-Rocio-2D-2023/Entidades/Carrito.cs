using System;
using System.Collections.Generic;
using System.Linq;
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
        //public double Recargo { get { return this.AplicarRecargo(this._precioTotal); } set { this._precioConRecargo = value; } }
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
        /// Constructor de la clase Ticket que me permite crear una instacia del objeto
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

        ///// <summary>
        ///// Me permite añadir un producto al carrito si este no se encuentra
        ///// ya contenido en el.
        ///// Utilizo la sobrecarga del == de Carne.
        ///// </summary>
        ///// <param name="carrito"></param>
        ///// <param name="carne"></param>
        ///// <returns></returns>
        //public static Carrito operator + (Carrito carrito,Carne carne)
        //{
        //    if(!(carrito is null) && !(carne is null))
        //    {
        //        foreach (Carne item in carrito._listaDeProductos)
        //        {
        //            if(item == carne)//-->Si son distintos puedo añadirlo
        //            {
        //                carrito._listaDeProductos.Add(carne);
        //            }
        //        }
        //    }
        //    return carrito;
        //}

        #region METODO
        ///// <summary>
        ///// El metodo AplicarRecargo aplica un recargo (IVA)
        ///// si el cliente decidio abonar con tarjeta de credito.
        ///// </summary>
        ///// <param name="precio"></param>
        ///// <returns></returns>
        //private double AplicarRecargo(double precio)
        //{
        //    double retorno = 0;
        //    if (this._conTarjeta && precio > 0)
        //    {
        //        double totalSinImpuestos = precio;
        //        double impuestos = totalSinImpuestos * precioIVA / 100;
        //        retorno = totalSinImpuestos + impuestos; 
        //    } 
        //    return retorno; 
        //}
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// Sobrecarga del .ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            double acumulador = 0;
            sb.AppendLine($"FECHA DE COMPRA:{this._fechaCompra.ToShortDateString()}"); 

            foreach (Carne producto in this._listaDeProductos)
            {
                if(this._listaDeProductos.Count > 0)
                {
                    sb.AppendLine($"Tipo: {producto.Tipo.ToString().Replace("_", " ")}");
                    sb.AppendLine($"Corte: {producto.Corte.ToString().Replace("_", " ")}");
                    sb.AppendLine($"Categoría: {producto.Categoria.ToString().Replace("_", " ")}");
                    sb.AppendLine($"Peso: {producto.Peso}");
                    sb.AppendLine($"Precio: ${producto.PrecioCompraCliente}");
                    acumulador += producto.PrecioCompraCliente;//-->Acumulo el total entre todos los productos
                }
                else
                {
                    sb.AppendLine("No hay productos seleccionados.");
                }
            }
            this._precioTotal = acumulador;

            sb.AppendLine($"Total: ${this._precioTotal:f}");

            return sb.ToString();
        }
        #endregion
    }
}
