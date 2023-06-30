using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Producto
    {
        #region ATRIBUTOS
        private string _tipoCarne;
        private string _categoria;
        private string _corteCarne;
        private int _codigo; 
        private string _proveedor;
        private double _peso;
        private DateTime _vencimiento;
        private double _precioVentaProveedor;//--->Precio por el cual compre en un frigorifico
        private double _precioCompraCliente;//--->Precio por el cual lo voy a vender
        private static int ultimoCodigo;
        #endregion

        #region  PROPIEDADES
        /// <summary>
        /// Propiedad de lectura y escritura.
        /// </summary>
        public int Codigo { get { return this._codigo; } set { this._codigo = value; } }
        /// <summary>
        /// Propiedad de lectura y escritura.
        /// </summary>
        public string Tipo { get { return this._tipoCarne; } set { this._tipoCarne = value; } }
        /// <summary>
        /// Propiedad de lectura y escritura.
        /// </summary>
        public string Corte { get { return this._corteCarne; } set { this._corteCarne = value; } }
        /// <summary>
        /// Propiedad de lectura y escritura.
        /// </summary>
        public double Stock { get { return this._peso; } set { this._peso = value; } }
        /// <summary>
        /// Propiedad de lectura y escritura.
        /// </summary>
        public string Categoria { get { return this._categoria; } set { this._categoria = value; } }
        /// <summary>
        /// Propiedad de lctura y escritura.
        /// </summary>
        public DateTime Vencimiento { get { return this._vencimiento; } set { this._vencimiento = value; } }
        /// <summary>
        /// Propiedad de lctura y escritura.
        /// </summary>
        public double PrecioVentaProveedor { get { return this._precioVentaProveedor; } set { this._precioVentaProveedor = value; } }
        /// <summary>
        /// Propiedad de lctura y escritura.
        /// </summary>
        public string Proveedor { get { return this._proveedor; } set { this._proveedor = value; } }
        /// <summary>
        /// Propiedad de lctura y escritura.
        /// </summary>
        public double PrecioCompraCliente { get { return this._precioCompraCliente; } set { this._precioCompraCliente = value; } }
        #endregion

        #region CONSTRUCTOR 
        /// <summary>
        /// Se llama la primera vez que creo una instancia
        /// y setteo el ultimo codigo a 100
        /// </summary>
        static Producto()
        {
            ultimoCodigo = 100;
        }

        /// <summary>
        /// Sera mi constructor por defecto.
        /// </summary>
        public Producto()
        {
            _tipoCarne = string.Empty;
            _categoria = string.Empty;
            _corteCarne = string.Empty; 
            _proveedor = "";
            _peso = 0;
            _vencimiento = DateTime.Now;
            _precioVentaProveedor = 0;
            _precioCompraCliente = 0; 
        }

        /// <summary>
        /// Constructor parametrizado que me permitira crear una instancia
        /// del tipo Carne.
        /// </summary>
        /// <param name="tipoCarne"></param>
        /// <param name="corteCarne"></param>
        /// <param name="peso"></param>
        /// <param name="texturaCarne"></param>
        /// <param name="vencimiento"></param>
        public Producto(string corteCarne, double peso, string texturaCarne, DateTime vencimiento, double precioProveedor,
            string proveedor, string tipoCarne, double precioCompraCliente)
            :this()
        {
            this._precioCompraCliente = precioCompraCliente;
            this._tipoCarne = tipoCarne;
            this._corteCarne = corteCarne;
            this._peso = peso;
            this._categoria = texturaCarne;
            this._vencimiento = vencimiento;
            this._precioVentaProveedor = precioProveedor;
            this._proveedor = proveedor; 
            this._codigo = ultimoCodigo;
            ultimoCodigo++;//Por cada instancia incrementa el numero del ultcodigo
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Metodo que me permite calcular el precio total del producto seleccionado.
        /// --> Si paga con Crédito tiene un 5% de recargo.
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="carne"></param>
        /// <param name="peso"></param>
        /// <returns>Devuelve el precio total del producto</returns>
        public static double CalcularPrecioTotalProducto(Cliente cliente, Producto carne, double peso)
        {
            double precioCarne = 0;
            double precioFinalTarjeta;
            double precio = carne.PrecioCompraCliente; 

            precioCarne = (peso) * precio;

            //--> Si paga con tarjeta y es de credito
            if (cliente.ConTarjeta && (cliente.Tarjeta.EsDebito == false))
            {
                double conRecargo = precioCarne * 0.05;//-->Recargo del %5
                precioFinalTarjeta = precioCarne + conRecargo;
                precioCarne = precioFinalTarjeta;
            }
            //-->Devuelvo
            return precioCarne;
        }
        #endregion 

        #region SOBRECARGA
        /// <summary>
        /// Compara si el codigo de un objeto Carne es igual al int
        /// que recibe. Me servira para el manejo de datagrids.
        /// </summary>
        /// <param name="carne1"></param>
        /// <param name="codigo"></param>
        /// <returns>Retorna true si coinciden,false sino</returns>
        public static bool operator ==(Producto carne1,int codigo)
        {
            bool sonIguales = false;
            if (!(carne1 is null) && codigo >= 0)
            {
                sonIguales = (carne1._codigo == codigo); 
            }
            return sonIguales;
        }
        public static bool operator !=(Producto carne1, int codigo)
        {
            return !(carne1 == codigo);
        }

        /// <summary>
        /// La sobrecarga del == me permitirá comparar si dos carnes son
        /// iguales mediante su codigo, su peso y su tipo.
        /// Me sevirá para hacer la sobrecarga del + en el Carrito.
        /// </summary>
        /// <param name="carne1"></param>
        /// <param name="carne2"></param>
        /// <returns></returns>
        public static bool operator == (Producto carne1,Producto carne2)
        {
            bool sonIguales = false;
            if(!(carne1 is null) && !(carne2 is null))
            { 
                sonIguales = (carne1._codigo == carne2._codigo);
            }
            return sonIguales;
        }

        public static bool operator !=(Producto carne1, Producto carne2)
        {
            return !(carne1 == carne2);
        }
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// La sobrecarga del .TOString() me permite devolver
        /// la informacion del objeto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Corte: {this._corteCarne.ToString().Replace("_"," ")} - Categoría: {this._categoria.ToString().Replace("_"," ")} " +
                $"- Tipo: {this._tipoCarne.ToString().Replace("_", " ")}");
            sb.AppendLine($"Kilos: {this._peso} - Vencimiento: {this._vencimiento.ToShortDateString()} - Precio proveedor: ${this._precioVentaProveedor} -" +
                $"Precio compra cliente: ${this._precioCompraCliente}");
            return sb.ToString();
        }

        /// <summary>
        /// Codigo Hash del objeto, es unico
        /// </summary>
        /// <returns>Codigo Hash del objeto </returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Compara si el objeto actual this es igual al objeto del parametro,
        /// es comparado por la sobrecarga del ==
        /// </summary>
        /// <param name="obj">de tipo object</param>
        /// <returns>si son iguales retorna true sino false</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Producto && !(obj is null))
            {
                retorno = this == ((Producto)obj);
            }
            return retorno;
        }
        #endregion
    }
}
