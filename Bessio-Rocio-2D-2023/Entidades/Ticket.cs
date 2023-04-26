using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ticket
    {
        #region ATRIBUTOS
        private DateTime _fechaCompra;
        private double _precioTotal;
        private double _precioConRecargo;
        private bool _conTarjeta;
        private List<Producto> _listaDeProductos;

        private static readonly double precioIVA = 5;
        #endregion

        #region PROPIEDADES
        public DateTime FechaCompra { get { return this._fechaCompra; } }
        public double PrecioTotal { get { return this._precioTotal; } }
        public double Recargo { get { return this.AplicarRecargo(this._precioTotal); } set { this._precioConRecargo = value; } }
        public bool ConTarjeta { get { return this._conTarjeta; } }
        public List<Producto> Productos { get { return this._listaDeProductos; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor de la clase Ticket que me permite crear una instacia del objeto
        /// parametrizado. 
        /// </summary>
        /// <param name="compra"></param>
        /// <param name="precioTotal"></param>
        /// <param name="descuento"></param>
        /// <param name="productos"></param>
        public Ticket(DateTime compra, double precioTotal, double descuento, List<Producto> productos,bool tarjeta)
        {
            this._conTarjeta = tarjeta;
            this._fechaCompra = compra; 
            this._precioTotal = precioTotal;
            this._precioConRecargo = descuento;
            this._listaDeProductos = productos;
        }
        #endregion

        #region METODO
        /// <summary>
        /// El metodo AplicarRecargo aplica un recargo (IVA)
        /// si el cliente decidio abonar con tarjeta de credito.
        /// </summary>
        /// <param name="precio"></param>
        /// <returns></returns>
        private double AplicarRecargo(double precio)
        {
            double retorno = 0;
            if (this._conTarjeta && precio > 0)
            {
                double totalSinImpuestos = precio;
                double impuestos = totalSinImpuestos * precioIVA / 100;
                retorno = totalSinImpuestos + impuestos; 
            } 
            return retorno; 
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
            sb.AppendLine($"{this._fechaCompra.ToShortTimeString()}-${this._precioTotal:f}");

            if( this._conTarjeta)//Si pago con tarjeta muestro el recargo
            {
                sb.AppendLine($"- ${this._precioConRecargo}");
            }

            foreach (Producto producto in this._listaDeProductos)
            {
                if(this._listaDeProductos.Count > 0)
                {
                    sb.AppendLine($"{producto.ToString()}");
                }
                else
                {
                    sb.AppendLine("No hay productos seleccionados.");
                }
            }

            return sb.ToString();
        }
        #endregion
    }
}
